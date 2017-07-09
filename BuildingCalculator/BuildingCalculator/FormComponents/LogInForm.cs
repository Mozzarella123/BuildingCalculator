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
            MaximizeBox = false;
            MinimizeBox = false;
            
            FormClosing += new FormClosingEventHandler(_FormClosing);


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

            login = LoginClass.login;
            pass = LoginClass.pass;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string LogInp;
            string PasInp;
            try
            {
                LogInp = LoginInp.Text.Substring(0, LoginClass.login.Length);
                PasInp = PassInp.Text.Substring(0, LoginClass.pass.Length);
            }
            catch
            {
                return;
            }

            if (LogInp == login && PasInp == pass)
            {
                if (Rememberme.Checked)
                    ConfigWorksService.ChangeValue("Remembered", "True");

                LoginClass.IsLoged = true;
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
