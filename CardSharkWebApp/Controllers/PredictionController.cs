using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Description;
using CardSharkWebApp.Models;
using CardSharkWebApp.Repository;

namespace CardSharkWebApp.Controllers
{
    [RoutePrefix("api/prediction")]
    [Authorize]
    public class PredictionController : ApiController
    {
        //private static CardSharkRepo repo = new CardSharkRepo();
        //private CardSharkContext db = new CardSharkContext();

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        this.db.Dispose();
        //    }

        //    base.Dispose(disposing);
        //}

        //// GET api/organization
        //[Route("api/organization")]
        //public List<Organization> Get()
        //{
        //    return repo.GetOrganizations();
        //}

        //private async Task<bool> StoreAsync(Organization organization)
        //{
        //    this.db.Organizations.Add(organization);

        //    await this.db.SaveChangesAsync();
        //    var selectedOption = await this.db.Organizations.FirstOrDefaultAsync(o => o.ID == organization.
        //        && o.QuestionId == organization.QuestionId);

        //    return selectedOption.IsCorrect;
        //}

        //private async Task<Organization> GetOrganizations(string userId)
        //{
        //    List<Organization> organizationList = new List<Organization>();
        //    var query = await this.db.Organizations
        //                .Select(o => db.Organizations)
        //                .OrderBy(o => o.Name)
        //                .Select(o)
        //                .FirstOrDefaultAsync();
        //    //foreach (var org in query)
        //    //{
        //    //    organizationList.Add(org);
        //    //}
        //    return await this.db.Organizations.FindAsync(CancellationToken.None, query);
        //}
    }
}
