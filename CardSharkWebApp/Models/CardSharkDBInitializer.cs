using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CardSharkWebApp.Models
{
    public class CardSharkDBInitializer : DropCreateDatabaseAlways<CardSharkContext>
    {
        protected override void Seed(CardSharkContext context)
        {
            var organizations = new List<Organization>();

            organizations.Add(new Organization
            {
                ID = 1,
                Name = "WWE"
            });

            organizations.Add(new Organization
            {
                ID = 2,
                Name = "UFC"
            });

            organizations.ForEach(o => context.Organizations.Add(o));

            context.SaveChanges();
        }
    }
}