using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    internal class Reservation
    {
        // Clé primaire de la table Reservation
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdReservation { get; set; }

        // Identifiant du livre associé à la réservation (obligatoire avec un message d'erreur personnalisé si manquant)
        [Required(ErrorMessage = "Le champ LivreId est requis.")]
        [ForeignKey(("IdLivre"))]
        public int livreId { get; set; }

        // Identifiant de l'adhérent associé à la réservation (obligatoire avec un message d'erreur personnalisé si manquant)
        [Required(ErrorMessage = "Le champ AdherentId est requis.")]
        [ForeignKey(("IdAdherent"))]
        public int AdherentId { get; set; }

        // Identifiant de l'employe associé à la réservation (obligatoire avec un message d'erreur personnalisé si manquant)
        [Required(ErrorMessage = "Le champ AdherentId est requis.")]
        [ForeignKey(("IdEmploye"))]
        public int EmployeId { get; set; }


        // Date de réservation (obligatoire avec un message d'erreur personnalisé si manquant)
        [Required(ErrorMessage = "Le champ DateReservation est requis.")]
        public DateTime DateReservation { get; set; }

        // Date de retour prévue (obligatoire avec un message d'erreur personnalisé si manquant)
        [Required(ErrorMessage = "Le champ DateRetourPrevue est requis.")]
        public DateTime DateRetourPrevue { get; set; }

        // Indicateur de retour effectué (par défaut à false, car la réservation n'a pas encore été retournée)
        public bool RetourEffectue { get; set; } = false;

        // Relation avec la table Livre (une réservation appartient à un livre)
        //public Livre livre { get; set; }

        // Relation avec la table Adherent (une réservation appartient à un adhérent)
        //public Adherent adherent { get; set; }
    }
}
