namespace EBookClient
{
    partial class SearchForBookForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BookNameField = new System.Windows.Forms.TextBox();
            this.GenreNamrField = new System.Windows.Forms.TextBox();
            this.CategoryField = new System.Windows.Forms.TextBox();
            this.AuthorField = new System.Windows.Forms.TextBox();
            this.AlterNameField = new System.Windows.Forms.TextBox();
            this.PublishedField = new System.Windows.Forms.TextBox();
            this.PublisherField = new System.Windows.Forms.TextBox();
            this.PriceField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CreatedField = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 27);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть назву книжки";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 66);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Знайти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CreatedField);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PriceField);
            this.groupBox1.Controls.Add(this.PublisherField);
            this.groupBox1.Controls.Add(this.PublishedField);
            this.groupBox1.Controls.Add(this.AlterNameField);
            this.groupBox1.Controls.Add(this.AuthorField);
            this.groupBox1.Controls.Add(this.CategoryField);
            this.groupBox1.Controls.Add(this.GenreNamrField);
            this.groupBox1.Controls.Add(this.BookNameField);
            this.groupBox1.Location = new System.Drawing.Point(198, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(284, 565);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Інформація про книгу";
            // 
            // BookNameField
            // 
            this.BookNameField.Location = new System.Drawing.Point(5, 47);
            this.BookNameField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BookNameField.Name = "BookNameField";
            this.BookNameField.Size = new System.Drawing.Size(258, 27);
            this.BookNameField.TabIndex = 0;
            // 
            // GenreNamrField
            // 
            this.GenreNamrField.Location = new System.Drawing.Point(5, 98);
            this.GenreNamrField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GenreNamrField.Name = "GenreNamrField";
            this.GenreNamrField.Size = new System.Drawing.Size(258, 27);
            this.GenreNamrField.TabIndex = 1;
            // 
            // CategoryField
            // 
            this.CategoryField.Location = new System.Drawing.Point(4, 155);
            this.CategoryField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategoryField.Name = "CategoryField";
            this.CategoryField.Size = new System.Drawing.Size(258, 27);
            this.CategoryField.TabIndex = 2;
            // 
            // AuthorField
            // 
            this.AuthorField.Location = new System.Drawing.Point(4, 214);
            this.AuthorField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AuthorField.Name = "AuthorField";
            this.AuthorField.Size = new System.Drawing.Size(258, 27);
            this.AuthorField.TabIndex = 3;
            // 
            // AlterNameField
            // 
            this.AlterNameField.Location = new System.Drawing.Point(4, 271);
            this.AlterNameField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AlterNameField.Name = "AlterNameField";
            this.AlterNameField.Size = new System.Drawing.Size(258, 27);
            this.AlterNameField.TabIndex = 4;
            // 
            // PublishedField
            // 
            this.PublishedField.Location = new System.Drawing.Point(5, 333);
            this.PublishedField.Margin = new System.Windows.Forms.Padding(2);
            this.PublishedField.Name = "PublishedField";
            this.PublishedField.Size = new System.Drawing.Size(258, 27);
            this.PublishedField.TabIndex = 5;
            // 
            // PublisherField
            // 
            this.PublisherField.Location = new System.Drawing.Point(4, 388);
            this.PublisherField.Margin = new System.Windows.Forms.Padding(2);
            this.PublisherField.Name = "PublisherField";
            this.PublisherField.Size = new System.Drawing.Size(258, 27);
            this.PublisherField.TabIndex = 6;
            // 
            // PriceField
            // 
            this.PriceField.Location = new System.Drawing.Point(5, 454);
            this.PriceField.Margin = new System.Windows.Forms.Padding(2);
            this.PriceField.Name = "PriceField";
            this.PriceField.Size = new System.Drawing.Size(258, 27);
            this.PriceField.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Назва книжки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Жанр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Категорія";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Автор";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Альтер Ім\'я";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Видано";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Видавець";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Ціна";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Написана";
            // 
            // CreatedField
            // 
            this.CreatedField.Location = new System.Drawing.Point(4, 515);
            this.CreatedField.Margin = new System.Windows.Forms.Padding(2);
            this.CreatedField.Name = "CreatedField";
            this.CreatedField.Size = new System.Drawing.Size(258, 27);
            this.CreatedField.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Очистити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchForBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 580);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SearchForBookForm";
            this.Text = "Про книгу";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PublisherField;
        private System.Windows.Forms.TextBox PublishedField;
        private System.Windows.Forms.TextBox AlterNameField;
        private System.Windows.Forms.TextBox AuthorField;
        private System.Windows.Forms.TextBox CategoryField;
        private System.Windows.Forms.TextBox GenreNamrField;
        private System.Windows.Forms.TextBox BookNameField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CreatedField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PriceField;
        private System.Windows.Forms.Button button2;
    }
}