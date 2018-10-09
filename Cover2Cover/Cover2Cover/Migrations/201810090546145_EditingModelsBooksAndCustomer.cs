namespace Cover2Cover.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditingModelsBooksAndCustomer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Authors", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Books", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Books", "Customer_Id1", "dbo.Customers");
            DropForeignKey("dbo.Customers", "Book_Id", "dbo.Books");
            DropIndex("dbo.Authors", new[] { "Customer_Id" });
            DropIndex("dbo.Books", new[] { "Customer_Id" });
            DropIndex("dbo.Books", new[] { "Customer_Id1" });
            DropIndex("dbo.Customers", new[] { "Book_Id" });
            DropColumn("dbo.Authors", "Customer_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Book_Id", c => c.Int());
            AddColumn("dbo.Books", "Customer_Id1", c => c.Int());
            AddColumn("dbo.Books", "Customer_Id", c => c.Int());
            AddColumn("dbo.Authors", "Customer_Id", c => c.Int());
            CreateIndex("dbo.Customers", "Book_Id");
            CreateIndex("dbo.Books", "Customer_Id1");
            CreateIndex("dbo.Books", "Customer_Id");
            CreateIndex("dbo.Authors", "Customer_Id");
            AddForeignKey("dbo.Customers", "Book_Id", "dbo.Books", "Id");
            AddForeignKey("dbo.Books", "Customer_Id1", "dbo.Customers", "Id");
            AddForeignKey("dbo.Books", "Customer_Id", "dbo.Customers", "Id");
            AddForeignKey("dbo.Authors", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
