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
                            Tanggal=t.Tanggal.ToString("dd MM yyyy"),
                            Total=t.Total.ToString("N2", CultureInfo.GetCultureInfo("de"))
                       }).ToList();

            return result;
        }
    }
}
