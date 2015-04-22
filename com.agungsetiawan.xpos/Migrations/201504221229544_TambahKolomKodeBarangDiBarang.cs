namespace com.agungsetiawan.xpos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TambahKolomKodeBarangDiBarang : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Barangs", "KodeBarang", c => c.String(maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Barangs", "KodeBarang");
        }
    }
}
