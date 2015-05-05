namespace com.agungsetiawan.xpos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BuatTabelStokHargaUkurans : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StokHargaUkurans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ukuran = c.String(unicode: false),
                        HargaJual = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HargaBeli = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Stock = c.Int(nullable: false),
                        BarangId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Barangs", t => t.BarangId, cascadeDelete: true)
                .Index(t => t.BarangId);
            
            DropColumn("dbo.Barangs", "HargaJual");
            DropColumn("dbo.Barangs", "HargaBeli");
            DropColumn("dbo.Barangs", "Stok");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Barangs", "Stok", c => c.Int(nullable: false));
            AddColumn("dbo.Barangs", "HargaBeli", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Barangs", "HargaJual", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropForeignKey("dbo.StokHargaUkurans", "BarangId", "dbo.Barangs");
            DropIndex("dbo.StokHargaUkurans", new[] { "BarangId" });
            DropTable("dbo.StokHargaUkurans");
        }
    }
}
