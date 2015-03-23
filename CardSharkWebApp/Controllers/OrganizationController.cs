using CardSharkWebApp.Models;
using CardSharkWebApp.Repository;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CardSharkWebApp.Controllers
{
    [RoutePrefix("api/organization")]
    [Authorize]
    public class OrganizationController : ApiController
    {
        private static CardSharkRepo repo = new CardSharkRepo();
        private CardSharkContext db = new CardSharkContext();

        // GET api/organization
        [HttpGet]
        [Route("list")]
        public List<Organization>GetOrganizations()
        {
            return repo.GetOrganizations();
        }

    }
}
