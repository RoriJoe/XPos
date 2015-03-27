namespace com.agungsetiawan.xpos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createSupplierUpdateBarang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NamaSupplier = c.String(unicode: false),
                        Alamat = c.String(unicode: false),
                        NoTelepon = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Barangs", "SupplierId", c => c.Int(nullable: false));
            CreateIndex("dbo.Barangs", "SupplierId");
            AddForeignKey("dbo.Barangs", "SupplierId", "dbo.Suppliers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Barangs", "SupplierId", "dbo.Suppliers");
            DropIndex("dbo.Barangs", new[] { "SupplierId" });
            DropColumn("dbo.Barangs", "SupplierId");
            DropTable("dbo.Suppliers");
        }
    }
}
