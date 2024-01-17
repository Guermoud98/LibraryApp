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
using Xceed.Wpf.Toolkit.Panels;


namespace Library.GUI
{
    /// <summary>
    /// Interaction logic for ListOfBooks.xaml
    /// </summary>
    public partial class ListOfBooks : Window
    {
        LibraryDBContext conn = new LibraryDBContext();
        public static int idLivreValue { get; set; }
        public ListOfBooks()
        {
            InitializeComponent();
        }

        private void History_Btn(object sender, RoutedEventArgs e)
        {

               var livres = (from t in conn.Livres where t.Categorie == "History" && t.Disponible == "Disponible" select new { t.Image, t.Titre, t.Disponible, t.Description, t.IdLivre } );
           
               foreach(var item in livres)
                {
                BooksOfHistory historyWindow = Application.Current.Windows.OfType<BooksOfHistory>().FirstOrDefault(); //this expression returns the first window in the collection of open windows that is of the type BooksOfHistory, or null if there are no such windows open.

                if (historyWindow == null)
                {
                    historyWindow = new BooksOfHistory(); //the window of history books
                    historyWindow.Show();
                    Hide();
                    
                }
                historyWindow.WrapPanel.Width = double.NaN; // Auto
                historyWindow.WrapPanel.Height = double.NaN; // Auto
                historyWindow.WrapPanel.Margin = new Thickness(10, 10, 10, 10);

                StackPanel stackPanel = new StackPanel();
                stackPanel.Margin = new Thickness(5);

                var image = item.Image; 
                Stream StreamObj = new MemoryStream(image);
                BitmapImage BitObj = new BitmapImage();
                BitObj.BeginInit();
                BitObj.StreamSource = StreamObj;
                BitObj.EndInit();

                // Create and configure Image control
                Image newImage = new Image();
                newImage.Width = 150;
                newImage.Height = 200;
                newImage.Source = BitObj;

                //TextBlock for book title
                TextBlock titre = new TextBlock();
                titre.TextAlignment = TextAlignment.Center;
                titre.Height = 25;
                titre.Text = item.Titre;
                titre.FontSize = 18; // Taille de police
                titre.FontWeight = FontWeights.Bold; // Poids de la police
                titre.Foreground = Brushes.Black; // Couleur du texte
                titre.Margin = new Thickness(0, 10, 0, 5);

                //TextBlock for book Availability
                TextBlock disponible = new TextBlock();
                disponible.TextAlignment = TextAlignment.Center;
                disponible.Foreground = Brushes.Green;
                disponible.Height = 25;
                disponible.Text = item.Disponible;
                disponible.Margin = new Thickness(0, 5, 0, 10);

                //btn Infos
                Button infoBtn = new Button();
                infoBtn.Content = "Infos";
                infoBtn.Height = 40;
                infoBtn.Width = 40;
                infoBtn.BorderThickness = new Thickness(2);
                infoBtn.Background= Brushes.Black;
                infoBtn.Foreground= Brushes.White;
            

                //Adding children(newImae, titre, disponible, btnInfo) to the stackPanel
                stackPanel.Children.Add(newImage);
                stackPanel.Children.Add(titre);
                stackPanel.Children.Add(disponible);
                stackPanel.Children.Add(infoBtn);

                //Adding stackPanel to the wrapPanel
                historyWindow.WrapPanel.Children.Add(stackPanel);
                infoBtn.Click += (senderBtn, eBtn) => btnInfo(senderBtn, eBtn, item.IdLivre, item.Description, BitObj, item.Titre);

            }

        }
       



        private void Science_Btn(object sender, RoutedEventArgs e)
        {
            var livres = (from t in conn.Livres where t.Categorie == "Science" && t.Disponible == "Disponible" select new { t.Image, t.Titre, t.Disponible, t.Description, t.IdLivre });


            foreach (var item in livres)
            {
                BooksOfScience ScienceWindow = Application.Current.Windows.OfType<BooksOfScience>().FirstOrDefault(); //this expression returns the first window in the collection of open windows that is of the type BooksOfHistory, or null if there are no such windows open.

                if (ScienceWindow == null)
                {
                    ScienceWindow = new BooksOfScience(); //the window of Science books
                    ScienceWindow.Show();
                    Hide();

                }

                //WrapPanel
                ScienceWindow.WrapPanel.Width = double.NaN; // Auto
                ScienceWindow.WrapPanel.Height = double.NaN; // Auto
                ScienceWindow.WrapPanel.Margin = new Thickness(10, 10, 10, 10);

                StackPanel stackPanel = new StackPanel();
                stackPanel.Margin = new Thickness(5);

                var image = item.Image;
                Stream StreamObj = new MemoryStream(image);
                BitmapImage BitObj = new BitmapImage();
                BitObj.BeginInit();
                BitObj.StreamSource = StreamObj;
                BitObj.EndInit();

                // Create and configure Image control
                Image newImage = new Image();
                newImage.Width = 150;
                newImage.Height = 200;
                newImage.Source = BitObj;

                //TextBlock for book title
                TextBlock titre = new TextBlock();
                titre.TextAlignment = TextAlignment.Center;
                titre.Height = 25;
                titre.Text = item.Titre;
                titre.FontSize = 18; // Taille de police
                titre.FontWeight = FontWeights.Bold; // Poids de la police
                titre.Foreground = Brushes.Black; // Couleur du texte
                titre.Margin = new Thickness(0, 10, 0, 5);

                //TextBlock for book Availability
                TextBlock disponible = new TextBlock();
                disponible.TextAlignment = TextAlignment.Center;
                disponible.Foreground = Brushes.Green;
                disponible.Height = 25;
                disponible.Text = item.Disponible;
                disponible.Margin = new Thickness(0, 5, 0, 10);

                //btn Infos
                Button infoBtn = new Button();
                infoBtn.Content = "Infos";
                infoBtn.Height = 40;
                infoBtn.Width = 40;
                infoBtn.BorderThickness = new Thickness(2);
                infoBtn.Background = Brushes.Black;
                infoBtn.Foreground = Brushes.White;

                //Adding children(newImae, titre, disponible, btnInfo) to the stackPanel
                stackPanel.Children.Add(newImage);
                stackPanel.Children.Add(titre);
                stackPanel.Children.Add(disponible);
                stackPanel.Children.Add(infoBtn);

                //Adding stackPanel to the wrapPanel
                ScienceWindow.WrapPanel.Children.Add(stackPanel);
                infoBtn.Click += (senderBtn, eBtn) => btnInfo(senderBtn, eBtn, item.IdLivre, item.Description, BitObj, item.Titre);
            }


        }

