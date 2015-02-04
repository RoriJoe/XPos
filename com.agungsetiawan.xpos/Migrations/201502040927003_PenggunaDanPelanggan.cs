namespace com.agungsetiawan.xpos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PenggunaDanPelanggan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pelanggans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NamaPelanggan = c.String(maxLength: 50, unicode: false),
                        Alamat = c.String(maxLength: 100, unicode: false),
                        NoTelepon = c.String(maxLength: 20, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Penggunas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 50, unicode: false),
                        Nama = c.String(maxLength: 50, unicode: false),
                        Password = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Penjualans", "PelangganId");
            CreateIndex("dbo.Penjualans", "PenggunaId");
            AddForeignKey("dbo.Penjualans", "PelangganId", "dbo.Pelanggans", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Penjualans", "PenggunaId", "dbo.Penggunas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Penjualans", "PenggunaId", "dbo.Penggunas");
            DropForeignKey("dbo.Penjualans", "PelangganId", "dbo.Pelanggans");
            DropIndex("dbo.Penjualans", new[] { "PenggunaId" });
            DropIndex("dbo.Penjualans", new[] { "PelangganId" });
            DropTable("dbo.Penggunas");
            DropTable("dbo.Pelanggans");
        }
    }
}
