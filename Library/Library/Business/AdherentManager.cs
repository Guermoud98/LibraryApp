using Library.DAO;
using Library.Models;
using Library.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
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
        //verification de l'email s'il est valid ou pas
        public bool ValidEmail(string email)
        {
            //regex expression
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
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
            Adherent connectedAdherent = _adherentDAO.GetAdherentByEmailPassword(email, motDePasse);
            if (connectedAdherent != null)
            {
                // Store the connected adherent's ID in the session
                int idConnectAdherent = connectedAdherent.IdAdherent;
                ConnectedAdherent.SetCurrentAdherentId(idConnectAdherent);
            }

            return connectedAdherent;
        }
        
    }
}
