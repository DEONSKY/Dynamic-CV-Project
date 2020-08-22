namespace MCY_CV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KnowLvl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TechKnows", "KnowLvl", c => c.Int(nullable: false));
            DropColumn("dbo.Abilities", "ImageURL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abilities", "ImageURL", c => c.String());
            DropColumn("dbo.TechKnows", "KnowLvl");
        }
    }
}
