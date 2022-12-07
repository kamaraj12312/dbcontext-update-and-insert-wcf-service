using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dbcontextupdate
{
    public class providerLocations
    {
        public int ProviderLocationID { get; set; }
        public int ProviderID { get; set; }
        public int FacilityID { get; set; }
        public System.DateTime EffectiveDate { get; set; }
        public Nullable<System.DateTime> TerminationDate { get; set; }
        public bool Deleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}