namespace MagazinTEST
{
    partial class Cars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cars));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewCars = new System.Windows.Forms.DataGridView();
            this.bShowDetails = new System.Windows.Forms.Button();
            this.bReview = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 65);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of our cars";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 56);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.AllowUserToResizeColumns = false;
            this.dataGridViewCars.AllowUserToResizeRows = false;
            this.dataGridViewCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCars.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCars.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Location = new System.Drawing.Point(12, 71);
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.ReadOnly = true;
            this.dataGridViewCars.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewCars.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewCars.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCars.RowTemplate.Height = 20;
            this.dataGridViewCars.RowTemplate.ReadOnly = true;
            this.dataGridViewCars.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCars.Size = new System.Drawing.Size(648, 321);
            this.dataGridViewCars.TabIndex = 1;
            // 
            // bShowDetails
            // 
            this.bShowDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bShowDetails.FlatAppearance.BorderSize = 0;
            this.bShowDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bShowDetails.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bShowDetails.ForeColor = System.Drawing.Color.Black;
            this.bShowDetails.Location = new System.Drawing.Point(373, 398);
            this.bShowDetails.Name = "bShowDetails";
            this.bShowDetails.Size = new System.Drawing.Size(108, 38);
            this.bShowDetails.TabIndex = 2;
            this.bShowDetails.Text = "Show details";
            this.bShowDetails.UseVisualStyleBackColor = false;
            this.bShowDetails.Click += new System.EventHandler(this.bShowDetails_Click);
            // 
            // bReview
            // 
            this.bReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bReview.FlatAppearance.BorderSize = 0;
            this.bReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReview.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReview.ForeColor = System.Drawing.Color.Black;
            this.bReview.Location = new System.Drawing.Point(487, 398);
            this.bReview.Name = "bReview";
            this.bReview.Size = new System.Drawing.Size(108, 38);
            this.bReview.TabIndex = 3;
            this.bReview.Text = "Review";
            this.bReview.UseVisualStyleBackColor = false;
            this.bReview.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cars
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bReview);
            this.Controls.Add(this.bShowDetails);
            this.Controls.Add(this.dataGridViewCars);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cars";
            this.Text = "Cars";
            this.Load += new System.EventHandler(this.Cars_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bShowDetails;
        private System.Windows.Forms.Button bReview;
        public System.Windows.Forms.DataGridView dataGridViewCars;
    }
}