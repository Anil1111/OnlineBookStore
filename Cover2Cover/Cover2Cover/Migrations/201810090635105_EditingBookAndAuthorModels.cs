namespace Cover2Cover.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditingBookAndAuthorModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Info", c => c.String());
            DropColumn("dbo.Books", "ReleaseDate");
            DropColumn("dbo.Authors", "BIO");
            AddColumn("dbo.Authors", "Bio", c => c.String());

        }

        public override void Down()
        {
            AddColumn("dbo.Books", "ReleaseDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Books", "Info");
        }
    }
}
