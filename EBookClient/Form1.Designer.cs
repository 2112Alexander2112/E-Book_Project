namespace EBookClient
{
    partial class Form1
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
            this.AboutBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AboutBook
            // 
            this.AboutBook.Location = new System.Drawing.Point(53, 59);
            this.AboutBook.Name = "AboutBook";
            this.AboutBook.Size = new System.Drawing.Size(187, 50);
            this.AboutBook.TabIndex = 0;
            this.AboutBook.Text = "Про книгу";
            this.AboutBook.UseVisualStyleBackColor = true;
            this.AboutBook.Click += new System.EventHandler(this.AboutBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 158);
            this.Controls.Add(this.AboutBook);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AboutBook;
    }
}

