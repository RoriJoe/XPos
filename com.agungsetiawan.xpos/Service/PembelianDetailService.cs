using com.agungsetiawan.xpos.ModelView;
using com.agungsetiawan.xpos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.agungsetiawan.xpos.Service
{
    public class PembelianDetailService
    {
        private PembelianDetailRepository pembelianDetailRepository;

        public PembelianDetailService()
        {
            pembelianDetailRepository = new PembelianDetailRepository();
        }

        public List<PembelianDetailView> FindByPembelianId(int id)
        {
            var result = pembelianDetailRepository.FindByPembelianId(id);
            var penjualanDetails = (from pd in result
                                    select new PembelianDetailView
                                    {
                                        Id = pd.Id,
                                        Barang = pd.Barang.NamaBarang,
                                        Ukuran = pd.Ukuran,
                                        Harga = pd.Harga,
                                        Jumlah = pd.Jumlah,
                                        Diskon = pd.Diskon,
                                        SubTotal = pd.SubTotal
                                    }).ToList();

            return penjualanDetails;
        }

        public List<PembelianDetailView> GetWithBarang(List<PembelianView> Pembelians)
        {
            var ids = (from p in Pembelians select p.Id).ToArray();

            var data = pembelianDetailRepository.GetWithBarang(ids);
            var result = from d in data select new PembelianDetailView { Barang = d.Barang.NamaBarang, Diskon = d.Diskon, Harga = d.Harga, Id = d.Id, Jumlah = d.Jumlah, SubTotal = d.SubTotal, Ukuran = d.Ukuran, PembelianId = d.PembelianId };
            return result.ToList();
        }
    }
}
