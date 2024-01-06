﻿using Library.Business;
using Library.DAO;
using Library.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO; //related to : File.ReadAllBytes();
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
    /// Interaction logic for BooksWindow.xaml
    /// </summary>
    public partial class BooksWindow : Window
    {
        LibraryDBContext conn = new LibraryDBContext();
        public BooksWindow()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                // Set the selected file path to the TextBox
                TextBoxBrowse.Text = openFileDialog.FileName;
            }
        }

        private void CreerCompte(object sender, RoutedEventArgs e)
        {
            LivreManager l = new LivreManager(new LivreDAO(conn));
            string titre = TextBoxTitre.Text;
            string auteur = TextBoxAuteur.Text;
            string categorie = TextBoxCategorie.Text;
            string disponible = TextBoxDisponible.Text;
            string image = TextBoxBrowse.Text;
            // Convert the image path to a byte array
            byte[] imageBytes = File.ReadAllBytes(image);
            Livre livre = new Livre()
            {
                Titre = titre,
                Auteur = auteur,
                Categorie = categorie,
                Disponible = disponible,
                Image = imageBytes,
            };
            l.AddLivre(livre);
           
        }
    }
}
