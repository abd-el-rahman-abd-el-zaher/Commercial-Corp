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
    
    public partial class Supply
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supply()
        {
            this.SupplyItems = new HashSet<SupplyItem>();
        }
    
        public int ID { get; set; }
        public System.DateTime SupplyDate { get; set; }
        public int SupplierID { get; set; }
        public int WarhouseID { get; set; }
    
        public virtual Supplier Supplier { get; set; }
        public virtual Warhouse Warhouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplyItem> SupplyItems { get; set; }
    }
}
