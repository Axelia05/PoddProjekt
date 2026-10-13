using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL.Interfaces
{
    public interface IPodcastRepository
    {
        Task<List<Podcast>> HamtaAllaPodcastAsync();
        Task<Podcast> HamtaPodcastViaIdAsync(string id);
        Task LaggTillPodcastAsync(Podcast podcast);
        Task UppdateraPodcastNamnAsync(string id, string nyttNamn);
        Task TaBortPodcastAsync(string id);
    }
}
