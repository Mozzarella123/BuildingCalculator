using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;
using System.IO;

namespace BuildingCalculator
{
    public static class DelegateAssemblyService
    {
        private static string begin = @"using System;
namespace MyNamespace
{
    public delegate double getPrice(params double parametr);
    public static class LambdaCreator 
    {
        ";
        private static string end = @"
        
    }
}";
        public static void AssemblyDelegate()
        {
            CompileString = begin;
            foreach (WorkTypeClass w in JSONSerializeService.InputItems)
            {
                CompileString += CreateFunctions(w);
            }
            CompileString += end;

            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateInMemory = true;
            parameters.OutputAssembly = "compile.dll";
            parameters.ReferencedAssemblies.Add("System.dll");
            CompilerResults results = provider.CompileAssemblyFromSource(parameters, CompileString);
            var cls = results.CompiledAssembly.GetType("MyNamespace.LambdaCreator");
            CompiledClass = cls;
            //var calc = (method.Invoke(null, null) as Delegate);
            //return calc.DynamicInvoke
        }

        static Type CompiledClass;
        public delegate double getPrice(params double[] parametr);
        public static double getPriceforWorkType(WorkTypeClass work,params double[] parametr)
        {
            var method = CompiledClass.GetMethod(work.delegateName, BindingFlags.Static | BindingFlags.Public);
            var calc = (method.Invoke(null, null) as Delegate);
            object[] par = new object[parametr.Length];
            for (int i = 0; i < parametr.Length; i++)
                par[i] = parametr[i];
            return calc.DynamicInvoke(par);
        }
        static int fId = 0;
        static string CreateFunctions(WorkTypeClass work)
        {
            string parametrs="";
            foreach (string str in work.parametrs)
                parametrs += "double " + str + ",";
            parametrs = parametrs.Substring(0, parametrs.Length - 1);
            string ret = @"
        public static getPrice " + "f" + fId + "(" + parametrs + ")" + "{ return (" + parametrs + ")=>" + work.formula + ";}";
            work.delegateName = "f" + fId.ToString();
            fId++;
            return ret;
        }
        static string CompileString = "";
        public static void WriteCompileStringToFile()
        {
            CompileString = begin;
            foreach(WorkTypeClass work in JSONSerializeService.InputItems)
            {
                CompileString += CreateFunctions(work);
            }
            CompileString += end;

            File.WriteAllText("ForCompile.cs", CompileString);
            
        } 
    }
}
