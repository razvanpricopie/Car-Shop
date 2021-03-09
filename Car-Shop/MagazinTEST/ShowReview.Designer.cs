namespace MagazinTEST
{
    partial class ShowReview
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxShowReview = new System.Windows.Forms.TextBox();
            this.textBoxCarReview = new System.Windows.Forms.TextBox();
            this.bSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxReviewModel = new System.Windows.Forms.TextBox();
            this.labelClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Review";
            // 
            // textBoxShowReview
            // 
            this.textBoxShowReview.Location = new System.Drawing.Point(176, 85);
            this.textBoxShowReview.Multiline = true;
            this.textBoxShowReview.Name = "textBoxShowReview";
            this.textBoxShowReview.Size = new System.Drawing.Size(536, 224);
            this.textBoxShowReview.TabIndex = 18;
            // 
            // textBoxCarReview
            // 
            this.textBoxCarReview.BackColor = System.Drawing.Color.White;
            this.textBoxCarReview.Location = new System.Drawing.Point(176, 12);
            this.textBoxCarReview.Name = "textBoxCarReview";
            this.textBoxCarReview.ReadOnly = true;
            this.textBoxCarReview.Size = new System.Drawing.Size(536, 20);
            this.textBoxCarReview.TabIndex = 19;
            // 
            // bSubmit
            // 
            this.bSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bSubmit.FlatAppearance.BorderSize = 0;
            this.bSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSubmit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSubmit.ForeColor = System.Drawing.Color.Black;
            this.bSubmit.Location = new System.Drawing.Point(604, 340);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(108, 38);
            this.bSubmit.TabIndex = 20;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = false;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Model";
            // 
            // textBoxReviewModel
            // 
            this.textBoxReviewModel.BackColor = System.Drawing.Color.White;
            this.textBoxReviewModel.Location = new System.Drawing.Point(176, 41);
            this.textBoxReviewModel.Name = "textBoxReviewModel";
            this.textBoxReviewModel.ReadOnly = true;
            this.textBoxReviewModel.Size = new System.Drawing.Size(536, 20);
            this.textBoxReviewModel.TabIndex = 22;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.White;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.Black;
            this.labelClose.Location = new System.Drawing.Point(768, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(20, 17);
            this.labelClose.TabIndex = 23;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // ShowReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.textBoxReviewModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.textBoxCarReview);
            this.Controls.Add(this.textBoxShowReview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowReview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxShowReview;
        private System.Windows.Forms.Button bSubmit;
        public System.Windows.Forms.TextBox textBoxCarReview;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxReviewModel;
        private System.Windows.Forms.Label labelClose;
    }
}