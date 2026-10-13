using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interfaces;
using Models;
using MongoDB.Driver;

namespace DAL.Repositories
{
    public class AvsnittRepository : IAvsnittRepository
    {
        //En privat variabel som representerar själva samlingen i MongoDB för modellen Avsnitt
        private readonly IMongoCollection<Avsnitt> _avsnittCollection;


        public AvsnittRepository(MongoDbContext context)
        {
            //Kopplar upp mot och hämtar MongoDB-kollektionen med namnet "Avsnitt" via kontexten
            _avsnittCollection = context.GetCollection<Avsnitt>("Avsnitt");

        }

        //Hämtar alla avsnitt för en specifik podcast
        public async Task<List<Avsnitt>> HamtaAvsnittForPodcastAsync(string podcastId)
        {
            return await _avsnittCollection.Find(a => a.PodcastId == podcastId).ToListAsync();
        }

        //Lägger till en hel lista med avsnitt på en gång
        public async Task LaggTillAvsnittListaAsync(List<Avsnitt> avsnittLista)
        {
            if(avsnittLista != null && avsnittLista.Count > 0)
            {
                await _avsnittCollection.InsertManyAsync(avsnittLista);
            }
        }

        //Hämtar ett specifikt avsnitt via dess ID
        public async Task<Avsnitt> HamtaAvsnittViaIdAsync(string id)
        {
            return await _avsnittCollection.Find(a => a.Id == id).FirstOrDefaultAsync();
        }
    }
}

