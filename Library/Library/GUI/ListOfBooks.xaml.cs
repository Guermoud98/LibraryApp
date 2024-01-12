using Library.Business;
using Library.DAO;
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

        private void History_Btn(object sender, RoutedEventArgs e)
        {

               var livres = (from t in conn.Livres where t.Categorie == "History" select new { t.Image, t.Titre, t.Disponible, t.Description, t.IdLivre } );
           
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

                //btn Infos
                Button infoBtn = new Button();
                infoBtn.Content = "Infos";
                infoBtn.Height = 30;
                infoBtn.Width = 30;

                //Adding children(newImae, titre, disponible) to the stackPanel
                stackPanel.Children.Add(newImage);
                stackPanel.Children.Add(titre);
                stackPanel.Children.Add(disponible);
                stackPanel.Children.Add(infoBtn);

                //Adding stackPanel to the wrapPanel
                historyWindow.WrapPanel.Children.Add(stackPanel);
                infoBtn.Click += (senderBtn, eBtn) => btnInfo(senderBtn, eBtn, item.IdLivre, item.Description, BitObj, item.Titre);

            }

        }
        private void btnInfo(object sender, RoutedEventArgs e, int idLivre, String description, BitmapImage bitObj, String titre)
        {
            BookInfo bookInfo = new BookInfo();
            bookInfo.Show();
            Hide();
            StackPanel stackPanel= new StackPanel();
            //image
            Image img = new Image();
            img.Width = 98;
            img.Height = 133;
            img.Source = bitObj;

            //book description
            TextBlock desc = new TextBlock();
            desc.Foreground = Brushes.Green;
            desc.Text = description;
            desc.TextWrapping = TextWrapping.Wrap;
            Console.WriteLine(description);

            //book title
            TextBlock title = new TextBlock();
            title.TextAlignment = TextAlignment.Center;
            title.Height = 16;
            title.Text = titre;


            //Adding elements to the stackPanel 
            stackPanel.Children.Add(title);
            stackPanel.Children.Add(img);
            stackPanel.Children.Add(desc);


            // Wrapping the stackPanel in a ScrollViewer
            ScrollViewer scrollViewer = new ScrollViewer();
            scrollViewer.Content = stackPanel;

            // Adding the ScrollViewer to the wrapPanel of the BookInfo window
            bookInfo.WrapPanel.Children.Add(scrollViewer);




        }



        private void Science_Btn(object sender, RoutedEventArgs e)
        {
            var livres = (from t in conn.Livres where t.Categorie == "Science" select new { t.Image, t.Titre, t.Disponible });

            foreach (var item in livres)
            {
                BooksOfScience ScienceWindow = Application.Current.Windows.OfType<BooksOfScience>().FirstOrDefault(); //this expression returns the first window in the collection of open windows that is of the type BooksOfHistory, or null if there are no such windows open.

                if (ScienceWindow == null)
                {
                    ScienceWindow = new BooksOfScience(); //the window of Science books
                    ScienceWindow.Show();
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
                ScienceWindow.WrapPanel.Children.Add(stackPanel);
            }

        }

        private void Business_Btn(object sender, RoutedEventArgs e)
        {
            var livres = (from t in conn.Livres where t.Categorie == "Business" select new { t.Image, t.Titre, t.Disponible });

            foreach (var item in livres)
            {
                BooksOfBusiness BusinessWindow = Application.Current.Windows.OfType<BooksOfBusiness>().FirstOrDefault(); //this expression returns the first window in the collection of open windows that is of the type BooksOfHistory, or null if there are no such windows open.

                if (BusinessWindow == null)
                {
                    BusinessWindow = new BooksOfBusiness(); //the window of Business books
                    BusinessWindow.Show();
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
                BusinessWindow.WrapPanel.Children.Add(stackPanel);
            }
        }
    }
}