        private void Business_Btn(object sender, RoutedEventArgs e)
        {
            var livres = (from t in conn.Livres where t.Categorie == "Business" && t.Disponible == "Disponible" select new { t.Image, t.Titre, t.Disponible, t.Description, t.IdLivre });

            foreach (var item in livres)
            {
                BooksOfBusiness BusinessWindow = Application.Current.Windows.OfType<BooksOfBusiness>().FirstOrDefault(); //this expression returns the first window in the collection of open windows that is of the type BooksOfHistory, or null if there are no such windows open.

                if (BusinessWindow == null)
                {
                    BusinessWindow = new BooksOfBusiness(); //the window of Business books
                    BusinessWindow.Show();
                    Hide();

                }
                //WrapPanel
                BusinessWindow.WrapPanel.Width = double.NaN; // Auto
                BusinessWindow.WrapPanel.Height = double.NaN; // Auto
                BusinessWindow.WrapPanel.Margin = new Thickness(10, 10, 10, 10);

                //stackPanel
                StackPanel stackPanel = new StackPanel();
                stackPanel.Margin = new Thickness(5);

                var image = item.Image;
                Stream StreamObj = new MemoryStream(image);
                BitmapImage BitObj = new BitmapImage();
                BitObj.BeginInit();
                BitObj.StreamSource = StreamObj;
                BitObj.EndInit();

                // Create and configure Image control
                Image newImage = new Image();
                newImage.Width = 150;
                newImage.Height = 200;
                newImage.Source = BitObj;

                //TextBlock for book title
                TextBlock titre = new TextBlock();
                titre.TextAlignment = TextAlignment.Center;
                titre.Height = 25;
                titre.Text = item.Titre;
                titre.FontSize = 18; // Taille de police
                titre.FontWeight = FontWeights.Bold; // Poids de la police
                titre.Foreground = Brushes.Black; // Couleur du texte
                titre.Margin = new Thickness(0, 10, 0, 5);

                //TextBlock for book Availability
                TextBlock disponible = new TextBlock();
                disponible.TextAlignment = TextAlignment.Center;
                disponible.Foreground = Brushes.Green;
                disponible.Height = 25;
                disponible.Text = item.Disponible;
                disponible.Margin = new Thickness(0, 5, 0, 10);

                //btn Infos
                Button infoBtn = new Button();
                infoBtn.Content = "Infos";
                infoBtn.Height = 40;
                infoBtn.Width = 40;
                infoBtn.BorderThickness = new Thickness(2);
                infoBtn.Background = Brushes.Black;
                infoBtn.Foreground = Brushes.White;

                //Adding children(newImae, titre, disponible, btnInfo) to the stackPanel
                stackPanel.Children.Add(newImage);
                stackPanel.Children.Add(titre);
                stackPanel.Children.Add(disponible);
                stackPanel.Children.Add(infoBtn);

                //Adding stackPanel to the wrapPanel
                BusinessWindow.WrapPanel.Children.Add(stackPanel);
                infoBtn.Click += (senderBtn, eBtn) => btnInfo(senderBtn, eBtn, item.IdLivre, item.Description, BitObj, item.Titre);

            }
        }
        //btnInfo
        private void btnInfo(object sender, RoutedEventArgs e, int idLivre, String description, BitmapImage bitObj, String titre)
        {
            BookInfo bookInfo = new BookInfo();
            bookInfo.Show();
            Hide();
            StackPanel stackPanel = new StackPanel();

            //idLivre
            idLivreValue = idLivre; //the idLireValue is a static member which is helpful for the reservation to remember the id of the wanted book 

            //image
            Image img = new Image();
            img.Width = 100;
            img.Height = 150;
            img.Source = bitObj;

            //book description
            TextBlock desc = new TextBlock();
            desc.Text = description;
            desc.TextWrapping = TextWrapping.Wrap;
            Console.WriteLine(description);
            desc.FontSize = 16; // Set the font size
            desc.FontWeight = FontWeights.Normal;
            desc.TextAlignment = TextAlignment.Justify; // Justify the text
            desc.Foreground = Brushes.Black; // la couleur du texte

            //book's title
            TextBlock title = new TextBlock();
            title.TextAlignment = TextAlignment.Center;
            title.Height = 20;
            title.Text = titre;
            title.FontWeight = FontWeights.Bold;

            //Adding elements to the stackPanel 
            stackPanel.Children.Add(img);
            stackPanel.Children.Add(title);
            stackPanel.Children.Add(desc);

            // Wrapping the stackPanel in a ScrollViewer
            ScrollViewer scrollViewer = new ScrollViewer();
            scrollViewer.Content = stackPanel;

            // Adding the ScrollViewer to the wrapPanel of the BookInfo window
            bookInfo.WrapPanel.Children.Add(scrollViewer);


        }
    }
}
