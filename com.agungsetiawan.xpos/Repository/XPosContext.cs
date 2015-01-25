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
    }
}
