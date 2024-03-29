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
    
    public partial class Urunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urunler()
        {
            this.AromaUrun = new HashSet<AromaUrun>();
            this.YorumTablo = new HashSet<YorumTablo>();
        }
    
        public int ID { get; set; }
        public string UrunAdi { get; set; }
        public Nullable<int> MarkaID { get; set; }
        public Nullable<int> CinsiyetID { get; set; }
        public Nullable<int> TurID { get; set; }
        public Nullable<int> BoyutID { get; set; }
        public Nullable<int> Indirim { get; set; }
        public string Resim { get; set; }
        public string Aciklama { get; set; }
        public Nullable<System.DateTime> EklenmeTarihi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AromaUrun> AromaUrun { get; set; }
        public virtual Boyut Boyut { get; set; }
        public virtual Cinsiyet Cinsiyet { get; set; }
        public virtual Marka Marka { get; set; }
        public virtual Tur Tur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YorumTablo> YorumTablo { get; set; }
    }
}
