using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Podcast
    {
        public string Id { get; set; }
        public string Namn { get; set; }
        public string Beskrivning { get; set; }
        public string RssUrl { get; set; } 
        public List<Avsnitt> Avsnitt { get; set; }
        public string KategoriId { get; set; }
    }
}
