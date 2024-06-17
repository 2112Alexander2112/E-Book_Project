namespace EBookClient.UC_Control
{
    partial class UC_WhishList
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
            this.SearchField = new EBookLib01.Controls.RoundTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FiltersButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNextFast = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonPreviousPage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchField
            // 
            this.SearchField.BackColor = System.Drawing.Color.White;
            this.SearchField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.SearchField.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.SearchField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchField.Dock = System.Windows.Forms.DockStyle.Left;
            this.SearchField.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchField.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.SearchField.ForeColor = System.Drawing.Color.Black;
            this.SearchField.Location = new System.Drawing.Point(133, 0);
            this.SearchField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchField.MaximumSize = new System.Drawing.Size(339, 49);
            this.SearchField.MinimumSize = new System.Drawing.Size(339, 49);
            this.SearchField.Name = "SearchField";
            this.SearchField.SelectionStart = 0;
            this.SearchField.Size = new System.Drawing.Size(339, 49);
            this.SearchField.TabIndex = 0;
            this.SearchField.TextInput = "";
            this.SearchField.TextPreview = "Search Wishlist";
            this.SearchField.UseSystemPasswordChar = false;
            this.SearchField.TextChanged += new System.EventHandler(this.SearchField_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::EBookClient.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FiltersButton);
            this.panel2.Controls.Add(this.SearchField);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 63);
            this.panel2.TabIndex = 12;
            // 
            // FiltersButton
            // 
            this.FiltersButton.Location = new System.Drawing.Point(1011, 17);
            this.FiltersButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FiltersButton.Name = "FiltersButton";
            this.FiltersButton.Size = new System.Drawing.Size(139, 32);
            this.FiltersButton.TabIndex = 3;
            this.FiltersButton.Text = "More Filters";
            this.FiltersButton.UseVisualStyleBackColor = true;
            this.FiltersButton.Click += new System.EventHandler(this.FiltersButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonNextFast);
            this.panel1.Controls.Add(this.buttonBack);
            this.panel1.Controls.Add(this.buttonPreviousPage);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 873);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 63);
            this.panel1.TabIndex = 13;
            // 
            // buttonNextFast
            // 
            this.buttonNextFast.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNextFast.Image = global::EBookClient.Properties.Resources.fast_forward;
            this.buttonNextFast.Location = new System.Drawing.Point(934, 0);
            this.buttonNextFast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNextFast.Name = "buttonNextFast";
            this.buttonNextFast.Size = new System.Drawing.Size(133, 63);
            this.buttonNextFast.TabIndex = 6;
            this.buttonNextFast.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBack.Image = global::EBookClient.Properties.Resources.fast_forward_back;
            this.buttonBack.Location = new System.Drawing.Point(133, 0);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(133, 63);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonPreviousPage
            // 
            this.buttonPreviousPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPreviousPage.Image = global::EBookClient.Properties.Resources.back;
            this.buttonPreviousPage.Location = new System.Drawing.Point(0, 0);
            this.buttonPreviousPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPreviousPage.Name = "buttonPreviousPage";
            this.buttonPreviousPage.Size = new System.Drawing.Size(133, 63);
            this.buttonPreviousPage.TabIndex = 7;
            this.buttonPreviousPage.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(596, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(37, 53);
            this.textBox1.TabIndex = 3;
            // 
            // buttonNext
            // 
            this.buttonNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonNext.Image = global::EBookClient.Properties.Resources.next;
            this.buttonNext.Location = new System.Drawing.Point(1067, 0);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(133, 63);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1200, 810);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // UC_WhishList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_WhishList";
            this.Size = new System.Drawing.Size(1200, 936);
            this.Load += new System.EventHandler(this.UC_WhishList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private EBookLib01.Controls.RoundTextBox SearchField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonNextFast;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonPreviousPage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button FiltersButton;
    }
}
