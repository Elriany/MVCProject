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
    
    public partial class orderProduct
    {
        public int id { get; set; }
        public Nullable<int> prodId { get; set; }
        public Nullable<int> orderId { get; set; }
        public Nullable<int> quantity { get; set; }
    
        public virtual orderTbl orderTbl { get; set; }
        public virtual product product { get; set; }
    }
}