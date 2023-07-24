namespace CatNewsAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.News", "Cat_Id", "dbo.Cats");
            DropIndex("dbo.News", new[] { "Cat_Id" });
            DropTable("dbo.News");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        Cat_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.News", "Cat_Id");
            AddForeignKey("dbo.News", "Cat_Id", "dbo.Cats", "Id");
        }
    }
}
