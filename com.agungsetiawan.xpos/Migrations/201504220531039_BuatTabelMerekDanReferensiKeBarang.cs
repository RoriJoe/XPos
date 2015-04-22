namespace com.agungsetiawan.xpos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BuatTabelMerekDanReferensiKeBarang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mereks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NamaMerek = c.String(maxLength: 50, unicode: false),
                        Keterangan = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Barangs", "MerekId", c => c.Int(nullable: false));
            CreateIndex("dbo.Barangs", "MerekId");
            AddForeignKey("dbo.Barangs", "MerekId", "dbo.Mereks", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Barangs", "MerekId", "dbo.Mereks");
            DropIndex("dbo.Barangs", new[] { "MerekId" });
            DropColumn("dbo.Barangs", "MerekId");
            DropTable("dbo.Mereks");
        }
    }
}
