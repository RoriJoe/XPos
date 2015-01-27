using com.agungsetiawan.xpos.Model;
using com.agungsetiawan.xpos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Service
{
    public class KategoriService
    {
        KategoriRepository kategoriRepository;

        public KategoriService()
        {
            kategoriRepository = new KategoriRepository();
        }
        public List<Kategori> Get()
        {
            return kategoriRepository.Get();
        }

        public Kategori Get(int id)
        {
            return kategoriRepository.Get(id);
        }
    }
}
