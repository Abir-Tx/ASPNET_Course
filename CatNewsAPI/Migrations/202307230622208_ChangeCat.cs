namespace CatNewsAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCat : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Cats", newName: "News");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.News", newName: "Cats");
        }
    }
}
