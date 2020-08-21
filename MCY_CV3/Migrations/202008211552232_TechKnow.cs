namespace MCY_CV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TechKnow : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TechKnows",
                c => new
                    {
                        TechKnowID = c.Int(nullable: false, identity: true),
                        Description_EN = c.String(),
                    })
                .PrimaryKey(t => t.TechKnowID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TechKnows");
        }
    }
}
