namespace Electronic_store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Appliance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appliances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Catagory = c.String(nullable: false),
                        Price = c.Int(nullable: false),
                        Brand = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Appliances");
        }
    }
}
