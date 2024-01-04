using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Library.Models;
using System.Linq;
namespace Library.DAO
{
    internal class LivreDAO
    {
        // La déclaration de readonly sur un champ signifie que sa valeur ne peut être modifiée qu'à l'intérieur du constructeur de la classe
        private readonly LibraryDBContext _dbContext; //L'objet dbContext encapsule la connexion à la base de données + l'underscore c'est une convention de codage pour dire que c'est un champ de classe

        public LivreDAO(LibraryDBContext context)
        {
            _dbContext = context;
        }
        // la méthode pour ajouter un livre

        public void AddLivre(Livre livre)
        {
            _dbContext.Livres.Add(livre);
            _dbContext.SaveChanges(); // to save the changes. This method is necessary to persist the changes.
        }
        // la methode qui retourne un livre en se basant de son id
        public Livre GetLivreByID(int id)
        {
            return _dbContext.Livres.FirstOrDefault(l => l.IdLivre == id); // lambda expression, default = null, "a" parameter represents each livre in the table
        }
        //  la methode qui fait l'update d'un livre en se basant de son id
        public void UpdateLivre(Livre updatedLivre)
        {
            _dbContext.Livres.Update(updatedLivre);
            _dbContext.SaveChanges();
        }
        // pour afficher tous les adherents
        public List<Livre> GetLivres()
        {
            return _dbContext.Livres.ToList(); // pour afficher tous les livres ss forme de liste

        }
        //pour supprimer un livre en se basant de son id
        public void RemoveLivre(int id)
        {
            var LivreToRemove = _dbContext.Livres.Find(id);
            if (LivreToRemove != null)
            {
                _dbContext.Livres.Remove(LivreToRemove);
                _dbContext.SaveChanges();
            }
        }


    }
}
