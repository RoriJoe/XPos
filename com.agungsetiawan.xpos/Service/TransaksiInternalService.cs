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
    public class TransaksiInternalService
    {
        private TransaksiInternalRepository transaksiInternalRepository;

        public TransaksiInternalService()
        {
            transaksiInternalRepository = new TransaksiInternalRepository();
        }

        public List<TransaksiInternalView> Get()
        {
            var transaksis=transaksiInternalRepository.Get();
            var result=(from t in transaksis select new TransaksiInternalView{
                            Id=t.Id,
                            Jenis=t.Jenis,
                            Jumlah=t.Jumlah.ToString("N2", CultureInfo.GetCultureInfo("de")),
                            Keterangan=t.Keterangan,
                            Tanggal=t.Tanggal.ToString("dd MMMM yyyy",CultureInfo.GetCultureInfo("id-ID"))
                       }).ToList();

            return result;
        }

        public void Post(TransaksiInternal transaksiInternal)
        {
            transaksiInternalRepository.Post(transaksiInternal);
        }

        public TransaksiInternal Get(int id)
        {
            return transaksiInternalRepository.Get(id);
        }

        //public decimal GetLastTotal()
        //{
        //    return transaksiInternalRepository.GetLastTotal();
        //}

        public void Put(TransaksiInternal transaksiInternal)
        {
            transaksiInternalRepository.Put(transaksiInternal);
        }
    }
}
