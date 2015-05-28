namespace com.agungsetiawan.xpos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TambahKolomHargaBeli : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PenjualanDetails", "HargaBeli", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PenjualanDetails", "HargaBeli");
        }
    }
}
