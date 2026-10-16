using DAL.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BL.Interfaces; 

namespace BL
{
    public class KategoriService : IKategoriService
    {
        //Services ska använda DAL:s abstraktioner.
        private readonly IKategoriRepository _kategoriRepo;

        //Dependency Injection: tjänsten får sitt beroende via interfacet.
        public KategoriService (IKategoriRepository kategoriRepo)
        {
            _kategoriRepo = kategoriRepo ?? throw new ArgumentNullException(nameof(kategoriRepo));
        }

        public async Task LaggTillKategoriAsync(string namn)
        {
            if (string.IsNullOrWhiteSpace(namn))
            {
                throw new ArgumentException("Kategorinamnet får inte vara tomt.", nameof(namn));
            }
            var nyKategori = new Kategori
            {
                Namn = namn.Trim()
            };

            await _kategoriRepo.LaggTillKategoriAsync(nyKategori);
        }

        public async Task<List<Kategori>> HamtaAllaKategorierAsync()
        {
            return await _kategoriRepo.HamtaAllaKategorierAsync();
        }

        public async Task UppdateraKategoriNamnAsync(string id, string nyttNamn)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Kategori-ID kan inte vara tomt.", nameof(id));
            }
            
            if (string.IsNullOrWhiteSpace(nyttNamn))
            {
                throw new ArgumentException("Det nya kategorinamnet får inte vara tomt.", nameof(nyttNamn));
            }
            await _kategoriRepo.UppdateraKategoriNamnAsync(id, nyttNamn.Trim());
        }

        public async Task TaBortKategoriAsync(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Kategori-ID kan inte vara tomt.", nameof(id));
            }
            await _kategoriRepo.TaBortKategoriAsync(id);
        }
    }
}
