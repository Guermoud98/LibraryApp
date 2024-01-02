using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Library.DAO
{
    internal class ReservationDAO
    {
        // La déclaration de readonly sur un champ signifie que sa valeur ne peut être modifiée qu'à l'intérieur du constructeur de la classe
        private readonly LibraryDBContext _dbContext; //L'objet dbContext encapsule la connexion à la base de données + l'underscore c'est une convention de codage pour dire que c'est un champ de classe

        public ReservationDAO(LibraryDBContext context)
        {
            _context = context;
        }
        // la méthode pour ajouter une reservation

        public void AddReservation(Reservation reservation)
        {
            _dbContext.Reservations.Add(reservation); // on ajoute a 'DbSet Reservations' une reservation passe au parametre
            _dbContext.SaveChanges(); // to save the changes. This method is necessary to persist the changes.
        }
        // la methode qui retourne un livre en se basant de son id
        public Reservation GetReserationByID(int id)
        {
            return _dbContext.Reservations.FirstOrDefault(r => r.IdReservation == id); // lambda expression, default = null, "a" parameter represents each reservation in the table
        }
        //  la methode qui fait l'update d'une reservation en se basant de son id
        public void UpdateLivre(Livre updatedReservation)
        {
            _dbContext.Reservations.Update(updatedReservation);
            _dbContext.SaveChanges();
        }
        // pour afficher toutes les reservations
        public List<Reservation> GetReservations()
        {
            return _dbContext.Reservations.ToList; // pour afficher toutes les reservations ss forme de liste

        }
        //pour supprimer une reservation en se basant de son id
        public void RemoveReservation(int id)
        {
            var ReservationToRemove = _dbContext.Reservations.Find(id);
            if (ReservationToRemove != null)
            {
                _dbContext.Livres.Remove(ReservationToRemove);
                _dbContext.SaveChanges();
            }
        }


    }
}
