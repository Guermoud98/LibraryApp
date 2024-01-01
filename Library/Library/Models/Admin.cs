﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    internal class Admin
    {
        // Clé primaire de la table Admin
        [Key]
        public int Id { get; set; }

        // Nom de l'administrateur (obligatoire avec un message d'erreur personnalisé si manquant)
        [Required(ErrorMessage = "Le champ Nom est requis.")]
        public string Nom { get; set; }

        // Prénom de l'administrateur (obligatoire avec un message d'erreur personnalisé si manquant)
        [Required(ErrorMessage = "Le champ Prénom est requis.")]
        public string Prenom { get; set; }

        // Adresse e-mail de l'administrateur (obligatoire avec un message d'erreur personnalisé si manquant et validation du format de l'e-mail)
        [Required(ErrorMessage = "Le champ Adresse e-mail est requis.")]
        [EmailAddress(ErrorMessage = "Veuillez spécifier une adresse e-mail valide.")]
        public string AdresseEmail { get; set; }

        // Identifiant de l'administrateur (obligatoire avec un message d'erreur personnalisé si manquant)
        [Required(ErrorMessage = "Le champ Identifiant est requis.")]
        public string Identifiant { get; set; }

        // Mot de passe de l'administrateur (obligatoire avec un message d'erreur personnalisé si manquant)
        [Required(ErrorMessage = "Le champ Mot de passe est requis.")]
        public string MotDePasse { get; set; }

    }
}
