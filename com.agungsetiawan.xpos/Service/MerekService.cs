using com.agungsetiawan.xpos.Model;
using com.agungsetiawan.xpos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Service
{
    public class MerekService
    {
        private MerekRepository merekRepository;

        public MerekService()
        {
            merekRepository = new MerekRepository();
        }

        public List<Merek> Get()
        {
            return merekRepository.Get();
        }

        public Merek Get(int id)
        {
            return merekRepository.Get(id);
        }

        public void Delete(Merek merek)
        {
            merekRepository.Delete(merek);
        }

        public void Post(Merek merek)
        {
            merekRepository.Post(merek);
        }

        public void Put(Merek merek)
        {
            merekRepository.Put(merek);
        }
    }
}
