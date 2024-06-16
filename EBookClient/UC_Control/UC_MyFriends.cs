using EBookLib01.BasicModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace EBookClient.UC_Control
{
    public partial class UC_MyFriends : UserControl
    {

        private int currentPage = 0;
        private int totalPages = 0;
        private int friendsPerPage = 12;
        private UC_Friends[] friendsElements;
        private static Random random = new Random();

        static List<User> friends = GenerateUsers(32);
        static List<Image> icons = CreateIconArray(friends.Count);

        int totalFriends = 0;


        public UC_MyFriends()
        {
            InitializeComponent();
        }

        void UC_Book_Click(object sender, EventArgs e)
        {
            var obj = (UC_Book)sender;
        }

        private void UC_MainPage_Load(object sender, EventArgs e)
        {
            ShowCurrentPage();
        }

        private void ShowCurrentPage()
        {
            string query = SearchField.Text.ToLower();

            List<User> filteredFriends = SearchFriends(friends, query);

            flowLayoutPanel1.Controls.Clear();

            int startIndex = currentPage * friendsPerPage;

            int remainingBooks = filteredFriends.Count - startIndex;
            int booksToShow = Math.Min(friendsPerPage, remainingBooks);

            totalFriends = filteredFriends.Count;
            totalPages = (totalFriends + friendsPerPage - 1) / friendsPerPage;
            friendsElements = new UC_Friends[booksToShow];

            for (int i = 0; i < friendsElements.Length; i++)
            {
                friendsElements[i] = new UC_Friends();
                friendsElements[i].Friend_Name = filteredFriends[startIndex + i].UserLogin;
                friendsElements[i].Icon = icons[startIndex + i];
                friendsElements[i].FriendRemoved += UC_FriendRemoved;
                friendsElements[i].Click += new System.EventHandler(this.UC_Book_Click);

                flowLayoutPanel1.Controls.Add(friendsElements[i]);
            }
            UpdateNavigationButtons();
        }
        private void UC_FriendRemoved(object sender, EventArgs e)
        {
            var removedFriend = sender as UC_Friends;
            if (removedFriend != null)
            {
                string friendName = removedFriend.Friend_Name;
                var friendToRemove = friends.FirstOrDefault(f => f.UserLogin == friendName);
                if (friendToRemove != null)
                {
                    friends.Remove(friendToRemove);
                    MessageBox.Show(friendName + " was removed");
                    ShowCurrentPage();
                }
            }
        }


        private void UpdateNavigationButtons()
        {
            buttonPreviousPage.Enabled = (currentPage > 0);
            buttonBack.Enabled = (currentPage > 0);

            buttonNext.Enabled = (currentPage < (friends.Count - 1) / friendsPerPage);
            buttonNextFast.Enabled = (currentPage < (friends.Count - 1) / friendsPerPage);
            textBox1.Text = (currentPage + 1).ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage = 0;
                ShowCurrentPage();
            }
        }


        private void buttonNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            ShowCurrentPage();
        }

        private void buttonPreviousPage_Click(object sender, EventArgs e)
        {
            currentPage--;
            ShowCurrentPage();
        }

        private void buttonNextFast_Click(object sender, EventArgs e)
        {
            currentPage = totalPages - 1;
            ShowCurrentPage();
        }

        private void SearchField_TextChanged(object sender, EventArgs e)
        {
            ShowCurrentPage();
        }

        static List<User> SearchFriends(List<User> friends, string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return friends;
            }

            searchTerm = searchTerm.ToLower();

            return friends.Where(friend =>
            friend.UserLogin.ToLower().Contains(searchTerm)).ToList();
        }
        //TODO: Delete Later
        public static List<Image> CreateIconArray(int numberOfIcons)
        {
            List<Image> images = new List<Image>();
            for (int i = 0; i < numberOfIcons; i++)
            {
                images.Add(Properties.Resources.No_Image_Available);
            }
            return images;
        }
        private static string GenerateUsername()
        {
            var adjectives = new List<string>
            {
                "Swift", "Silent", "Brave", "Clever", "Mighty", "Nimble", "Fierce", "Bold", "Lucky", "Wise"
            };

            var nouns = new List<string>
            {
                "Eagle", "Tiger", "Lion", "Panther", "Hawk", "Wolf", "Dragon", "Shark", "Falcon", "Bear"
            };

            string adjective = adjectives[random.Next(adjectives.Count)];
            string noun = nouns[random.Next(nouns.Count)];
            int number = random.Next(1000, 9999);
            return $"{adjective}{noun}{number}";
        }
        private static List<User> GenerateUsers(int numberOfUsers)
        {
            List<User> users = new List<User>();

            for (int i = 0; i < numberOfUsers; i++)
            {
                User user = new User
                {
                    Id = i + 1,
                    UserLogin = GenerateUsername(),
                    Email = $"user{i + 1}@example.com",
                    Password = "Password123",
                    RegDate = DateTime.Now,
                    RoleId = 1,
                    PublisherId = 1,
                    Wishlist = new List<Wishlist>(),
                    MyLibrary = new MyLibrary(),
                    Friends = new List<Friend>(),
                    Role = new Role(), 
                    Publisher = new Publisher() 
                };

                users.Add(user);
            }

            return users;
        }
    }
}