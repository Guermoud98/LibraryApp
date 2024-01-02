using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Library.DAO
{
    internal class AdherentDAO
	{
        // La déclaration de readonly sur un champ signifie que sa valeur ne peut être modifiée qu'à l'intérieur du constructeur de la classe
        private readonly LibraryDBContext _dbContext; //L'objet dbContext encapsule la connexion à la base de données + l'underscore c'est une convention de codage pour dire que c'est un champ de classe

        public AdherentDAO(LibraryDBContext context)
		{
			_context = context;
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
			return _dbContext.Adherents.FirstOrDefault(a => a.AdherentID == id); // lambda expression, default = null, "a" parameter represents each adherent in the table
		}
		//  la methode qui fait l'update d'un adherent en se basant de son id
		public void UpdateAdherent(Adherent updateeAdherent)
		{
			_dbContext.Adherents.Update(updateeAdherent);
			_dbContext.SaveChanges();
		}
		// pour afficher tous les adherents
		public List<Adherent> GetAdherents ()
		{
			return _dbContext.Adherents.ToList; // pour afficher tous les adherents ss forme de liste

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
