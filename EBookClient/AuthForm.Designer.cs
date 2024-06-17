﻿using System;
using System.Windows.Forms;
using EBookLib01;
using EBookLib01.Components;
namespace EBookClient
{
    partial class AuthForm : Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RegButton = new EBookLib01.Controls.yt_buttons();
            this.AuthButton = new EBookLib01.Controls.yt_buttons();
            this.PassField = new EBookLib01.Controls.RoundTextBox();
            this.LoginField = new EBookLib01.Controls.RoundTextBox();
            this.egoldsFormStyle1 = new EBookLib01.Components.EgoldsFormStyle(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.RegButton);
            this.panel2.Controls.Add(this.AuthButton);
            this.panel2.Controls.Add(this.PassField);
            this.panel2.Controls.Add(this.LoginField);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1208, 542);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(22, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 37);
            this.label2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(22, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 6;
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
            this.RegButton.Location = new System.Drawing.Point(646, 327);
            this.RegButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.RegButton.Name = "RegButton";
            this.RegButton.RippleColor = System.Drawing.Color.Black;
            this.RegButton.RoundingEnable = false;
            this.RegButton.Size = new System.Drawing.Size(498, 58);
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
            this.AuthButton.Location = new System.Drawing.Point(24, 333);
            this.AuthButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.RippleColor = System.Drawing.Color.Black;
            this.AuthButton.RoundingEnable = false;
            this.AuthButton.Size = new System.Drawing.Size(514, 58);
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
            this.PassField.Location = new System.Drawing.Point(24, 169);
            this.PassField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PassField.Name = "PassField";
            this.PassField.SelectionStart = 0;
            this.PassField.Size = new System.Drawing.Size(1120, 77);
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
            this.LoginField.Location = new System.Drawing.Point(24, 23);
            this.LoginField.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LoginField.Name = "LoginField";
            this.LoginField.SelectionStart = 0;
            this.LoginField.Size = new System.Drawing.Size(1120, 77);
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
            this.egoldsFormStyle1.FormStyle = EBookLib01.Components.EgoldsFormStyle.fStyle.SimpleDark;
            this.egoldsFormStyle1.HeaderColor = System.Drawing.Color.DimGray;
            this.egoldsFormStyle1.HeaderColorAdditional = System.Drawing.Color.White;
            this.egoldsFormStyle1.HeaderColorGradientEnable = false;
            this.egoldsFormStyle1.HeaderColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.egoldsFormStyle1.HeaderHeight = 0;
            this.egoldsFormStyle1.HeaderImage = null;
            this.egoldsFormStyle1.HeaderTextColor = System.Drawing.Color.White;
            this.egoldsFormStyle1.HeaderTextFont = new System.Drawing.Font("Segoe UI", 9.75F);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 542);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Увійти E-Book";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private EBookLib01.Components.EgoldsFormStyle egoldsFormStyle1;
        private EBookLib01.Controls.yt_buttons RegButton;
        private EBookLib01.Controls.yt_buttons AuthButton;
        private EBookLib01.Controls.RoundTextBox PassField;
        private EBookLib01.Controls.RoundTextBox LoginField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}