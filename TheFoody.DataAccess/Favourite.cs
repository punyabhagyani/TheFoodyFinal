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
    
    public partial class Favourite
    {
        public int Favourite_id { get; set; }
        public int FavouriteRestId { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual Restaurant Restaurant { get; set; }
    }
}
