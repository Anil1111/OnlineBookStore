namespace Cover2Cover.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reeditingModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "AuthorId" });
            AddColumn("dbo.Authors", "Customer_Id", c => c.Int());
            AddColumn("dbo.Books", "PurchasedByCustomer_Id", c => c.Int());
            AddColumn("dbo.Customers", "PurchasedBooks_Id", c => c.Int());

        }

        public override void Down()
        {
        }
    }
}
