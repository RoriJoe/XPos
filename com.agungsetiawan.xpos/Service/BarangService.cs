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
    public class BarangService
    {
        BarangRepository barangRepository;
        StokHargaUkuranRepository shuRepository;

        public BarangService()
        {
            barangRepository = new BarangRepository();
            shuRepository = new StokHargaUkuranRepository();
        }

        public List<BarangView> Get()
        {
            var barangs = barangRepository.GetWithKategoriAndSupplierAndMerek();
            var barangViews = (from b in barangs
                              select new BarangView
                                  {
                                      Id = b.Id,
                                      NamaBarang = b.NamaBarang,
                                      Merek=b.Merek.NamaMerek,
                                      Kategori = b.Kategori.NamaKategori,
                                      Keterangan = b.Keterangan,
                                      Supplier = b.Supplier.NamaSupplier,
                                      KodeBarang=b.KodeBarang
                                  }).ToList();

            return barangViews;
        }

        public Barang Get(int id)
        {
            return barangRepository.Get(id);
        }

        public void Post(Barang barang)
        {
            barangRepository.Post(barang);
        }

        public void Put(Barang barang)
        {
            shuRepository.DeleteByBarangId(barang.Id);
            barangRepository.Put(barang);
        }

        public void Delete(Barang barang)
        {
            barangRepository.Delete(barang);
        }

        public List<BarangView> FindByNama(String nama)
        {
            var barangs = barangRepository.FindByNama(nama);
            var barangViews = (from b in barangs
                               select new BarangView
                               {
                                   Id = b.Id,
                                   NamaBarang = b.NamaBarang,
                                   Merek = b.Merek.NamaMerek,
                                   Keterangan = b.Keterangan,
                                   Kategori = b.Kategori.NamaKategori,
                                   Supplier = b.Supplier.NamaSupplier,
                                   KodeBarang = b.KodeBarang
                               }).ToList();

            return barangViews;
        }

        public Barang FindByKodeBarang(string kodeBarang)
        {
            return barangRepository.FindByKodeBarang(kodeBarang);
        }

        public string GenerateKodeBarang(string namaBarang, string merek)
        {
            string FirstPart = namaBarang.Trim().Substring(0, 3);
            string SecondPart = merek.Trim().Substring(0, 3);

            Barang barangAda = barangRepository.FindTopLikeKodeBarang(FirstPart + SecondPart);

            if(barangAda==null)
            {
                return FirstPart.ToUpper() + SecondPart.ToUpper() + "001";
            }

            int currentNumber = int.Parse(barangAda.KodeBarang.Substring(6, 3));
            int nextNumber = currentNumber + 1;

            return FirstPart.ToUpper()+SecondPart.ToUpper()+nextNumber.ToString().PadLeft(3,'0');
        }
    }
}
