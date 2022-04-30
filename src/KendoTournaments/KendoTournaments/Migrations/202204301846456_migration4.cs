namespace KendoTournaments.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Players", "Sex", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Players", "Sex", c => c.Boolean(nullable: false));
        }
    }
}
