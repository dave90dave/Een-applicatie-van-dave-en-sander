namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Medicaties", "KlantID", "dbo.Klantens");
            DropIndex("dbo.Medicaties", new[] { "KlantID" });
            CreateTable(
                "dbo.KlantenVerzekerings",
                c => new
                    {
                        VerzekeringID = c.Int(nullable: false, identity: true),
                        VerzekeringNaam = c.Int(nullable: false),
                        KlantID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VerzekeringID);
            
            AddColumn("dbo.Klantens", "KlantenVerzekering_VerzekeringID", c => c.Int());
            CreateIndex("dbo.Klantens", "KlantenVerzekering_VerzekeringID");
            AddForeignKey("dbo.Klantens", "KlantenVerzekering_VerzekeringID", "dbo.KlantenVerzekerings", "VerzekeringID");
            DropColumn("dbo.Medicaties", "KlantID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Medicaties", "KlantID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Klantens", "KlantenVerzekering_VerzekeringID", "dbo.KlantenVerzekerings");
            DropIndex("dbo.Klantens", new[] { "KlantenVerzekering_VerzekeringID" });
            DropColumn("dbo.Klantens", "KlantenVerzekering_VerzekeringID");
            DropTable("dbo.KlantenVerzekerings");
            CreateIndex("dbo.Medicaties", "KlantID");
            AddForeignKey("dbo.Medicaties", "KlantID", "dbo.Klantens", "KlantID", cascadeDelete: true);
        }
    }
}
