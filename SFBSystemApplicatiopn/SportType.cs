//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SFBSystemApplicatiopn
{
    using System;
    using System.Collections.Generic;
    
    public partial class SportType
    {
        public SportType()
        {
            this.SportFacilities = new HashSet<SportFacility>();
        }
    
        public int SportTypeID { get; set; }
        public string SportTypeName { get; set; }
    
        public virtual ICollection<SportFacility> SportFacilities { get; set; }
    }
}
