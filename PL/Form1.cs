using BL;
using Models;
using DAL.Interfaces;
using DAL.Repositories;
using DAL.Rss;


namespace PL
{
    public partial class Form1 : Form
    {
        private PodcastService enPodcastService;
        private Podcast hamtadPodd;

        public Form1()
        {
            InitializeComponent();
            enPodcastService = new PodcastService(
                new PodcastRepository(),
                new AvsnittRepository(),
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
