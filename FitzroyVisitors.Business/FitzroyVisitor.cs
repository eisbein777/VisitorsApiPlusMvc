using FitzroyVisitors.DTO;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitzroyVisitors.DAL;

namespace FitzroyVisitors.Business
{
   public class FitzroyBusService : IFitzroyBusSvc
    {
       
        private List<ADUsers> GetadUsers()
        {
            var Userlist = new List<ADUsers>();

            using (var context = new PrincipalContext(ContextType.Domain, "FITZROY", "OU=FITZROY,DC=private,DC=fitzroy,DC=co,DC=nz"))
            {
                using (var searcher = new PrincipalSearcher(new UserPrincipal(context)))
                {
                    foreach (var result in searcher.FindAll())
                    {


                        var user = new ADUsers();


                        DirectoryEntry de = result.GetUnderlyingObject() as DirectoryEntry;
                        user.FirstName = de.Properties["givenName"].Value.ToString();
                        user.LastName = de.Properties["sn"]?.Value?.ToString() ?? "";
                        user.Email = de.Properties["userPrincipalName"].Value.ToString();

                        Userlist.Add(user);

                        //de.Properties["samAccountName"].Value
                        //de.Properties["userPrincipalName"].Value
                        //Console.WriteLine();
                    }
                }
            }

            return Userlist;
        }

        public List<ADUsers> GetDirectoryUsers() {
            return GetadUsers();
        }

        public void SaveNewVisistor(DTO.Visitor visitor)
        {
            using (var entities = new FitzroyVisitorsEntities())
            {

                var vis = new DAL.Visitor();
                {
                    vis.FirstName = visitor.FirstName;
                    vis.LastName = visitor.LastName;
                    vis.Company = visitor.Company;
                    vis.PersonVisiting = visitor.PersonVisting;
                    vis.TagID = visitor.Company;
                    vis.TimeIn = DateTime.Now;  // Timstamp In
                    vis.Signature = visitor.Signature;
                };
                entities.Visitors.Add(vis);
                entities.SaveChanges();

            }
            return;
        }

        public List<DTO.Visitor> GetVisitors()
        {
            List<DTO.Visitor> displayvisitors = new List<DTO.Visitor>();

            using (var entities = new FitzroyVisitorsEntities())
            {
                var visitors = entities.Visitors.ToList();

                foreach (var v in visitors)
                {
                    var vis = new DTO.Visitor();
                    {
                        vis.FirstName = v.FirstName;
                        vis.LastName = v.LastName;
                        vis.Company = v.Company;
                        vis.PersonVisting = v.PersonVisiting;
                        vis.TagID = v.Company;
                        vis.TimeIn = v.TimeIn;  // Timstamp In
                        vis.TimeOut = v.TimeOut;
                        vis.Signature = v.Signature;
                    };
                    displayvisitors.Add(vis);
                  
                }


            


            }
            return displayvisitors;
        }


        public List<DTO.Visitor> GetVisitorsForSignout()
        {
            List<DTO.Visitor> signoutvisitors = new List<DTO.Visitor>();

            using (var entities = new FitzroyVisitorsEntities())
            {
                var visitors = entities.Visitors.ToList();

                foreach (var v in visitors)
                {
                    var vis = new DTO.Visitor();
                    {
                        vis.FirstName = v.FirstName;
                        vis.LastName = v.LastName;
                        vis.Company = v.Company;
                        vis.PersonVisting = v.PersonVisiting;
                        vis.TagID = v.Company;
                        vis.TimeIn = v.TimeIn;  // Timstamp In
                        vis.TimeOut = v.TimeOut;
                        vis.Signature = v.Signature;
                    };
                    signoutvisitors.Add(vis);

                }





            }
            return signoutvisitors;
        }

    }
}
