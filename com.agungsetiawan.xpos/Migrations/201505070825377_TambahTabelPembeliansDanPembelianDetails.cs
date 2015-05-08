namespace com.agungsetiawan.xpos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TambahTabelPembeliansDanPembelianDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pembelians",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KodeTransaksi = c.String(maxLength: 50, unicode: false),
                        Tanggal = c.DateTime(nullable: false, precision: 0),
                        TotalHargaBeli = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SupplierId = c.Int(nullable: false),
                        PenggunaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Penggunas", t => t.PenggunaId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.PenggunaId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.PembelianDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PembelianId = c.Int(nullable: false),
                        BarangId = c.Int(nullable: false),
                        Ukuran = c.String(maxLength: 10, unicode: false),
                        Harga = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Jumlah = c.Int(nullable: false),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Diskon = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Barangs", t => t.BarangId, cascadeDelete: true)
                .ForeignKey("dbo.Pembelians", t => t.PembelianId, cascadeDelete: true)
                .Index(t => t.BarangId)
                .Index(t => t.PembelianId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pembelians", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Pembelians", "PenggunaId", "dbo.Penggunas");
            DropForeignKey("dbo.PembelianDetails", "PembelianId", "dbo.Pembelians");
            DropForeignKey("dbo.PembelianDetails", "BarangId", "dbo.Barangs");
            DropIndex("dbo.Pembelians", new[] { "SupplierId" });
            DropIndex("dbo.Pembelians", new[] { "PenggunaId" });
            DropIndex("dbo.PembelianDetails", new[] { "PembelianId" });
            DropIndex("dbo.PembelianDetails", new[] { "BarangId" });
            DropTable("dbo.PembelianDetails");
            DropTable("dbo.Pembelians");
        }
    }
}
