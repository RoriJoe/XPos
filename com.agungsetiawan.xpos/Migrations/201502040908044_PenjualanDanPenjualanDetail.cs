namespace com.agungsetiawan.xpos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PenjualanDanPenjualanDetail : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PenjualanDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PenjualanId = c.Int(nullable: false),
                        BarangId = c.Int(nullable: false),
                        Harga = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Jumlah = c.Int(nullable: false),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Diskon = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Barangs", t => t.BarangId, cascadeDelete: true)
                .ForeignKey("dbo.Penjualans", t => t.PenjualanId, cascadeDelete: true)
                .Index(t => t.BarangId)
                .Index(t => t.PenjualanId);
            
            CreateTable(
                "dbo.Penjualans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KodeTransaksi = c.String(maxLength: 50, unicode: false),
                        Tanggal = c.DateTime(nullable: false, storeType: "date"),
                        TotalHargaJual = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PelangganId = c.Int(nullable: false),
                        PenggunaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PenjualanDetails", "PenjualanId", "dbo.Penjualans");
            DropForeignKey("dbo.PenjualanDetails", "BarangId", "dbo.Barangs");
            DropIndex("dbo.PenjualanDetails", new[] { "PenjualanId" });
            DropIndex("dbo.PenjualanDetails", new[] { "BarangId" });
            DropTable("dbo.Penjualans");
            DropTable("dbo.PenjualanDetails");
        }
    }
}
