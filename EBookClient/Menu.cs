using EBookClient.UC_Control;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EBookClient
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private bool MenuBarEx;
        private bool StoreBarEx;
        private bool PfBarEx;
        private bool LibBarEx;

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private void addUserContorol(UserControl userControl)
        {
            //TODO: Fix
            userControl.Dock = DockStyle.Top;
            userControl.Height -= 200;
            PanelBox.Controls.Clear();
            PanelBox.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void MenuTimer_Tick(object sender, EventArgs e)
        {
            if(MenuBarEx)
            {
                MenuBox.Width -= 10;
                if (MenuBox.Width == MenuBox.MinimumSize.Width)
                {
                    MenuBarEx = false;
                    MenuTimer.Stop();
                }
            }
            else
            {
                MenuBox.Width += 10;
                if(MenuBox.Width == MenuBox.MaximumSize.Width)
                {
                    MenuBarEx = true;
                    MenuTimer.Stop();
                }
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            MenuTimer.Start();
        }

        private void TimerStore_Tick(object sender, EventArgs e)
        {
            if (StoreBarEx)
            {
                StoreBox.Height -= 10;
                if (StoreBox.Height == StoreBox.MinimumSize.Height)
                {
                    StoreBarEx = false;
                    TimerStore.Stop();
                }
            }
            else
            {
                StoreBox.Height += 10;
                if (StoreBox.Height == StoreBox.MaximumSize.Height)
                {
                    StoreBarEx = true;
                    TimerStore.Stop();
                }
            }
        }

        private void StoreButt_Click(object sender, EventArgs e)
        {
            TimerStore.Start();
        }

        private void ProfileTime_Tick(object sender, EventArgs e)
        {
            if (PfBarEx)
            {
                ProfileBox.Height -= 10;
                if (ProfileBox.Height == ProfileBox.MinimumSize.Height)
                {
                    PfBarEx = false;
                    ProfileTime.Stop();
                }
            }
            else
            {
                ProfileBox.Height += 10;
                if (ProfileBox.Height == ProfileBox.MaximumSize.Height)
                {
                    PfBarEx = true;
                    ProfileTime.Stop();
                }
            }
        }

        private void ProfileButt_Click(object sender, EventArgs e)
        {
            ProfileTime.Start();
        }

        private void ClosedsButt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LibraryTime_Tick(object sender, EventArgs e)
        {
            if (LibBarEx)
            {
                LibraryBox.Height -= 10;
                if (LibraryBox.Height == LibraryBox.MinimumSize.Height)
                {
                    LibBarEx = false;
                    LibraryTime.Stop();
                }
            }
            else
            {
                LibraryBox.Height += 10;
                if (LibraryBox.Height == LibraryBox.MaximumSize.Height)
                {
                    LibBarEx = true;
                    LibraryTime.Stop();
                }
            }
        }

        private void LibButt_Click(object sender, EventArgs e)
        {
            LibraryTime.Start();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            var mainpage = new UC_MainPage();
            addUserContorol(mainpage);
        }

        private void WishlistButt_Click(object sender, EventArgs e)
        {
            var WishList = new UC_WishList();
            addUserContorol(WishList);
        }

        private void SoBButt_Click(object sender, EventArgs e)
        {
            var SrBook = new UC_SrBook();
            addUserContorol(SrBook);
        }

        private void MainpageButt_Click(object sender, EventArgs e)
        {
            var mainpage = new UC_MainPage();
            addUserContorol(mainpage);
        }

        private void MyProfileButt_Click(object sender, EventArgs e)
        {
            var MyProfile = new UC_MyProfile();
            addUserContorol(MyProfile);
        }

        private void MyPageButt_Click(object sender, EventArgs e)
        {
            var MyPage = new UC_MyPage();
            addUserContorol(MyPage);
        }

        private void FriendsButt_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void flowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void AllBooksButt_Click(object sender, EventArgs e)
        {
            var AllBooks = new UC_AllBooks();
            addUserContorol(AllBooks);
        }

        private void MSButt_Click(object sender, EventArgs e)
        {
            var ms = new UC_MySeries();
            addUserContorol(ms);
        }
    }
}
