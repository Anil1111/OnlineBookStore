namespace Cover2Cover.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingFavBookListToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "FavouriteBooks_Id", c => c.Int());

        }

        public override void Down()
        {
        }
    }
}
