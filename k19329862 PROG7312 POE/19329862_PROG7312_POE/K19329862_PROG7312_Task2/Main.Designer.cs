namespace K19329862_PROG7312_Task1
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblReplace = new System.Windows.Forms.Label();
            this.lblIdentify = new System.Windows.Forms.Label();
            this.lblFind = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBooks
            // 
            this.btnBooks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBooks.BackgroundImage")));
            this.btnBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBooks.Location = new System.Drawing.Point(52, 150);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(149, 142);
            this.btnBooks.TabIndex = 0;
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnIdentify
            // 
            this.btnIdentify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIdentify.BackgroundImage")));
            this.btnIdentify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIdentify.Location = new System.Drawing.Point(298, 150);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(149, 142);
            this.btnIdentify.TabIndex = 1;
            this.btnIdentify.UseVisualStyleBackColor = true;
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFind.BackgroundImage")));
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFind.Location = new System.Drawing.Point(532, 150);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(149, 142);
            this.btnFind.TabIndex = 2;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplace.Location = new System.Drawing.Point(69, 295);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(102, 16);
            this.lblReplace.TabIndex = 3;
            this.lblReplace.Text = "Replacing Books";
            // 
            // lblIdentify
            // 
            this.lblIdentify.AutoSize = true;
            this.lblIdentify.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentify.Location = new System.Drawing.Point(317, 295);
            this.lblIdentify.Name = "lblIdentify";
            this.lblIdentify.Size = new System.Drawing.Size(107, 16);
            this.lblIdentify.TabIndex = 4;
            this.lblIdentify.Text = "Identifying Areas";
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFind.Location = new System.Drawing.Point(548, 295);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(115, 16);
            this.lblFind.TabIndex = 5;
            this.lblFind.Text = "Find Call Numbers";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(176, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(375, 62);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Library Shelf";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 357);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblFind);
            this.Controls.Add(this.lblIdentify);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnIdentify);
            this.Controls.Add(this.btnBooks);
            this.Name = "frmMain";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnIdentify;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Label lblIdentify;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Label lblTitle;
    }
}

