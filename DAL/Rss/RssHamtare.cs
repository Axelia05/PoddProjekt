using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Xml.Linq;
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
        public async Task<Podcast> HamtaPodcastFlodeAsync(string url)
        {
            //Skapar objekt som kan hämta data från internet
            HttpClient client = new HttpClient();

            //Hämtar RSS-länkens innehåll
            string xml = await client.GetStringAsync(url);

            XDocument dokument = XDocument.Parse(xml);

            //Skapar podd
            Podcast podcast = new Podcast();

            podcast.RssUrl = url;

            podcast.Namn =
                dokument.Root?
                .Element("channel")?
                .Element("title")?
                .Value;

            podcast.Beskrivning =
                dokument.Root?
                .Element("channel")?
                .Element("description")?
                .Value;

            podcast.Avsnitt = new List<Avsnitt>();

            foreach (var item in dokument.Descendants("item"))
            {
                DateTime datum;

                DateTime.TryParse(
                    item.Element("pubDate")?.Value,
                    out datum);

                podcast.Avsnitt.Add(new Avsnitt
                {
                    Titel = item.Element("title")?.Value,
                    Beskrivning = item.Element("description")?.Value,
                    Publiceringsdatum = datum
                });
            }

                return podcast;
        }
    }
}
    