using com.agungsetiawan.xpos.Model;
using com.agungsetiawan.xpos.ModelView;
using com.agungsetiawan.xpos.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Service
{
    public class TransaksiEksternalService
    {
        private TransaksiEksternalRepository transaksiEksternalRepository;

        public TransaksiEksternalService()
        {
            transaksiEksternalRepository = new TransaksiEksternalRepository();
        }

        public List<TransaksiEksternalView> Get()
        {
            var transaksis=transaksiEksternalRepository.Get();
            var result = (from t in transaksis
                          select new TransaksiEksternalView
                          {
                            Id=t.Id,
                            Jenis=t.Jenis,
                            Jumlah=t.Jumlah.ToString("N2", CultureInfo.GetCultureInfo("de")),
                            Keterangan=t.Keterangan,
                            Tanggal=t.Tanggal.ToString("dd MMMM yyyy",CultureInfo.GetCultureInfo("id-ID"))
                       }).ToList();

            return result;
        }

        public void Post(TransaksiEksternal transaksiEksternal)
        {
            transaksiEksternalRepository.Post(transaksiEksternal);
        }

        public TransaksiEksternal Get(int id)
        {
            return transaksiEksternalRepository.Get(id);
        }

        public void Put(TransaksiEksternal transaksiEksternal)
        {
            transaksiEksternalRepository.Put(transaksiEksternal);
        }

        public void Delete(TransaksiEksternal transaksiEksternal)
        {
            transaksiEksternalRepository.Delete(transaksiEksternal);
        }
    }
}
