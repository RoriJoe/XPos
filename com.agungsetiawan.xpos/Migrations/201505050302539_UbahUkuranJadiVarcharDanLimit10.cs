namespace com.agungsetiawan.xpos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UbahUkuranJadiVarcharDanLimit10 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PenjualanDetails", "Ukuran", c => c.String(maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PenjualanDetails", "Ukuran", c => c.String(unicode: false));
        }
    }
}
