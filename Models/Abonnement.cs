//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookingBus.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Abonnement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Abonnement()
        {
            this.Effectuers = new HashSet<Effectuer>();
        }
    
        public int id_abonnement { get; set; }
        public string nom_abonnement { get; set; }
        public System.DateTime date_debut { get; set; }
        public System.DateTime date_fin { get; set; }
        public int id_navette { get; set; }
        public int id_societe { get; set; }
        public float prix { get; set; }
        public string image { get; set; }
    
        public virtual Navette Navette { get; set; }
        public virtual Societe Societe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Effectuer> Effectuers { get; set; }
    }
}
