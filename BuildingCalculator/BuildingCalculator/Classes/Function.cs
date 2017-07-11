using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace BuildingCalculator.Classes
{
    public static class Functions
    {
        
        public delegate void SetMethod(object obj,Control control);
        public enum ValidateType { Default,OnlyText,OnlyNumbers, UserValidate }
        /// <summary>
        /// Создает контекстное меню для любого элемента
        /// </summary>
        /// <param name="control">Control к которому нужно привязать меню</param>
        /// <param name="names">Названия элементов</param>
        /// <param name="funcs">Функции элементов</param>
        /// <returns>Возвращает созданное контекстное меню</returns>
        public static ContextMenuStrip ContextMenu(Control control,List<string> names,List<EventHandler> funcs)
        {           
            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            for (int i=0;i<names.Count;i++)
            {
                menu.Items.Add(names[i]);
                menu.Items[i].Click += funcs[i];
            }
            control.ContextMenuStrip = menu;
            return menu;         
        }
        /// <summary>
        /// Создать валидатор для Control
        /// </summary>
        /// <param name="type">Тип валидации</param>
        /// <param name="control">Control, к которому привязать</param>
        /// <param name="userfunc">Собственный обработчик</param>
        public static void SetValidator(Control control,ValidateType type, KeyPressEventHandler userfunc = null)
        {
            switch (type)
            {
                case ValidateType.OnlyNumbers:
                    {
                        control.KeyPress += ValidNumbers;
                        control.Text = "0";
                        break;
                    }
                case ValidateType.OnlyText:
                    {
                        control.KeyPress += ValidText;
                        break;
                    }
                case ValidateType.UserValidate:
                    {
                        if (userfunc != null)
                            control.KeyPress += userfunc;
                        break;
                    }
            }
        }
        private static void ValidNumbers (object sender, KeyPressEventArgs e)
        {
            TextBox input = sender as TextBox;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && !(e.KeyChar == ',' || e.KeyChar == '.'))
                e.Handled = true;
            else
            {

                if (input.Text == "0")
                        (sender as Control).Text = "";
                if (e.KeyChar == '\b' && input.Text.Length == 1)
                {
                    e.Handled = true;
                    input.Text = "0";
                }
                if (e.KeyChar == ','||e.KeyChar=='.')
                {
                    if (e.KeyChar == '.') e.KeyChar = ',';
                    if (input.Text == "")
                        input.Text += "0";                    
                    if (input.Text.Contains(e.KeyChar))
                        e.Handled = true;
                }
                if (input.SelectionLength==0)
                input.SelectionStart = input.Text.Length;

            }
        }
        private static void ValidText(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }       
        public static void SetToolTip(string text,Control control)
        {
            if (Convert.ToBoolean(ConfigWorksService.getValue(ConfigWorksService.Options.Hints)))
            { 
                ToolTip hint = new ToolTip();
                hint.InitialDelay = 10;
                //hint.ReshowDelay = 1;
                hint.ShowAlways = true;
                hint.Active = true;
                hint.UseAnimation = true;
                hint.UseFading = true;
                hint.SetToolTip(control, text);
            }
        }
        
        public static void CenterForm(Form form, Form parentform)
        {
            form.Top = (parentform.Top + (parentform.Height / 2)) - form.Height / 2;
            form.Left = (parentform.Left + (parentform.Width / 2)) - form.Width / 2;
            form.StartPosition = FormStartPosition.Manual;
        }
        private static List<TreeNode> CurrentNodeMatches = new List<TreeNode>();
        private static int LastNodeIndex = 0;
        private static string LastSearchText;
        public static void Search(string pattern,TreeView tree)
        {
            
            string searchText = pattern;
            if (String.IsNullOrEmpty(searchText))
            {
                return;
            };
            if (LastSearchText != searchText)
            {
                //It's a new Search
                CurrentNodeMatches.Clear();
                LastSearchText = searchText;
                LastNodeIndex = 0;
                SearchNodes(searchText, tree.Nodes[0]);
            }

            if (LastNodeIndex >= 0 && CurrentNodeMatches.Count > 0)
            {
                TreeNode selectedNode = CurrentNodeMatches[LastNodeIndex];
                LastNodeIndex++;
                if (tree.SelectedNode!= null&&tree.SelectedNode.Parent!=null&& tree.SelectedNode.Parent != selectedNode.Parent)
                    tree.SelectedNode.Parent.Collapse();
                tree.SelectedNode = selectedNode;
                tree.SelectedNode.Expand();
                if (LastNodeIndex == CurrentNodeMatches.Count)
                    LastNodeIndex = 0;
            }
        }
        private static void SearchNodes(string SearchText, TreeNode StartNode)
        {
            while (StartNode != null)
            {
                if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                {
                    CurrentNodeMatches.Add(StartNode);
                };
                if (StartNode.Nodes.Count != 0)
                {
                    SearchNodes(SearchText, StartNode.Nodes[0]);//Recursive Search 
                };
                StartNode = StartNode.NextNode;
            };

        }

    }
}
