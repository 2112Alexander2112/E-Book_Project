namespace EBookClient
{
    partial class RegForm
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
            this.egoldsFormStyle1 = new yt_DesignUI.Components.EgoldsFormStyle(this.components);
            this.LoginField = new EBookLib01.Controls.RoundTextBox();
            this.EmailField = new EBookLib01.Controls.RoundTextBox();
            this.CopyEmailField = new EBookLib01.Controls.RoundTextBox();
            this.PassField = new EBookLib01.Controls.RoundTextBox();
            this.CopyPassField = new EBookLib01.Controls.RoundTextBox();
            this.toggleSwitch1 = new EBookLib01.Controls.ToggleSwitch();
            this.RegButton = new EBookLib01.Controls.yt_buttons();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // egoldsFormStyle1
            // 
            this.egoldsFormStyle1.AllowUserResize = false;
            this.egoldsFormStyle1.BackColor = System.Drawing.Color.White;
            this.egoldsFormStyle1.ContextMenuForm = null;
            this.egoldsFormStyle1.ControlBoxButtonsWidth = 20;
            this.egoldsFormStyle1.EnableControlBoxIconsLight = true;
            this.egoldsFormStyle1.EnableControlBoxMouseLight = true;
            this.egoldsFormStyle1.Form = this;
            this.egoldsFormStyle1.FormStyle = yt_DesignUI.Components.EgoldsFormStyle.fStyle.SimpleDark;
            this.egoldsFormStyle1.HeaderColor = System.Drawing.Color.DimGray;
            this.egoldsFormStyle1.HeaderColorAdditional = System.Drawing.Color.White;
            this.egoldsFormStyle1.HeaderColorGradientEnable = true;
            this.egoldsFormStyle1.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.egoldsFormStyle1.HeaderHeight = 0;
            this.egoldsFormStyle1.HeaderImage = null;
            this.egoldsFormStyle1.HeaderTextColor = System.Drawing.Color.White;
            this.egoldsFormStyle1.HeaderTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            // 
            // LoginField
            // 
            this.LoginField.BackColor = System.Drawing.Color.White;
            this.LoginField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.LoginField.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.LoginField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginField.Font = new System.Drawing.Font("Arial", 11.25F);
            this.LoginField.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.LoginField.ForeColor = System.Drawing.Color.Black;
            this.LoginField.Location = new System.Drawing.Point(23, 47);
            this.LoginField.Name = "LoginField";
            this.LoginField.SelectionStart = 0;
            this.LoginField.Size = new System.Drawing.Size(297, 40);
            this.LoginField.TabIndex = 0;
            this.LoginField.TextInput = "";
            this.LoginField.TextPreview = "Введіть свій логін";
            this.LoginField.UseSystemPasswordChar = false;
            // 
            // EmailField
            // 
            this.EmailField.BackColor = System.Drawing.Color.White;
            this.EmailField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.EmailField.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.EmailField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailField.Font = new System.Drawing.Font("Arial", 11.25F);
            this.EmailField.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.EmailField.ForeColor = System.Drawing.Color.Black;
            this.EmailField.Location = new System.Drawing.Point(23, 116);
            this.EmailField.Name = "EmailField";
            this.EmailField.SelectionStart = 0;
            this.EmailField.Size = new System.Drawing.Size(297, 40);
            this.EmailField.TabIndex = 1;
            this.EmailField.TextInput = "";
            this.EmailField.TextPreview = "Введіть свій Email";
            this.EmailField.UseSystemPasswordChar = false;
            // 
            // CopyEmailField
            // 
            this.CopyEmailField.BackColor = System.Drawing.Color.White;
            this.CopyEmailField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.CopyEmailField.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.CopyEmailField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CopyEmailField.Font = new System.Drawing.Font("Arial", 11.25F);
            this.CopyEmailField.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.CopyEmailField.ForeColor = System.Drawing.Color.Black;
            this.CopyEmailField.Location = new System.Drawing.Point(23, 182);
            this.CopyEmailField.Name = "CopyEmailField";
            this.CopyEmailField.SelectionStart = 0;
            this.CopyEmailField.Size = new System.Drawing.Size(297, 40);
            this.CopyEmailField.TabIndex = 2;
            this.CopyEmailField.TextInput = "";
            this.CopyEmailField.TextPreview = "Продублюйте свій Email";
            this.CopyEmailField.UseSystemPasswordChar = false;
            // 
            // PassField
            // 
            this.PassField.BackColor = System.Drawing.Color.White;
            this.PassField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.PassField.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.PassField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassField.Font = new System.Drawing.Font("Arial", 11.25F);
            this.PassField.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.PassField.ForeColor = System.Drawing.Color.Black;
            this.PassField.Location = new System.Drawing.Point(23, 241);
            this.PassField.Name = "PassField";
            this.PassField.SelectionStart = 0;
            this.PassField.Size = new System.Drawing.Size(297, 40);
            this.PassField.TabIndex = 3;
            this.PassField.TextInput = "";
            this.PassField.TextPreview = "Введіть свій пароль";
            this.PassField.UseSystemPasswordChar = false;
            // 
            // CopyPassField
            // 
            this.CopyPassField.BackColor = System.Drawing.Color.White;
            this.CopyPassField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.CopyPassField.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.CopyPassField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CopyPassField.Font = new System.Drawing.Font("Arial", 11.25F);
            this.CopyPassField.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.CopyPassField.ForeColor = System.Drawing.Color.Black;
            this.CopyPassField.Location = new System.Drawing.Point(23, 303);
            this.CopyPassField.Name = "CopyPassField";
            this.CopyPassField.SelectionStart = 0;
            this.CopyPassField.Size = new System.Drawing.Size(297, 40);
            this.CopyPassField.TabIndex = 4;
            this.CopyPassField.TextInput = "";
            this.CopyPassField.TextPreview = "Продублюйте свій пароль";
            this.CopyPassField.UseSystemPasswordChar = false;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.BackColor = System.Drawing.Color.White;
            this.toggleSwitch1.BackColorOFF = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.toggleSwitch1.BackColorON = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.toggleSwitch1.Checked = false;
            this.toggleSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleSwitch1.Font = new System.Drawing.Font("Verdana", 9F);
            this.toggleSwitch1.Location = new System.Drawing.Point(23, 371);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Size = new System.Drawing.Size(232, 15);
            this.toggleSwitch1.TabIndex = 5;
            this.toggleSwitch1.Text = "Я приймаю ліцензійну угоду";
            this.toggleSwitch1.TextOnChecked = "";
            this.toggleSwitch1.CheckedChanged += new EBookLib01.Controls.ToggleSwitch.OnCheckedChangedHandler(this.toggleSwitch1_CheckedChanged);
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.Tomato;
            this.RegButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.RegButton.BackColorGradientEnabled = false;
            this.RegButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.RegButton.BorderColor = System.Drawing.Color.Tomato;
            this.RegButton.BorderColorEnabled = false;
            this.RegButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.RegButton.BorderColorOnHoverEnabled = false;
            this.RegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegButton.Enabled = false;
            this.RegButton.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.RegButton.ForeColor = System.Drawing.Color.White;
            this.RegButton.Location = new System.Drawing.Point(23, 392);
            this.RegButton.Name = "RegButton";
            this.RegButton.RippleColor = System.Drawing.Color.Black;
            this.RegButton.RoundingEnable = false;
            this.RegButton.Size = new System.Drawing.Size(297, 30);
            this.RegButton.TabIndex = 6;
            this.RegButton.Text = "Зареєструватися";
            this.RegButton.TextHover = null;
            this.RegButton.UseDownPressEffectOnClick = false;
            this.RegButton.UseRippleEffect = true;
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.UseZoomEffectOnHover = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(23, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(23, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(23, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(23, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.CopyPassField);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.CopyEmailField);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.LoginField);
            this.Name = "RegForm";
            this.Text = "Форма Реєстрації E-Book";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private yt_DesignUI.Components.EgoldsFormStyle egoldsFormStyle1;
        private EBookLib01.Controls.RoundTextBox CopyPassField;
        private EBookLib01.Controls.RoundTextBox PassField;
        private EBookLib01.Controls.RoundTextBox CopyEmailField;
        private EBookLib01.Controls.RoundTextBox EmailField;
        private EBookLib01.Controls.RoundTextBox LoginField;
        private EBookLib01.Controls.ToggleSwitch toggleSwitch1;
        private EBookLib01.Controls.yt_buttons RegButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}