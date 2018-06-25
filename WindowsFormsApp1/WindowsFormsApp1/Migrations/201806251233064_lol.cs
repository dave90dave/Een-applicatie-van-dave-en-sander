namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lol : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Klantens", "Arts_ArtsID", c => c.Int());
            AddColumn("dbo.Klantens", "Verzekering_VerzekeringNaam", c => c.String(maxLength: 128));
            CreateIndex("dbo.Klantens", "Arts_ArtsID");
            CreateIndex("dbo.Klantens", "Verzekering_VerzekeringNaam");
            AddForeignKey("dbo.Klantens", "Arts_ArtsID", "dbo.Arts", "ArtsID");
            AddForeignKey("dbo.Klantens", "Verzekering_VerzekeringNaam", "dbo.Verzekerings", "VerzekeringNaam");
            DropColumn("dbo.Arts", "Postcode");
            DropColumn("dbo.Klantens", "ArtsID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Klantens", "ArtsID", c => c.Int(nullable: false));
            AddColumn("dbo.Arts", "Postcode", c => c.String());
            DropForeignKey("dbo.Klantens", "Verzekering_VerzekeringNaam", "dbo.Verzekerings");
            DropForeignKey("dbo.Klantens", "Arts_ArtsID", "dbo.Arts");
            DropIndex("dbo.Klantens", new[] { "Verzekering_VerzekeringNaam" });
            DropIndex("dbo.Klantens", new[] { "Arts_ArtsID" });
            DropColumn("dbo.Klantens", "Verzekering_VerzekeringNaam");
            DropColumn("dbo.Klantens", "Arts_ArtsID");
        }
    }
}
