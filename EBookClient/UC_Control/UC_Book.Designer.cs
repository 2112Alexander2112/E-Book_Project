namespace EBookClient.UC_Control
{
    partial class UC_Book
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.AddToOrderButton = new System.Windows.Forms.Button();
            this.AddToWishlistButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Location = new System.Drawing.Point(4, 204);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(133, 23);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.Location = new System.Drawing.Point(7, 231);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(130, 23);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Author";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 3);
            this.panel1.TabIndex = 3;
            // 
            // ImageBox
            // 
            this.ImageBox.BackColor = System.Drawing.Color.White;
            this.ImageBox.Image = global::EBookClient.Properties.Resources.No_Image_Available;
            this.ImageBox.Location = new System.Drawing.Point(0, 13);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(140, 187);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 0;
            this.ImageBox.TabStop = false;
            this.ImageBox.MouseEnter += new System.EventHandler(this.ImageBox_MouseEnter);
            this.ImageBox.MouseLeave += new System.EventHandler(this.ImageBox_MouseLeave);
            // 
            // PriceLabel
            // 
            this.PriceLabel.Location = new System.Drawing.Point(7, 254);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(130, 23);
            this.PriceLabel.TabIndex = 10;
            this.PriceLabel.Text = "Price";
            // 
            // AddToOrderButton
            // 
            this.AddToOrderButton.Location = new System.Drawing.Point(13, 307);
            this.AddToOrderButton.Name = "AddToOrderButton";
            this.AddToOrderButton.Size = new System.Drawing.Size(107, 23);
            this.AddToOrderButton.TabIndex = 9;
            this.AddToOrderButton.Text = "Add to order";
            this.AddToOrderButton.UseVisualStyleBackColor = true;
            this.AddToOrderButton.Click += new System.EventHandler(this.AddToOrderButton_Click);
            // 
            // AddToWishlistButton
            // 
            this.AddToWishlistButton.Location = new System.Drawing.Point(13, 276);
            this.AddToWishlistButton.Name = "AddToWishlistButton";
            this.AddToWishlistButton.Size = new System.Drawing.Size(107, 23);
            this.AddToWishlistButton.TabIndex = 8;
            this.AddToWishlistButton.Text = "Add to wishlist";
            this.AddToWishlistButton.UseVisualStyleBackColor = true;
            this.AddToWishlistButton.Click += new System.EventHandler(this.AddToWishlistButton_Click);
            // 
            // UC_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.AddToOrderButton);
            this.Controls.Add(this.AddToWishlistButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ImageBox);
            this.MaximumSize = new System.Drawing.Size(140, 340);
            this.MinimumSize = new System.Drawing.Size(140, 260);
            this.Name = "UC_Book";
            this.Size = new System.Drawing.Size(140, 340);
            this.MouseEnter += new System.EventHandler(this.UC_Book_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UC_Book_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button AddToOrderButton;
        private System.Windows.Forms.Button AddToWishlistButton;
    }
}
