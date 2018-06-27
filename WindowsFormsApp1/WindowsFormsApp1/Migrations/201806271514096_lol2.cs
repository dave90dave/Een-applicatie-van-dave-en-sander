namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lol2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Klantens", "Klanten_KlantID", c => c.Int());
            CreateIndex("dbo.Klantens", "Klanten_KlantID");
            AddForeignKey("dbo.Klantens", "Klanten_KlantID", "dbo.Klantens", "KlantID");
            DropColumn("dbo.Klantens", "VerzekeringsID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Klantens", "VerzekeringsID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Klantens", "Klanten_KlantID", "dbo.Klantens");
            DropIndex("dbo.Klantens", new[] { "Klanten_KlantID" });
            DropColumn("dbo.Klantens", "Klanten_KlantID");
        }
    }
}
