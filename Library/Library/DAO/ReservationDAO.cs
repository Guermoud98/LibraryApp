using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Library.Models;
using System.Linq;

namespace Library.DAO
{
    internal class ReservationDAO
    {
        // La déclaration de readonly sur un champ signifie que sa valeur ne peut être modifiée qu'à l'intérieur du constructeur de la classe
        private readonly LibraryDBContext _dbContext; //L'objet dbContext encapsule la connexion à la base de données + l'underscore c'est une convention de codage pour dire que c'est un champ de classe

        // Constructeur qui reçoit le contexte de base de données pour avoir une référence 
        // Ce design pattern est appele Constructor Dependency Injection
        public ReservationDAO(LibraryDBContext context)
        {
            _dbContext = context;
        }
        // la méthode pour ajouter une reservation

        public void AddReservation(Reservation reservation)
        {
            try
            {
                using (LibraryDBContext dbContext = new LibraryDBContext())
                {
                    dbContext.Reservations.Add(reservation);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, you might want to log it or show an error message
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }
        // la methode qui retourne un livre en se basant de son id
        public Reservation GetReserationByID(int id)
        {
            return _dbContext.Reservations.FirstOrDefault(r => r.IdReservation == id); // lambda expression, default = null, "a" parameter represents each reservation in the table
        }
        //  la methode qui fait l'update d'une reservation en se basant de son id
        public void UpdateReservation(Reservation updatedReservation)
        {
            if (updatedReservation == null)
                throw new ArgumentNullException(nameof(updatedReservation));

            var updatedRes = _dbContext.Adherents.Find(updatedReservation.IdReservation); //On cherche  l'id du element passé au parametre s'il existe dans la db
            if (updatedRes != null)
            {
                _dbContext.Reservations.Update(updatedReservation);
                _dbContext.SaveChanges();
            }
        }
        // pour afficher toutes les reservations
        public List<Reservation> GetReservations()
        {
            return _dbContext.Reservations.ToList(); // pour afficher toutes les reservations ss forme de liste

        }
        //pour supprimer une reservation en se basant de son id
        public void RemoveReservation(int id)
        {
            var ReservationToRemove = _dbContext.Reservations.Find(id);
            if (ReservationToRemove != null)
            {
                _dbContext.Reservations.Remove(ReservationToRemove);
                _dbContext.SaveChanges();
            }
        }


    }
}
