using Models;
using MongoDB.Driver;

namespace DAL.Interfaces
{
    public interface IAvsnittRepository
    {
        Task<List<Avsnitt>> HamtaAvsnittForPodcastAsync(string podcastId);
        Task LaggTillAvsnittListaAsync(List<Avsnitt> avsnittLista);
        Task<Avsnitt> HamtaAvsnittViaIdAsync(string id);
        Task TaBortAvsnittForPodcastAsync(IClientSessionHandle session, string podcastId);
    }
}
