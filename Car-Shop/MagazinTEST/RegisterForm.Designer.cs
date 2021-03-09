namespace MagazinTEST
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bGoLogin = new System.Windows.Forms.Button();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.bCreateAccount = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.bGoLogin);
            this.panel1.Controls.Add(this.textBoxConfirmPassword);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxLastname);
            this.panel1.Controls.Add(this.bCreateAccount);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.textBoxFirstname);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Normal user"});
            this.comboBox1.Location = new System.Drawing.Point(337, 322);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // bGoLogin
            // 
            this.bGoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bGoLogin.FlatAppearance.BorderSize = 0;
            this.bGoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGoLogin.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGoLogin.ForeColor = System.Drawing.Color.Black;
            this.bGoLogin.Location = new System.Drawing.Point(265, 416);
            this.bGoLogin.Name = "bGoLogin";
            this.bGoLogin.Size = new System.Drawing.Size(233, 22);
            this.bGoLogin.TabIndex = 10;
            this.bGoLogin.Text = "Already have an account? Login";
            this.bGoLogin.UseVisualStyleBackColor = false;
            this.bGoLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPassword.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(131, 294);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(533, 22);
            this.textBoxConfirmPassword.TabIndex = 9;
            this.textBoxConfirmPassword.Text = "confirm password";
            this.textBoxConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxConfirmPassword.Enter += new System.EventHandler(this.textBoxConfirmPassword_Enter);
            this.textBoxConfirmPassword.Leave += new System.EventHandler(this.textBoxConfirmPassword_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxPassword.Location = new System.Drawing.Point(131, 266);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(533, 22);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.Text = "password";
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxEmail.Location = new System.Drawing.Point(131, 232);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(533, 28);
            this.textBoxEmail.TabIndex = 7;
            this.textBoxEmail.Text = "email adress";
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastname.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxLastname.Location = new System.Drawing.Point(406, 144);
            this.textBoxLastname.Multiline = true;
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(258, 39);
            this.textBoxLastname.TabIndex = 6;
            this.textBoxLastname.Text = "last name";
            this.textBoxLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLastname.Enter += new System.EventHandler(this.textBoxLastname_Enter);
            this.textBoxLastname.Leave += new System.EventHandler(this.textBoxLastname_Leave);
            // 
            // bCreateAccount
            // 
            this.bCreateAccount.BackColor = System.Drawing.Color.PaleGreen;
            this.bCreateAccount.FlatAppearance.BorderSize = 0;
            this.bCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCreateAccount.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCreateAccount.ForeColor = System.Drawing.Color.Black;
            this.bCreateAccount.Location = new System.Drawing.Point(265, 355);
            this.bCreateAccount.Name = "bCreateAccount";
            this.bCreateAccount.Size = new System.Drawing.Size(233, 55);
            this.bCreateAccount.TabIndex = 5;
            this.bCreateAccount.Text = "Register";
            this.bCreateAccount.UseVisualStyleBackColor = false;
            this.bCreateAccount.Click += new System.EventHandler(this.bCreateAccount_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxUsername.Location = new System.Drawing.Point(131, 189);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(533, 35);
            this.textBoxUsername.TabIndex = 4;
            this.textBoxUsername.Text = "username";
            this.textBoxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxUsername.Enter += new System.EventHandler(this.textBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.textBoxUsername_Leave);
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstname.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxFirstname.Location = new System.Drawing.Point(131, 144);
            this.textBoxFirstname.Multiline = true;
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(269, 39);
            this.textBoxFirstname.TabIndex = 2;
            this.textBoxFirstname.Text = "first name";
            this.textBoxFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFirstname.Enter += new System.EventHandler(this.textBoxFirstname_Enter);
            this.textBoxFirstname.Leave += new System.EventHandler(this.textBoxFirstname_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGreen;
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 89);
            this.panel2.TabIndex = 0;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelClose.Location = new System.Drawing.Point(779, -1);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(20, 17);
            this.labelClose.TabIndex = 1;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.Enter += new System.EventHandler(this.labelClose_Enter);
            this.labelClose.Leave += new System.EventHandler(this.labelClose_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(313, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bCreateAccount;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Button bGoLogin;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}