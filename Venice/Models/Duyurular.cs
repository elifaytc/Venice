//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Venice.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Duyurular
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Duyurular()
        {
            this.DuyuruDurum = new HashSet<DuyuruDurum>();
        }
    
        public int ID { get; set; }
        public string DuyuruBasligi { get; set; }
        public string Duyuru { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DuyuruDurum> DuyuruDurum { get; set; }
    }
}
