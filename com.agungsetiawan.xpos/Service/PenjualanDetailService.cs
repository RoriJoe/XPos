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
                                        Harga=pd.Harga,
                                        Jumlah=pd.Jumlah,
                                        Diskon=pd.Diskon,
                                        SubTotal=pd.SubTotal
                                    }).ToList();

            return penjualanDetails;
        }
    }
}
