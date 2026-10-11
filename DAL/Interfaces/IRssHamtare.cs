using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL.Interfaces
{
    public interface IRssHamtare
    {
        Task<Podcast> HamtaPodcastFlodeAsync(string url);
    }
}
