namespace EBookClient.UC_Control
{
    partial class UC_MYLIBRARYBOOK
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.TitleLebel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.AboutLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageBox
            // 
            this.ImageBox.Location = new System.Drawing.Point(4, 4);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(100, 133);
            this.ImageBox.TabIndex = 0;
            this.ImageBox.TabStop = false;
            // 
            // TitleLebel
            // 
            this.TitleLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLebel.Location = new System.Drawing.Point(111, 4);
            this.TitleLebel.Name = "TitleLebel";
            this.TitleLebel.Size = new System.Drawing.Size(681, 32);
            this.TitleLebel.TabIndex = 1;
            this.TitleLebel.Text = "Title";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.Location = new System.Drawing.Point(116, 40);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(44, 20);
            this.DateLabel.TabIndex = 2;
            this.DateLabel.Text = "Date";
            // 
            // AboutLabel
            // 
            this.AboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutLabel.Location = new System.Drawing.Point(116, 64);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(676, 73);
            this.AboutLabel.TabIndex = 3;
            this.AboutLabel.Text = "About";
            // 
            // UC_MYLIBRARYBOOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AboutLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TitleLebel);
            this.Controls.Add(this.ImageBox);
            this.Name = "UC_MYLIBRARYBOOK";
            this.Size = new System.Drawing.Size(795, 140);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Label TitleLebel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label AboutLabel;
    }
}
