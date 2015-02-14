namespace com.agungsetiawan.xpos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TambahMemberUbahPelanggan : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NamaMember = c.String(unicode: false),
                        Diskon = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Pelanggans", "MemberId", c => c.Int(nullable: false));
            CreateIndex("dbo.Pelanggans", "MemberId");
            AddForeignKey("dbo.Pelanggans", "MemberId", "dbo.Members", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pelanggans", "MemberId", "dbo.Members");
            DropIndex("dbo.Pelanggans", new[] { "MemberId" });
            DropColumn("dbo.Pelanggans", "MemberId");
            DropTable("dbo.Members");
        }
    }
}
