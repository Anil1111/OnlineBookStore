namespace Cover2Cover.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editingModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "AuthorId" });
            AddColumn("dbo.Authors", "Customer_Id", c => c.Int());
            AddColumn("dbo.Books", "Customer_Id", c => c.Int());
            AddColumn("dbo.Books", "Customer_Id1", c => c.Int());
            AddColumn("dbo.Customers", "Book_Id", c => c.Int());
            AlterColumn("dbo.Books", "Category", c => c.Int());
            AlterColumn("dbo.Books", "AuthorId", c => c.Int());
            CreateIndex("dbo.Authors", "Customer_Id");
            CreateIndex("dbo.Books", "AuthorId");
            CreateIndex("dbo.Books", "Customer_Id");
            CreateIndex("dbo.Books", "Customer_Id1");
            CreateIndex("dbo.Customers", "Book_Id");
            AddForeignKey("dbo.Authors", "Customer_Id", "dbo.Customers", "Id");
            AddForeignKey("dbo.Books", "Customer_Id", "dbo.Customers", "Id");
            AddForeignKey("dbo.Books", "Customer_Id1", "dbo.Customers", "Id");
            AddForeignKey("dbo.Customers", "Book_Id", "dbo.Books", "Id");
            AddForeignKey("dbo.Books", "AuthorId", "dbo.Authors", "AuthorId");
        }
        
        public override void Down()
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
    }
}
