//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommProtocolApp.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLSehir
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLSehir()
        {
            this.TBLProje = new HashSet<TBLProje>();
        }
    
        public int SehirId { get; set; }
        public string SehirAd { get; set; }
        public string SehirUlke { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLProje> TBLProje { get; set; }
    }
}