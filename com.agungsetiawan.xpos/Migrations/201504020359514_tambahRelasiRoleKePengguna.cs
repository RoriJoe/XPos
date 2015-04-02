namespace com.agungsetiawan.xpos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tambahRelasiRoleKePengguna : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Penggunas", "RoleId", c => c.Int(nullable: false));
            CreateIndex("dbo.Penggunas", "RoleId");
            AddForeignKey("dbo.Penggunas", "RoleId", "dbo.Roles", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Penggunas", "RoleId", "dbo.Roles");
            DropIndex("dbo.Penggunas", new[] { "RoleId" });
            DropColumn("dbo.Penggunas", "RoleId");
        }
    }
}
