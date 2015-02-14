namespace com.agungsetiawan.xpos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UbahNamaMemberJadiVarchar : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Members", "NamaMember", c => c.String(maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "NamaMember", c => c.String(unicode: false));
        }
    }
}
