//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FINALL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ArriveNote
    {
        public string ArID { get; set; }
        public System.DateTime ArDate { get; set; }
        public string ProductID { get; set; }
        public double ArPrice { get; set; }
        public int Quantity { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
