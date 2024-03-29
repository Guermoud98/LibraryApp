﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DAO;
using Library.Models;

namespace Library.Business
{
    internal class LivreManager
    {
        private readonly LivreDAO _livreDAO;
        public LivreManager(LivreDAO livreDAO)
        {
            _livreDAO = livreDAO;
        }
        public void AddLivre(Livre livre)
        {
            _livreDAO.AddLivre(livre);
        }
        public Livre GetLivreByID(int id)
        {
           return  _livreDAO.GetLivreByID(id);
        }
        public void UpdateLivre(Livre livre)
        {
            _livreDAO.UpdateLivre(livre);
        }
        public List<Livre> GetAllLivre()
        {
            return _livreDAO.GetLivres();
        }
        public void RemoveLivre(int id)
        {
            _livreDAO.RemoveLivre(id);
        }
    }
}
