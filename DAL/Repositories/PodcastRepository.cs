using DAL.Interfaces;
using Models;
using MongoDB.Driver;

namespace DAL.Repositories
{
    public class PodcastRepository : IPodcastRepository
    {
        //Kopplingen till MongoDB-samlingen för podcasts
        private readonly IMongoCollection<Podcast> _podcastCollection;
        private readonly IAvsnittRepository _avsnittRepository; 

        public PodcastRepository(MongoDbContext context, IAvsnittRepository avsnittRepository)
        {
            //Hämtar kollektionen för podcasts från databasen
            _podcastCollection = context.GetCollection<Podcast>("Podcasts");

            //Tar emot avsnitt-repository via interface (dependency injection)
            _avsnittRepository = avsnittRepository;
        }

        //Hämtar alla sparade podcasts
        public async Task<List<Podcast>> HamtaAllaPodcastAsync()
        {
        return await _podcastCollection.Find(p => true).ToListAsync();
        }

        //Hämtar en specifik podcast från databasen baserat på dess unika ID
        public async Task<Podcast> HamtaPodcastViaIdAsync(string id)
        {
            return await _podcastCollection.Find(p => p.Id == id).FirstOrDefaultAsync();
        }

        //Lägger till en ny podcast (transaktion används för att kunna rulla tillbaka vid fel)
        public async Task LaggTillPodcastAsync(Podcast podcast)
        {
            //Startar en session och transaktion för att säkerställa dataintegriteten
            using var session = await _podcastCollection.Database.Client.StartSessionAsync();
            session.StartTransaction();

            try
            {
                await _podcastCollection.InsertOneAsync(session, podcast);
                await session.CommitTransactionAsync(); //Bekräftar ändringen
            }
            catch
            {
                await session.AbortTransactionAsync(); //Rullar tillbaka vid fel
                throw;
            }

        }

        //Uppdaterar endast namnet på en specifik podcast baserat på dess ID
        //(transaktion används för att kunna rulla tillbaka vid fel)
        public async Task UppdateraPodcastNamnAsync(string id, string nyttNamn)
        {
            //Startar en session och transaktion för att säkerställa dataintegriteten
            using var session = await _podcastCollection.Database.Client.StartSessionAsync();
            session.StartTransaction();

            try
            {
                var update = Builders<Podcast>.Update.Set(p => p.Namn, nyttNamn);
                await _podcastCollection.UpdateOneAsync(session, p => p.Id == id, update);
                await session.CommitTransactionAsync(); //Bekräftar ändringen
            }
            catch
            {
                await session.AbortTransactionAsync(); //Rullar tillbaka vid fel
                throw;
            }
            }


        //Ersätter hela podcast-dokumentet i databasen för att uppdatera det
        //(transaktion används för att kunna rulla tillbaka vid fel)
        public async Task UppdateraPodcastAsync(Podcast podcast)
        {
            //Startar en session och transaktion för att säkerställa dataintegriteten
            using var session = await _podcastCollection.Database.Client.StartSessionAsync();
            session.StartTransaction();

            try
            {
                await _podcastCollection.ReplaceOneAsync(session, p => p.Id == podcast.Id, podcast);
                await session.CommitTransactionAsync(); //Bekräftar ändringen
            }
            catch
            {
                await session.AbortTransactionAsync(); //Rullar tillbaka vid fel
                throw;
            }
           
        }

        //Tar bort en podcast (transaktion används för att kunna rulla tillbaka vid fel)
        public async Task TaBortPodcastAsync(string id)
        {
            //Startar en session och transaktion för att säkerställa dataintegriteten
            using var session = await _podcastCollection.Database.Client.StartSessionAsync();
            session.StartTransaction();

            try
            {
               //Tar bort podden
                await _podcastCollection.DeleteOneAsync(session, p => p.Id == id);

                //Tar bort alla avsnitt kopplade till podden 
                await _avsnittRepository.TaBortAvsnittForPodcastAsync(session, id);

                await session.CommitTransactionAsync(); //Bekräftar ändringen
            }
            catch
            {
                await session.AbortTransactionAsync(); //Rullar tillbaka vid fel
                throw;
            }
        }

        //Ändra kategorin för en podcast
        public async Task AndraPodcastKategoriAsync(
            string podcastId,
            string kategoriId)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, podcastId);
            var update = Builders<Podcast>.Update.Set(p => p.KategoriId, kategoriId);

            await _podcastCollection.UpdateOneAsync(filter, update);
        }

        //Filtrera poddar efter kategori
        public async Task<List<Podcast>> HamtaPoddarForKategoriAsync(string kategoriId)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.KategoriId,kategoriId);

            return await _podcastCollection.Find(filter).ToListAsync();
        }
    }
}
