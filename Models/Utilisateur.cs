//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookingBus.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Utilisateur
    {
        public int id_utilisateur { get; set; }
        [Display(Name ="Nom Complet")]
        public string nom_complet { get; set; }
        [Display(Name = "E-mail")]
        [Required]
        public string mail { get; set; }
        [Display(Name = "Mot de passe")]
        [Required(ErrorMessage = "Mot de passe est obligatoire")]
        [StringLength(255, ErrorMessage = "Doit contenir minimun 5 caractères", MinimumLength = 5)]
        public string mdp { get; set; }
        public string telephone { get; set; }
        public string role { get; set; }
        public string image { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual Client Client { get; set; }
        public virtual Societe Societe { get; set; }
    }
}
