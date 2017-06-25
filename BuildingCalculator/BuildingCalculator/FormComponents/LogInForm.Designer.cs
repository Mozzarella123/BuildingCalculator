namespace BuildingCalculator
{
    partial class LogInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginInp = new System.Windows.Forms.TextBox();
            this.PassInp = new System.Windows.Forms.TextBox();
            this.LoginT = new System.Windows.Forms.Label();
            this.PassT = new System.Windows.Forms.Label();
            this.Log_In = new System.Windows.Forms.Button();
            this.Rememberme = new System.Windows.Forms.CheckBox();
            this.MarkUp = new System.Windows.Forms.TableLayoutPanel();
            this.MarkUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginInp
            // 
            this.LoginInp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LoginInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginInp.Location = new System.Drawing.Point(61, 44);
            this.LoginInp.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.LoginInp.Multiline = true;
            this.LoginInp.Name = "LoginInp";
            this.LoginInp.Size = new System.Drawing.Size(160, 35);
            this.LoginInp.TabIndex = 0;
            this.LoginInp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginInp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PassInp
            // 
            this.PassInp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PassInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassInp.Location = new System.Drawing.Point(61, 128);
            this.PassInp.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.PassInp.Multiline = true;
            this.PassInp.Name = "PassInp";
            this.PassInp.PasswordChar = '*';
            this.PassInp.Size = new System.Drawing.Size(160, 35);
            this.PassInp.TabIndex = 1;
            this.PassInp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginT
            // 
            this.LoginT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LoginT.AutoSize = true;
            this.LoginT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginT.Location = new System.Drawing.Point(96, 5);
            this.LoginT.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.LoginT.Name = "LoginT";
            this.LoginT.Size = new System.Drawing.Size(89, 29);
            this.LoginT.TabIndex = 2;
            this.LoginT.Text = "Логин:";
            this.LoginT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PassT
            // 
            this.PassT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PassT.AutoSize = true;
            this.PassT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassT.Location = new System.Drawing.Point(88, 89);
            this.PassT.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.PassT.Name = "PassT";
            this.PassT.Size = new System.Drawing.Size(105, 29);
            this.PassT.TabIndex = 3;
            this.PassT.Text = "Пароль:";
            // 
            // Log_In
            // 
            this.Log_In.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Log_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_In.Location = new System.Drawing.Point(66, 222);
            this.Log_In.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Log_In.Name = "Log_In";
            this.Log_In.Size = new System.Drawing.Size(150, 53);
            this.Log_In.TabIndex = 4;
            this.Log_In.Text = "Войти";
            this.Log_In.UseVisualStyleBackColor = true;
            this.Log_In.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rememberme
            // 
            this.Rememberme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Rememberme.AutoSize = true;
            this.Rememberme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rememberme.Location = new System.Drawing.Point(23, 173);
            this.Rememberme.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Rememberme.Name = "Rememberme";
            this.Rememberme.Size = new System.Drawing.Size(236, 33);
            this.Rememberme.TabIndex = 5;
            this.Rememberme.Text = "Запомнить меня";
            this.Rememberme.UseVisualStyleBackColor = true;
            // 
            // MarkUp
            // 
            this.MarkUp.ColumnCount = 1;
            this.MarkUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MarkUp.Controls.Add(this.LoginT, 0, 0);
            this.MarkUp.Controls.Add(this.Rememberme, 0, 5);
            this.MarkUp.Controls.Add(this.LoginInp, 0, 1);
            this.MarkUp.Controls.Add(this.PassT, 0, 2);
            this.MarkUp.Controls.Add(this.PassInp, 0, 4);
            this.MarkUp.Controls.Add(this.Log_In, 0, 6);
            this.MarkUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MarkUp.Location = new System.Drawing.Point(0, 0);
            this.MarkUp.Name = "MarkUp";
            this.MarkUp.RowCount = 7;
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MarkUp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MarkUp.Size = new System.Drawing.Size(282, 280);
            this.MarkUp.TabIndex = 6;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 280);
            this.Controls.Add(this.MarkUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Войти в админ-панель";
            this.Load += new System.EventHandler(this.LogInForm_Load);
            this.MarkUp.ResumeLayout(false);
            this.MarkUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox LoginInp;
        private System.Windows.Forms.TextBox PassInp;
        private System.Windows.Forms.Label LoginT;
        private System.Windows.Forms.Label PassT;
        private System.Windows.Forms.Button Log_In;
        private System.Windows.Forms.CheckBox Rememberme;
        private System.Windows.Forms.TableLayoutPanel MarkUp;
    }
}