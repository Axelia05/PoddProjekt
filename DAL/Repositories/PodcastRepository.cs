using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interfaces;
using Models;
using MongoDB.Driver;

namespace DAL.Repositories
{
    public class PodcastRepository : IPodcastRepository
    {
        //Kopplingen till MongoDB-samlingen för podcasts
        private readonly IMongoCollection<Podcast> _podcastCollection;

        public PodcastRepository(MongoDbContext context)
        {
            //Hämtar kollektionen för podcasts från databasen
            _podcastCollection = context.GetCollection<Podcast>("Podcasts");
        }

        //Hämtar alla sparade possar
        public async Task<List<Podcast>> HamtaAllaPodcastAsync()
        {
            return await _podcastCollection.Find(p => true).ToListAsync();
        }

        //Hämtar en specifik podcast från databasen baserat på dess unika ID
        public async Task<Podcast> HamtaPodcastViaIdAsync(string id)
        {
            return await _podcastCollection.Find(p => p.Id == id).FirstOrDefaultAsync();
        }

        //Lägger till en ny podcast
        public async Task LaggTillPodcastAsync(Podcast podcast)
        {
            await _podcastCollection.InsertOneAsync(podcast);
        }

        //Uppdaterar endast namnet på en specifik podcast baserat på dess ID
        public async Task UppdateraPodcastNamnAsync(string id, string nyttNamn)
        {
            var update = Builders<Podcast>.Update.Set(p => p.Namn, nyttNamn);
            await _podcastCollection.UpdateOneAsync(p => p.Id == id, update);
        }

        //Ersätter hela podcast-dokumentet i databasen för att uppdatera det
        public async Task UppdateraPodcastAsync(Podcast podcast)
        {
            await _podcastCollection.ReplaceOneAsync(p => p.Id == podcast.Id, podcast);
        }

        //Tar bort en podcast
        public async Task TaBortPodcastAsync(string id)
        {
            await _podcastCollection.DeleteOneAsync(p => p.Id == id);
        }
    }
}
