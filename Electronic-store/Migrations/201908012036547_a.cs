namespace Electronic_store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Phone_Number");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Phone_Number", c => c.Int(nullable: true));
        }
    }
}
