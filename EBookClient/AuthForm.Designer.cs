namespace EBookClient
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.toggleSwitch1 = new EBookLIb.Controls.ToggleSwitch();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.RegButton = new EBookClient.Controls.yt_buttons();
            this.AuthButton = new EBookClient.Controls.yt_buttons();
            this.PassField = new EBookClient.Controls.RoundTextBox();
            this.LoginField = new EBookClient.Controls.RoundTextBox();
            this.egoldsFormStyle1 = new yt_DesignUI.Components.EgoldsFormStyle(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.toggleSwitch1);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.RegButton);
            this.panel2.Controls.Add(this.AuthButton);
            this.panel2.Controls.Add(this.PassField);
            this.panel2.Controls.Add(this.LoginField);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 282);
            this.panel2.TabIndex = 1;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.BackColor = System.Drawing.Color.White;
            this.toggleSwitch1.BackColorOFF = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.toggleSwitch1.BackColorON = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.toggleSwitch1.Checked = false;
            this.toggleSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleSwitch1.Font = new System.Drawing.Font("Verdana", 9F);
            this.toggleSwitch1.Location = new System.Drawing.Point(12, 168);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Size = new System.Drawing.Size(162, 15);
            this.toggleSwitch1.TabIndex = 5;
            this.toggleSwitch1.Text = "Запамятати мене";
            this.toggleSwitch1.TextOnChecked = "";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(412, 158);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(160, 25);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Забув пароль?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            this.RegButton.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.RegButton.ForeColor = System.Drawing.Color.White;
            this.RegButton.Location = new System.Drawing.Point(323, 125);
            this.RegButton.Name = "RegButton";
            this.RegButton.RippleColor = System.Drawing.Color.Black;
            this.RegButton.RoundingEnable = false;
            this.RegButton.Size = new System.Drawing.Size(249, 30);
            this.RegButton.TabIndex = 3;
            this.RegButton.Text = "Реєстрація";
            this.RegButton.TextHover = null;
            this.RegButton.UseDownPressEffectOnClick = false;
            this.RegButton.UseRippleEffect = true;
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.UseZoomEffectOnHover = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // AuthButton
            // 
            this.AuthButton.BackColor = System.Drawing.Color.Tomato;
            this.AuthButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.AuthButton.BackColorGradientEnabled = false;
            this.AuthButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.AuthButton.BorderColor = System.Drawing.Color.Tomato;
            this.AuthButton.BorderColorEnabled = false;
            this.AuthButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.AuthButton.BorderColorOnHoverEnabled = false;
            this.AuthButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthButton.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.AuthButton.ForeColor = System.Drawing.Color.White;
            this.AuthButton.Location = new System.Drawing.Point(12, 128);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.RippleColor = System.Drawing.Color.Black;
            this.AuthButton.RoundingEnable = false;
            this.AuthButton.Size = new System.Drawing.Size(257, 30);
            this.AuthButton.TabIndex = 2;
            this.AuthButton.Text = "Увійти";
            this.AuthButton.TextHover = null;
            this.AuthButton.UseDownPressEffectOnClick = false;
            this.AuthButton.UseRippleEffect = true;
            this.AuthButton.UseVisualStyleBackColor = false;
            this.AuthButton.UseZoomEffectOnHover = false;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
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
            this.PassField.Location = new System.Drawing.Point(12, 79);
            this.PassField.Name = "PassField";
            this.PassField.SelectionStart = 0;
            this.PassField.Size = new System.Drawing.Size(560, 40);
            this.PassField.TabIndex = 1;
            this.PassField.TextInput = "";
            this.PassField.TextPreview = "Введіть свій пароль";
            this.PassField.UseSystemPasswordChar = false;
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
            this.LoginField.Location = new System.Drawing.Point(12, 12);
            this.LoginField.Name = "LoginField";
            this.LoginField.SelectionStart = 0;
            this.LoginField.Size = new System.Drawing.Size(560, 40);
            this.LoginField.TabIndex = 0;
            this.LoginField.TextInput = "";
            this.LoginField.TextPreview = "Введіть свій Логін";
            this.LoginField.UseSystemPasswordChar = false;
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
            this.egoldsFormStyle1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(200)))), ((int)(((byte)(80)))));
            this.egoldsFormStyle1.HeaderColorAdditional = System.Drawing.Color.White;
            this.egoldsFormStyle1.HeaderColorGradientEnable = true;
            this.egoldsFormStyle1.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.egoldsFormStyle1.HeaderHeight = 0;
            this.egoldsFormStyle1.HeaderImage = null;
            this.egoldsFormStyle1.HeaderTextColor = System.Drawing.Color.White;
            this.egoldsFormStyle1.HeaderTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 282);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthForm";
            this.Text = "Увійти E-Book";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private yt_DesignUI.Components.EgoldsFormStyle egoldsFormStyle1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Controls.yt_buttons RegButton;
        private Controls.yt_buttons AuthButton;
        private Controls.RoundTextBox PassField;
        private Controls.RoundTextBox LoginField;
        private EBookLIb.Controls.ToggleSwitch toggleSwitch1;
    }
}