using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interfaces;

namespace BL
{
    public class PodcastService
    {

        //Services ska använda DAL:s abstraktioner.
        private readonly IPodcastRepository _podcastRepo;
        private readonly IAvsnittRepository  _avsnittRepo;
        private readonly IRssHamtare _rss;

        //Dependency Injection: tjänsten får sitt beroende via interfacen.
        public PodcastService (IPodcastRepository poddcastRepo, IAvsnittRepository avsnittrepo, IRssHamtare rss)
        {
            _podcastRepo = poddcastRepo;
            _avsnittRepo = avsnittrepo;
            _rss = rss;
        }

    }
}
