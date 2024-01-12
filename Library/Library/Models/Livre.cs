using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Library.Models
{
    internal class Livre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLivre { get; set; }
        [Required(ErrorMessage = " Le titre est requis")]
        public string Titre { get; set; }
        [Required(ErrorMessage = "le champ auteur est requis")] // equivalent a NOT NULL
        public string Auteur { get; set;}
       
        [Required(ErrorMessage = "Le champ categorie est requis")]
        public string Categorie { get; set; }

        [Required(ErrorMessage = "Le champ Disponible est requis.")]
        public string Disponible { get; set; }

        public byte[] Image { get; set; }

        public string Description { get; set; }
      

        // Relation avec la table Reservation (un livre peut avoir plusieurs réservations)
        //public ICollection<Reservation> Reservations { get; set; }
    }
}
