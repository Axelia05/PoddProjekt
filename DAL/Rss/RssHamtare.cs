using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interfaces;
using Models;

namespace DAL.Rss
{
    public class RssHamtare : IRssHamtare
    {
        public RssHamtare()
        {

        }

        public Task<Podcast> HamtaPodcastFlodeAsync (string id)
        {
            throw new System.NotImplementedException(); 
        }
    }
}
