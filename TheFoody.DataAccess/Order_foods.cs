//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheFoody.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_foods
    {
        public int Order_food_id { get; set; }
        public Nullable<int> Order_id { get; set; }
        public Nullable<int> Menu_id { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual Menu Menu { get; set; }
        public virtual Order Order { get; set; }
    }
}