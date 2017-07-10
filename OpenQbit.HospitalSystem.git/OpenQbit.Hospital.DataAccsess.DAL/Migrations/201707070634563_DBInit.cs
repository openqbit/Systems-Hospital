namespace OpenQbit.Hospital.DataAccsess.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Drug",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        drugName = c.String(),
                        Description = c.String(),
                        Company = c.String(),
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
                "dbo.Doctor",
                c => new
                    {
                        DoctorID = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DoctorID)
                .ForeignKey("dbo.Employee", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Person", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        ContactNumber = c.String(),
                        DOB = c.DateTime(nullable: false),
                        GlobalId = c.String(),
                    })
                .PrimaryKey(t => t.PersonId);
            
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
                        Date = c.DateTime(nullable: false),
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
                        TotalAmount = c.Double(nullable: false),
                        ItemDiscount = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
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
                        OrderQty = c.Int(nullable: false),
                        ItemName = c.String(),
                        UnitPrice = c.Double(nullable: false),
                        ItemTotalPrice = c.Double(nullable: false),
                        Category_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Category", t => t.Category_ID)
                .Index(t => t.Category_ID);
            
            CreateTable(
                "dbo.Room",
                c => new
                    {
                        RoomID = c.String(nullable: false, maxLength: 128),
                        RoomType = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.RoomID);
            
            CreateTable(
                "dbo.RoomDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoomID = c.Int(nullable: false),
                        WardID = c.Int(nullable: false),
                        Room_RoomID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Room", t => t.Room_RoomID)
                .ForeignKey("dbo.Ward", t => t.WardID, cascadeDelete: true)
                .Index(t => t.WardID)
                .Index(t => t.Room_RoomID);
            
            CreateTable(
                "dbo.Ward",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Description = c.String(),
                        InchargeID = c.Int(nullable: false),
                        WardTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employee", t => t.InchargeID, cascadeDelete: true)
                .ForeignKey("dbo.WardType", t => t.WardTypeId, cascadeDelete: true)
                .Index(t => t.InchargeID)
                .Index(t => t.WardTypeId);
            
            CreateTable(
                "dbo.WardType",
                c => new
                    {
                        WardTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.WardTypeId);
            
            CreateTable(
                "dbo.Treatment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        WardAdmitionID = c.Int(nullable: false),
                        DoctorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Doctor", t => t.DoctorID, cascadeDelete: true)
                .ForeignKey("dbo.WardAdmition", t => t.WardAdmitionID, cascadeDelete: true)
                .Index(t => t.WardAdmitionID)
                .Index(t => t.DoctorID);
            
            CreateTable(
                "dbo.WardAdmition",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CheckIn = c.DateTime(nullable: false),
                        CheckOut = c.DateTime(nullable: false),
                        Description = c.String(),
                        RoomID = c.Int(nullable: false),
                        PatientID = c.Int(nullable: false),
                        Room_RoomID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Patient", t => t.PatientID, cascadeDelete: true)
                .ForeignKey("dbo.Room", t => t.Room_RoomID)
                .Index(t => t.PatientID)
                .Index(t => t.Room_RoomID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Treatment", "WardAdmitionID", "dbo.WardAdmition");
            DropForeignKey("dbo.WardAdmition", "Room_RoomID", "dbo.Room");
            DropForeignKey("dbo.WardAdmition", "PatientID", "dbo.Patient");
            DropForeignKey("dbo.Treatment", "DoctorID", "dbo.Doctor");
            DropForeignKey("dbo.RoomDetails", "WardID", "dbo.Ward");
            DropForeignKey("dbo.Ward", "WardTypeId", "dbo.WardType");
            DropForeignKey("dbo.Ward", "InchargeID", "dbo.Employee");
            DropForeignKey("dbo.RoomDetails", "Room_RoomID", "dbo.Room");
            DropForeignKey("dbo.PharmacyOrdersDetail", "Category_ID", "dbo.Category");
            DropForeignKey("dbo.PatientAdmition", "PatientId", "dbo.Patient");
            DropForeignKey("dbo.Payment", "PharmacyOrders_ID", "dbo.PharmacyOrders");
            DropForeignKey("dbo.PharmacyOrders", "PatientAdmitionId", "dbo.PatientAdmition");
            DropForeignKey("dbo.Doctor", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Employee", "PersonId", "dbo.Person");
            DropForeignKey("dbo.Drug", "MedicineId", "dbo.Medicine");
            DropForeignKey("dbo.Drug", "CategoryId", "dbo.Category");
            DropIndex("dbo.WardAdmition", new[] { "Room_RoomID" });
            DropIndex("dbo.WardAdmition", new[] { "PatientID" });
            DropIndex("dbo.Treatment", new[] { "DoctorID" });
            DropIndex("dbo.Treatment", new[] { "WardAdmitionID" });
            DropIndex("dbo.Ward", new[] { "WardTypeId" });
            DropIndex("dbo.Ward", new[] { "InchargeID" });
            DropIndex("dbo.RoomDetails", new[] { "Room_RoomID" });
            DropIndex("dbo.RoomDetails", new[] { "WardID" });
            DropIndex("dbo.PharmacyOrdersDetail", new[] { "Category_ID" });
            DropIndex("dbo.Payment", new[] { "PharmacyOrders_ID" });
            DropIndex("dbo.PharmacyOrders", new[] { "PatientAdmitionId" });
            DropIndex("dbo.PatientAdmition", new[] { "PatientId" });
            DropIndex("dbo.Employee", new[] { "PersonId" });
            DropIndex("dbo.Doctor", new[] { "EmployeeId" });
            DropIndex("dbo.Drug", new[] { "CategoryId" });
            DropIndex("dbo.Drug", new[] { "MedicineId" });
            DropTable("dbo.WardAdmition");
            DropTable("dbo.Treatment");
            DropTable("dbo.WardType");
            DropTable("dbo.Ward");
            DropTable("dbo.RoomDetails");
            DropTable("dbo.Room");
            DropTable("dbo.PharmacyOrdersDetail");
            DropTable("dbo.Payment");
            DropTable("dbo.PharmacyOrders");
            DropTable("dbo.PatientAdmition");
            DropTable("dbo.Patient");
            DropTable("dbo.Item");
            DropTable("dbo.Person");
            DropTable("dbo.Employee");
            DropTable("dbo.Doctor");
            DropTable("dbo.Medicine");
            DropTable("dbo.Drug");
            DropTable("dbo.Category");
        }
    }
}
