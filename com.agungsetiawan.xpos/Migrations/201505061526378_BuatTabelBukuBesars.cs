namespace com.agungsetiawan.xpos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BuatTabelBukuBesars : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BukuBesars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tanggal = c.DateTime(nullable: false, precision: 0),
                        Keterangan = c.String(maxLength: 50, unicode: false),
                        Debet = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Kredit = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BukuBesars");
        }
    }
}
