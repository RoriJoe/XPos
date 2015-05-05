namespace com.agungsetiawan.xpos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TambahUkuranDiPenjualanDetail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PenjualanDetails", "Ukuran", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PenjualanDetails", "Ukuran");
        }
    }
}
