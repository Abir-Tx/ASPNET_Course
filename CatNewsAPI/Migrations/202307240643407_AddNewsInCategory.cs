namespace CatNewsAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewsInCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.News", "Category_Id", c => c.Int());
            CreateIndex("dbo.News", "Category_Id");
            AddForeignKey("dbo.News", "Category_Id", "dbo.Categories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.News", "Category_Id", "dbo.Categories");
            DropIndex("dbo.News", new[] { "Category_Id" });
            DropColumn("dbo.News", "Category_Id");
        }
    }
}
