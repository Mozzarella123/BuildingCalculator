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
            login = LoginClass.login;
            pass = LoginClass.pass;
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
                    ConfigWorksService.ChangeValue("Remembered", "true");

                LoginClass.IsLoged = true;
                LoginClass.af.Top = (this.Top + (this.Height / 2)) - LoginClass.af.Height / 2;
                LoginClass.af.Left = (this.Top + (this.Height / 2)) - LoginClass.af.Height / 2;
                LoginClass.af.StartPosition = FormStartPosition.Manual;
                LoginClass.af.Show();
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
