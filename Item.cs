//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Corp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            this.DemandItems = new HashSet<DemandItem>();
            this.SupplyItems = new HashSet<SupplyItem>();
        }
    
        public int Code { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public int MeasureID { get; set; }
        public Nullable<int> WarhouseID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DemandItem> DemandItems { get; set; }
        public virtual Warhouse Warhouse { get; set; }
        public virtual MeasureUnite MeasureUnite { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplyItem> SupplyItems { get; set; }
    }
}
