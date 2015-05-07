using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.agungsetiawan.xpos.Model;
using MySql.Data.Entity;

namespace com.agungsetiawan.xpos.Repository
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class XPosContext:DbContext
    {
        public XPosContext() : base("XPosConnection")
        {

        }

        public DbSet<Barang> Barangs { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Penjualan> Penjualans { get; set; }
        public DbSet<PenjualanDetail> PenjualanDetails { get; set; }

        public DbSet<Pengguna> Penggunas { get; set; }
        public DbSet<Pelanggan> Pelanggans { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Merek> Mereks { get; set; }
        public DbSet<StokHargaUkuran> StockHargaUkurans { get; set; }
        public DbSet<TransaksiInternal> TransaksiInternals { get; set; }
        public DbSet<BukuBesar> BukuBesars { get; set; }
    }
}
