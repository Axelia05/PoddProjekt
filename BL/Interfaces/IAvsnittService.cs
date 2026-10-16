using Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace BL.Interfaces
{
    public interface IAvsnittService
    {
        Task<List<Avsnitt>> HamtaAvsnittForPodcastAsync(string podcastId);
        Task<Avsnitt> HamtaAvsnittViaAsync(string id);
    }
}
