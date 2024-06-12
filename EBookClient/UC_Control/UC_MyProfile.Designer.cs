namespace EBookClient.UC_Control
{
    partial class UC_MyProfile
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
            this.ChangeImgButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.ChangeUsernameButton = new System.Windows.Forms.Button();
            this.ChangeDateOfBirthButton = new System.Windows.Forms.Button();
            this.ChangeGenderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ChangeEmailButton = new System.Windows.Forms.Button();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageBox
            // 
            this.ImageBox.BackColor = System.Drawing.Color.White;
            this.ImageBox.Image = global::EBookClient.Properties.Resources.No_Image_Available;
            this.ImageBox.Location = new System.Drawing.Point(33, 135);
            this.ImageBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(347, 398);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 1;
            this.ImageBox.TabStop = false;
            // 
            // ChangeImgButton
            // 
            this.ChangeImgButton.Location = new System.Drawing.Point(125, 543);
            this.ChangeImgButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChangeImgButton.Name = "ChangeImgButton";
            this.ChangeImgButton.Size = new System.Drawing.Size(158, 64);
            this.ChangeImgButton.TabIndex = 2;
            this.ChangeImgButton.Text = "Change Image";
            this.ChangeImgButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(522, 345);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 349);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date of Birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username: ";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(522, 228);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(212, 26);
            this.UsernameTextBox.TabIndex = 6;
            // 
            // ChangeUsernameButton
            // 
            this.ChangeUsernameButton.Location = new System.Drawing.Point(747, 224);
            this.ChangeUsernameButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeUsernameButton.Name = "ChangeUsernameButton";
            this.ChangeUsernameButton.Size = new System.Drawing.Size(93, 34);
            this.ChangeUsernameButton.TabIndex = 7;
            this.ChangeUsernameButton.Text = "Change";
            this.ChangeUsernameButton.UseVisualStyleBackColor = true;
            this.ChangeUsernameButton.Click += new System.EventHandler(this.ChangeUsernameButton_Click);
            // 
            // ChangeDateOfBirthButton
            // 
            this.ChangeDateOfBirthButton.Location = new System.Drawing.Point(747, 342);
            this.ChangeDateOfBirthButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeDateOfBirthButton.Name = "ChangeDateOfBirthButton";
            this.ChangeDateOfBirthButton.Size = new System.Drawing.Size(93, 34);
            this.ChangeDateOfBirthButton.TabIndex = 8;
            this.ChangeDateOfBirthButton.Text = "Change";
            this.ChangeDateOfBirthButton.UseVisualStyleBackColor = true;
            this.ChangeDateOfBirthButton.Click += new System.EventHandler(this.ChangeDateOfBirthButton_Click);
            // 
            // ChangeGenderButton
            // 
            this.ChangeGenderButton.Location = new System.Drawing.Point(747, 380);
            this.ChangeGenderButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeGenderButton.Name = "ChangeGenderButton";
            this.ChangeGenderButton.Size = new System.Drawing.Size(93, 34);
            this.ChangeGenderButton.TabIndex = 11;
            this.ChangeGenderButton.Text = "Change";
            this.ChangeGenderButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 384);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gender:";
            // 
            // ChangeEmailButton
            // 
            this.ChangeEmailButton.Location = new System.Drawing.Point(747, 264);
            this.ChangeEmailButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeEmailButton.Name = "ChangeEmailButton";
            this.ChangeEmailButton.Size = new System.Drawing.Size(93, 34);
            this.ChangeEmailButton.TabIndex = 14;
            this.ChangeEmailButton.Text = "Change";
            this.ChangeEmailButton.UseVisualStyleBackColor = true;
            this.ChangeEmailButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(522, 268);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(212, 26);
            this.EmailTextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 271);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email: ";
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(747, 302);
            this.ChangePasswordButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(93, 34);
            this.ChangePasswordButton.TabIndex = 17;
            this.ChangePasswordButton.Text = "Change";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(522, 306);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(212, 26);
            this.PasswordTextBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 309);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Password: ";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Location = new System.Drawing.Point(519, 381);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(215, 28);
            this.GenderComboBox.TabIndex = 18;
            // 
            // UC_MyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ChangeEmailButton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChangeGenderButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChangeDateOfBirthButton);
            this.Controls.Add(this.ChangeUsernameButton);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ChangeImgButton);
            this.Controls.Add(this.ImageBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_MyProfile";
            this.Size = new System.Drawing.Size(900, 760);
            this.Load += new System.EventHandler(this.UC_MyProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.Button ChangeImgButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button ChangeUsernameButton;
        private System.Windows.Forms.Button ChangeDateOfBirthButton;
        private System.Windows.Forms.Button ChangeGenderButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ChangeEmailButton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox GenderComboBox;
    }
}
