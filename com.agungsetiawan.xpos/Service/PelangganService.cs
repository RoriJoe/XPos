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
    public class PelangganService
    {
        PelangganRepository pelangganRepository;

        public PelangganService()
        {
            pelangganRepository = new PelangganRepository();
        }
        public List<PelangganView> Get()
        {
            var pelanggans= pelangganRepository.Get();
            var pelangganView = (from p in pelanggans 
                                 select new PelangganView 
                                 { 
                                    Id=p.Id,
                                    NamaPelanggan=p.NamaPelanggan,
                                    Alamat=p.Alamat,
                                    NoTelepon=p.NoTelepon,
                                    JenisMember=p.Member.NamaMember
                                 }).ToList();

            return pelangganView;
        }

        public Pelanggan Get(int id)
        {
            return pelangganRepository.Get(id);
        }

        public List<PelangganView> FinyByNama(string nama)
        {
            var pelanggans= pelangganRepository.FindyByNama(nama);
            var pelangganView = (from p in pelanggans 
                                 select new PelangganView 
                                 { 
                                    Id=p.Id,
                                    NamaPelanggan=p.NamaPelanggan,
                                    Alamat=p.Alamat,
                                    NoTelepon=p.NoTelepon,
                                    JenisMember=p.Member.NamaMember
                                 }).ToList();

            return pelangganView;
        }

        public Pelanggan FindDiskonNol()
        {
            return pelangganRepository.FindDiskonNol();
        }

        public void Post(Pelanggan pelanggan)
        {
            pelangganRepository.Post(pelanggan);
        }
    }
}
