namespace MCY_CV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HobbyTitle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hobbies", "Title_EN", c => c.String());
            DropColumn("dbo.Hobbies", "Symbol");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hobbies", "Symbol", c => c.String());
            DropColumn("dbo.Hobbies", "Title_EN");
        }
    }
}
