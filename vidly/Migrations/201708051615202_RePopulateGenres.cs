namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RePopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Animated')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Fantasy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Sci-Fi')");
        }
        
        public override void Down()
        {
        }
    }
}
