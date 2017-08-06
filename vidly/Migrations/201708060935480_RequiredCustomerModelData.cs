namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredCustomerModelData : DbMigration
    {
        public override void Up()
        {
            // Has to be American format MM/DD/YYYY
            Sql("UPDATE Customers SET BirthDate = CAST('05/31/1992 00:00:00' AS DATETIME) WHERE BirthDate IS NULL");
            AlterColumn("dbo.Customers", "BirthDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "BirthDate", c => c.DateTime());
        }
    }
}
