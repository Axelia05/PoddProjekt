using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interfaces;
using Models;

namespace DAL.Repositories
{
    public class AvsnittRepository : IAvsnittRepository
    {
        public AvsnittRepository()
        {

        }

        public Task<List<Avsnitt>> HamtaAvsnittForPodcastAsync(string podcastId)
        {
            throw new System.NotImplementedException(); 
        }

        public Task LaggTillAvsnittListaAsync(List<Avsnitt> avsnittLista)
        {
            throw new System.NotImplementedException(); 
        }

        public Task<Avsnitt> HamtaAvsnittViaIdAsync(string id)
        {
            throw new System.NotImplementedException(); 
        }
    }
}
