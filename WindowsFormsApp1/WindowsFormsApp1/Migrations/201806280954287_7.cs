namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Klantens", "KlantenVerzekering_VerzekeringID", "dbo.KlantenVerzekerings");
            DropIndex("dbo.Klantens", new[] { "KlantenVerzekering_VerzekeringID" });
            DropColumn("dbo.Klantens", "KlantenVerzekering_VerzekeringID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Klantens", "KlantenVerzekering_VerzekeringID", c => c.Int());
            CreateIndex("dbo.Klantens", "KlantenVerzekering_VerzekeringID");
            AddForeignKey("dbo.Klantens", "KlantenVerzekering_VerzekeringID", "dbo.KlantenVerzekerings", "VerzekeringID");
        }
    }
}
