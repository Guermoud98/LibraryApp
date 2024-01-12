using Library.Business;
using Library.DAO;
using Library.Models;
using Library.Sessions;
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
    /// Interaction logic for BookInfo.xaml
    /// </summary>
    public partial class BookInfo : Window
    {
        LibraryDBContext conn = new LibraryDBContext(); //connexion
        public BookInfo()
        {
            InitializeComponent();
        }

        private void ReserverBtn(object sender, RoutedEventArgs e)
        {
            ListOfBooks listOfBooks = new ListOfBooks();

            Reservation reservation = new Reservation()
            {
                livreId = ListOfBooks.idLivreValue,
                AdherentId = ConnectedAdherent.CurrentAdherentId,
                DateReservation = DateTime.Now,
                DateRetourPrevue = DateTime.Now.AddDays(5)
            };
            ReservationManager reservationManager = new ReservationManager(new ReservationDAO(conn));
            reservationManager.AddReservation(reservation);
            // Query the database for the row to be updated.
            Livre disponibilite = (from t in conn.Livres where t.IdLivre == ListOfBooks.idLivreValue select t).FirstOrDefault();
            disponibilite.Disponible = "Non Disponible";
            conn.SaveChanges();
          



        }
    }
}
