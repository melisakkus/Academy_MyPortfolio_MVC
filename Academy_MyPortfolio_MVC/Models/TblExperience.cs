//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Academy_MyPortfolio_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblExperience
    {
        public int ExperienceId { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Description { get; set; }
    }
}