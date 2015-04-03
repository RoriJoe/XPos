using com.agungsetiawan.xpos.Model;
using com.agungsetiawan.xpos.ModelView;
using com.agungsetiawan.xpos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Service
{
    public class PenggunaService
    {
        private PenggunaRepository penggunaRepository;

        public PenggunaService()
        {
            penggunaRepository = new PenggunaRepository();
        }

        public List<PenggunaView> FindWithRole()
        {
            var penggunas = penggunaRepository.FindWithRole();
            var result = (from p in penggunas
                          select new PenggunaView
                          {
                              Id=p.Id,
                              Nama=p.Nama,
                              Username=p.Username,
                              Role=p.Role.NamaRole
                          }).ToList();

            return result;
        }

        public Pengguna Get(int id)
        {
            return penggunaRepository.Get(id);
        }

        public void Post(Pengguna pengguna)
        {
            penggunaRepository.Post(pengguna);
        }

        public void Put(Pengguna pengguna)
        {
            penggunaRepository.Put(pengguna);
        }
    }
}
