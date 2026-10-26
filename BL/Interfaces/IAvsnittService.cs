using Models;


namespace BL.Interfaces
{
    public interface IAvsnittService
    {
        Task<List<Avsnitt>> HamtaAvsnittForPodcastAsync(string podcastId);
        Task<Avsnitt> HamtaAvsnittViaAsync(string id);
    }
}
