namespace com.agungsetiawan.xpos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ubahJadiVarcharDanLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Barangs", "NamaBarang", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Barangs", "Keterangan", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Kategoris", "NamaKategori", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Kategoris", "Keterangan", c => c.String(maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kategoris", "Keterangan", c => c.String(unicode: false));
            AlterColumn("dbo.Kategoris", "NamaKategori", c => c.String(maxLength: 1000, unicode: false));
            AlterColumn("dbo.Barangs", "Keterangan", c => c.String(unicode: false));
            AlterColumn("dbo.Barangs", "NamaBarang", c => c.String(unicode: false));
        }
    }
}
