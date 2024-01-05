﻿using Library.Models;
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
    /// Interaction logic for Inscription.xaml
    /// </summary>
    public partial class Inscription : Window
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CreerCompte(object sender, RoutedEventArgs e)
        {
            //Récupération des valeurs
            string nom = TextBoxNom.Text;
            string prenom = TextBoxPrenom.Text;
            string adresse = TextBoxEmail.Text;
            string password = PasswordBox.Password;

            // Validater les inputs
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) || string.IsNullOrWhiteSpace(adresse) || string.IsNullOrWhiteSpace(password))
            {
                // On Affiche un message d'erreur
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Adherent newAdherent = new Adherent
            {
                Nom = nom,
                Prenom = prenom,
                //Adresse = adresse,
                //MotDePasse = password
                // Set other properties as needed
            };

        }
    }
}
