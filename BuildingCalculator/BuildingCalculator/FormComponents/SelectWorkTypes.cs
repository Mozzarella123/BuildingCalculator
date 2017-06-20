using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BuildingCalculator.FormComponents
{
    public partial class SelectWorkTypes : Form
    {
        public SelectWorkTypes()
        {
            InitializeComponent();
            //JSONSerializeService.ReadInput(Directory.GetCurrentDirectory() + "\\works.json");
            List<WorkTypeClass> works = JSONSerializeService.OutputItems;
            for (int i=0;i<works.Count;i++)
            {
                WorkTypeList.Items.Add(works[i].article);
                WorkTypeList.SetItemCheckState(i,CheckState.Checked);
            }         


        }
        private void Edit_Puntcs(object sender, EventArgs e)
        {
            switch ((sender as Control).Name)
            {
                case "checkall":
                    {
                        for (int i = 0; i < WorkTypeList.Items.Count; i++)
                            WorkTypeList.SetItemCheckState(i, CheckState.Checked);
                        break;
                    } 
                case "uncheckall":
                    {
                        for (int i = 0; i < WorkTypeList.Items.Count; i++)
                            WorkTypeList.SetItemCheckState(i, CheckState.Unchecked);
                        break;
                    }
            }
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            foreach (WorkTypeClass elem in JSONSerializeService.OutputItems)
            {

            }
            PDFWriteService.InitializeNewFile("отчёт", Directory.GetCurrentDirectory());
            
        }
    }
}
