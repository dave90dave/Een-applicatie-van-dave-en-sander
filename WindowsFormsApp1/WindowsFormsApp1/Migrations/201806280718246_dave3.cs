namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dave3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KlantenMedicaties",
                c => new
                    {
                        MedicatieID = c.Int(nullable: false, identity: true),
                        KlantID = c.Int(nullable: false),
                        Medicatie_MedicatieID = c.Int(),
                    })
                .PrimaryKey(t => t.MedicatieID)
                .ForeignKey("dbo.Klantens", t => t.KlantID, cascadeDelete: true)
                .ForeignKey("dbo.Medicaties", t => t.Medicatie_MedicatieID)
                .Index(t => t.KlantID)
                .Index(t => t.Medicatie_MedicatieID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KlantenMedicaties", "Medicatie_MedicatieID", "dbo.Medicaties");
            DropForeignKey("dbo.KlantenMedicaties", "KlantID", "dbo.Klantens");
            DropIndex("dbo.KlantenMedicaties", new[] { "Medicatie_MedicatieID" });
            DropIndex("dbo.KlantenMedicaties", new[] { "KlantID" });
            DropTable("dbo.KlantenMedicaties");
        }
    }
}
