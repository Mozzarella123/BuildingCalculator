using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BuildingCalculator
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            
            
            InitializeComponent();
            login = LoginClass.login;
            pass = LoginClass.pass;
            this.FormClosing += new FormClosingEventHandler(_FormClosing);


        }

        private void _FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        string login;
        string pass;
        private void LogInForm_Load(object sender, EventArgs e)
        {
            
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string LogInp;
            string PasInp;
            try
            {
                LogInp = textBox1.Text.Substring(0, LoginClass.login.Length);
                PasInp = textBox2.Text.Substring(0, LoginClass.pass.Length);
            }
            catch
            {
                return;
            }

            if (LogInp == login && PasInp == pass)
            {
                if (checkBox1.Checked)
                    ConfigWorksService.ChangeValue("Remembered", "true");

                LoginClass.IsLoged = true;
                LoginClass.af.Show();
                this.Hide();
            }
        }
    }
    
}
