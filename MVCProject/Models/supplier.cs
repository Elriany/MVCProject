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
    
    public partial class supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public supplier()
        {
            this.products = new HashSet<product>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string passwrd { get; set; }
        public Nullable<int> phone { get; set; }
        public string addres { get; set; }
        public string website { get; set; }
        public Nullable<int> adminId { get; set; }
        public Nullable<bool> status { get; set; }
    
        public virtual Adminstrator Adminstrator { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<product> products { get; set; }
    }
}
