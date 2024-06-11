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
            flowLayoutPanel1.Controls.Clear();

            int startIndex = currentPage * friendsPerPage;

            int remainingFriends = friends.Count - startIndex;
            int friendsToShow = Math.Min(friendsPerPage, remainingFriends);

            totalFriends = friends.Count;
            totalPages = (totalFriends + friendsPerPage - 1) / friendsPerPage;
            friendsElements = new UC_Friends[friendsToShow];

            for (int i = 0; i < friendsElements.Length; i++)
            {
                friendsElements[i] = new UC_Friends();
                friendsElements[i].Friend_Name = friends[startIndex + i].UserLogin;
                friendsElements[i].Icon = icons[startIndex + i];
                friendsElements[i].Click += new System.EventHandler(this.UC_Book_Click);

                flowLayoutPanel1.Controls.Add(friendsElements[i]);
            }
            UpdateNavigationButtons();
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
                friendsElements[i].Click += new System.EventHandler(this.UC_Book_Click);

                flowLayoutPanel1.Controls.Add(friendsElements[i]);
            }
            UpdateNavigationButtons();
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
        public static List<Book> GenerateRandomBooks(int count, List<Author> authors)
        {
            var random = new Random();
            var books = new List<Book>();

            var sampleBookNames = new List<string>
            {
                "The Great Adventure", "Mystery of the Night", "Journey to the Unknown", "The Last Frontier", "Echoes of the Past",
                "Whispers of the Wind", "Shadows in the Moonlight", "The Enchanted Forest", "Beyond the Horizon", "Silent Thunder",
                "The Lost Kingdom", "Rise of the Phoenix", "Secrets of the Deep", "The Time Traveler's Diary", "Legends of the Ancient",
                "Guardian of the Realm", "The Hidden Path", "Voice of the Sea", "The Eternal Quest", "Realm of Dreams",
                "The Forgotten Temple", "Echoes in the Valley", "Winds of Change", "Beneath the Surface", "The Crystal Cave"
            };

            var sampleAlterNames = new List<string>
            {
                "Adventure Series", "Night Tales", "Unknown Chronicles", "Frontier Stories", "Past Echoes",
                "Wind Whispers", "Moonlight Shadows", "Forest Enchantment", "Horizon Beyond", "Thunder Silence",
                "Kingdom Lost", "Phoenix Rising", "Deep Secrets", "Traveler's Tales", "Ancient Legends",
                "Realm Guardians", "Path Hidden", "Sea Voices", "Quest Eternal", "Dream Realms",
                "Temple Forgotten", "Valley Echoes", "Change Winds", "Surface Depths", "Cave Crystals"
            };

            for (int i = 0; i < count; i++)
            {
                var author = authors[random.Next(authors.Count)];
                var book = new Book
                {
                    Id = i + 1,
                    GenreId = random.Next(1, 10),
                    CategoryId = random.Next(1, 10),
                    AuthorId = author.Id,
                    BookName = sampleBookNames[random.Next(sampleBookNames.Count)],
                    AlterName = sampleAlterNames[random.Next(sampleAlterNames.Count)],
                    Published = DateTime.Now.AddDays(-random.Next(0, 3650)), // Random date within the last 10 years
                    PublisherId = random.Next(1, 10),
                    BookInfoId = random.Next(1, 10),
                    BookInfos = new List<BookInfo>(),
                    BookInfo = new BookInfo(),
                    Publisher = new Publisher(),
                    Genre = new Genre(),
                    Category = new Category(),
                    Author = author,
                    Books = new List<Book>(),
                    Reviews = new List<Review>(),
                    Wishlists = new List<Wishlist>(),
                    Transactions = new List<Transaction>()
                };

                author.Books.Add(book);
                books.Add(book);
            }
            return books;
        }

        public static List<Author> GenerateRandomAuthors(int count)
        {
            var random = new Random();
            var authors = new List<Author>();

            var sampleAuthorNames = new List<string>
            {
                "John Smith", "Emily Johnson", "Michael Williams", "Sarah Jones", "David Brown",
                "Laura Davis", "James Wilson", "Linda Martinez", "Robert Taylor", "Barbara Anderson",
                "Daniel Thomas", "Jennifer Lee", "Matthew Harris", "Elizabeth Clark", "Andrew Lewis",
                "Jessica Walker", "Joshua Robinson", "Sophia Hall", "William Young", "Olivia King"
            };

            for (int i = 0; i < count; i++)
            {
                authors.Add(new Author
                {
                    Id = i + 1,
                    AuthorName = sampleAuthorNames[random.Next(sampleAuthorNames.Count)],
                    Rate = (float)Math.Round(random.NextDouble() * 5, 2),
                    Books = new List<Book>()
                });
            }

            return authors;
        }
        public static List<Image> CreateIconArray(int numberOfIcons)
        {
            List<Image> images = new List<Image>();
            for (int i = 0; i < numberOfIcons; i++)
            {
                images.Add(Properties.Resources.No_Image_Available);
            }
            return images;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false; ;
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

            var random = new Random();
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
                    Password = "Password123", // In a real application, ensure to hash passwords.
                    RegDate = DateTime.Now,
                    RoleId = 1, // Assuming a default RoleId, adjust as needed.
                    PublisherId = 1, // Assuming a default PublisherId, adjust as needed.
                    Wishlist = new List<Wishlist>(),
                    MyLibraries = new List<MyLibrary>(),
                    Friends = new List<Friend>(),
                    Role = new Role(), // Assuming default Role object, adjust as needed.
                    Publisher = new Publisher() // Assuming default Publisher object, adjust as needed.
                };

                users.Add(user);
            }

            return users;
        }
    }
}