using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CardSharkWebApp.Models
{
    public class CardSharkContext : DbContext
    {
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Prediction> Predictions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ModelConfigurations.OrganizationConfiguration());
            modelBuilder.Configurations.Add(new ModelConfigurations.EventConfiguration());
            modelBuilder.Configurations.Add(new ModelConfigurations.MatchConfiguration());
            modelBuilder.Configurations.Add(new ModelConfigurations.PredictionConfiguration());
        }

    }
}