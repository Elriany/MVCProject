//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class orderTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public orderTbl()
        {
            this.orderProducts = new HashSet<orderProduct>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> orderDate { get; set; }
        public Nullable<System.DateTime> derliveryDate { get; set; }
        public string destination { get; set; }
        public Nullable<int> userId { get; set; }
        public Nullable<bool> status { get; set; }
        public Nullable<int> adminId { get; set; }
    
        public virtual Adminstrator Adminstrator { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orderProduct> orderProducts { get; set; }
        public virtual userTbl userTbl { get; set; }
    }
}
