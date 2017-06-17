namespace OpenQbit.Hospital.DataAccsess.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbInit : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Drug", "madeDate");
            DropColumn("dbo.Drug", "expireDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Drug", "expireDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Drug", "madeDate", c => c.DateTime(nullable: false));
        }
    }
}
