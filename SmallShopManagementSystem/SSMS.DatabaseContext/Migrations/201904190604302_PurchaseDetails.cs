namespace SSMS.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PurchaseDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PurchaseDetails",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Qty = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        ProductId = c.Long(nullable: false),
                        Purchase_Id = c.Int(),
                        Sale_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Purchase_Id)
                .ForeignKey("dbo.Sales", t => t.Sale_Id)
                .Index(t => t.Purchase_Id)
                .Index(t => t.Sale_Id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PurchaseDetails", "Sale_Id", "dbo.Sales");
            DropForeignKey("dbo.PurchaseDetails", "Purchase_Id", "dbo.Products");
            DropIndex("dbo.PurchaseDetails", new[] { "Sale_Id" });
            DropIndex("dbo.PurchaseDetails", new[] { "Purchase_Id" });
            DropTable("dbo.Sales");
            DropTable("dbo.PurchaseDetails");
        }
    }
}
