namespace CardSharkWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialize : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Date = c.DateTime(nullable: false),
                        OrganizationID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Organizations", t => t.OrganizationID, cascadeDelete: true)
                .Index(t => t.OrganizationID);
            
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstOpponent = c.String(nullable: false),
                        SecondOpponent = c.String(nullable: false),
                        Winner = c.String(),
                        EventID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Events", t => t.EventID, cascadeDelete: true)
                .Index(t => t.EventID);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Predictions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserID = c.String(nullable: false),
                        Guess = c.String(),
                        MatchID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Matches", t => t.MatchID, cascadeDelete: true)
                .Index(t => t.MatchID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Predictions", "MatchID", "dbo.Matches");
            DropForeignKey("dbo.Events", "OrganizationID", "dbo.Organizations");
            DropForeignKey("dbo.Matches", "EventID", "dbo.Events");
            DropIndex("dbo.Predictions", new[] { "MatchID" });
            DropIndex("dbo.Matches", new[] { "EventID" });
            DropIndex("dbo.Events", new[] { "OrganizationID" });
            DropTable("dbo.Predictions");
            DropTable("dbo.Organizations");
            DropTable("dbo.Matches");
            DropTable("dbo.Events");
        }
    }
}
