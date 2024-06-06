namespace EBookClient
{
    partial class PassResetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassResetForm));
            this.egoldsFormStyle1 = new yt_DesignUI.Components.EgoldsFormStyle(this.components);
            this.CopyNewPassField = new EBookLib01.Controls.RoundTextBox();
            this.NewPassField = new EBookLib01.Controls.RoundTextBox();
            this.EmailField = new EBookLib01.Controls.RoundTextBox();
            this.ResetPassButton = new EBookLib01.Controls.yt_buttons();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.egoldsFormStyle1.HeaderColorGradientEnable = false;
            this.egoldsFormStyle1.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.egoldsFormStyle1.HeaderHeight = 0;
            this.egoldsFormStyle1.HeaderImage = null;
            this.egoldsFormStyle1.HeaderTextColor = System.Drawing.Color.White;
            this.egoldsFormStyle1.HeaderTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            // 
            // CopyNewPassField
            // 
            this.CopyNewPassField.BackColor = System.Drawing.Color.White;
            this.CopyNewPassField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.CopyNewPassField.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.CopyNewPassField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CopyNewPassField.Font = new System.Drawing.Font("Arial", 11.25F);
            this.CopyNewPassField.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.CopyNewPassField.ForeColor = System.Drawing.Color.Black;
            this.CopyNewPassField.Location = new System.Drawing.Point(12, 146);
            this.CopyNewPassField.Name = "CopyNewPassField";
            this.CopyNewPassField.SelectionStart = 0;
            this.CopyNewPassField.Size = new System.Drawing.Size(388, 40);
            this.CopyNewPassField.TabIndex = 0;
            this.CopyNewPassField.TextInput = "";
            this.CopyNewPassField.TextPreview = "Продублюйте пароль";
            this.CopyNewPassField.UseSystemPasswordChar = true;
            // 
            // NewPassField
            // 
            this.NewPassField.BackColor = System.Drawing.Color.White;
            this.NewPassField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.NewPassField.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.NewPassField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewPassField.Font = new System.Drawing.Font("Arial", 11.25F);
            this.NewPassField.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.NewPassField.ForeColor = System.Drawing.Color.Black;
            this.NewPassField.Location = new System.Drawing.Point(12, 82);
            this.NewPassField.Name = "NewPassField";
            this.NewPassField.SelectionStart = 0;
            this.NewPassField.Size = new System.Drawing.Size(388, 40);
            this.NewPassField.TabIndex = 1;
            this.NewPassField.TextInput = "";
            this.NewPassField.TextPreview = "Введіть новий пароль";
            this.NewPassField.UseSystemPasswordChar = true;
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
            this.EmailField.Location = new System.Drawing.Point(12, 12);
            this.EmailField.Name = "EmailField";
            this.EmailField.SelectionStart = 0;
            this.EmailField.Size = new System.Drawing.Size(388, 40);
            this.EmailField.TabIndex = 2;
            this.EmailField.TextInput = "";
            this.EmailField.TextPreview = "Введіть свій Email ";
            this.EmailField.UseSystemPasswordChar = false;
            // 
            // ResetPassButton
            // 
            this.ResetPassButton.BackColor = System.Drawing.Color.Tomato;
            this.ResetPassButton.BackColorAdditional = System.Drawing.Color.Gray;
            this.ResetPassButton.BackColorGradientEnabled = false;
            this.ResetPassButton.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.ResetPassButton.BorderColor = System.Drawing.Color.Tomato;
            this.ResetPassButton.BorderColorEnabled = false;
            this.ResetPassButton.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.ResetPassButton.BorderColorOnHoverEnabled = false;
            this.ResetPassButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetPassButton.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.ResetPassButton.ForeColor = System.Drawing.Color.White;
            this.ResetPassButton.Location = new System.Drawing.Point(12, 231);
            this.ResetPassButton.Name = "ResetPassButton";
            this.ResetPassButton.RippleColor = System.Drawing.Color.Black;
            this.ResetPassButton.Rounding = 50;
            this.ResetPassButton.RoundingEnable = true;
            this.ResetPassButton.Size = new System.Drawing.Size(387, 30);
            this.ResetPassButton.TabIndex = 3;
            this.ResetPassButton.Text = "Змінити пароль";
            this.ResetPassButton.TextHover = null;
            this.ResetPassButton.UseDownPressEffectOnClick = false;
            this.ResetPassButton.UseRippleEffect = true;
            this.ResetPassButton.UseVisualStyleBackColor = false;
            this.ResetPassButton.UseZoomEffectOnHover = false;
            this.ResetPassButton.Click += new System.EventHandler(this.ResetPassButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PassResetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 332);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetPassButton);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.NewPassField);
            this.Controls.Add(this.CopyNewPassField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PassResetForm";
            this.Text = "Змінити пароль";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PassResetForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private yt_DesignUI.Components.EgoldsFormStyle egoldsFormStyle1;
        private EBookLib01.Controls.RoundTextBox CopyNewPassField;
        private EBookLib01.Controls.yt_buttons ResetPassButton;
        private EBookLib01.Controls.RoundTextBox EmailField;
        private EBookLib01.Controls.RoundTextBox NewPassField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}