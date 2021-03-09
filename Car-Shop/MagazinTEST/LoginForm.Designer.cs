namespace MagazinTEST
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGoReg = new System.Windows.Forms.Button();
            this.labelClose = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGreen;
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Location = new System.Drawing.Point(287, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "User login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 36);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(107, 137);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(589, 22);
            this.textBoxUserName.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(50, 219);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 28);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(107, 219);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(589, 22);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.Color.PaleGreen;
            this.bLogin.FlatAppearance.BorderSize = 0;
            this.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogin.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.Location = new System.Drawing.Point(260, 301);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(233, 55);
            this.bLogin.TabIndex = 5;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.buttonGoReg);
            this.panel1.Controls.Add(this.bLogin);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.textBoxUserName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // buttonGoReg
            // 
            this.buttonGoReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonGoReg.FlatAppearance.BorderSize = 0;
            this.buttonGoReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoReg.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoReg.Location = new System.Drawing.Point(260, 390);
            this.buttonGoReg.Name = "buttonGoReg";
            this.buttonGoReg.Size = new System.Drawing.Size(233, 23);
            this.buttonGoReg.TabIndex = 6;
            this.buttonGoReg.Text = "Create account";
            this.buttonGoReg.UseVisualStyleBackColor = false;
            this.buttonGoReg.Click += new System.EventHandler(this.buttonGoReg_Click);
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
            this.labelClose.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGoReg;
        private System.Windows.Forms.Label labelClose;
    }
}