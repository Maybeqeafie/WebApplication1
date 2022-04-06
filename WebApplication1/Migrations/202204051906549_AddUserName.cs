namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Users", "ConfirmPassword", c => c.String(nullable: false));
            AddColumn("dbo.Users", "Age", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            DropColumn("dbo.Users", "Age");
            DropColumn("dbo.Users", "ConfirmPassword");
            DropColumn("dbo.Users", "Name");
        }
    }
}
