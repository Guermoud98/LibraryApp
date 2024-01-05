using Library.DAO;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business
{
    internal class AdminManager
    {
        AdminDAO _adminDAO;
        private readonly EmployeDAO _employeDAO;
        private readonly LivreDAO _livreDAO;
        private readonly ReservationDAO _reservationDAO;

        public AdminManager(AdminDAO adminDAO, EmployeDAO employeDAO, LivreDAO livreDAO, ReservationDAO reservationDAO)
        {
            _adminDAO = adminDAO;
            _employeDAO = employeDAO;
            _livreDAO = livreDAO;
            _reservationDAO = reservationDAO;
        }

        // Ajout d'un nouvel employé
        public void AjouterEmploye(Employe employe)
        {
            // Logique d'ajout d'un employé
            _employeDAO.AddEmploye(employe);
        }

        // Ajout d'un nouveau livre
        public void AjouterLivre(Livre livre)
        {
            // Logique d'ajout d'un livre
            _livreDAO.AddLivre(livre);
        }

        // Consultation de tous les employés
        /* public List<Employe> ConsulterEmployes()
         {
             // Logique de consultation des employés
             return null
         }*/

        // Consultation de tous les livres
        public List<Livre> ConsulterLivres()
        {
            // Logique de consultation des livres
            return _livreDAO.GetLivres();
        }

        // Suppression d'un employé
        public void SupprimerEmploye(int employeId)
        {
            // Logique de suppression d'un employé
            _employeDAO.DeleteEmploye(employeId);
        }

        // Suppression d'un livre
        public void SupprimerLivre(int livreId)
        {
            // Logique de suppression d'un livre
            _livreDAO.RemoveLivre(livreId);
        }

        // Autres méthodes pour la gestion des réservations, des admins, etc.
    }
}
