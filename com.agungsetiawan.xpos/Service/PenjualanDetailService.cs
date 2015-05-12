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
    public class PenjualanDetailService
    {
        PenjualanDetailRepository penjualanDetailRepository;
        public PenjualanDetailService()
        {
            penjualanDetailRepository = new PenjualanDetailRepository();
        }

        public List<PenjualanDetailView> FindByPenjualanId(int id)
        {
            var result= penjualanDetailRepository.FindByPenjualanId(id);
            var penjualanDetails = (from pd in result
                                    select new PenjualanDetailView
                                    {
                                        Id=pd.Id,
                                        Barang=pd.Barang.NamaBarang,
                                        Ukuran=pd.Ukuran,
                                        Harga=pd.Harga,
                                        Jumlah=pd.Jumlah,
                                        Diskon=pd.Diskon,
                                        SubTotal=pd.SubTotal
                                    }).ToList();

            return penjualanDetails;
        }

         public List<PenjualanDetailView> GetWithBarang(List<PenjualanView> Penjualans)
        {
            var ids = (from p in Penjualans select p.Id).ToArray();

            var data = penjualanDetailRepository.GetWithBarang(ids);
            var result = from d in data select new PenjualanDetailView { Barang = d.Barang.NamaBarang, Diskon = d.Diskon, Harga = d.Harga, Id = d.Id, Jumlah = d.Jumlah, SubTotal = d.SubTotal, Ukuran = d.Ukuran, PenjualanId = d.PenjualanId };
            return result.ToList();
         }
    }
}
