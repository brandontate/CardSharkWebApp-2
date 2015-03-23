namespace CardSharkWebApp.Migrations
{
    using CardSharkWebApp.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CardSharkContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CardSharkContext context)
        {
            {

                //  This method will be called after migrating to the latest version.
                //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
                //  to avoid creating duplicate seed data. E.g.
                //
                //    context.People.AddOrUpdate(
                //      p => p.FullName,
                //      new Person { FullName = "Andrew Peters" },
                //      new Person { FullName = "Brice Lambson" },
                //      new Person { FullName = "Rowan Miller" }
                //    );
                //

                context.Organizations.Add(new Organization
                {
                    ID = 1,
                    Name = "WWE",
                    Events = new List<Event>
                {
                    new Event
                    {
                        ID = 1,
                        Name = "Royal Rumble",
                        Date = new DateTime(2015, 01, 25, 19, 0, 0),
                        Matches = new List<Match> 
                        {
                            new Match
                            {
                                FirstOpponent = "The Bella Twins",
                                SecondOpponent = "Paige",
                                Winner = "The Bella Twins"
                            }
                        }
                    },

                    new Event
                    {
                        ID = 2,
                        Name = "Fastlane",
                        Date = new DateTime(2015, 02, 22, 19, 0, 0),
                        Matches = new List<Match>
                        {
                            new Match
                            {
                                FirstOpponent = "Daniel Bryan",
                                SecondOpponent = "Roman Reigns",
                                Winner = "Daniel Bryan"
                            }
                        }
                    },

                    new Event
                    {
                        ID = 3,
                        Name = "TLC",
                        Date = new DateTime(2014, 12, 14, 19, 0, 0),
                        Matches = new List<Match>
                        {
                            new Match
                            {
                                FirstOpponent = "The New Day",
                                SecondOpponent = "Goldust & Stardust",
                                Winner = "The New Day"
                            },

                            new Match
                            {
                                FirstOpponent = "Dolph Ziggler",
                                SecondOpponent = "Luke Harper",
                                Winner = "Dolph Ziggler"
                            },

                            new Match
                            {
                                FirstOpponent = "The Usos",
                                SecondOpponent = "The Miz & Damien Mizdow",
                                Winner = "The Usos"
                            },

                            new Match
                            {
                                FirstOpponent = "Big Show",
                                SecondOpponent = "Erick Rowan",
                                Winner = "Big Show"
                            },

                            new Match
                            {
                                FirstOpponent = "John Cena",
                                SecondOpponent = "Seth Rollins",
                                Winner = "John Cena"
                            },

                            new Match
                            {
                                FirstOpponent = "Nikki Bella",
                                SecondOpponent = "AJ Lee",
                                Winner = "Nikki Bella"
                            },

                            new Match
                            {
                                FirstOpponent = "Ryback",
                                SecondOpponent = "Kane",
                                Winner = "Ryback"
                            },

                            new Match
                            {
                                FirstOpponent = "Rusev",
                                SecondOpponent = "Jack Swagger",
                                Winner = "Rusev"
                            },

                            new Match
                            {
                                FirstOpponent = "Bray Wyatt",
                                SecondOpponent = "Dean Ambrose",
                                Winner = "Bray Wyatt"
                            }
                        }
                    }
                }
                });

                context.Organizations.Add(new Organization
                {
                    ID = 2,
                    Name = "UFC",
                    Events = new List<Event>
                {
                    new Event
                    {
                        ID = 1,
                        Name = "UFC 183",
                        Date = new DateTime(2015,01,31,19,0,0),
                        Matches = new List<Match>
                        {
                            new Match { FirstOpponent = "Anderson 'The Spider' Silva", SecondOpponent = "Nick Diaz", Winner = "Anderson 'The Spider' Silva"}
                        }
                    },

                    new Event
                    {
                        ID = 2,
                        Name = "UFC 184",
                        Date = new DateTime(2015,02,28,19,0,0),
                        Matches = new List<Match>
                        {
                            new Match { FirstOpponent = "Masio Fullen", SecondOpponent = "Alexander Torres" },
                            new Match { FirstOpponent = "James Krause", SecondOpponent = "Valmir Lazaro" },
                            new Match { FirstOpponent = "Derrick Lewis", SecondOpponent = "Ruan Potts" },
                            new Match { FirstOpponent = "Dhiego Lima", SecondOpponent = "Tim Means" },
                            new Match { FirstOpponent = "Roman Salazar", SecondOpponent = "Norifumi Yamamoto" },
                            new Match { FirstOpponent = "Mark Mu�oz", SecondOpponent = "Roan Carneiro" },
                            new Match { FirstOpponent = "Tony Ferguson", SecondOpponent = "Gleison Tibau" },
                            new Match { FirstOpponent = "Alan Jouban", SecondOpponent = "Richard Walsh" },
                            new Match { FirstOpponent = "Jake Ellenberger", SecondOpponent = "Josh Koscheck" },
                            new Match { FirstOpponent = "Raquel Pennington", SecondOpponent = "Holly Holm" },
                            new Match { FirstOpponent = "Rhonda Rousey", SecondOpponent = "Catt Zigano" }   
                        }
                    },

                    new Event
                    {
                        ID = 3,
                        Name = "UFC Test",
                        Date = new DateTime(2015,01,31,19,0,0),
                        Matches = new List<Match>
                        {
                        }
                    }
                }
                });
            }
        }
    }
}
