using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DAO
{
    internal class EmployeDAO
    {
        private readonly LibraryDBContext _dbcontext;

        // Constructeur qui reçoit le contexte de base de données pour avoir une référence 
        // Ce design pattern est appele dependency injection
        public EmployeDAO(LibraryDBContext context)
        {
            _dbcontext = context ?? throw new ArgumentNullException(nameof(context));
        }
        //cherche  si identifiant et mdp est dans  database pour qu'il puisse se connecter
        public Employe GetEmployeByIdentifiantPassword(string identifiant, string motDePasse)
        {
            return _dbcontext.Employees.SingleOrDefault(e => e.Identifiant == identifiant && e.MotDePasse == motDePasse);
        }



        // Méthode pour récupérer tous les employés de la base de données
        public List<Employe> GetAllEmployes()
        {
            return _dbcontext.Employees.ToList();
        }

        // Méthode pour récupérer un employé par son ID
        public Employe GetEmployeByID(int employeId)
        {
            return _dbcontext.Employees.FirstOrDefault(e => e.IdEmploye == employeId);
        }

        // Méthode pour ajouter un nouvel employé à la base de données
        public void AddEmploye(Employe employe)
        {
            if (employe == null)
                throw new ArgumentNullException(nameof(employe));

            _dbcontext.Employees.Add(employe);
            _dbcontext.SaveChanges(); // Sauvegarder les changements dans la base de données
        }

        // Méthode pour mettre à jour les informations d'un employé existant
        public void UpdateEmploye(Employe employe)
        {
            if (employe == null)
                throw new ArgumentNullException(nameof(employe));

            // Rechercher l'employé existant par son ID
            var existingEmploye = _dbcontext.Employees.Find(employe.IdEmploye); //chercher l'employe dans la bd s'il existe

            if (existingEmploye != null)
            {
                _dbcontext.Employees.Update(existingEmploye);
                _dbcontext.SaveChanges(); // Sauvegarder les changements dans la base de données
            }
        }

        // Méthode pour supprimer un employé de la base de données par son ID
        public void DeleteEmploye(int employeId)
        {
            // Rechercher l'employé à supprimer par son ID
            var employeToDelete = _dbcontext.Employees.Find(employeId);

            if (employeToDelete != null)
            {
                _dbcontext.Employees.Remove(employeToDelete);
                _dbcontext.SaveChanges(); // Sauvegarder les changements dans la base de données
            }
        }

    }
}
