//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jams.DAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Application
    {
        public int ApplicationId { get; set; }
        public int CompanyId { get; set; }
        public string Motivation { get; set; }
        public System.DateTime DateSent { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
