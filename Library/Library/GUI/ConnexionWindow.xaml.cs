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
    /// Interaction logic for ConnexionWindow.xaml
    /// </summary>
    public partial class ConnexionWindow : Window
    {
        LibraryDBContext conn = new LibraryDBContext();
        public ConnexionWindow()
        {
            InitializeComponent();
        }


        private void SeConnecter(object sender, RoutedEventArgs e)
        {
            String email = TextBoxEmail.Text;
            String password = PasswordBox.Password;
            if(String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            AdherentManager adherentManager = new AdherentManager(new AdherentDAO(conn));
            Adherent connectedtAdherent = adherentManager.Connecter(email, password);
            if(connectedtAdherent != null)
            {
                MessageBox.Show("Welcome! You are now connected.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                ListOfBooks list = new ListOfBooks();
                list.Show();
                Hide();

            }
            // si les identifiants sont incorrectes
            else
            {
                MessageBox.Show("Incorrect email or password. Please try again.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
             



        }

        //le btn dans la page cnx juste pour tester l'insertion des livres
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BooksWindow b = new BooksWindow();
            b.Show();
            Hide();
        }
    }
}
