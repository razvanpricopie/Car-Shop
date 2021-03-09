namespace MagazinTEST
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.bReview = new System.Windows.Forms.Button();
            this.bCars = new System.Windows.Forms.Button();
            this.bContact = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.bHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bReview);
            this.panel1.Controls.Add(this.bCars);
            this.panel1.Controls.Add(this.bContact);
            this.panel1.Controls.Add(this.bExit);
            this.panel1.Controls.Add(this.bHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "WROOM !";
            // 
            // bReview
            // 
            this.bReview.FlatAppearance.BorderSize = 0;
            this.bReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReview.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bReview.Location = new System.Drawing.Point(3, 152);
            this.bReview.Name = "bReview";
            this.bReview.Size = new System.Drawing.Size(151, 31);
            this.bReview.TabIndex = 4;
            this.bReview.Text = "Reviews";
            this.bReview.UseVisualStyleBackColor = true;
            this.bReview.Click += new System.EventHandler(this.bReview_Click);
            // 
            // bCars
            // 
            this.bCars.FlatAppearance.BorderSize = 0;
            this.bCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCars.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bCars.Location = new System.Drawing.Point(0, 115);
            this.bCars.Name = "bCars";
            this.bCars.Size = new System.Drawing.Size(151, 31);
            this.bCars.TabIndex = 3;
            this.bCars.Text = "Cars";
            this.bCars.UseVisualStyleBackColor = true;
            this.bCars.Click += new System.EventHandler(this.bCars_Click);
            // 
            // bContact
            // 
            this.bContact.FlatAppearance.BorderSize = 0;
            this.bContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bContact.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bContact.Location = new System.Drawing.Point(3, 189);
            this.bContact.Name = "bContact";
            this.bContact.Size = new System.Drawing.Size(151, 31);
            this.bContact.TabIndex = 2;
            this.bContact.Text = "Contact";
            this.bContact.UseVisualStyleBackColor = true;
            this.bContact.Click += new System.EventHandler(this.button1_Click);
            // 
            // bExit
            // 
            this.bExit.FlatAppearance.BorderSize = 0;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Location = new System.Drawing.Point(0, 424);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(154, 23);
            this.bExit.TabIndex = 1;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // bHome
            // 
            this.bHome.FlatAppearance.BorderSize = 0;
            this.bHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bHome.Location = new System.Drawing.Point(1, 78);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(151, 31);
            this.bHome.TabIndex = 0;
            this.bHome.Text = "Home";
            this.bHome.UseVisualStyleBackColor = true;
            this.bHome.Click += new System.EventHandler(this.bHome_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(154, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 450);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bHome;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bReview;
        private System.Windows.Forms.Button bCars;
        private System.Windows.Forms.Button bContact;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}