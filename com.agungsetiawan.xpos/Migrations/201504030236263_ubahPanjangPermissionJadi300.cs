namespace com.agungsetiawan.xpos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ubahPanjangPermissionJadi300 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Roles", "Permissions", c => c.String(maxLength: 300, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Roles", "Permissions", c => c.String(maxLength: 50, unicode: false));
        }
    }
}
