using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using Models;
using BL.Interfaces;

namespace BL
{
    public class AvsnittService : IAvsnittService 
    {
        //Services ska använda DAL:s abstraktioner.
        private readonly IAvsnittRepository _avsnittRepo;

        //Dependency Injection: tjänsten får sitt beroende via interfacet.
        public AvsnittService(IAvsnittRepository avsnittRepo)
        {
            _avsnittRepo = avsnittRepo;
        }
    

    public async Task<List<Avsnitt>> HamtaAvsnittForPodcastAsync(string podcastId)
        {
            if (string.IsNullOrWhiteSpace(podcastId))
            {
                throw new ArgumentException("PodcastId saknas");
            }

            var avsnitt = await
                _avsnittRepo.HamtaAvsnittForPodcastAsync(podcastId);
            avsnitt = avsnitt.OrderByDescending(a => a.Publiceringsdatum)
                .ToList();
            return avsnitt;

        }

        public async Task<Avsnitt> HamtaAvsnittViaAsync(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("AvsnittId saknas");
            }

            var avsnitt = await
                _avsnittRepo.HamtaAvsnittViaIdAsync(id);
            if (avsnitt == null)
            {
                throw new ArgumentException("Avsnitt hittades inte");
            }
            return avsnitt;

        }

    }
}
