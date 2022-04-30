namespace KendoTournaments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        Tournament_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tournaments", t => t.Tournament_Id)
                .Index(t => t.Tournament_Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Lastname = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Age = c.Int(nullable: false),
                        Sex = c.Boolean(nullable: false),
                        Grade = c.Int(nullable: false),
                        Group_Id = c.Int(),
                        Tournament_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.Group_Id)
                .ForeignKey("dbo.Tournaments", t => t.Tournament_Id)
                .Index(t => t.Group_Id)
                .Index(t => t.Tournament_Id);
            
            CreateTable(
                "dbo.Tournaments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DateStart = c.DateTime(nullable: false),
                        DateEnd = c.DateTime(nullable: false),
                        AgeLimit = c.Int(nullable: false),
                        SexLimit = c.Boolean(nullable: false),
                        GradeLimit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Matchups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Datetime = c.DateTime(nullable: false),
                        MatchupRound = c.Int(nullable: false),
                        Overtime = c.Boolean(nullable: false),
                        Group_Id = c.Int(),
                        Winner_Id = c.Int(),
                        Tournament_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.Group_Id)
                .ForeignKey("dbo.Players", t => t.Winner_Id)
                .ForeignKey("dbo.Tournaments", t => t.Tournament_Id)
                .Index(t => t.Group_Id)
                .Index(t => t.Winner_Id)
                .Index(t => t.Tournament_Id);
            
            CreateTable(
                "dbo.MatchupPlayers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentMatchUp_Id = c.Int(),
                        Player_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Matchups", t => t.ParentMatchUp_Id)
                .ForeignKey("dbo.Players", t => t.Player_Id)
                .Index(t => t.ParentMatchUp_Id)
                .Index(t => t.Player_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Groups", "Tournament_Id", "dbo.Tournaments");
            DropForeignKey("dbo.Players", "Tournament_Id", "dbo.Tournaments");
            DropForeignKey("dbo.Matchups", "Tournament_Id", "dbo.Tournaments");
            DropForeignKey("dbo.Matchups", "Winner_Id", "dbo.Players");
            DropForeignKey("dbo.MatchupPlayers", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.MatchupPlayers", "ParentMatchUp_Id", "dbo.Matchups");
            DropForeignKey("dbo.Matchups", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.Players", "Group_Id", "dbo.Groups");
            DropIndex("dbo.MatchupPlayers", new[] { "Player_Id" });
            DropIndex("dbo.MatchupPlayers", new[] { "ParentMatchUp_Id" });
            DropIndex("dbo.Matchups", new[] { "Tournament_Id" });
            DropIndex("dbo.Matchups", new[] { "Winner_Id" });
            DropIndex("dbo.Matchups", new[] { "Group_Id" });
            DropIndex("dbo.Players", new[] { "Tournament_Id" });
            DropIndex("dbo.Players", new[] { "Group_Id" });
            DropIndex("dbo.Groups", new[] { "Tournament_Id" });
            DropTable("dbo.MatchupPlayers");
            DropTable("dbo.Matchups");
            DropTable("dbo.Tournaments");
            DropTable("dbo.Players");
            DropTable("dbo.Groups");
        }
    }
}
