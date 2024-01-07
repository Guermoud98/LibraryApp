using Library.Business;
using Library.DAO;
using Library.Models;
using System;
using System.Collections.Generic;
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



        private void HistoryBook(object sender, RoutedEventArgs e)
        {
            BooksOfHistory historyBooks = new BooksOfHistory();
            historyBooks.Show();
            Hide();
            LivreManager livreManager = new LivreManager(new LivreDAO(conn));
            List<Livre> livres = livreManager.GetAllLivre();

            // Bind the history books to the DataGrid
            historyBooks.dataGridHistoryBooks.ItemsSource = livres;
        }
    }
}
