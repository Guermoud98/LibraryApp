using Library.DAO;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library.Business
{
    internal class AdherentManager
    {
        private readonly AdherentDAO _adherentDAO;
        public AdherentManager(AdherentDAO adherent)
        {
            _adherentDAO = adherent;
        }
        public void AddAdherent(Adherent adherent)
        {
            _adherentDAO.AddAdherent(adherent);
        }
        public void GetAdherentByID(int id)
        {
            _adherentDAO.GetAdherentByID(id);
        }
        public void UpdateAdherent(Adherent adherent)
        {
            _adherentDAO.UpdateAdherent(adherent);
        }
        public List<Adherent> GetAllAdherents()
        {
            return _adherentDAO.GetAdherents();
        }
        public void RemoveAdherent(int id)
        {
            _adherentDAO.RemoveAdherent(id);
        }
        // Se connecter 
        
        public Adherent Connecter(string email, string motDePasse)
        {
            return _adherentDAO.GetAdherentByEmailPassword(email, motDePasse);
        }
        
    }
}
