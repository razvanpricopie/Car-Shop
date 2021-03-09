namespace MagazinTEST
{
    partial class NewCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bAddCar = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxPret = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.dataGridViewShowCars = new System.Windows.Forms.DataGridView();
            this.labelBody = new System.Windows.Forms.Label();
            this.labelMileage = new System.Windows.Forms.Label();
            this.labelGearbox = new System.Windows.Forms.Label();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.textBoxMileage = new System.Windows.Forms.TextBox();
            this.textBoxGearbox = new System.Windows.Forms.TextBox();
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCars)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(792, 65);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add a new car";
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
            // bAddCar
            // 
            this.bAddCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bAddCar.FlatAppearance.BorderSize = 0;
            this.bAddCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddCar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddCar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bAddCar.Location = new System.Drawing.Point(76, 427);
            this.bAddCar.Name = "bAddCar";
            this.bAddCar.Size = new System.Drawing.Size(151, 31);
            this.bAddCar.TabIndex = 3;
            this.bAddCar.Text = "Add";
            this.bAddCar.UseVisualStyleBackColor = false;
            this.bAddCar.Click += new System.EventHandler(this.bAddCar_Click);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bDelete.FlatAppearance.BorderSize = 0;
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelete.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bDelete.Location = new System.Drawing.Point(275, 427);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(151, 31);
            this.bDelete.TabIndex = 4;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bUpdate.FlatAppearance.BorderSize = 0;
            this.bUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUpdate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bUpdate.Location = new System.Drawing.Point(487, 427);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(151, 31);
            this.bUpdate.TabIndex = 5;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = false;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Model";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pret";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(12, 372);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 17);
            this.labelID.TabIndex = 18;
            this.labelID.Text = "ID";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(179, 71);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(479, 20);
            this.textBoxBrand.TabIndex = 12;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(179, 107);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(479, 20);
            this.textBoxYear.TabIndex = 13;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(179, 140);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(479, 20);
            this.textBoxModel.TabIndex = 14;
            // 
            // textBoxPret
            // 
            this.textBoxPret.Location = new System.Drawing.Point(179, 175);
            this.textBoxPret.Name = "textBoxPret";
            this.textBoxPret.Size = new System.Drawing.Size(479, 20);
            this.textBoxPret.TabIndex = 16;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(179, 372);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(479, 20);
            this.textBoxID.TabIndex = 17;
            // 
            // dataGridViewShowCars
            // 
            this.dataGridViewShowCars.AllowUserToAddRows = false;
            this.dataGridViewShowCars.AllowUserToDeleteRows = false;
            this.dataGridViewShowCars.AllowUserToResizeColumns = false;
            this.dataGridViewShowCars.AllowUserToResizeRows = false;
            this.dataGridViewShowCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShowCars.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewShowCars.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewShowCars.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewShowCars.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewShowCars.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewShowCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowCars.GridColor = System.Drawing.Color.White;
            this.dataGridViewShowCars.Location = new System.Drawing.Point(46, 482);
            this.dataGridViewShowCars.Name = "dataGridViewShowCars";
            this.dataGridViewShowCars.RowHeadersWidth = 51;
            this.dataGridViewShowCars.Size = new System.Drawing.Size(646, 253);
            this.dataGridViewShowCars.TabIndex = 11;
            // 
            // labelBody
            // 
            this.labelBody.AutoSize = true;
            this.labelBody.Location = new System.Drawing.Point(9, 333);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(50, 13);
            this.labelBody.TabIndex = 34;
            this.labelBody.Text = "Car Body";
            // 
            // labelMileage
            // 
            this.labelMileage.AutoSize = true;
            this.labelMileage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMileage.Location = new System.Drawing.Point(9, 296);
            this.labelMileage.Name = "labelMileage";
            this.labelMileage.Size = new System.Drawing.Size(96, 17);
            this.labelMileage.TabIndex = 33;
            this.labelMileage.Text = "Mileage meter";
            // 
            // labelGearbox
            // 
            this.labelGearbox.AutoSize = true;
            this.labelGearbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGearbox.Location = new System.Drawing.Point(9, 257);
            this.labelGearbox.Name = "labelGearbox";
            this.labelGearbox.Size = new System.Drawing.Size(60, 17);
            this.labelGearbox.TabIndex = 32;
            this.labelGearbox.Text = "Gearbox";
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapacity.Location = new System.Drawing.Point(6, 215);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(125, 17);
            this.labelCapacity.TabIndex = 31;
            this.labelCapacity.Text = "Cilindrical Capacity";
            // 
            // textBoxBody
            // 
            this.textBoxBody.Location = new System.Drawing.Point(179, 333);
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(479, 20);
            this.textBoxBody.TabIndex = 30;
            // 
            // textBoxMileage
            // 
            this.textBoxMileage.Location = new System.Drawing.Point(179, 296);
            this.textBoxMileage.Name = "textBoxMileage";
            this.textBoxMileage.Size = new System.Drawing.Size(479, 20);
            this.textBoxMileage.TabIndex = 29;
            // 
            // textBoxGearbox
            // 
            this.textBoxGearbox.Location = new System.Drawing.Point(179, 254);
            this.textBoxGearbox.Name = "textBoxGearbox";
            this.textBoxGearbox.Size = new System.Drawing.Size(479, 20);
            this.textBoxGearbox.TabIndex = 28;
            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.Location = new System.Drawing.Point(179, 212);
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.Size = new System.Drawing.Size(479, 20);
            this.textBoxCapacity.TabIndex = 27;
            // 
            // NewCar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(100, 100);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(753, 788);
            this.Controls.Add(this.labelBody);
            this.Controls.Add(this.labelMileage);
            this.Controls.Add(this.labelGearbox);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.textBoxMileage);
            this.Controls.Add(this.textBoxGearbox);
            this.Controls.Add(this.textBoxCapacity);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxPret);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.dataGridViewShowCars);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bAddCar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewCar";
            this.Text = "NewCar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bAddCar;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxPret;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.DataGridView dataGridViewShowCars;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.Label labelMileage;
        private System.Windows.Forms.Label labelGearbox;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.TextBox textBoxMileage;
        private System.Windows.Forms.TextBox textBoxGearbox;
        private System.Windows.Forms.TextBox textBoxCapacity;
    }
}