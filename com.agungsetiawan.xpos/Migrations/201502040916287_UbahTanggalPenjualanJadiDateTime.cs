namespace com.agungsetiawan.xpos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UbahTanggalPenjualanJadiDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Penjualans", "Tanggal", c => c.DateTime(nullable: false, precision: 0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Penjualans", "Tanggal", c => c.DateTime(nullable: false, storeType: "date"));
        }
    }
}
