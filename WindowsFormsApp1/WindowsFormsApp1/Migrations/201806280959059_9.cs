namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Klantens", "KlantenVerzekering_VerzekeringID", c => c.Int());
            CreateIndex("dbo.Klantens", "KlantenVerzekering_VerzekeringID");
            AddForeignKey("dbo.Klantens", "KlantenVerzekering_VerzekeringID", "dbo.KlantenVerzekerings", "VerzekeringID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Klantens", "KlantenVerzekering_VerzekeringID", "dbo.KlantenVerzekerings");
            DropIndex("dbo.Klantens", new[] { "KlantenVerzekering_VerzekeringID" });
            DropColumn("dbo.Klantens", "KlantenVerzekering_VerzekeringID");
        }
    }
}
