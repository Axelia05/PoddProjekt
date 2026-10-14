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
        //Fält
        private PodcastService enPodcastService;
        private Podcast hamtadPodd;

        //Konstruktor
        public Form1()
        {
            InitializeComponent();

            var context = new MongoDbContext();

            enPodcastService = new PodcastService(
                new PodcastRepository(context),
                new AvsnittRepository(context),
                new RssHamtare());
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await VisaSparadePoddar();
            await VisaPodcastComboBox();
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
            if (hamtadPodd != null)
            {
                await enPodcastService.SparaPodcastAsync(hamtadPodd);

                await VisaSparadePoddar();
                await VisaPodcastComboBox();

                MessageBox.Show("Podcast har sparats!");
            }
        }

        //Lägger till poddar i podcast
        private async Task VisaSparadePoddar()
        {
            var poddar = await enPodcastService.HamtaAllaPoddarAsync();
            //Lägger till poddarna i mina poddar
            listBoxMinaPoddar.DataSource = null;
            listBoxMinaPoddar.DataSource = poddar;
            listBoxMinaPoddar.DisplayMember = "Namn";
        }

        //Lägger till poddar i combobox för avsnittssidan
        private async Task VisaPodcastComboBox()
        {
            var poddar = await enPodcastService.HamtaAllaPoddarAsync();

            comboBoxValj.DataSource = null;
            comboBoxValj.DataSource = poddar;
            comboBoxValj.DisplayMember = "Namn";
        }

        //Knapp för att ta bort en podd
        private async void btnTaBortPodd_Click(object sender, EventArgs e)
        {
            Podcast valdPodd =
                (Podcast)listBoxMinaPoddar.SelectedItem;

            if (valdPodd == null)
            {
                MessageBox.Show("Välj den podcast du vill radera");
                return;
            }

            DialogResult svar = MessageBox.Show(
                "Är du säker på att du vill radera podcasten?",
                "Bekräfta",
                MessageBoxButtons.YesNo);

            if (svar == DialogResult.Yes)
            {
                await enPodcastService.TaBortPodcastAsync(valdPodd.Id);

                await VisaSparadePoddar();
                await VisaPodcastComboBox();

                MessageBox.Show("Podcasten har tagits bort");
            }
        }

        //Avsnitt visas då användaren väljer en podd
        private void comboBoxValj_SelectedIndexChanged(object sender, EventArgs e)
        {
            Podcast valdPodd = (Podcast)comboBoxValj.SelectedItem;

            if (valdPodd == null)
                return;

            listBoxValtAvsnitt.DataSource = null;
            listBoxValtAvsnitt.DataSource = valdPodd.Avsnitt;
            listBoxValtAvsnitt.DisplayMember = "Titel";
        }

        //Knapp för att visa information i rutan till höger
        private void btnVisaDetaljer_Click(object sender, EventArgs e)
        {
            Avsnitt valtAvsnitt =
                (Avsnitt)listBoxValtAvsnitt.SelectedItem;

            if (valtAvsnitt == null)
                return;

            rtbDetaljer.Text =
                $"Titel: {valtAvsnitt.Titel}\n\n" +
                $"Datum: {valtAvsnitt.Publiceringsdatum}\n\n" +
                $"Beskrivning:\n{valtAvsnitt.Beskrivning}";
        }

        private void listBoxMinaPoddar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Podcast valdPodd =
                (Podcast)listBoxMinaPoddar.SelectedItem;

            if (valdPodd == null)
                return;

            textBoxNamn.Text = valdPodd.Namn;
        }

        //Sparar namnändrning
        private async void btnSparaÄndring_Click(object sender, EventArgs e)
        {
            Podcast valdPodd =
                (Podcast)listBoxMinaPoddar.SelectedItem;

            if (valdPodd == null)
            {
                MessageBox.Show("Välj först en podcast att byta namn på");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxNamn.Text))
            {
                MessageBox.Show("Ange ett namn");
                return;
            }
            await enPodcastService.AndraPodcastNamnAsync(
                valdPodd.Id,
                textBoxNamn.Text);

            await VisaSparadePoddar();
            await VisaPodcastComboBox();

            MessageBox.Show("Namnet har ändrats");
        }

        private void comboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
