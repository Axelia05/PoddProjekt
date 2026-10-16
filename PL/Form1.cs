using BL;
using BL.Interfaces;
using DAL;
using DAL.Interfaces;
using DAL.Repositories;
using DAL.Rss;
using Models;
using System.CodeDom;
using System.Linq;


namespace PL
{
    public partial class Form1 : Form
    {
        //Fält för alla tre tjänsterna (via interfaces)
        private readonly IPodcastService enPodcastService;
        private readonly IKategoriService enKategoriService;
        private readonly IAvsnittService enAvsnittService;
        private Podcast hamtadPodd; 


        //Konstruktorn tar in alla tre tjänster som skickas från Program
        public Form1(IPodcastService podcastService, IKategoriService kategoriService, IAvsnittService avsnittService)
        {
            InitializeComponent();

            //Sparar undan dem i fälten och skyddar mot nullvärden
            enPodcastService = podcastService ?? throw new ArgumentNullException(nameof(PodcastService));
            enKategoriService = kategoriService ?? throw new ArgumentNullException(nameof(KategoriService));
            enAvsnittService = avsnittService ?? throw new ArgumentNullException(nameof(AvsnittService));
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await VisaSparadePoddar();
            await VisaPodcastComboBox();
            await VisaKategorier();
            await VisaKategoriComboBoxar();
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
            try
            {
                if (hamtadPodd != null)
                {
                    await enPodcastService.SparaPodcastAsync(hamtadPodd);

                    await VisaSparadePoddar();
                    await VisaPodcastComboBox();

                    MessageBox.Show("Podcast har sparats!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kunde inte spara podd: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //Lägger in kategorierna
        private async Task VisaKategorier()
        {
            var kategorier =
                await enKategoriService.HamtaAllaKategorierAsync();

            listBoxKategorier.DataSource = null;
            listBoxKategorier.DataSource = kategorier;
            listBoxKategorier.DisplayMember = "Namn";
        }

        private async Task VisaKategoriComboBoxar()
        {
            var kategorier =
                await enKategoriService.HamtaAllaKategorierAsync();

            comboBoxPoddKategori.DataSource = null;
            comboBoxPoddKategori.DataSource = kategorier;
            comboBoxPoddKategori.DisplayMember = "Namn";

            comboBoxFilterKategori.DataSource = null;
            comboBoxFilterKategori.DataSource = kategorier.ToList();
            comboBoxFilterKategori.DisplayMember = "Namn";
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

        //Visar kategori i textbox när användaren klickar
        private void listBoxKategorier_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kategori valdKategori =
                (Kategori)listBoxKategorier.SelectedItem;

            if (valdKategori == null)
                return;

            textBoxKategoriNamn.Text = valdKategori.Namn;
        }

        //Knapp för att lägga till kategori
        private async void btnLaggTill_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxKategoriNamn.Text))
            {
                MessageBox.Show("Ange ett namn på kategorin du vill lägga till");
                return;
            }

            await enKategoriService.LaggTillKategoriAsync(
                textBoxKategoriNamn.Text);

            await VisaKategorier();
            await VisaKategoriComboBoxar();

            textBoxKategoriNamn.Clear();
        }

        //Knapp för att spara ändrat namn på kategorin  
        private async void btnSparaAndradKategori_Click(object sender, EventArgs e)
        {
            Kategori valdKategori =
                (Kategori)listBoxKategorier.SelectedItem;

            if (valdKategori == null)
            {
                MessageBox.Show("Välj den kategori du vill ändra namn på");
                return;
            }

            await enKategoriService.UppdateraKategoriNamnAsync(
                valdKategori.Id,
                textBoxKategoriNamn.Text);

            await VisaKategorier();
            await VisaKategoriComboBoxar();

            MessageBox.Show("Kategorins namn har uppdaterats");
        }

        private async void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            Kategori valdKategori =
                (Kategori)listBoxKategorier.SelectedItem;

            if (valdKategori == null)
            {
                MessageBox.Show("Välj den kategori du vill ta bort");
                return;
            }

            await enKategoriService.TaBortKategoriAsync(
                valdKategori.Id);

            await VisaKategorier();
            await VisaKategoriComboBoxar();

            MessageBox.Show("Kategorin har nu tagits bort");
        }

        private async void btnTilldela_Click(object sender, EventArgs e)
        {
            Podcast valdPodd = (Podcast)listBoxMinaPoddar.SelectedItem;

            Kategori valdKategori = (Kategori)comboBoxPoddKategori.SelectedItem;

            if (valdPodd == null)
            {
                MessageBox.Show("Välj en podcast");
                return;
            }

            if (valdKategori == null)
            {
                MessageBox.Show("Välj en kategori.");
                return;
            }

            await enPodcastService.AndraPodcastKategoriAsync(valdPodd.Id, valdKategori.Id);

            MessageBox.Show("Podcasten har tilldelats den valda kategorin");
        }

        //Filtrera poddar som visas efter kategori
        private async void btnVisaKategori_Click(object sender, EventArgs e)
        {
            Kategori valdKategori = (Kategori)comboBoxFilterKategori.SelectedItem;

            if (valdKategori == null)
            {
                MessageBox.Show("Välj en kategori.");
                return;
            }

            var poddar =
                await enPodcastService.HamtaPoddarForKategoriAsync(
                    valdKategori.Id);

            listBoxMinaPoddar.DataSource = null;
            listBoxMinaPoddar.DataSource = poddar;
            listBoxMinaPoddar.DisplayMember = "Namn";
        }
        //Visar återigen alla poddar i listboxen
        private async void btnVisaAlla_Click(object sender, EventArgs e)
        {
            await VisaSparadePoddar();
        }
    }
}
