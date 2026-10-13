using BL;
using DAL;
using DAL.Interfaces;
using DAL.Repositories;
using DAL.Rss;
using Models;


namespace PL
{
    public partial class Form1 : Form
    {
        private PodcastService enPodcastService;
        private Podcast hamtadPodd;

        public Form1()
        {
            InitializeComponent();

            var context = new MongoDbContext();

            enPodcastService = new PodcastService(
                new PodcastRepository(context),
                new AvsnittRepository(context),
                new RssHamtare());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxPodd_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnHamta_Click(object sender, EventArgs e)
        {
            try
            {
                hamtadPodd =
                    await enPodcastService.HamtaPodcastFranRssAsync(txtBoxSokRss.Text);

                txtBoxPodd.Text = hamtadPodd.Namn;

                listBoxAvsnitt.DataSource = null;
                listBoxAvsnitt.DataSource = hamtadPodd.Avsnitt;
                listBoxAvsnitt.DisplayMember = "Titel";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnSparaPodd_Click(object sender, EventArgs e)
        {
            {
                if (hamtadPodd != null)
                {
                    await enPodcastService.SparaPodcastAsync(hamtadPodd);

                    MessageBox.Show("Podcast sparades!");
                }
            }
        }
    }
}
