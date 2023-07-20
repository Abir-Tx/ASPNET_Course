namespace CatNewsAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIdType : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Cats");
            AlterColumn("dbo.Cats", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Cats", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Cats");
            AlterColumn("dbo.Cats", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Cats", "Id");
        }
    }
}
