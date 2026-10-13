using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interfaces;
using Models;
using MongoDB.Driver;

namespace DAL.Repositories
{
    public class KategoriRepository : IKategoriRepository
    {
        //Kopplingen till MongoDB-samlingen för kategorier
        private readonly IMongoCollection<Kategori> _kategoriCollection;
        public KategoriRepository(MongoDbContext context)
        {
            _kategoriCollection = context.GetCollection<Kategori>("kategorier");
        }

        //Hämtar alla kategorier
        public async Task<List<Kategori>> HamtaAllaKategorierAsync()
        {
            return await _kategoriCollection.Find(k => true).ToListAsync();
        }

        //Lägger till en ny kategori
        public async Task LaggTillKategoriAsync(Kategori kategori)
        {
            if(kategori != null)
            {
                await _kategoriCollection.InsertOneAsync(kategori);
            }
        }

        //Uppdaterar namn på en kategori
        public async Task UppdateraKategoriNamnAsync (string id, string nyttNamn)
        {
            var update = Builders<Kategori>.Update.Set(k => k.Namn, nyttNamn);
            await _kategoriCollection.UpdateOneAsync(k => k.Id == id, update);
        }

        //Tar bort en kategori
        public async Task TaBortKategoriAsync(string id)
        {
            await _kategoriCollection.DeleteOneAsync(k => k.Id == id);  
        }
    }
}
