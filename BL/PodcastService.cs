using DAL.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace BL
{
    public class PodcastService
    {

        //Services ska använda DAL:s abstraktioner.
        private readonly IPodcastRepository _podcastRepo;
        private readonly IAvsnittRepository _avsnittRepo;
        private readonly IRssHamtare _rss;

        //Dependency Injection: tjänsten får sitt beroende via interfacen.
        public PodcastService(IPodcastRepository poddcastRepo, IAvsnittRepository avsnittrepo, IRssHamtare rss)
        {
            _podcastRepo = poddcastRepo;
            _avsnittRepo = avsnittrepo;
            _rss = rss;
        }

        //Sparar podd i databasen
        public async Task SparaPodcastAsync(Podcast enPodcast)
        {
            await _podcastRepo.LaggTillPodcastAsync(enPodcast);
        }

        //Hämtar alla sparade poddar från databasen
        public async Task<List<Podcast>> HamtaAllaPoddarAsync()
        {
            return await _podcastRepo.HamtaAllaPodcastAsync();
        }

        //Hämtar en angiven podd baserat på ID
        public async Task<Podcast> HamtaPodcastAsync(string podcastId)
        {
            return await _podcastRepo.HamtaPodcastViaIdAsync(podcastId);
        }

        //Ändrar namnet på en sparad podd
        public async Task AndraPodcastNamnAsync(string podcastId, string nyttNamn)
        {
            await _podcastRepo.UppdateraPodcastNamnAsync(podcastId, nyttNamn);
        }

        //Byter kategori på podd
        public async Task BytKategoriAsync(string podcastId, string kategoriId)
        {
            Podcast podcast =
                await _podcastRepo.HamtaPodcastViaIdAsync(podcastId);

            if (podcast != null)
            {
                podcast.KategoriId = kategoriId;

                await _podcastRepo.UppdateraPodcastAsync(podcast);
            }
        }

        //Tar bort en podd från databas
        public async Task TaBortPodcastAsync(string podcastId)
        {
            await _podcastRepo.TaBortPodcastAsync(podcastId);
        }
        
        //Hämtar info om podd från RSS-flöde via URL
        public async Task<Podcast> HamtaPodcastFranRssAsync(string url)
        {
            return await _rss.HamtaPodcastFlodeAsync(url);
        }
    }
}
