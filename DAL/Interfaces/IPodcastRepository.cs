using Models;

namespace DAL.Interfaces
{
    public interface IPodcastRepository
    {
        Task<List<Podcast>> HamtaAllaPodcastAsync();
        Task<Podcast> HamtaPodcastViaIdAsync(string id);
        Task LaggTillPodcastAsync(Podcast podcast);
        Task UppdateraPodcastNamnAsync(string id, string nyttNamn);
        Task UppdateraPodcastAsync(Podcast podcast); 
        Task TaBortPodcastAsync(string id);
        Task AndraPodcastKategoriAsync(string podcastId, string kategoriId);
        Task<List<Podcast>> HamtaPoddarForKategoriAsync(string kategoriId);
    }
}
