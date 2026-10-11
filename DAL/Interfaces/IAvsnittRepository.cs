using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL.Interfaces
{
    public interface IAvsnittRepository
    {
        Task<List<Avsnitt>> HamtaAvsnittForPodcastAsync(string podcastId);
        Task LaggTillAvsnittListaAsync(List<Avsnitt> avsnittLista);
        Task<Avsnitt> HamtaAvsnittViaIdAsync(string id);
    }
}
