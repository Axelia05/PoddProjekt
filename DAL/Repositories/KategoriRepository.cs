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

        //Lägger till en ny kategori (transaktion används för att kunna rulla tillbaka vid fel)
        public async Task LaggTillKategoriAsync(Kategori kategori)
        {
            if(kategori != null)
            {
                //Startar en session och transaktion för att säkerställa dataintegritet
                using var session = await _kategoriCollection.Database.Client.StartSessionAsync();
                session.StartTransaction();

                try
                {
                    await _kategoriCollection.InsertOneAsync(session, kategori);
                    await session.CommitTransactionAsync(); //Bekräftar ändringen
                }
                catch
                {
                    await session.AbortTransactionAsync(); //Rullar tillbaka vid fel 
                    throw;
                }
                
            }
        }

        //Uppdaterar namn på en kategori (transaktion används för att kunna rulla tillbaka vid fel)
        public async Task UppdateraKategoriNamnAsync (string id, string nyttNamn)
        {
            //Startar en session och transaktion för att säkerställa dataintegriteten
            using var session = await _kategoriCollection.Database.Client.StartSessionAsync();
            session.StartTransaction();

            try
            {
                var update = Builders<Kategori>.Update.Set(k => k.Namn, nyttNamn);
                await _kategoriCollection.UpdateOneAsync(session, k => k.Id == id, update);
                await session.CommitTransactionAsync(); //Bekräftar ändringen
            }
            catch
            {
                await session.AbortTransactionAsync(); //Rullar tillbaka vid fel
                throw;
            }
            
        }

        //Tar bort en kategori (transaktion används för att kunna rulla tillbaka vid fel)
        public async Task TaBortKategoriAsync(string id)
        {
            //Startar en session och transaktion för att säkerställa dataintegriteten
            using var session = await _kategoriCollection.Database.Client.StartSessionAsync();
            session.StartTransaction();

            try
            {
                await _kategoriCollection.DeleteOneAsync(session, k => k.Id == id);
                await session.CommitTransactionAsync(); //Bekräftar ändringen
            }
            catch
            {
                await session.AbortTransactionAsync(); //Rullar tillbaka vid fel
                throw;
            }
        
        }
    }
}
