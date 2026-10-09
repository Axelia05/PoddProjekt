using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Avsnitt
    {
        public string Id { get; set; }
        public string PodcastId { get; set; }
        public string Titel { get; set; }
        public string Beskrivning { get; set; }
        public DateTime Publiceringsdatum { get; set; }
    }
}
