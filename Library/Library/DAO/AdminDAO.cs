using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAO
{
    internal class AdminDAO
    {
        private readonly LibraryDBContext _dbcontext;// Référence vers le contexte de la base de données pour effectuer des opérations CRUD.

        // Constructeur qui reçoit le contexte de base de données
        public AdminDAO(LibraryDBContext context)
        {
            _dbcontext = context ?? throw new ArgumentNullException(nameof(context));
        }

        // Méthode pour récupérer tous les administrateurs de la base de données
        public List<Admin> GetAllAdmins()
        {
            return _dbcontext.Admins.ToList();
        }

        // Méthode pour récupérer un administrateur par son ID
        public Admin GetAdminByID(int adminId)
        {
            return _dbcontext.Admins.FirstOrDefault(a => a.IdAdmin == adminId);
        }

        // Méthode pour ajouter un nouvel administrateur à la base de données
        public void AddAdmin(Admin admin)
        {
            if (admin == null)
                throw new ArgumentNullException(nameof(admin));

            _dbcontext.Admins.Add(admin);
            _dbcontext.SaveChanges(); // Sauvegarder les changements dans la base de données
        }

        // Méthode pour mettre à jour les informations d'un administrateur existant
        public void UpdateAdmin(Admin admin)
        {
            if (admin == null)
                throw new ArgumentNullException(nameof(admin));

            // Rechercher l'administrateur existant par son ID
            var existingAdmin = _dbcontext.Admins.Find(admin.IdAdmin);

            if (existingAdmin != null)
            {
                _dbcontext.Admins.Update(existingAdmin);
                _dbcontext.SaveChanges(); // Sauvegarder les changements dans la base de données
            }
        }

        // Méthode pour supprimer un administrateur de la base de données par son ID
        public void DeleteAdmin(int adminId)
        {
            // Rechercher l'administrateur à supprimer par son ID
            var adminToDelete = _dbcontext.Admins.Find(adminId);

            if (adminToDelete != null)
            {
                _dbcontext.Admins.Remove(adminToDelete);
                _dbcontext.SaveChanges(); // Sauvegarder les changements dans la base de données
            }
        }
    }
}
