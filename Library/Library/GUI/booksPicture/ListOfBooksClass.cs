using System;
using System.Collections.Generic;


namespace Library.GUI.booksPicture
{
    internal class ListOfBooksClass
    {
        private List<BookTitlePath.BookInfo> Books { get;set; }

        public ListOfBooksClass()
        {
            Books = new List<BookTitlePath.BookInfo>()
            {
                new BookTitlePath.BookInfo { Title = "A City On Mars", ImagePath = @"C:\Users\Administrateur\Desktop\Main\EMSI\s7\DotNet\LibraryApp\Library\Library\GUI\booksPicture\ACityOnMarsScience.jpg" },
                new BookTitlePath.BookInfo { Title = "Ali Abdal", ImagePath = @"C:\Users\Administrateur\Desktop\Main\EMSI\s7\DotNet\LibraryApp\Library\Library\GUI\booksPicture\AliAbdalBusiness.jpg" },
                new BookTitlePath.BookInfo { Title = "Bonesheker", ImagePath = @"C:\Users\Administrateur\Desktop\Main\EMSI\s7\DotNet\LibraryApp\Library\Library\GUI\booksPicture\Bonesheker.jpg" },
                new BookTitlePath.BookInfo { Title = "Breaking Twitter", ImagePath = @"C:\Users\Administrateur\Desktop\Main\EMSI\s7\DotNet\LibraryApp\Library\Library\GUI\booksPicture\BreakingTwitterBusiness.jpg" },
                new BookTitlePath.BookInfo { Title = "Clementine", ImagePath = @"C:\Users\Administrateur\Desktop\Main\EMSI\s7\DotNet\LibraryApp\Library\Library\GUI\booksPicture\Clementine.jpg" },
                new BookTitlePath.BookInfo { Title = "Data Baby", ImagePath = @"C:\Users\Administrateur\Desktop\Main\EMSI\s7\DotNet\LibraryApp\Library\Library\GUI\booksPicture\DataBabyScience.jpg" },
                new BookTitlePath.BookInfo { Title = "Douglas", ImagePath = @"C:\Users\Administrateur\Desktop\Main\EMSI\s7\DotNet\LibraryApp\Library\Library\GUI\booksPicture\DouglasHistory.jpg" },
                new BookTitlePath.BookInfo { Title = "Elon Musk", ImagePath = @"C:\Users\Administrateur\Desktop\Main\EMSI\s7\DotNet\LibraryApp\Library\Library\GUI\booksPicture\ElonMuskScience.jpg" },
                new BookTitlePath.BookInfo { Title = "Gator", ImagePath = @"C:\Users\Administrateur\Desktop\Main\EMSI\s7\DotNet\LibraryApp\Library\Library\GUI\booksPicture\GatorScience.jpg" },
                new BookTitlePath.BookInfo { Title = "Mike", ImagePath = @"C:\Users\Administrateur\Desktop\Main\EMSI\s7\DotNet\LibraryApp\Library\Library\GUI\booksPicture\Mike.jpg" },
                new BookTitlePath.BookInfo { Title = "Network Of Lies", ImagePath = @"C:\Users\Administrateur\Desktop\Main\EMSI\s7\DotNet\LibraryApp\Library\Library\GUI\booksPicture\NetworkOfLiesBusiness.jpg" },
                new BookTitlePath.BookInfo { Title = "Rich Af", ImagePath = @"C:\Users\Administrateur\Desktop\Main\EMSI\s7\DotNet\LibraryApp\Library\Library\GUI\booksPicture\RichAfBusiness.jpg" },
                new BookTitlePath.BookInfo { Title = "Rot and Ruin", ImagePath = @"C:\Users\Administrateur\Desktop\Main\EMSI\s7\DotNet\LibraryApp\Library\Library\GUI\booksPicture\Rot&Ruin.jpg" },
                new BookTitlePath.BookInfo { Title = "Soldier Of Destiny", ImagePath = @"C:\Users\Administrateur\Desktop\Main\EMSI\s7\DotNet\LibraryApp\Library\Library\GUI\booksPicture\SoldierOfDestinyHistory.jpg" },
                new BookTitlePath.BookInfo { Title = "The First Days", ImagePath = @"C:\Users\Administrateur\Desktop\Main\EMSI\s7\DotNet\LibraryApp\Library\Library\GUI\booksPicture\TheFirstDays.jpg" },
                new BookTitlePath.BookInfo { Title = "The Anubis Gates", ImagePath = @"C:\Users\Administrateur\Desktop\Main\EMSI\s7\DotNet\LibraryApp\Library\Library\GUI\booksPicture\TheAnubisGates.jpg" },
                new BookTitlePath.BookInfo { Title = "Ufo", ImagePath = @"C:\Users\Administrateur\Desktop\Main\EMSI\s7\DotNet\LibraryApp\Library\Library\GUI\booksPicture\UfoHistory.jpg" },
            };

        }
        public List<BookTitlePath.BookInfo> GetLivre()
        {
            return Books;
        }
    }
}
