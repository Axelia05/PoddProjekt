using Models;

namespace DAL.Interfaces
{
    public interface IRssHamtare
    {
        Task<Podcast> HamtaPodcastFlodeAsync(string url);
    }
}
