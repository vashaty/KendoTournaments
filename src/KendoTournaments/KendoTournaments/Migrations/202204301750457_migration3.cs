namespace KendoTournaments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Players", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.Matchups", "Tournament_Id", "dbo.Tournaments");
            DropForeignKey("dbo.Players", "Tournament_Id", "dbo.Tournaments");
            DropIndex("dbo.Players", new[] { "Group_Id" });
            DropIndex("dbo.Players", new[] { "Tournament_Id" });
            DropIndex("dbo.Matchups", new[] { "Tournament_Id" });
            CreateTable(
                "dbo.PlayerGroups",
                c => new
                    {
                        Player_Id = c.Int(nullable: false),
                        Group_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Player_Id, t.Group_Id })
                .ForeignKey("dbo.Players", t => t.Player_Id, cascadeDelete: true)
                .ForeignKey("dbo.Groups", t => t.Group_Id, cascadeDelete: true)
                .Index(t => t.Player_Id)
                .Index(t => t.Group_Id);
            
            CreateTable(
                "dbo.TournamentPlayers",
                c => new
                    {
                        Tournament_Id = c.Int(nullable: false),
                        Player_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tournament_Id, t.Player_Id })
                .ForeignKey("dbo.Tournaments", t => t.Tournament_Id, cascadeDelete: true)
                .ForeignKey("dbo.Players", t => t.Player_Id, cascadeDelete: true)
                .Index(t => t.Tournament_Id)
                .Index(t => t.Player_Id);
            
            AddColumn("dbo.MatchupPlayers", "MatchUp_Id", c => c.Int());
            CreateIndex("dbo.MatchupPlayers", "MatchUp_Id");
            AddForeignKey("dbo.MatchupPlayers", "MatchUp_Id", "dbo.Matchups", "Id");
            DropColumn("dbo.Players", "Group_Id");
            DropColumn("dbo.Players", "Tournament_Id");
            DropColumn("dbo.Matchups", "Tournament_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Matchups", "Tournament_Id", c => c.Int());
            AddColumn("dbo.Players", "Tournament_Id", c => c.Int());
            AddColumn("dbo.Players", "Group_Id", c => c.Int());
            DropForeignKey("dbo.MatchupPlayers", "MatchUp_Id", "dbo.Matchups");
            DropForeignKey("dbo.TournamentPlayers", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.TournamentPlayers", "Tournament_Id", "dbo.Tournaments");
            DropForeignKey("dbo.PlayerGroups", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.PlayerGroups", "Player_Id", "dbo.Players");
            DropIndex("dbo.TournamentPlayers", new[] { "Player_Id" });
            DropIndex("dbo.TournamentPlayers", new[] { "Tournament_Id" });
            DropIndex("dbo.PlayerGroups", new[] { "Group_Id" });
            DropIndex("dbo.PlayerGroups", new[] { "Player_Id" });
            DropIndex("dbo.MatchupPlayers", new[] { "MatchUp_Id" });
            DropColumn("dbo.MatchupPlayers", "MatchUp_Id");
            DropTable("dbo.TournamentPlayers");
            DropTable("dbo.PlayerGroups");
            CreateIndex("dbo.Matchups", "Tournament_Id");
            CreateIndex("dbo.Players", "Tournament_Id");
            CreateIndex("dbo.Players", "Group_Id");
            AddForeignKey("dbo.Players", "Tournament_Id", "dbo.Tournaments", "Id");
            AddForeignKey("dbo.Matchups", "Tournament_Id", "dbo.Tournaments", "Id");
            AddForeignKey("dbo.Players", "Group_Id", "dbo.Groups", "Id");
        }
    }
}
