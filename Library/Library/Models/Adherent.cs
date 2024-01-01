using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    internal class Adherent
    {  
        [Key] // c'est une annotation de la clé primaire
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //auto increment
        public int id { get; }
        [Required(ErrorMessage = "Le champ nom est requis")]
        public string nom { get; set; }
        [Required(ErrorMessage = "Le champ prenom est requis")]
        public string prenom { get; set; }
        [Required(ErrorMessage = "Le champ adresse est requis")]
        [EmailAddress(ErrorMessage = "Veuillez saisir un email valide")] //cette anotation vérifie la validité de l'emails
        public string adresse { get; set; }
        [Required(ErrorMessage = "Le champ telephone est requis")]
        public string numTelephone { set; get; }


    }
}
