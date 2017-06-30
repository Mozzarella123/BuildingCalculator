using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingCalculator.FormComponents
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            if (!ConfigWorksService.Contains("tutorial"))
                ConfigWorksService.Add("tutorial", "true");
            if(!ConfigWorksService.Contains("units"))
                ConfigWorksService.Add("units", "m");
            if(!ConfigWorksService.Contains("endDir"))
                ConfigWorksService.Add("endDir", "");
            label1.Text = ConfigWorksService.getValue(ConfigWorksService.Options.ReportDirectory);
            if (ConfigWorksService.getValue(ConfigWorksService.Options.Units) == "sm")
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        

        private void SettingForm_Load(object sender, EventArgs e)
        {
            if (!ConfigWorksService.Contains("tutorial"))
                ConfigWorksService.Add("tutorial", "True");
            if (!ConfigWorksService.Contains("units"))
                ConfigWorksService.Add("units", "m");
            if (!ConfigWorksService.Contains("endDir"))
                ConfigWorksService.Add("endDir", "");
            label1.Text = ConfigWorksService.getValue(ConfigWorksService.Options.ReportDirectory);
            if (ConfigWorksService.getValue(ConfigWorksService.Options.Units) == "sm")
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;
            
        }

        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConfigWorksService.ChangeValue("tutorial", checkBox1.Checked.ToString());
            if (radioButton1.Checked)
                ConfigWorksService.ChangeValue("units", "sm");
            if (radioButton2.Checked)
                ConfigWorksService.ChangeValue("units", "m");
            ConfigWorksService.ChangeValue("endDir", folderBrowserDialog1.SelectedPath);
            this.Hide();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
