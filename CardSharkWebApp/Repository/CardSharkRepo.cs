using CardSharkWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Description;
using CardSharkWebApp.Repository;
using System.Web.Http;

namespace CardSharkWebApp.Repository
{
    public class CardSharkRepo : ApiController
    {
        protected CardSharkContext db = new CardSharkContext();


        public List<Organization> GetOrganizations()
        {
            var organizationList = new List<Organization>();
            var query = from o in db.Organizations
                        orderby o.Name
                        select o;

            foreach (var organization in query)
            {
                organizationList.Add(organization);
            }
            return organizationList;
        }



        public int GetOrganizationID(string company)
        {
            foreach (var organization in db.Organizations)
            {
                if (company == organization.Name)
                {
                    return organization.ID;
                }
            }
            throw new ArgumentException();
        }

        public List<Event> GetEvents(int companyID)
        {
            var eventList = new List<Event>();
            var query = (from e in db.Events
                         orderby e.Date
                         where companyID == e.OrganizationID
                         select e).ToList();
            foreach (var eventItem in query)
            {
                //var year = eventItem.Date.Year;
                //var month = eventItem.Date.Month;
                //var day = eventItem.Date.Day;
                //string eventDate = String.Format("{1}/{2}/{3}", month, day, year);

                Event eve = new Event
                {
                    ID = eventItem.ID,
                    Name = eventItem.Name,
                    Date = eventItem.Date
                };

                eventList.Add(eve);
            }
            
            return eventList;
        }

        //public int GetEventID(string checkEvent)
        //{
        //    var query = from e in db.Events
        //                where checkEvent == e.Name
        //                select e;

        //    foreach (var eventItem in query)
        //    {
        //        if (eventItem.Name == )
        //        {
                    
        //        }
        //        //var year = eventItem.Date.Year;
        //        //var month = eventItem.Date.Month;
        //        //var day = eventItem.Date.Day;
        //        //string eventName = String.Format("{0} ({1}/{2}/{3})", eventItem.Name, month, day, year);

        //    }
        //    throw new ArgumentException();
        //}

    }
}