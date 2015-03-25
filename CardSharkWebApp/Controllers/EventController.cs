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
    [RoutePrefix("api/organization/{companyName}")]
    [Authorize]
    public class EventController : ApiController
    {
        private static CardSharkRepo repo = new CardSharkRepo();

        // GET api/event
        [HttpGet]
        [Route("event")]
        public List<Event> GetEvents(string companyName)
        {
            int companyID = repo.GetOrganizationID(companyName);
            return repo.GetEvents(companyID);
        }
    }
}
