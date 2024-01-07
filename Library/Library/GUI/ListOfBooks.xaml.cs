﻿using Library.Business;
using Library.DAO;
using Library.GUI.booksPicture;
using Library.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
            ListOfBooksClass listOfBooks = new ListOfBooksClass();
            BooksOfHistory historyBooks = new BooksOfHistory();
            historyBooks.Show();
            Hide(); // we hide the listOfBooks window
            LivreManager livreManager = new LivreManager(new LivreDAO(conn));
            List<Livre> livres = livreManager.GetAllLivre();

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

            foreach (var livre in livres)
            {
                StackPanel stackPanel = new StackPanel();
                stackPanel.Margin = new Thickness(10);

                // Image
                Image image = new Image();

                // Condition to use a specific local image for a specific livre
                foreach (var book in listOfBooks.GetLivre())
                {
                    // Check if the titles match
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
                readTextBlock.Inlines.Add(new Run("Read"));
                stackPanel.Children.Add(readTextBlock);

                wrapPanel.Children.Add(stackPanel);
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





    }
}
