namespace EBookClient.UC_Control
{
    partial class UC_Friends
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
            this.FriendNameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.Remove_Friend_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FriendNameLabel
            // 
            this.FriendNameLabel.Location = new System.Drawing.Point(4, 204);
            this.FriendNameLabel.Name = "FriendNameLabel";
            this.FriendNameLabel.Size = new System.Drawing.Size(133, 23);
            this.FriendNameLabel.TabIndex = 1;
            this.FriendNameLabel.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 257);
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
            // Remove_Friend_Button
            // 
            this.Remove_Friend_Button.Location = new System.Drawing.Point(30, 221);
            this.Remove_Friend_Button.Name = "Remove_Friend_Button";
            this.Remove_Friend_Button.Size = new System.Drawing.Size(67, 30);
            this.Remove_Friend_Button.TabIndex = 4;
            this.Remove_Friend_Button.Text = "Remove";
            this.Remove_Friend_Button.UseVisualStyleBackColor = true;
            this.Remove_Friend_Button.Click += new System.EventHandler(this.Remove_Friend_Button_Click);
            // 
            // UC_Friends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Remove_Friend_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FriendNameLabel);
            this.Controls.Add(this.ImageBox);
            this.MaximumSize = new System.Drawing.Size(140, 260);
            this.MinimumSize = new System.Drawing.Size(140, 260);
            this.Name = "UC_Friends";
            this.Size = new System.Drawing.Size(140, 260);
            this.MouseEnter += new System.EventHandler(this.UC_Book_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UC_Book_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Label FriendNameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Remove_Friend_Button;
    }
}
