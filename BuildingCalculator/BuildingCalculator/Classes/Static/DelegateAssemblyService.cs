using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace BuildingCalculator
{

    public static class DelegateAssemblyService
    {
        private static string begin = @"using System;
namespace MyNamespace
{
    
    public static class PriceFunctions 
    {
        public static double Pow(double val,int count)
        {
            return Math.Pow(val, count);
        }
        public static double Sqrt(double val)
        {
            return Math.Sqrt(val);
        }
        ";
        private static string end = @"
        
    }
}";
        
        /// <summary>
        /// функция компиляции файла(запускается при загрузке входных данных)
        /// </summary>
        public static void AssemblyDelegate()
        {
            CompileString = begin;//формирование файла с кодом для дальнейшей компиляции
            foreach (WorkTypeClass w in JSONSerializeService.InputItems)
            {
                if (!w.IsFixedPrice)
                    CompileString += CreateFunctions(w);
            }
            CompileString += end;//завершение формирования кода
            fId = 0;

            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateInMemory = false;//задание параметров компиляции
            //if (File.Exists("compile.dll"))
            //    File.Delete("compile.dll");
            //parameters.OutputAssembly = "compile.dll";
            parameters.ReferencedAssemblies.Add("System.dll");
            CompilerResults results = provider.CompileAssemblyFromSource(parameters, CompileString);//компиляция
            var cls = results.CompiledAssembly.GetType("MyNamespace.PriceFunctions");//извлечение скомпилированного класса
            CompiledClass = cls;
            
        }

        static Type CompiledClass;
        /// <summary>
        /// функция расчета цены для конкретного объекта с конкретными параметрами
        /// </summary>
        /// <param name="work">объект для которого нужно найти цену</param>
        /// <param name="parametr">массив со значениями параметров обьекта(параметры расположены в том же порядке, что и в файле)</param>
        /// <returns></returns>
        public static double getPriceforWorkType(WorkTypeClass work, double[] parametr)
        {
            var method = CompiledClass.GetMethod(work.delegateName, BindingFlags.Static | BindingFlags.Public);//получение метода соответствующего объекту            
            object[] ObjPar = new object[parametr.Length];
            for (int i = 0; i < parametr.Length; i++)
                ObjPar[i] = parametr[i];//конвертация double в object КОСТЫЛЬ
            var ret = method.Invoke(null, ObjPar);//получение значения
            return (double)ret;
            
        }
        static int fId = 0;
        /// <summary>
        /// создание функции для объекта для последующей компиляции
        /// </summary>
        /// <param name="work">объект для которого формируется функция</param>
        /// <returns></returns>
        static string CreateFunctions(WorkTypeClass work)
        {
            //if (work.isFixedPrice)
            //    return "";
            string parametrs="";
            foreach (string str in work.parametrs)
                parametrs += "double " + str + ",";//формирование стороки параметров
            if (parametrs != "")
            {
                parametrs = parametrs.Substring(0, parametrs.Length - 1);
            }
            string ret = @"
        public static double " + "f" + fId + "(" + parametrs + ")" + "{ return " + work.Formula + ";}";//формирование кода
            work.delegateName = "f" + fId.ToString();//запоминание объектом имени соответствующей ему функции
            fId++;
            return ret;
        }
        static string CompileString = "";
        /// <summary>
        /// запись всех функций в .cs файл(нужно для проверки)
        /// </summary>
        public static void WriteCompileStringToFile()
        {
            
            CompileString = begin;
            foreach(WorkTypeClass work in JSONSerializeService.InputItems)
            {
                if (!work.IsFixedPrice)
                    CompileString += CreateFunctions(work);
            }
            CompileString += end;
            fId = 0;
            File.WriteAllText("ForCompile.cs", CompileString);
            
        }
        /// <summary>
        /// проверка корректности данных в объекте
        /// </summary>
        /// <param name="work">проверяемый объект</param>
        /// <returns></returns>
        public static bool isCreatedCorrect(WorkTypeClass work)
        {
            if (!work.IsFixedPrice)
            {
                string func = CreateFunctions(work);//генерация кода
                try
                {
                    CSharpCodeProvider provider = new CSharpCodeProvider();
                    CompilerParameters parameters = new CompilerParameters();
                    parameters.GenerateInMemory = false;
                    //if (File.Exists("test.dll"))
                    //    File.Delete("test.dll");
                    //parameters.OutputAssembly = "test.dll";
                    parameters.ReferencedAssemblies.Add("System.dll");
                    CompilerResults results = provider.CompileAssemblyFromSource(parameters, begin + func + end);//компиляция кода

                    if (results.Errors.Count == 0)
                        return true;
                    else
                    {

                        return false;
                    }
                }
                catch
                {
                    return false;//в случае ошибки, код сгенерирован неверно
                }
            }
            else
                return true;
        } 
    }
}
