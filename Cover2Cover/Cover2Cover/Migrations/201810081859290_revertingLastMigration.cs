namespace Cover2Cover.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editingfavouriteBooksForiegnKeyName : DbMigration
    {
        public override void Up()
        {

            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.Customers", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.Books", "Customer_Id1", "dbo.Customers");
            DropForeignKey("dbo.Books", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Authors", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Customers", new[] { "Book_Id" });
            DropIndex("dbo.Books", new[] { "Customer_Id1" });
            DropIndex("dbo.Books", new[] { "Customer_Id" });
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropIndex("dbo.Authors", new[] { "Customer_Id" });
            AlterColumn("dbo.Books", "AuthorId", c => c.Int(nullable: false));
            AlterColumn("dbo.Books", "Category", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "Book_Id");
            DropColumn("dbo.Books", "Customer_Id1");
            DropColumn("dbo.Books", "Customer_Id");
            DropColumn("dbo.Authors", "Customer_Id");
            CreateIndex("dbo.Books", "AuthorId");
            AddForeignKey("dbo.Books", "AuthorId", "dbo.Authors", "AuthorId", cascadeDelete: true);

        }

        public override void Down()
        {
        }
    }
}
