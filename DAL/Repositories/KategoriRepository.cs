using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interfaces;
using Models;

namespace DAL.Repositories
{
    public class KategoriRepository : IKategoriRepository
    {
        public KategoriRepository()
        {

        }

        public Task<List<Kategori>> HamtaAllaKategorierAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task LaggTillKategoriAsync(Kategori kategori)
        {
            throw new System.NotImplementedException(); 
        }

        public Task UppdateraKategoriAsync (Kategori kategori)
        {
            throw new System.NotImplementedException(); 
        }

        public Task TaBortKategoriAsync(string id)
        {
            throw new System.NotImplementedException ();    
        }
    }
}
