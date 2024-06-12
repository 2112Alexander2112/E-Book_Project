using EBookLib01.BasicModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EBookClient.UC_Control
{
    public partial class UC_WhishList : UserControl
    {

        private int currentPage = 0;
        private int totalPages = 0;
        private int booksPerPage = 12;
        private UC_Book[] booksElements;

        static List<Author> authors = GenerateRandomAuthors(17);
        static List<Book> books = GenerateRandomBooks(52, authors);
        static List<Image> icons = CreateIconArray(books.Count);

        int totalBooks = 0;


        public UC_WhishList()
        {
            InitializeComponent();
        }

        void UC_Book_Click(object sender, EventArgs e)
        {
            var obj = (UC_Book)sender;
        }


        private void ShowCurrentPage()
        {
            flowLayoutPanel1.Controls.Clear();

            int startIndex = currentPage * booksPerPage;

            int remainingBooks = books.Count - startIndex;
            int booksToShow = Math.Min(booksPerPage, remainingBooks);

            totalBooks = books.Count;
            totalPages = (totalBooks + booksPerPage - 1) / booksPerPage;
            booksElements = new UC_Book[booksToShow];

            for (int i = 0; i < booksElements.Length; i++)
            {
                booksElements[i] = new UC_Book(true);
                booksElements[i].Title = books[startIndex + i].BookName;
                booksElements[i].Author = books[startIndex + i].Author.AuthorName;
                booksElements[i].Icon = icons[startIndex + i];
                booksElements[i].Click += new System.EventHandler(this.UC_Book_Click);

                flowLayoutPanel1.Controls.Add(booksElements[i]);
            }
            UpdateNavigationButtons();
        }

        private void UpdateNavigationButtons()
        {
            buttonPreviousPage.Enabled = (currentPage > 0);
            buttonBack.Enabled = (currentPage > 0);

            buttonNext.Enabled = (currentPage < (books.Count - 1) / booksPerPage);
            buttonNextFast.Enabled = (currentPage < (books.Count - 1) / booksPerPage);
            textBox1.Text = (currentPage + 1).ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

        }


        private void buttonNext_Click(object sender, EventArgs e)
        {

        }

        private void buttonPreviousPage_Click(object sender, EventArgs e)
        {

        }

        private void buttonNextFast_Click(object sender, EventArgs e)
        {

        }

        private void SearchField_TextChanged(object sender, EventArgs e)
        {
            string query = SearchField.Text.ToLower();

            List<Book> filteredBooks = SearchBooks(books, query);

            flowLayoutPanel1.Controls.Clear();

            int startIndex = currentPage * booksPerPage;

            int remainingBooks = filteredBooks.Count - startIndex;
            int booksToShow = Math.Min(booksPerPage, remainingBooks);

            totalBooks = filteredBooks.Count;
            totalPages = (totalBooks + booksPerPage - 1) / booksPerPage;
            booksElements = new UC_Book[booksToShow];

            for (int i = 0; i < booksElements.Length; i++)
            {
                booksElements[i] = new UC_Book(true);
                booksElements[i].Title = filteredBooks[startIndex + i].BookName;
                booksElements[i].Author = filteredBooks[startIndex + i].Author.AuthorName;
                booksElements[i].Icon = icons[startIndex + i];
                booksElements[i].Click += new System.EventHandler(this.UC_Book_Click);

                flowLayoutPanel1.Controls.Add(booksElements[i]);
            }
            UpdateNavigationButtons();
        }

        static List<Book> SearchBooks(List<Book> books, string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return books;
            }

            searchTerm = searchTerm.ToLower();

            return books.Where(book =>
            book.BookName.ToLower().Contains(searchTerm) ||
            book.AlterName.ToLower().Contains(searchTerm) ||
            book.Author.AuthorName.ToLower().Contains(searchTerm)
            ).ToList();
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

        private void UC_WhishList_Load(object sender, EventArgs e)
        {
            ShowCurrentPage();
        }
    }
}
