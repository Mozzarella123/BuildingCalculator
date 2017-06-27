﻿using System;
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
    public partial class inputparams : Form
    {
        public TextBox TextBox
        {
            get { return ParamInput; }
        }
        public Label Label
        {
            get { return Paramname; }
        }
        public inputparams()
        {
            InitializeComponent();
            Classes.Functions.SetValidator(ParamInput, Classes.Functions.ValidateType.OnlyNumbers);
            Classes.Functions.SetToolTip("Нажмите enter, чтобы завершить ввод", ParamInput);
        }

        private void ParamInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Hide();
        }

        private void inputparams_FormClosing(object sender, FormClosingEventArgs e)
        {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                    this.Hide();
                }
        }
    }
}
