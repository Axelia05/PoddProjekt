using BL.Interfaces;
using DAL.Interfaces;
using Models;

namespace BL
{
    public class PodcastService : IPodcastService
    {

        //Services ska använda DAL:s abstraktioner.
        private readonly IPodcastRepository _podcastRepo;
        private readonly IAvsnittRepository _avsnittRepo;
        private readonly IRssHamtare _rss;

        //Dependency Injection: tjänsten får sitt beroende via interfacen.
        public PodcastService(IPodcastRepository podcastRepo, IAvsnittRepository avsnittrepo, IRssHamtare rss)
        {
            _podcastRepo = podcastRepo;
            _avsnittRepo = avsnittrepo;
            _rss = rss;
        }

        //Sparar podd i databasen
        public async Task SparaPodcastAsync(Podcast enPodcast)
        {
            await _podcastRepo.LaggTillPodcastAsync(enPodcast);

            //Sätter podcastId på alla avsnitt
            foreach(var avsnitt in enPodcast.Avsnitt)
            {
                avsnitt.PodcastId = enPodcast.Id; 
            }

            //Sparar avsnitten i databasen
            await _avsnittRepo.LaggTillAvsnittListaAsync(enPodcast.Avsnitt);
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
        public async Task TaBortPodcastMedAvsnittAsync(string podcastId)
        {
            await _podcastRepo.TaBortPodcastAsync(podcastId);
        }
        
        //Hämtar info om podd från RSS-flöde via URL
        public async Task<Podcast> HamtaPodcastFranRssAsync(string url)
        {
            return await _rss.HamtaPodcastFlodeAsync(url);
        }

        //Ändra kategori för en podd
        public async Task AndraPodcastKategoriAsync(string podcastId, string kategoriId)
        {
            await _podcastRepo.AndraPodcastKategoriAsync(podcastId, kategoriId);
        }

        //Hämtar poddar efter kategori
        public async Task<List<Podcast>> HamtaPoddarForKategoriAsync(string kategoriId)
        {
            return await _podcastRepo.HamtaPoddarForKategoriAsync(kategoriId);
        }
    }
}
