namespace EBookClient
{
    partial class AddBookForm
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
            this.components = new System.ComponentModel.Container();
            this.eBookBaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genresField = new System.Windows.Forms.ComboBox();
            this.genresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._EBookServer_EF_ORM_DataManagerDataSet3 = new EBookClient._EBookServer_EF_ORM_DataManagerDataSet3();
            this._EBookServer_EF_ORM_DataManagerDataSet = new EBookClient._EBookServer_EF_ORM_DataManagerDataSet();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new EBookClient._EBookServer_EF_ORM_DataManagerDataSetTableAdapters.CategoriesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryField = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._EBookServer_EF_ORM_DataManagerDataSet1 = new EBookClient._EBookServer_EF_ORM_DataManagerDataSet1();
            this.categoriesTableAdapter1 = new EBookClient._EBookServer_EF_ORM_DataManagerDataSet1TableAdapters.CategoriesTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.authorField = new System.Windows.Forms.ComboBox();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._EBookServer_EF_ORM_DataManagerDataSet2 = new EBookClient._EBookServer_EF_ORM_DataManagerDataSet2();
            this.authorsTableAdapter = new EBookClient._EBookServer_EF_ORM_DataManagerDataSet2TableAdapters.AuthorsTableAdapter();
            this.genresTableAdapter = new EBookClient._EBookServer_EF_ORM_DataManagerDataSet3TableAdapters.GenresTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.alterNameField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.publishedDateField = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.publishedField = new System.Windows.Forms.ComboBox();
            this.publishersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._EBookServer_EF_ORM_DataManagerDataSet4 = new EBookClient._EBookServer_EF_ORM_DataManagerDataSet4();
            this.publishersTableAdapter = new EBookClient._EBookServer_EF_ORM_DataManagerDataSet4TableAdapters.PublishersTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.bookInfoField = new System.Windows.Forms.ComboBox();
            this.bookInfoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._EBookServer_EF_ORM_DataManagerDataSet5 = new EBookClient._EBookServer_EF_ORM_DataManagerDataSet5();
            this.bookInfoesTableAdapter = new EBookClient._EBookServer_EF_ORM_DataManagerDataSet5TableAdapters.BookInfoesTableAdapter();
            this.priceField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.iconPathField = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.addBookButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eBookBaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._EBookServer_EF_ORM_DataManagerDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._EBookServer_EF_ORM_DataManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._EBookServer_EF_ORM_DataManagerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._EBookServer_EF_ORM_DataManagerDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._EBookServer_EF_ORM_DataManagerDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookInfoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._EBookServer_EF_ORM_DataManagerDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // eBookBaseBindingSource
            // 
            this.eBookBaseBindingSource.DataSource = typeof(EBookServer.EF_ORM.DataManager);
            // 
            // genresField
            // 
            this.genresField.DataSource = this.genresBindingSource;
            this.genresField.DisplayMember = "GenreName";
            this.genresField.FormattingEnabled = true;
            this.genresField.Location = new System.Drawing.Point(252, 27);
            this.genresField.Margin = new System.Windows.Forms.Padding(4);
            this.genresField.Name = "genresField";
            this.genresField.Size = new System.Drawing.Size(228, 26);
            this.genresField.TabIndex = 1;
            this.genresField.ValueMember = "GenreName";
            // 
            // genresBindingSource
            // 
            this.genresBindingSource.DataMember = "Genres";
            this.genresBindingSource.DataSource = this._EBookServer_EF_ORM_DataManagerDataSet3;
            // 
            // _EBookServer_EF_ORM_DataManagerDataSet3
            // 
            this._EBookServer_EF_ORM_DataManagerDataSet3.DataSetName = "_EBookServer_EF_ORM_DataManagerDataSet3";
            this._EBookServer_EF_ORM_DataManagerDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _EBookServer_EF_ORM_DataManagerDataSet
            // 
            this._EBookServer_EF_ORM_DataManagerDataSet.DataSetName = "_EBookServer_EF_ORM_DataManagerDataSet";
            this._EBookServer_EF_ORM_DataManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this._EBookServer_EF_ORM_DataManagerDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Оберіть жанр:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Оберіть категорію:";
            // 
            // categoryField
            // 
            this.categoryField.DataSource = this.categoriesBindingSource1;
            this.categoryField.DisplayMember = "CategoryName";
            this.categoryField.FormattingEnabled = true;
            this.categoryField.Location = new System.Drawing.Point(252, 73);
            this.categoryField.Margin = new System.Windows.Forms.Padding(4);
            this.categoryField.Name = "categoryField";
            this.categoryField.Size = new System.Drawing.Size(228, 26);
            this.categoryField.TabIndex = 3;
            this.categoryField.ValueMember = "CategoryName";
            // 
            // categoriesBindingSource1
            // 
            this.categoriesBindingSource1.DataMember = "Categories";
            this.categoriesBindingSource1.DataSource = this._EBookServer_EF_ORM_DataManagerDataSet1;
            // 
            // _EBookServer_EF_ORM_DataManagerDataSet1
            // 
            this._EBookServer_EF_ORM_DataManagerDataSet1.DataSetName = "_EBookServer_EF_ORM_DataManagerDataSet1";
            this._EBookServer_EF_ORM_DataManagerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Оберіть автора:";
            // 
            // authorField
            // 
            this.authorField.DataSource = this.authorsBindingSource;
            this.authorField.DisplayMember = "AuthorName";
            this.authorField.FormattingEnabled = true;
            this.authorField.Location = new System.Drawing.Point(252, 126);
            this.authorField.Margin = new System.Windows.Forms.Padding(4);
            this.authorField.Name = "authorField";
            this.authorField.Size = new System.Drawing.Size(228, 26);
            this.authorField.TabIndex = 5;
            this.authorField.ValueMember = "AuthorName";
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this._EBookServer_EF_ORM_DataManagerDataSet2;
            // 
            // _EBookServer_EF_ORM_DataManagerDataSet2
            // 
            this._EBookServer_EF_ORM_DataManagerDataSet2.DataSetName = "_EBookServer_EF_ORM_DataManagerDataSet2";
            this._EBookServer_EF_ORM_DataManagerDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // genresTableAdapter
            // 
            this.genresTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введіть назву:";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(252, 177);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(228, 24);
            this.nameField.TabIndex = 8;
            // 
            // alterNameField
            // 
            this.alterNameField.Location = new System.Drawing.Point(252, 227);
            this.alterNameField.Name = "alterNameField";
            this.alterNameField.Size = new System.Drawing.Size(228, 24);
            this.alterNameField.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Alter name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Дата виходу:";
            // 
            // publishedDateField
            // 
            this.publishedDateField.Location = new System.Drawing.Point(252, 274);
            this.publishedDateField.Name = "publishedDateField";
            this.publishedDateField.Size = new System.Drawing.Size(228, 24);
            this.publishedDateField.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Оберіть видавництво:";
            // 
            // publishedField
            // 
            this.publishedField.DataSource = this.publishersBindingSource;
            this.publishedField.DisplayMember = "PublisherName";
            this.publishedField.FormattingEnabled = true;
            this.publishedField.Location = new System.Drawing.Point(252, 327);
            this.publishedField.Margin = new System.Windows.Forms.Padding(4);
            this.publishedField.Name = "publishedField";
            this.publishedField.Size = new System.Drawing.Size(228, 26);
            this.publishedField.TabIndex = 13;
            this.publishedField.ValueMember = "PublisherName";
            // 
            // publishersBindingSource
            // 
            this.publishersBindingSource.DataMember = "Publishers";
            this.publishersBindingSource.DataSource = this._EBookServer_EF_ORM_DataManagerDataSet4;
            // 
            // _EBookServer_EF_ORM_DataManagerDataSet4
            // 
            this._EBookServer_EF_ORM_DataManagerDataSet4.DataSetName = "_EBookServer_EF_ORM_DataManagerDataSet4";
            this._EBookServer_EF_ORM_DataManagerDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publishersTableAdapter
            // 
            this.publishersTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Інформація про книгу:";
            // 
            // bookInfoField
            // 
            this.bookInfoField.DataSource = this.bookInfoesBindingSource;
            this.bookInfoField.DisplayMember = "Id";
            this.bookInfoField.FormattingEnabled = true;
            this.bookInfoField.Location = new System.Drawing.Point(252, 383);
            this.bookInfoField.Margin = new System.Windows.Forms.Padding(4);
            this.bookInfoField.Name = "bookInfoField";
            this.bookInfoField.Size = new System.Drawing.Size(228, 26);
            this.bookInfoField.TabIndex = 15;
            this.bookInfoField.ValueMember = "Id";
            // 
            // bookInfoesBindingSource
            // 
            this.bookInfoesBindingSource.DataMember = "BookInfoes";
            this.bookInfoesBindingSource.DataSource = this._EBookServer_EF_ORM_DataManagerDataSet5;
            // 
            // _EBookServer_EF_ORM_DataManagerDataSet5
            // 
            this._EBookServer_EF_ORM_DataManagerDataSet5.DataSetName = "_EBookServer_EF_ORM_DataManagerDataSet5";
            this._EBookServer_EF_ORM_DataManagerDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookInfoesTableAdapter
            // 
            this.bookInfoesTableAdapter.ClearBeforeFill = true;
            // 
            // priceField
            // 
            this.priceField.Location = new System.Drawing.Point(252, 435);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(228, 24);
            this.priceField.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ціна:";
            // 
            // iconPathField
            // 
            this.iconPathField.Location = new System.Drawing.Point(252, 479);
            this.iconPathField.Name = "iconPathField";
            this.iconPathField.Size = new System.Drawing.Size(228, 24);
            this.iconPathField.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 482);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Шлях до обкладинки:";
            // 
            // addBookButton
            // 
            this.addBookButton.Location = new System.Drawing.Point(289, 514);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(162, 42);
            this.addBookButton.TabIndex = 21;
            this.addBookButton.Text = "Додати книгу";
            this.addBookButton.UseVisualStyleBackColor = true;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 568);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.iconPathField);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.priceField);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bookInfoField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.publishedField);
            this.Controls.Add(this.publishedDateField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.alterNameField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.authorField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categoryField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genresField);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddBookForm";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eBookBaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._EBookServer_EF_ORM_DataManagerDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._EBookServer_EF_ORM_DataManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._EBookServer_EF_ORM_DataManagerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._EBookServer_EF_ORM_DataManagerDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publishersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._EBookServer_EF_ORM_DataManagerDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookInfoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._EBookServer_EF_ORM_DataManagerDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource eBookBaseBindingSource;
        private System.Windows.Forms.ComboBox genresField;
        private _EBookServer_EF_ORM_DataManagerDataSet _EBookServer_EF_ORM_DataManagerDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private _EBookServer_EF_ORM_DataManagerDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categoryField;
        private _EBookServer_EF_ORM_DataManagerDataSet1 _EBookServer_EF_ORM_DataManagerDataSet1;
        private System.Windows.Forms.BindingSource categoriesBindingSource1;
        private _EBookServer_EF_ORM_DataManagerDataSet1TableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox authorField;
        private _EBookServer_EF_ORM_DataManagerDataSet2 _EBookServer_EF_ORM_DataManagerDataSet2;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private _EBookServer_EF_ORM_DataManagerDataSet2TableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private _EBookServer_EF_ORM_DataManagerDataSet3 _EBookServer_EF_ORM_DataManagerDataSet3;
        private System.Windows.Forms.BindingSource genresBindingSource;
        private _EBookServer_EF_ORM_DataManagerDataSet3TableAdapters.GenresTableAdapter genresTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox alterNameField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker publishedDateField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox publishedField;
        private _EBookServer_EF_ORM_DataManagerDataSet4 _EBookServer_EF_ORM_DataManagerDataSet4;
        private System.Windows.Forms.BindingSource publishersBindingSource;
        private _EBookServer_EF_ORM_DataManagerDataSet4TableAdapters.PublishersTableAdapter publishersTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox bookInfoField;
        private _EBookServer_EF_ORM_DataManagerDataSet5 _EBookServer_EF_ORM_DataManagerDataSet5;
        private System.Windows.Forms.BindingSource bookInfoesBindingSource;
        private _EBookServer_EF_ORM_DataManagerDataSet5TableAdapters.BookInfoesTableAdapter bookInfoesTableAdapter;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox iconPathField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button addBookButton;
    }
}