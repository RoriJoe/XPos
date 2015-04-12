namespace com.agungsetiawan.xpos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TambahNomorKtpDiPelanggan : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pelanggans", "NomorKtp", c => c.String(maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pelanggans", "NomorKtp");
        }
    }
}
