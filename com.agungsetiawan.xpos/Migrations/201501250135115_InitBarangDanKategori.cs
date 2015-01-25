namespace com.agungsetiawan.xpos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitBarangDanKategori : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Barangs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NamaBarang = c.String(unicode: false),
                        HargaJual = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HargaBeli = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Stok = c.Int(nullable: false),
                        Keterangan = c.String(unicode: false),
                        KategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategoris", t => t.KategoriId, cascadeDelete: true)
                .Index(t => t.KategoriId);
            
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NamaKategori = c.String(unicode: false),
                        Keterangan = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Barangs", "KategoriId", "dbo.Kategoris");
            DropIndex("dbo.Barangs", new[] { "KategoriId" });
            DropTable("dbo.Kategoris");
            DropTable("dbo.Barangs");
        }
    }
}
