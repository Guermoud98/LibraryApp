using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    internal class Employe
    {
        // Clé primaire de la table Employe
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //auto increment
        public int IdEmploye { get; set; }

        // Nom de l'employé (obligatoire avec un message d'erreur personnalisé si manquant)
        [Required(ErrorMessage = "Le champ Nom est requis.")]
        public string Nom { get; set; }

        // Prénom de l'employé (obligatoire avec un message d'erreur personnalisé si manquant)
        [Required(ErrorMessage = "Le champ Prénom est requis.")]
        public string Prenom { get; set; }

        // Adresse e-mail de l'employé (obligatoire avec un message d'erreur personnalisé si manquant et validation du format de l'e-mail)
        [Required(ErrorMessage = "Le champ Adresse e-mail est requis.")]
        [EmailAddress(ErrorMessage = "Veuillez spécifier une adresse e-mail valide.")]
        public string AdresseEmail { get; set; }

        // Identifiant de l'employé (obligatoire avec un message d'erreur personnalisé si manquant)
        [Required(ErrorMessage = "Le champ Identifiant est requis.")]
        public string Identifiant { get; set; }

        // Mot de passe de l'employé (obligatoire avec un message d'erreur personnalisé si manquant)
        [Required(ErrorMessage = "Le champ Mot de passe est requis.")]
        public string MotDePasse { get; set; }

        // Relation avec la table Reservation (un employé peut avoir plusieurs réservations)
        //public ICollection<Reservation> Reservations { get; set; }

    }
}
