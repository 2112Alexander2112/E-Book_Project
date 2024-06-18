using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;

using EBookLib01;
using EBookLib01.HelperModels.TransitModels;
using EBookServer.EF_ORM;
using EBookLib01.HelperModels;
using EBookLib01.BasicModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace EBookServer
{
    public partial class Form1 : Form
    {
        private readonly int _numberOfUsers;
        private int _port;
        private string _clientMessage;

        private IPAddress _ipAdress;
        private IPEndPoint _ep;
        private TcpListener _tcpListener;
        private Thread _listenerThread;

        private DataManager _shopDb;
        private JSONSender _jsonSender;
        public Form1()
        {
            InitializeComponent();
            _port = 9001;
            _ipAdress = IPAddress.Parse("127.0.0.1");
            _ep = new IPEndPoint(_ipAdress, _port);
            _shopDb = new DataManager();
            _numberOfUsers = 20;
            _jsonSender = new JSONSender();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _tcpListener = new TcpListener(_ep);
            _tcpListener.Start(_numberOfUsers);

            _listenerThread = new Thread(new ThreadStart(MainLoop));
            _listenerThread.IsBackground = true;
            _listenerThread.Start();
        }
        private async void MainLoop()
        {
            while (true)
            {
                TcpClient client = _tcpListener.AcceptTcpClient();
                NetworkStream ns = client.GetStream();
                StreamReader sr = new StreamReader(ns);
                _clientMessage = sr.ReadLine();
                ClientMessage clientMessage = _jsonSender.ClientMessageDeserialize(_clientMessage);

                switch (clientMessage.Header)
                {
                    case "REG_USER":
                        var verUser = _shopDb.Users
                           .Where(b => b.UserLogin == clientMessage.RegTrans.UserLogin).FirstOrDefault();
                        if (verUser != null)
                        {
                            var serverMessage = new ServerMessage()
                            {
                                Messagge = "NOREG"
                            };
                            var response = _jsonSender.ServerMessageSerialize(serverMessage);
                            StreamWriter streamWritter = new StreamWriter(ns);

                            streamWritter.WriteLine(response);
                            streamWritter.Flush();
                        }
                        else
                        {
                            var newUser = new User()
                            {
                                UserLogin = clientMessage.RegTrans.UserLogin,
                                RegDate = DateTime.Now,
                                Email = clientMessage.RegTrans.Email,
                                PublisherId = clientMessage.RegTrans.PublisherId,
                                Password = clientMessage.RegTrans.Password,
                            };
                           
                            _shopDb.Users.Add(newUser);
                            _shopDb.SaveChanges();
                               
                           
                            var refMessage = new ServerMessage()
                            {
                                Messagge = "YESREG",
                            };
                            var regOk = _jsonSender.ServerMessageSerialize(refMessage);
                            StreamWriter streaWriter = new StreamWriter(ns);
                            streaWriter.WriteLine(regOk);
                            streaWriter.Flush();
                        }
                        break;
                    case "AUTH_USER":
                        var authUserLogin = _shopDb.Users
                          .Where(b => b.UserLogin == clientMessage.AuthUser.UserLogin).FirstOrDefault();
                        var authUserPassw = _shopDb.Users
                          .Where(b => b.Password == clientMessage.AuthUser.Password).FirstOrDefault();
                        if (authUserLogin != null || authUserPassw != null)
                        {
                            var refMessage = new ServerMessage()
                            {
                                Messagge = "YESAUTH",
                                User = authUserLogin,
                            };
                            var regOk = _jsonSender.ServerMessageSerialize(refMessage);
                            StreamWriter streamWriter = new StreamWriter(ns);
                            streamWriter.WriteLine(regOk);
                            streamWriter.Flush();
                        }
                        else
                        {
                            var serverMessage = new ServerMessage()
                            {
                                Messagge = "NOAUTH"
                            };
                            var response = _jsonSender.ServerMessageSerialize(serverMessage);
                            StreamWriter streamWritter = new StreamWriter(ns);

                            streamWritter.WriteLine(response);
                            streamWritter.Flush();
                        }
                            break;
                    case "GET_BOOK":
                        break;
                    case "GET_ALL_BOOKS":
                        List<Book> allBooks = _shopDb.Books.ToList();
                        var allBooksMessage = new ServerMessage()
                        {
                            Messagge = "ALL_BOOKS_LIST",
                            AllBooks = allBooks
                        };

                        var booksSerialized = _jsonSender.ServerMessageSerialize(allBooksMessage);
                        StreamWriter sw = new StreamWriter(ns);
                        sw.WriteLine(booksSerialized);
                        sw.Flush();
                        break;
                    case "ADD_WHISHLIST":
                        var whishlistMessage = new ServerMessage();
                        try
                        {
                            var newWishlist = new Wishlist
                            {
                                Id = -1,
                                UserId = clientMessage.UserId,
                                BookId = clientMessage.BookId,
                            };
                            _shopDb.Wishlists.Add(newWishlist);
                            _shopDb.SaveChanges();
                            whishlistMessage.Messagge = "WISHLIST:OK";
                        }catch (Exception ex)
                        {
                            whishlistMessage.Messagge = "WISHLIST:ERROR";
                        }
                        

                        var whishlist = _jsonSender.ServerMessageSerialize(whishlistMessage);
                        StreamWriter streamW = new StreamWriter(ns);
                        streamW.WriteLine(whishlist);
                        streamW.Flush();
                        break;
                    case "REMOVE_WHISHLIST":
                        var whishlistRemoveMessage = new ServerMessage();
                        try
                        {

                            var wishlistEntry = _shopDb.Wishlists
                                   .FirstOrDefault(w => w.UserId == clientMessage.UserId && w.BookId == clientMessage.BookId);

                            if (wishlistEntry != null)
                            {
                                _shopDb.Wishlists.Remove(wishlistEntry);
                                _shopDb.SaveChanges();
                            }
                            whishlistRemoveMessage.Messagge = "WISHLIST:OK";
                        }
                        catch (Exception ex)
                        {
                            whishlistRemoveMessage.Messagge = "WISHLIST:ERROR";
                        }


                        var whishlistMess = _jsonSender.ServerMessageSerialize(whishlistRemoveMessage);
                        StreamWriter streamWr = new StreamWriter(ns);
                        streamWr.WriteLine(whishlistMess);
                        streamWr.Flush();
                        break;
                    case "GET_WHISHLIST":
                        var getWhishlistMessage = new ServerMessage();
                        try
                        {
                            var booksInWishlist = _shopDb.Wishlists
                                          .Where(w => w.UserId == clientMessage.UserId)
                                          .Select(w => w.Book)
                                          .Distinct()
                                          .ToList();

                            getWhishlistMessage.Messagge = "WHISHLIST_BOOKS:OK";
                            getWhishlistMessage.AllBooks = booksInWishlist;

                        }catch (Exception ex)
                        {
                            getWhishlistMessage.Messagge = "WHISHLIST_BOOKS:ERROR";
                        }
                        var wishlistBooks = _jsonSender.ServerMessageSerialize(getWhishlistMessage);
                        StreamWriter stw = new StreamWriter(ns);
                        stw.WriteLine(wishlistBooks);
                        stw.Flush();
                        break;
                    case "UPDATE_USER":
                        var updateUserMessage = new ServerMessage();
                        try
                        {
                            var existingUser = _shopDb.Users.FirstOrDefault(p => p.Id == clientMessage.AuthUser.Id);
                            if (existingUser == null)
                            {
                                Console.WriteLine($"User with ID {clientMessage.AuthUser.Id} not found.");
                                updateUserMessage.Messagge = "UPDATE_USER:USER_NOT_FOUND";
                            }
                            else
                            {
                                Console.WriteLine("User found. Proceeding with update...");
                                existingUser.UserLogin = clientMessage.AuthUser.UserLogin;
                                existingUser.Email = clientMessage.AuthUser.Email;
                                existingUser.RegDate = clientMessage.AuthUser.RegDate;

                                if (!string.IsNullOrEmpty(clientMessage.AuthUser.Password))
                                {
                                    existingUser.Password = clientMessage.AuthUser.Password;
                                }
                                _shopDb.SaveChanges();
                                Console.WriteLine("Changes saved to the database.");

                                updateUserMessage.Messagge = "UPDATE_USER:OK";
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Exception: {ex.Message}\n{ex.StackTrace}");

                            updateUserMessage.Messagge = "UPDATE_USER:ERROR";
                        }

                        var updateUser = _jsonSender.ServerMessageSerialize(updateUserMessage);
                        using (StreamWriter stwr = new StreamWriter(ns))
                        {
                            stwr.WriteLine(updateUser);
                            stwr.Flush();
                        }
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
