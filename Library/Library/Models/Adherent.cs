using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    internal class Adherent
    {
        //all properties are public to creat classes that represent entities or data models
        [Key] // c'est une annotation de la clé primaire
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //auto increment
        public int IdAdherent { get; set; }
        [Required(ErrorMessage = "Le champ nom est requis")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Le champ prenom est requis")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "Le champ adresse est requis")]
        [EmailAddress(ErrorMessage = "Veuillez saisir un email valide")] //cette anotation vérifie la validité de l'emails
        public string email { get; set; }
        [Required(ErrorMessage = "Le champ telephone est requis")]

        // Mot de passe de l'adherent 
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$", ErrorMessage = "Le mot de passe doit contenir au moins une lettre et un chiffre.")]
        [DataType(DataType.Password)] //hashage du password //doesnt work
        public string MotDePasse { get; set; }




        // Relation avec la table Reservation (un adhérent peut avoir plusieurs réservations)
        //Spublic ICollection<Reservation> Reservations { get; set; }


    }
}
