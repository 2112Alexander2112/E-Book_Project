namespace EBookClient
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.MenuBox = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuButton = new System.Windows.Forms.PictureBox();
            this.StoreBox = new System.Windows.Forms.Panel();
            this.SoBButt = new System.Windows.Forms.Button();
            this.WishlistButt = new System.Windows.Forms.Button();
            this.MainpageButt = new System.Windows.Forms.Button();
            this.StoreButt = new System.Windows.Forms.Button();
            this.ProfileBox = new System.Windows.Forms.Panel();
            this.MyProfileButt = new System.Windows.Forms.Button();
            this.MyPageButt = new System.Windows.Forms.Button();
            this.FriendsButt = new System.Windows.Forms.Button();
            this.ProfileButt = new System.Windows.Forms.Button();
            this.LibraryBox = new System.Windows.Forms.Panel();
            this.MSButt = new System.Windows.Forms.Button();
            this.AllBooksButt = new System.Windows.Forms.Button();
            this.LibButt = new System.Windows.Forms.Button();
            this.SettingsBox = new System.Windows.Forms.Panel();
            this.Settings = new System.Windows.Forms.Button();
            this.MenuTimer = new System.Windows.Forms.Timer(this.components);
            this.TimerStore = new System.Windows.Forms.Timer(this.components);
            this.ProfileTime = new System.Windows.Forms.Timer(this.components);
            this.LibraryTime = new System.Windows.Forms.Timer(this.components);
            this.egoldsFormStyle1 = new EBookLib01.Components.EgoldsFormStyle(this.components);
            this.PanelBox = new System.Windows.Forms.Panel();
            this.MenuBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).BeginInit();
            this.StoreBox.SuspendLayout();
            this.ProfileBox.SuspendLayout();
            this.LibraryBox.SuspendLayout();
            this.SettingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBox
            // 
            this.MenuBox.BackColor = System.Drawing.Color.DarkGray;
            this.MenuBox.Controls.Add(this.panel1);
            this.MenuBox.Controls.Add(this.StoreBox);
            this.MenuBox.Controls.Add(this.ProfileBox);
            this.MenuBox.Controls.Add(this.LibraryBox);
            this.MenuBox.Controls.Add(this.SettingsBox);
            this.MenuBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuBox.Location = new System.Drawing.Point(0, 0);
            this.MenuBox.MaximumSize = new System.Drawing.Size(200, 0);
            this.MenuBox.MinimumSize = new System.Drawing.Size(60, 0);
            this.MenuBox.Name = "MenuBox";
            this.MenuBox.Size = new System.Drawing.Size(200, 800);
            this.MenuBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MenuButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 59);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // MenuButton
            // 
            this.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButton.Image = global::EBookClient.Properties.Resources.menu;
            this.MenuButton.Location = new System.Drawing.Point(0, 3);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(51, 50);
            this.MenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuButton.TabIndex = 0;
            this.MenuButton.TabStop = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // StoreBox
            // 
            this.StoreBox.Controls.Add(this.SoBButt);
            this.StoreBox.Controls.Add(this.WishlistButt);
            this.StoreBox.Controls.Add(this.MainpageButt);
            this.StoreBox.Controls.Add(this.StoreButt);
            this.StoreBox.Location = new System.Drawing.Point(3, 68);
            this.StoreBox.MaximumSize = new System.Drawing.Size(200, 102);
            this.StoreBox.MinimumSize = new System.Drawing.Size(200, 31);
            this.StoreBox.Name = "StoreBox";
            this.StoreBox.Size = new System.Drawing.Size(200, 31);
            this.StoreBox.TabIndex = 2;
            // 
            // SoBButt
            // 
            this.SoBButt.FlatAppearance.BorderSize = 0;
            this.SoBButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SoBButt.Image = global::EBookClient.Properties.Resources.point;
            this.SoBButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SoBButt.Location = new System.Drawing.Point(0, 76);
            this.SoBButt.Name = "SoBButt";
            this.SoBButt.Size = new System.Drawing.Size(200, 23);
            this.SoBButt.TabIndex = 3;
            this.SoBButt.Text = "Series of book";
            this.SoBButt.UseVisualStyleBackColor = true;
            this.SoBButt.Click += new System.EventHandler(this.SoBButt_Click);
            // 
            // WishlistButt
            // 
            this.WishlistButt.FlatAppearance.BorderSize = 0;
            this.WishlistButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WishlistButt.Image = global::EBookClient.Properties.Resources.point;
            this.WishlistButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WishlistButt.Location = new System.Drawing.Point(0, 57);
            this.WishlistButt.Name = "WishlistButt";
            this.WishlistButt.Size = new System.Drawing.Size(200, 23);
            this.WishlistButt.TabIndex = 2;
            this.WishlistButt.Text = "Wishlist";
            this.WishlistButt.UseVisualStyleBackColor = true;
            this.WishlistButt.Click += new System.EventHandler(this.WishlistButt_Click);
            // 
            // MainpageButt
            // 
            this.MainpageButt.FlatAppearance.BorderSize = 0;
            this.MainpageButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainpageButt.Image = global::EBookClient.Properties.Resources.point;
            this.MainpageButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainpageButt.Location = new System.Drawing.Point(0, 37);
            this.MainpageButt.Name = "MainpageButt";
            this.MainpageButt.Size = new System.Drawing.Size(200, 23);
            this.MainpageButt.TabIndex = 1;
            this.MainpageButt.Text = "Mainpage";
            this.MainpageButt.UseVisualStyleBackColor = true;
            this.MainpageButt.Click += new System.EventHandler(this.MainpageButt_Click);
            // 
            // StoreButt
            // 
            this.StoreButt.FlatAppearance.BorderSize = 0;
            this.StoreButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoreButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StoreButt.Image = global::EBookClient.Properties.Resources.Book_Store;
            this.StoreButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StoreButt.Location = new System.Drawing.Point(0, 0);
            this.StoreButt.Name = "StoreButt";
            this.StoreButt.Size = new System.Drawing.Size(200, 35);
            this.StoreButt.TabIndex = 0;
            this.StoreButt.Text = "Store";
            this.StoreButt.UseVisualStyleBackColor = true;
            this.StoreButt.Click += new System.EventHandler(this.StoreButt_Click);
            // 
            // ProfileBox
            // 
            this.ProfileBox.Controls.Add(this.MyProfileButt);
            this.ProfileBox.Controls.Add(this.MyPageButt);
            this.ProfileBox.Controls.Add(this.FriendsButt);
            this.ProfileBox.Controls.Add(this.ProfileButt);
            this.ProfileBox.Location = new System.Drawing.Point(3, 105);
            this.ProfileBox.MaximumSize = new System.Drawing.Size(200, 110);
            this.ProfileBox.MinimumSize = new System.Drawing.Size(200, 31);
            this.ProfileBox.Name = "ProfileBox";
            this.ProfileBox.Size = new System.Drawing.Size(200, 31);
            this.ProfileBox.TabIndex = 3;
            // 
            // MyProfileButt
            // 
            this.MyProfileButt.FlatAppearance.BorderSize = 0;
            this.MyProfileButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyProfileButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyProfileButt.Image = global::EBookClient.Properties.Resources.point;
            this.MyProfileButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyProfileButt.Location = new System.Drawing.Point(0, 85);
            this.MyProfileButt.Name = "MyProfileButt";
            this.MyProfileButt.Size = new System.Drawing.Size(200, 23);
            this.MyProfileButt.TabIndex = 3;
            this.MyProfileButt.Text = "My Profile";
            this.MyProfileButt.UseVisualStyleBackColor = true;
            this.MyProfileButt.Click += new System.EventHandler(this.MyProfileButt_Click);
            // 
            // MyPageButt
            // 
            this.MyPageButt.FlatAppearance.BorderSize = 0;
            this.MyPageButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyPageButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyPageButt.Image = global::EBookClient.Properties.Resources.point;
            this.MyPageButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyPageButt.Location = new System.Drawing.Point(0, 59);
            this.MyPageButt.Name = "MyPageButt";
            this.MyPageButt.Size = new System.Drawing.Size(200, 23);
            this.MyPageButt.TabIndex = 2;
            this.MyPageButt.Text = "My Page";
            this.MyPageButt.UseVisualStyleBackColor = true;
            this.MyPageButt.Click += new System.EventHandler(this.MyPageButt_Click);
            // 
            // FriendsButt
            // 
            this.FriendsButt.FlatAppearance.BorderSize = 0;
            this.FriendsButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FriendsButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FriendsButt.Image = global::EBookClient.Properties.Resources.point;
            this.FriendsButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FriendsButt.Location = new System.Drawing.Point(0, 38);
            this.FriendsButt.Name = "FriendsButt";
            this.FriendsButt.Size = new System.Drawing.Size(200, 23);
            this.FriendsButt.TabIndex = 1;
            this.FriendsButt.Text = "My Friends";
            this.FriendsButt.UseVisualStyleBackColor = true;
            this.FriendsButt.Click += new System.EventHandler(this.FriendsButt_Click);
            // 
            // ProfileButt
            // 
            this.ProfileButt.FlatAppearance.BorderSize = 0;
            this.ProfileButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfileButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfileButt.Image = global::EBookClient.Properties.Resources.Profile;
            this.ProfileButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfileButt.Location = new System.Drawing.Point(0, 0);
            this.ProfileButt.Name = "ProfileButt";
            this.ProfileButt.Size = new System.Drawing.Size(200, 35);
            this.ProfileButt.TabIndex = 0;
            this.ProfileButt.Text = "Profile";
            this.ProfileButt.UseVisualStyleBackColor = true;
            this.ProfileButt.Click += new System.EventHandler(this.ProfileButt_Click);
            // 
            // LibraryBox
            // 
            this.LibraryBox.Controls.Add(this.MSButt);
            this.LibraryBox.Controls.Add(this.AllBooksButt);
            this.LibraryBox.Controls.Add(this.LibButt);
            this.LibraryBox.Location = new System.Drawing.Point(3, 142);
            this.LibraryBox.MaximumSize = new System.Drawing.Size(200, 95);
            this.LibraryBox.MinimumSize = new System.Drawing.Size(200, 31);
            this.LibraryBox.Name = "LibraryBox";
            this.LibraryBox.Size = new System.Drawing.Size(200, 42);
            this.LibraryBox.TabIndex = 4;
            // 
            // MSButt
            // 
            this.MSButt.FlatAppearance.BorderSize = 0;
            this.MSButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MSButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MSButt.Image = global::EBookClient.Properties.Resources.point;
            this.MSButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MSButt.Location = new System.Drawing.Point(0, 70);
            this.MSButt.Name = "MSButt";
            this.MSButt.Size = new System.Drawing.Size(200, 23);
            this.MSButt.TabIndex = 2;
            this.MSButt.Text = "My Seires";
            this.MSButt.UseVisualStyleBackColor = true;
            this.MSButt.Click += new System.EventHandler(this.MSButt_Click);
            // 
            // AllBooksButt
            // 
            this.AllBooksButt.FlatAppearance.BorderSize = 0;
            this.AllBooksButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllBooksButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllBooksButt.Image = global::EBookClient.Properties.Resources.point;
            this.AllBooksButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllBooksButt.Location = new System.Drawing.Point(0, 41);
            this.AllBooksButt.Name = "AllBooksButt";
            this.AllBooksButt.Size = new System.Drawing.Size(200, 23);
            this.AllBooksButt.TabIndex = 1;
            this.AllBooksButt.Text = "All Books";
            this.AllBooksButt.UseVisualStyleBackColor = true;
            this.AllBooksButt.Click += new System.EventHandler(this.AllBooksButt_Click);
            // 
            // LibButt
            // 
            this.LibButt.FlatAppearance.BorderSize = 0;
            this.LibButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LibButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LibButt.Image = global::EBookClient.Properties.Resources.library;
            this.LibButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LibButt.Location = new System.Drawing.Point(0, 0);
            this.LibButt.Name = "LibButt";
            this.LibButt.Size = new System.Drawing.Size(200, 35);
            this.LibButt.TabIndex = 0;
            this.LibButt.Text = "Library";
            this.LibButt.UseVisualStyleBackColor = true;
            this.LibButt.Click += new System.EventHandler(this.LibButt_Click);
            // 
            // SettingsBox
            // 
            this.SettingsBox.Controls.Add(this.Settings);
            this.SettingsBox.Location = new System.Drawing.Point(3, 190);
            this.SettingsBox.Name = "SettingsBox";
            this.SettingsBox.Size = new System.Drawing.Size(200, 30);
            this.SettingsBox.TabIndex = 3;
            // 
            // Settings
            // 
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Settings.Image = global::EBookClient.Properties.Resources.settings;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(0, 0);
            this.Settings.MinimumSize = new System.Drawing.Size(200, 31);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(200, 31);
            this.Settings.TabIndex = 0;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // MenuTimer
            // 
            this.MenuTimer.Interval = 10;
            this.MenuTimer.Tick += new System.EventHandler(this.MenuTimer_Tick);
            // 
            // TimerStore
            // 
            this.TimerStore.Interval = 10;
            this.TimerStore.Tick += new System.EventHandler(this.TimerStore_Tick);
            // 
            // ProfileTime
            // 
            this.ProfileTime.Interval = 10;
            this.ProfileTime.Tick += new System.EventHandler(this.ProfileTime_Tick);
            // 
            // LibraryTime
            // 
            this.LibraryTime.Interval = 10;
            this.LibraryTime.Tick += new System.EventHandler(this.LibraryTime_Tick);
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
            // PanelBox
            // 
            this.PanelBox.BackColor = System.Drawing.Color.White;
            this.PanelBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBox.Location = new System.Drawing.Point(200, 0);
            this.PanelBox.Name = "PanelBox";
            this.PanelBox.Size = new System.Drawing.Size(900, 800);
            this.PanelBox.TabIndex = 3;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 800);
            this.Controls.Add(this.PanelBox);
            this.Controls.Add(this.MenuBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MenuBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButton)).EndInit();
            this.StoreBox.ResumeLayout(false);
            this.ProfileBox.ResumeLayout(false);
            this.LibraryBox.ResumeLayout(false);
            this.SettingsBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel MenuBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox MenuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer MenuTimer;
        private System.Windows.Forms.Panel StoreBox;
        private System.Windows.Forms.Button StoreButt;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Panel SettingsBox;
        private System.Windows.Forms.Button ProfileButt;
        private System.Windows.Forms.Panel ProfileBox;
        private System.Windows.Forms.Button LibButt;
        private System.Windows.Forms.Panel LibraryBox;
        private System.Windows.Forms.Button MainpageButt;
        private System.Windows.Forms.Button SoBButt;
        private System.Windows.Forms.Button WishlistButt;
        private System.Windows.Forms.Timer TimerStore;
        private System.Windows.Forms.Button MyPageButt;
        private System.Windows.Forms.Button FriendsButt;
        private System.Windows.Forms.Timer ProfileTime;
        private System.Windows.Forms.Button MSButt;
        private System.Windows.Forms.Button AllBooksButt;
        private System.Windows.Forms.Timer LibraryTime;
        private System.Windows.Forms.Button MyProfileButt;
        private EBookLib01.Components.EgoldsFormStyle egoldsFormStyle1;
        private System.Windows.Forms.Panel PanelBox;
    }
}