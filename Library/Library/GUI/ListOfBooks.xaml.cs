using Library.Business;
using Library.DAO;
using Library.GUI.booksPicture;
using Library.Models;
using Library.Sessions;
using System;
using System.Collections.Generic;
using System.IO; //MemoryStream
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static Library.GUI.booksPicture.BookTitlePath;

namespace Library.GUI
{
    /// <summary>
    /// Interaction logic for ListOfBooks.xaml
    /// </summary>
    public partial class ListOfBooks : Window
    {
        LibraryDBContext conn = new LibraryDBContext();
        public ListOfBooks()
        {
            InitializeComponent();
        }

        private void HistoryBook(object sender, RoutedEventArgs e)
        {

                var livres = (from t in conn.Livres where t.Categorie == "History" select new { t.Image, t.Titre, t.Disponible } );
               /* var result = (from t in conn.Livres where t.Categorie == "History" select t.Image).FirstOrDefault();// on s'interesse aux images des livres avec la catégorie = History 
                Stream StreamObj = new MemoryStream(result); // j'alloue une partie de la mémoire vive pour stocker temporairement les images avant d'être utilisées pour créer un objet BitmapImage
                BitmapImage BitObj = new BitmapImage();
                BitObj.BeginInit();
                BitObj.StreamSource = StreamObj;
                BitObj.EndInit();
                BooksOfHistory booksHistory = new BooksOfHistory(); //the window of history books
                booksHistory.Show();
                Hide();
                booksHistory.image.Source = BitObj; //image c'est le nom de l'image dans wrapPanel
                */
               foreach(var item in livres)
                {
                BooksOfHistory historyWindow = Application.Current.Windows.OfType<BooksOfHistory>().FirstOrDefault(); //this expression returns the first window in the collection of open windows that is of the type BooksOfHistory, or null if there are no such windows open.

                if (historyWindow == null)
                {
                    historyWindow = new BooksOfHistory(); //the window of history books
                    historyWindow.Show();
                    Hide();
                    
                }
                StackPanel stackPanel = new StackPanel();
                var image = item.Image; 
                Stream StreamObj = new MemoryStream(image);
                BitmapImage BitObj = new BitmapImage();
                BitObj.BeginInit();
                BitObj.StreamSource = StreamObj;
                BitObj.EndInit();

                // Create and configure Image control
                Image newImage = new Image();
                newImage.Width = 98;
                newImage.Height = 133;
                newImage.Source = BitObj;

                //TextBlock for book title
                TextBlock titre = new TextBlock();
                titre.TextAlignment = TextAlignment.Center;
                titre.Height = 16;
                titre.Text = item.Titre;

                //TextBlock for book Availability
                TextBlock disponible = new TextBlock();
                disponible.TextAlignment = TextAlignment.Center;
                disponible.Foreground = Brushes.Green;
                disponible.Height = 17;
                disponible.Text = item.Disponible;

                //Adding children(newImae, titre, disponible) to the stackPanel
                stackPanel.Children.Add(newImage);
                stackPanel.Children.Add(titre);
                stackPanel.Children.Add(disponible);

                //Adding stackPanel to the wrapPanel
                historyWindow.WrapPanel.Children.Add(stackPanel);



                /* historyWindow.image.Source = BitObj;
                 historyWindow.titre.Text = item.Titre;
                 historyWindow.availableOrNot.Text = item.Disponible;*/






            }


        }




        /*

        private void HistoryBook(object sender, RoutedEventArgs e)
        {
            ListOfBooksClass listOfBooks = new ListOfBooksClass();  //la liste des titres de tous les livres qu'on a au niveau de ce projet
            BooksOfHistory historyBooks = new BooksOfHistory();
            historyBooks.Show(); //window of history books 
            Hide(); // we hide the listOfBooks window
            LivreManager livreManager = new LivreManager(new LivreDAO(conn));
            List<Livre> livres = livreManager.GetAllLivre(); // we retrieve books of histroy from database

            // Create a ScrollViewer
            ScrollViewer scrollViewer = new ScrollViewer();
            scrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            scrollViewer.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;

            WrapPanel wrapPanel = new WrapPanel();
            wrapPanel.Orientation = Orientation.Horizontal;
            wrapPanel.VerticalAlignment = VerticalAlignment.Top;
            wrapPanel.HorizontalAlignment = HorizontalAlignment.Left;
            wrapPanel.Width = 720;
            wrapPanel.Margin = new Thickness(54, 110, 0, 0);

            foreach (var livre in livres) //looping through books retrieved from db
            {
                StackPanel stackPanel = new StackPanel();
                stackPanel.Margin = new Thickness(10);

                // Image
                Image image = new Image();

                
                foreach (var book in listOfBooks.GetLivre())
                {
                    
                    if (book.Title == livre.Titre)
                    {
                        // Set the local image path on your PC
                        image.Source = new BitmapImage(new Uri(book.ImagePath));
                        break; // Break out of the loop once a match is found
                    }
                }
                image.Width = 92;
                image.Height = 133;
                stackPanel.Children.Add(image);

                // Title
                TextBlock titleTextBlock = new TextBlock();
                titleTextBlock.Text = livre.Titre;
                titleTextBlock.TextAlignment = TextAlignment.Center;
                titleTextBlock.Height = 16;
                stackPanel.Children.Add(titleTextBlock);

                // Read Text
                TextBlock readTextBlock = new TextBlock();
                readTextBlock.TextAlignment = TextAlignment.Center;
                readTextBlock.Foreground = Brushes.Green;
                Button readButton = new Button();
                readButton.Content = "Reserver";
                stackPanel.Children.Add(readButton);
                wrapPanel.Children.Add(stackPanel);
                readButton.Click += (s, e) => ReserverHistoryBook_Click(livre);
            }

            // Set the WrapPanel as the content of the ScrollViewer
            scrollViewer.Content = wrapPanel;

            // Set the ScrollViewer as the content of the historyBooks window
            historyBooks.Content = scrollViewer;
        }

        private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            // Exclude the "Image" column from auto-generation
            if (e.PropertyName == "Image")
            {
                e.Cancel = true;
            }
        }
        private void ReserverHistoryBook_Click(Livre livre)
        {
            // Create a new window for book details and pass the selected livre
            if (livre.Titre == "A City On Mars")
            {
             
                int userId = ConnectedAdherent.CurrentAdherentId; 

                // Create a new Reservation object
                Reservation reservation = new Reservation
                {
                    livreId = livre.IdLivre, 
                    AdherentId = userId,   
                    DateReservation = DateTime.Now,
                    DateRetourPrevue = DateTime.Now.AddDays(14) // Set the return date to 14 days from now
                   
                };



                // Update the Livre entity to mark it as unavailable
                    LibraryDBContext dbContext = new LibraryDBContext();
                
                    LivreManager livreManager = new LivreManager(new LivreDAO(dbContext));
                    Livre updatedLivre = livreManager.GetLivreByID(livre.IdLivre);
                    updatedLivre.Disponible = "non";
                    livreManager.UpdateLivre(updatedLivre);
                    ReservationManager res = new ReservationManager(new ReservationDAO(dbContext));
                    res.AddReservation(reservation);
                    dbContext.SaveChanges();
                    MessageBox.Show("Vous venez de reserver le livre " + livre.Titre, "Success", MessageBoxButton.OK, MessageBoxImage.Information);



            }

        } */

     
 


    }
}
