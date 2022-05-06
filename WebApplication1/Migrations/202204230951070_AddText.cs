namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddText : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parties", "Text", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parties", "Text");
        }
    }
}
