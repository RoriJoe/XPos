namespace com.agungsetiawan.xpos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ubahVarcharDiSupplier : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Suppliers", "NamaSupplier", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Suppliers", "Alamat", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Suppliers", "NoTelepon", c => c.String(maxLength: 20, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Suppliers", "NoTelepon", c => c.String(unicode: false));
            AlterColumn("dbo.Suppliers", "Alamat", c => c.String(unicode: false));
            AlterColumn("dbo.Suppliers", "NamaSupplier", c => c.String(unicode: false));
        }
    }
}
