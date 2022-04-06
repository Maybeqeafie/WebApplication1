namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInsertData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers(Name) VALUES " +
                "('CD project RED, Inc'), " +
                "('Starbucks Ltd'), " +
                "('Samsung Corp'), " +
                "('Xiaomi Corp'), " +
                "('Ubisoft, Inc'), " +
                "('PSG OAO')," +
                "('Maestro Std')," +
                "('JBL Inc')");

            Sql("INSERT INTO Companies(Name, CustomerId) VALUES " +
                "('Some company name for CD project RED', 1)," +
                "('CD project RED company name', 1)," +
                "('1 games', 1)," +
                "('Beleberda', 2)," +
                "('LOL', 2)," +
                "('Hello World!', 2)," +
                "('bili jin', 3)," +
                "('Source', 4)," +
                "('Valve', 4)," +
                "('VS BAD', 4)," +
                "('Minecraft', 4)," +
                "('TouchMe', 5)," +
                "('Multfilm', 6)," +
                "('Animation', 6)," +
                "('qwerty', 6)," +
                "('headphones', 7)");
        }

        public override void Down()
        {
            Sql("DELETE FROM Customers");
            Sql("DELETE FROM Companies");
        }
    }
}
