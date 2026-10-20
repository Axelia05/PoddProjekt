using DAL;
using DAL.Interfaces;
using DAL.Repositories;
using DAL.Rss;
using BL;
using BL.Interfaces;

namespace PL
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //skapar databas-kontexten
            var context = new MongoDbContext();

            //Skapa repositorys via interfacen
            IAvsnittRepository avsnittRepo = new AvsnittRepository(context);
            IPodcastRepository podcastRepo = new PodcastRepository(context, avsnittRepo);
            IKategoriRepository kategoriRepo = new KategoriRepository(context);
            IRssHamtare rssHamtare = new RssHamtare();

            //Skapar tjänsterna via interfacen
            IPodcastService podcastService = new PodcastService(podcastRepo, avsnittRepo, rssHamtare);
            IKategoriService kategoriService = new KategoriService(kategoriRepo);
            IAvsnittService avsnittService = new AvsnittService(avsnittRepo);

            //Startar formuläret och skickar in alla tre tjänster
            Application.Run(new Form1(podcastService, kategoriService, avsnittService));
        }
    }
}