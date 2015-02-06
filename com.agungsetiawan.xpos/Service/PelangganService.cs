﻿using com.agungsetiawan.xpos.Model;
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
        public List<Pelanggan> Get()
        {
            return pelangganRepository.Get();
        }

        public Pelanggan Get(int id)
        {
            return pelangganRepository.Get(id);
        }

        public List<Pelanggan> FinyByNama(string nama)
        {
            return pelangganRepository.FindyByNama(nama);
        }
    }
}