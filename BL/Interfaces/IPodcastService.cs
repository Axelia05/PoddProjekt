using System;
using System.Collections.Generic;
using System.Text;
using Models; 

namespace BL.Interfaces
{
    public interface IPodcastService
    {
        Task SparaPodcastAsync(Podcast enPodcast);
        Task<List<Podcast>> HamtaAllaPoddarAsync();
        Task<Podcast> HamtaPodcastAsync(string podcastId);
        Task AndraPodcastNamnAsync(string podcastId, string nyttNamn);
        Task BytKategoriAsync(string podcastId, string KategoriId);
        Task TaBortPodcastAsync(string podcastId);
        Task<Podcast> HamtaPodcastFranRssAsync(string url);
        Task AndraPodcastKategoriAsync(string podcastId, string kategoriId);
        Task<List<Podcast>> HamtaPoddarForKategoriAsync(string kategoriId);
    }
}
