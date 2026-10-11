using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interfaces;
using Models;

namespace DAL.Repositories
{
    public class PodcastRepository : IPodcastRepository
    {

        public PodcastRepository()
        {

        }

        public Task<List<Podcast>> HamtaAllaPodcastAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Podcast> HamtaPodcastViaIdAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task LaggTillPodcastAsync(Podcast podcast)
        {
            throw new System.NotImplementedException();
        }

        public Task UppdateraPodcastAsync(Podcast podcast)
        {
            throw new System.NotImplementedException(); 
        }

        public Task TaBortPodcastAsync(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
