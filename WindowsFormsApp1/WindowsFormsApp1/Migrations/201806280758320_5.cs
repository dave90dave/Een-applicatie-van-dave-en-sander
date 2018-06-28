namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Klantens", "Klanten_KlantID", "dbo.Klantens");
            DropForeignKey("dbo.Klantens", "Arts_ArtsID", "dbo.Arts");
            DropIndex("dbo.Klantens", new[] { "Klanten_KlantID" });
            DropIndex("dbo.Klantens", new[] { "Arts_ArtsID" });
            CreateTable(
                "dbo.KlantenArts",
                c => new
                    {
                        Klanten_KlantID = c.Int(nullable: false),
                        Arts_ArtsID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Klanten_KlantID, t.Arts_ArtsID })
                .ForeignKey("dbo.Klantens", t => t.Klanten_KlantID, cascadeDelete: true)
                .ForeignKey("dbo.Arts", t => t.Arts_ArtsID, cascadeDelete: true)
                .Index(t => t.Klanten_KlantID)
                .Index(t => t.Arts_ArtsID);
            
            AddColumn("dbo.Klantens", "ArtsID", c => c.Int(nullable: false));
            DropColumn("dbo.Klantens", "Klanten_KlantID");
            DropColumn("dbo.Klantens", "Arts_ArtsID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Klantens", "Arts_ArtsID", c => c.Int());
            AddColumn("dbo.Klantens", "Klanten_KlantID", c => c.Int());
            DropForeignKey("dbo.KlantenArts", "Arts_ArtsID", "dbo.Arts");
            DropForeignKey("dbo.KlantenArts", "Klanten_KlantID", "dbo.Klantens");
            DropIndex("dbo.KlantenArts", new[] { "Arts_ArtsID" });
            DropIndex("dbo.KlantenArts", new[] { "Klanten_KlantID" });
            DropColumn("dbo.Klantens", "ArtsID");
            DropTable("dbo.KlantenArts");
            CreateIndex("dbo.Klantens", "Arts_ArtsID");
            CreateIndex("dbo.Klantens", "Klanten_KlantID");
            AddForeignKey("dbo.Klantens", "Arts_ArtsID", "dbo.Arts", "ArtsID");
            AddForeignKey("dbo.Klantens", "Klanten_KlantID", "dbo.Klantens", "KlantID");
        }
    }
}
