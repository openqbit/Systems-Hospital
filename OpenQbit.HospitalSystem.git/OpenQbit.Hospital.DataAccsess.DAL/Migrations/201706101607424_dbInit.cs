namespace OpenQbit.Hospital.DataAccsess.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        categoryName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Drug",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        drugName = c.String(),
                        description = c.String(),
                        company = c.String(),
                        madeDate = c.DateTime(nullable: false),
                        expireDate = c.DateTime(nullable: false),
                        MedicineId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Medicine", t => t.MedicineId, cascadeDelete: true)
                .Index(t => t.MedicineId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Medicine",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GenricName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        ItemType = c.Int(nullable: false),
                        RefID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Patient",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PatientName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PatientAdmition",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Patient", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.PharmacyOrders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Time = c.DateTime(nullable: false),
                        date = c.DateTime(nullable: false),
                        PatientAdmitionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PatientAdmition", t => t.PatientAdmitionId, cascadeDelete: true)
                .Index(t => t.PatientAdmitionId);
            
            CreateTable(
                "dbo.Payment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        totalAmount = c.Double(nullable: false),
                        ItemDiscount = c.Double(nullable: false),
                        date = c.DateTime(nullable: false),
                        PharmacyOrders_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PharmacyOrders", t => t.PharmacyOrders_ID)
                .Index(t => t.PharmacyOrders_ID);
            
            CreateTable(
                "dbo.PharmacyOrdersDetail",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        orderQty = c.Int(nullable: false),
                        ItemName = c.String(),
                        unitPrice = c.Double(nullable: false),
                        itemTotalPrice = c.Double(nullable: false),
                        Category_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Category", t => t.Category_ID)
                .Index(t => t.Category_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PharmacyOrdersDetail", "Category_ID", "dbo.Category");
            DropForeignKey("dbo.PatientAdmition", "PatientId", "dbo.Patient");
            DropForeignKey("dbo.Payment", "PharmacyOrders_ID", "dbo.PharmacyOrders");
            DropForeignKey("dbo.PharmacyOrders", "PatientAdmitionId", "dbo.PatientAdmition");
            DropForeignKey("dbo.Drug", "MedicineId", "dbo.Medicine");
            DropForeignKey("dbo.Drug", "CategoryId", "dbo.Category");
            DropIndex("dbo.PharmacyOrdersDetail", new[] { "Category_ID" });
            DropIndex("dbo.Payment", new[] { "PharmacyOrders_ID" });
            DropIndex("dbo.PharmacyOrders", new[] { "PatientAdmitionId" });
            DropIndex("dbo.PatientAdmition", new[] { "PatientId" });
            DropIndex("dbo.Drug", new[] { "CategoryId" });
            DropIndex("dbo.Drug", new[] { "MedicineId" });
            DropTable("dbo.PharmacyOrdersDetail");
            DropTable("dbo.Payment");
            DropTable("dbo.PharmacyOrders");
            DropTable("dbo.PatientAdmition");
            DropTable("dbo.Patient");
            DropTable("dbo.Item");
            DropTable("dbo.Medicine");
            DropTable("dbo.Drug");
            DropTable("dbo.Category");
        }
    }
}
