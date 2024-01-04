using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Library.Models;
using System.Linq;

namespace Library.DAO
{
    internal class AdherentDAO
	{
        // La déclaration de readonly sur un champ signifie que sa valeur ne peut être modifiée qu'à l'intérieur du constructeur de la classe
        private readonly LibraryDBContext _dbContext; //L'objet dbContext encapsule la connexion à la base de données + l'underscore c'est une convention de codage pour dire que c'est un champ de classe
		
		// Constructeur qui reçoit le contexte de base de données pour avoir une référence 
        // Ce design pattern est appele dependency injection
        public AdherentDAO(LibraryDBContext context)
		{
			_dbContext = context;
		}
		// la méthode pour ajouter un adherent

		public void AddAdherent(Adherent adherent)
		{
			_dbContext.Adherents.Add(adherent);
			_dbContext.SaveChanges(); // to save the changes. This method is necessary to persist the changes.
        }
		// la methode qui retourne un adherent en se basant de son id
		public Adherent GetAdherentByID(int id)
		{
			// FirstOrDefault c'est une methode de la classe Linq
			Adherent a  = _dbContext.Adherents.FirstOrDefault(a => a.IdAdherent == id); // lambda expression, default = null, "a" parameter represents each adherent in the table
            if (a != null) // si l'id existe
			{
				return a;
			}

			return null; 
		}
		//  la methode qui fait l'update d'un adherent en se basant de son id
		public void UpdateAdherent(Adherent updatedAdherent)
		{
            if (updatedAdherent == null)
                throw new ArgumentNullException(nameof(updatedAdherent));

            var updatedAd = _dbContext.Adherents.Find(updatedAdherent.IdAdherent); //On cherche  l'id du element passé au parametre s'il existe dans la db
			if (updatedAd != null)
			{
				_dbContext.Adherents.Update(updatedAdherent);
				_dbContext.SaveChanges();
			}   
		}
		// pour afficher tous les adherents
		public List<Adherent> GetAdherents ()
		{
			return _dbContext.Adherents.ToList(); // pour afficher tous les adherents ss forme de liste

		}
		//pour supprimer un adherent en se basant de son id
		public void RemoveAdherent(int id)
		{
			var AdherentToRemove = _dbContext.Adherents.Find(id);
			if (AdherentToRemove != null)
			{
				_dbContext.Adherents.Remove(AdherentToRemove);
				_dbContext.SaveChanges();
			}
		}


	}
}
