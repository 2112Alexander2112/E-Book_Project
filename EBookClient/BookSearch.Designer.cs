namespace EBookClient
{
    partial class BookSearch
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
            this.button1 = new System.Windows.Forms.Button();
            this.ClearField = new System.Windows.Forms.Button();
            this.BookSerch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GenreField = new System.Windows.Forms.TextBox();
            this.AuthorField = new System.Windows.Forms.TextBox();
            this.PriceField = new System.Windows.Forms.TextBox();
            this.PublisherField = new System.Windows.Forms.TextBox();
            this.Published = new System.Windows.Forms.TextBox();
            this.AlterName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Знайти книжку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearField
            // 
            this.ClearField.Location = new System.Drawing.Point(21, 114);
            this.ClearField.Name = "ClearField";
            this.ClearField.Size = new System.Drawing.Size(142, 41);
            this.ClearField.TabIndex = 1;
            this.ClearField.Text = "Очистити поле";
            this.ClearField.UseVisualStyleBackColor = true;
            this.ClearField.Click += new System.EventHandler(this.ClearField_Click);
            // 
            // BookSerch
            // 
            this.BookSerch.Location = new System.Drawing.Point(11, 37);
            this.BookSerch.Name = "BookSerch";
            this.BookSerch.Size = new System.Drawing.Size(168, 22);
            this.BookSerch.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AlterName);
            this.groupBox1.Controls.Add(this.Published);
            this.groupBox1.Controls.Add(this.PublisherField);
            this.groupBox1.Controls.Add(this.PriceField);
            this.groupBox1.Controls.Add(this.AuthorField);
            this.groupBox1.Controls.Add(this.GenreField);
            this.groupBox1.Location = new System.Drawing.Point(192, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 425);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // GenreField
            // 
            this.GenreField.Location = new System.Drawing.Point(25, 64);
            this.GenreField.Name = "GenreField";
            this.GenreField.Size = new System.Drawing.Size(148, 22);
            this.GenreField.TabIndex = 0;
            // 
            // AuthorField
            // 
            this.AuthorField.Location = new System.Drawing.Point(25, 111);
            this.AuthorField.Name = "AuthorField";
            this.AuthorField.Size = new System.Drawing.Size(148, 22);
            this.AuthorField.TabIndex = 1;
            // 
            // PriceField
            // 
            this.PriceField.Location = new System.Drawing.Point(25, 166);
            this.PriceField.Name = "PriceField";
            this.PriceField.Size = new System.Drawing.Size(148, 22);
            this.PriceField.TabIndex = 2;
            // 
            // PublisherField
            // 
            this.PublisherField.Location = new System.Drawing.Point(25, 222);
            this.PublisherField.Name = "PublisherField";
            this.PublisherField.Size = new System.Drawing.Size(148, 22);
            this.PublisherField.TabIndex = 3;
            // 
            // Published
            // 
            this.Published.Location = new System.Drawing.Point(25, 280);
            this.Published.Name = "Published";
            this.Published.Size = new System.Drawing.Size(148, 22);
            this.Published.TabIndex = 4;
            // 
            // AlterName
            // 
            this.AlterName.Location = new System.Drawing.Point(25, 336);
            this.AlterName.Name = "AlterName";
            this.AlterName.Size = new System.Drawing.Size(148, 22);
            this.AlterName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Жанр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ціна";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Видавець";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Видано";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Альтер ім\'я";
            // 
            // BookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BookSerch);
            this.Controls.Add(this.ClearField);
            this.Controls.Add(this.button1);
            this.Name = "BookSearch";
            this.Text = "BookSearch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ClearField;
        private System.Windows.Forms.TextBox BookSerch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AlterName;
        private System.Windows.Forms.TextBox Published;
        private System.Windows.Forms.TextBox PublisherField;
        private System.Windows.Forms.TextBox PriceField;
        private System.Windows.Forms.TextBox AuthorField;
        private System.Windows.Forms.TextBox GenreField;
    }
}