//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TilausXIITommiAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Asiakkaat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Asiakkaat()
        {
            this.Tilaukset = new HashSet<Tilaukset>();
        }
    
        public int AsiakasID { get; set; }
        public string Nimi { get; set; }
        public string Osoite { get; set; }
        public string Postinumero { get; set; }
    
        public virtual Postitoimipaikat Postitoimipaikat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tilaukset> Tilaukset { get; set; }
    }
}
