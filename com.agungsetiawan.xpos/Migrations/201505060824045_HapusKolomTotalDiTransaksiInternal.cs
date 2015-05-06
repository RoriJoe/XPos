namespace com.agungsetiawan.xpos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HapusKolomTotalDiTransaksiInternal : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TransaksiInternals", "Total");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TransaksiInternals", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
