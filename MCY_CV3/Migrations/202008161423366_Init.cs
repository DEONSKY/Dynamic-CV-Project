namespace MCY_CV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abilities",
                c => new
                    {
                        AbilityID = c.Int(nullable: false, identity: true),
                        Description_EN = c.String(),
                        Symbol = c.String(),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.AbilityID);
            
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AboutMe = c.String(),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        FirstKey = c.String(nullable: false),
                        SecondKey = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ComChannels",
                c => new
                    {
                        ComChannelID = c.Int(nullable: false, identity: true),
                        Title_EN = c.String(),
                        Link = c.String(),
                        Symbol = c.String(),
                    })
                .PrimaryKey(t => t.ComChannelID);
            
            CreateTable(
                "dbo.Hobbies",
                c => new
                    {
                        HobbyID = c.Int(nullable: false, identity: true),
                        Description_EN = c.String(),
                        Symbol = c.String(),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.HobbyID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectID = c.Int(nullable: false, identity: true),
                        Link = c.String(),
                        Title_EN = c.String(),
                        Description_EN = c.String(),
                        ImageURL = c.String(),
                    })
                .PrimaryKey(t => t.ProjectID);
            
            CreateTable(
                "dbo.WorkExps",
                c => new
                    {
                        WorkExpID = c.Int(nullable: false, identity: true),
                        Company = c.String(),
                        Position = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.WorkExpID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WorkExps");
            DropTable("dbo.Projects");
            DropTable("dbo.Hobbies");
            DropTable("dbo.ComChannels");
            DropTable("dbo.Admins");
            DropTable("dbo.Abouts");
            DropTable("dbo.Abilities");
        }
    }
}
