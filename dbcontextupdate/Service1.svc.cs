using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace dbcontextupdate
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public IList<providerLocation> GetProviderLocations()
        {

            var location = (from a in endocDataContext.GetProviderLocations.Where(x => x.Deleted !=true & x.ProviderID <2)
                            select a



                           ).ToList();
            this.addlocation(location[0]);
            return location;

            //EndocDataContext obj = new EndocDataContext(ConnectionString);
            //var location = (from s in obj.GetProviderLocations
            //                select s).ToList();
            //return location;
        }
        public void addlocation(ProviderLocation locatos)
        {
            var mylocation = (from a in endocDataContext.GetProviderLocations.Where(x => x.ProviderID == locatos.ProviderID & x.Deleted !=true) select a).OrderByDescending(x => x.ProviderID).FirstOrDefault();
            mylocation.Deleted =true;
            mylocation.ModifiedDate = DateTime.Now;
            mylocation.ModifiedBy ="userss";

            endocDataContext.Entry(mylocation).State =System.Data.Entity.EntityState.Modified;
            endocDataContext.SaveChanges();
        }
    }
}
    

