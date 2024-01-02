using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.DAO
{
    internal class LibraryDBContext : DbContext // manages the connection to the database. It contains information about the database provider (e.g., SQL Server, SQLite) and the connection string used to connect to the database.
    {
        public DbSet<Adherent> Adherents { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Employe> Employees { get; set; }
        public DbSet<Livre> Livres { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MARIA-GM;Database=libraryApp;Integrated Security=True;");
        }

    }
}
