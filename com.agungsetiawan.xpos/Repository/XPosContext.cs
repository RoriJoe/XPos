using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.agungsetiawan.xpos.Model;

namespace com.agungsetiawan.xpos.Repository
{
    public class XPosContext:DbContext
    {
        public XPosContext() : base("XPosConnection")
        {

        }

        public DbSet<Barang> Barangs { get; set; }
    }
}
