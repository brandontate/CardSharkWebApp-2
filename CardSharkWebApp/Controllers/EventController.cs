using CardSharkWebApp.Models;
using CardSharkWebApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CardSharkWebApp.Controllers
{
    public class EventController : ApiController
    {
        private static CardSharkRepo repo = new CardSharkRepo();
        private CardSharkContext db = new CardSharkContext();

        // GET api/event
        [Route("api/event")]
        public List<Event> Get()
        {
            string companyName = "WWE";
            int companyID = repo.GetOrganizationID(companyName);
            return repo.GetEvents(companyID);
        }
    }
}
