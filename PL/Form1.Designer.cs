namespace PL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPageAvsnitt = new TabPage();
            rtbDetaljer = new RichTextBox();
            btnVisaDetaljer = new Button();
            listBoxValtAvsnitt = new ListBox();
            lblDetaljer = new Label();
            lblValtAvsnitt = new Label();
            comboBoxValj = new ComboBox();
            lblValjPodd = new Label();
            tabPageMinaPoddar = new TabPage();
            comboBoxFilterKategori = new ComboBox();
            label2 = new Label();
            btnVisaAlla = new Button();
            btnVisaKategori = new Button();
            btnTilldela = new Button();
            comboBoxPoddKategori = new ComboBox();
            lblPoddKategori = new Label();
            btnTaBortPodd = new Button();
            btnSparaÄndring = new Button();
            textBoxNamn = new TextBox();
            lblNamn = new Label();
            listBoxMinaPoddar = new ListBox();
            lblMinaPoddar = new Label();
            tabPageUtforska = new TabPage();
            button3 = new Button();
            btnSparaPodd = new Button();
            btnHamta = new Button();
            lblAvsnitt = new Label();
            lblPodd = new Label();
            txtBoxPodd = new TextBox();
            label1 = new Label();
            listBoxAvsnitt = new ListBox();
            txtBoxSokRss = new TextBox();
            tabControl1 = new TabControl();
            tabPageKategorier = new TabPage();
            lblKategorier = new Label();
            btnSparaAndradKategori = new Button();
            btnTaBortKategori = new Button();
            btnLaggTill = new Button();
            textBoxKategoriNamn = new TextBox();
            lblKategoriNamn = new Label();
            listBoxKategorier = new ListBox();
            tabPageAvsnitt.SuspendLayout();
            tabPageMinaPoddar.SuspendLayout();
            tabPageUtforska.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageKategorier.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageAvsnitt
            // 
            tabPageAvsnitt.Controls.Add(rtbDetaljer);
            tabPageAvsnitt.Controls.Add(btnVisaDetaljer);
            tabPageAvsnitt.Controls.Add(listBoxValtAvsnitt);
            tabPageAvsnitt.Controls.Add(lblDetaljer);
            tabPageAvsnitt.Controls.Add(lblValtAvsnitt);
            tabPageAvsnitt.Controls.Add(comboBoxValj);
            tabPageAvsnitt.Controls.Add(lblValjPodd);
            tabPageAvsnitt.Location = new Point(4, 34);
            tabPageAvsnitt.Name = "tabPageAvsnitt";
            tabPageAvsnitt.Padding = new Padding(3);
            tabPageAvsnitt.Size = new Size(791, 415);
            tabPageAvsnitt.TabIndex = 2;
            tabPageAvsnitt.Text = "Avsnitt";
            tabPageAvsnitt.UseVisualStyleBackColor = true;
            // 
            // rtbDetaljer
            // 
            rtbDetaljer.Location = new Point(396, 130);
            rtbDetaljer.Name = "rtbDetaljer";
            rtbDetaljer.Size = new Size(260, 180);
            rtbDetaljer.TabIndex = 7;
            rtbDetaljer.Text = "";
            // 
            // btnVisaDetaljer
            // 
            btnVisaDetaljer.Location = new Point(48, 370);
            btnVisaDetaljer.Name = "btnVisaDetaljer";
            btnVisaDetaljer.Size = new Size(220, 34);
            btnVisaDetaljer.TabIndex = 6;
            btnVisaDetaljer.Text = "Visa avsnittsdetaljer";
            btnVisaDetaljer.UseVisualStyleBackColor = true;
            btnVisaDetaljer.Click += btnVisaDetaljer_Click;
            // 
            // listBoxValtAvsnitt
            // 
            listBoxValtAvsnitt.FormattingEnabled = true;
            listBoxValtAvsnitt.Location = new Point(107, 131);
            listBoxValtAvsnitt.Name = "listBoxValtAvsnitt";
            listBoxValtAvsnitt.Size = new Size(260, 179);
            listBoxValtAvsnitt.TabIndex = 4;
            listBoxValtAvsnitt.SelectedIndexChanged += listBoxValtAvsnitt_SelectedIndexChanged;
            // 
            // lblDetaljer
            // 
            lblDetaljer.AutoSize = true;
            lblDetaljer.Location = new Point(396, 94);
            lblDetaljer.Name = "lblDetaljer";
            lblDetaljer.Size = new Size(137, 25);
            lblDetaljer.TabIndex = 3;
            lblDetaljer.Text = "Avsnittsdetaljer:";
            // 
            // lblValtAvsnitt
            // 
            lblValtAvsnitt.AutoSize = true;
            lblValtAvsnitt.Location = new Point(107, 94);
            lblValtAvsnitt.Name = "lblValtAvsnitt";
            lblValtAvsnitt.Size = new Size(71, 25);
            lblValtAvsnitt.TabIndex = 2;
            lblValtAvsnitt.Text = "Avsnitt:";
            // 
            // comboBoxValj
            // 
            comboBoxValj.FormattingEnabled = true;
            comboBoxValj.Location = new Point(145, 32);
            comboBoxValj.Name = "comboBoxValj";
            comboBoxValj.Size = new Size(187, 33);
            comboBoxValj.TabIndex = 1;
            comboBoxValj.SelectedIndexChanged += comboBoxValj_SelectedIndexChanged;
            // 
            // lblValjPodd
            // 
            lblValjPodd.AutoSize = true;
            lblValjPodd.Location = new Point(27, 32);
            lblValjPodd.Name = "lblValjPodd";
            lblValjPodd.Size = new Size(112, 25);
            lblValjPodd.TabIndex = 0;
            lblValjPodd.Text = "Välj podcast:";
            // 
            // tabPageMinaPoddar
            // 
            tabPageMinaPoddar.Controls.Add(comboBoxFilterKategori);
            tabPageMinaPoddar.Controls.Add(label2);
            tabPageMinaPoddar.Controls.Add(btnVisaAlla);
            tabPageMinaPoddar.Controls.Add(btnVisaKategori);
            tabPageMinaPoddar.Controls.Add(btnTilldela);
            tabPageMinaPoddar.Controls.Add(comboBoxPoddKategori);
            tabPageMinaPoddar.Controls.Add(lblPoddKategori);
            tabPageMinaPoddar.Controls.Add(btnTaBortPodd);
            tabPageMinaPoddar.Controls.Add(btnSparaÄndring);
            tabPageMinaPoddar.Controls.Add(textBoxNamn);
            tabPageMinaPoddar.Controls.Add(lblNamn);
            tabPageMinaPoddar.Controls.Add(listBoxMinaPoddar);
            tabPageMinaPoddar.Controls.Add(lblMinaPoddar);
            tabPageMinaPoddar.Location = new Point(4, 34);
            tabPageMinaPoddar.Name = "tabPageMinaPoddar";
            tabPageMinaPoddar.Padding = new Padding(3);
            tabPageMinaPoddar.Size = new Size(791, 415);
            tabPageMinaPoddar.TabIndex = 1;
            tabPageMinaPoddar.Text = "Mina Poddar";
            tabPageMinaPoddar.UseVisualStyleBackColor = true;
            // 
            // comboBoxFilterKategori
            // 
            comboBoxFilterKategori.FormattingEnabled = true;
            comboBoxFilterKategori.Location = new Point(531, 256);
            comboBoxFilterKategori.Name = "comboBoxFilterKategori";
            comboBoxFilterKategori.Size = new Size(182, 33);
            comboBoxFilterKategori.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(531, 223);
            label2.Name = "label2";
            label2.Size = new Size(176, 25);
            label2.TabIndex = 13;
            label2.Text = "Filtrera efter kategori";
            // 
            // btnVisaAlla
            // 
            btnVisaAlla.Location = new Point(567, 334);
            btnVisaAlla.Name = "btnVisaAlla";
            btnVisaAlla.Size = new Size(112, 34);
            btnVisaAlla.TabIndex = 12;
            btnVisaAlla.Text = "Visa alla";
            btnVisaAlla.UseVisualStyleBackColor = true;
            btnVisaAlla.Click += btnVisaAlla_Click;
            // 
            // btnVisaKategori
            // 
            btnVisaKategori.Location = new Point(542, 295);
            btnVisaKategori.Name = "btnVisaKategori";
            btnVisaKategori.Size = new Size(161, 33);
            btnVisaKategori.TabIndex = 11;
            btnVisaKategori.Text = "Filtrera";
            btnVisaKategori.UseVisualStyleBackColor = true;
            btnVisaKategori.Click += btnVisaKategori_Click;
            // 
            // btnTilldela
            // 
            btnTilldela.Location = new Point(542, 163);
            btnTilldela.Name = "btnTilldela";
            btnTilldela.Size = new Size(150, 34);
            btnTilldela.TabIndex = 10;
            btnTilldela.Text = "Tilldela kategori";
            btnTilldela.UseVisualStyleBackColor = true;
            btnTilldela.Click += btnTilldela_Click;
            // 
            // comboBoxPoddKategori
            // 
            comboBoxPoddKategori.FormattingEnabled = true;
            comboBoxPoddKategori.Location = new Point(531, 124);
            comboBoxPoddKategori.Name = "comboBoxPoddKategori";
            comboBoxPoddKategori.Size = new Size(182, 33);
            comboBoxPoddKategori.TabIndex = 9;
            // 
            // lblPoddKategori
            // 
            lblPoddKategori.AutoSize = true;
            lblPoddKategori.Location = new Point(552, 93);
            lblPoddKategori.Name = "lblPoddKategori";
            lblPoddKategori.Size = new Size(140, 25);
            lblPoddKategori.TabIndex = 8;
            lblPoddKategori.Text = "Tilldela kategori:";
            // 
            // btnTaBortPodd
            // 
            btnTaBortPodd.Location = new Point(340, 254);
            btnTaBortPodd.Name = "btnTaBortPodd";
            btnTaBortPodd.Size = new Size(150, 34);
            btnTaBortPodd.TabIndex = 7;
            btnTaBortPodd.Text = "Ta bort podcast";
            btnTaBortPodd.UseVisualStyleBackColor = true;
            btnTaBortPodd.Click += btnTaBortPodd_Click;
            // 
            // btnSparaÄndring
            // 
            btnSparaÄndring.Location = new Point(340, 204);
            btnSparaÄndring.Name = "btnSparaÄndring";
            btnSparaÄndring.Size = new Size(150, 34);
            btnSparaÄndring.TabIndex = 6;
            btnSparaÄndring.Text = "Ändra namn";
            btnSparaÄndring.UseVisualStyleBackColor = true;
            btnSparaÄndring.Click += btnSparaÄndring_Click;
            // 
            // textBoxNamn
            // 
            textBoxNamn.Location = new Point(328, 155);
            textBoxNamn.Name = "textBoxNamn";
            textBoxNamn.Size = new Size(169, 31);
            textBoxNamn.TabIndex = 4;
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(376, 127);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(64, 25);
            lblNamn.TabIndex = 2;
            lblNamn.Text = "Namn:";
            // 
            // listBoxMinaPoddar
            // 
            listBoxMinaPoddar.FormattingEnabled = true;
            listBoxMinaPoddar.Location = new Point(76, 93);
            listBoxMinaPoddar.Name = "listBoxMinaPoddar";
            listBoxMinaPoddar.Size = new Size(232, 254);
            listBoxMinaPoddar.TabIndex = 1;
            listBoxMinaPoddar.SelectedIndexChanged += listBoxMinaPoddar_SelectedIndexChanged;
            // 
            // lblMinaPoddar
            // 
            lblMinaPoddar.AutoSize = true;
            lblMinaPoddar.Location = new Point(129, 46);
            lblMinaPoddar.Name = "lblMinaPoddar";
            lblMinaPoddar.Size = new Size(119, 25);
            lblMinaPoddar.TabIndex = 0;
            lblMinaPoddar.Text = "Mina poddar:";
            // 
            // tabPageUtforska
            // 
            tabPageUtforska.Controls.Add(button3);
            tabPageUtforska.Controls.Add(btnSparaPodd);
            tabPageUtforska.Controls.Add(btnHamta);
            tabPageUtforska.Controls.Add(lblAvsnitt);
            tabPageUtforska.Controls.Add(lblPodd);
            tabPageUtforska.Controls.Add(txtBoxPodd);
            tabPageUtforska.Controls.Add(label1);
            tabPageUtforska.Controls.Add(listBoxAvsnitt);
            tabPageUtforska.Controls.Add(txtBoxSokRss);
            tabPageUtforska.Location = new Point(4, 34);
            tabPageUtforska.Name = "tabPageUtforska";
            tabPageUtforska.Padding = new Padding(3);
            tabPageUtforska.Size = new Size(791, 415);
            tabPageUtforska.TabIndex = 0;
            tabPageUtforska.Text = "Utforska";
            tabPageUtforska.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(619, 329);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 8;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnSparaPodd
            // 
            btnSparaPodd.Location = new Point(47, 329);
            btnSparaPodd.Name = "btnSparaPodd";
            btnSparaPodd.Size = new Size(220, 34);
            btnSparaPodd.TabIndex = 7;
            btnSparaPodd.Text = "Spara till Mina Poddar";
            btnSparaPodd.UseVisualStyleBackColor = true;
            btnSparaPodd.Click += btnSparaPodd_Click;
            // 
            // btnHamta
            // 
            btnHamta.Location = new Point(292, 45);
            btnHamta.Name = "btnHamta";
            btnHamta.Size = new Size(112, 34);
            btnHamta.TabIndex = 6;
            btnHamta.Text = "Hämta";
            btnHamta.UseVisualStyleBackColor = true;
            btnHamta.Click += btnHamta_Click;
            // 
            // lblAvsnitt
            // 
            lblAvsnitt.AutoSize = true;
            lblAvsnitt.Location = new Point(441, 91);
            lblAvsnitt.Name = "lblAvsnitt";
            lblAvsnitt.Size = new Size(71, 25);
            lblAvsnitt.TabIndex = 5;
            lblAvsnitt.Text = "Avsnitt:";
            // 
            // lblPodd
            // 
            lblPodd.AutoSize = true;
            lblPodd.Location = new Point(82, 91);
            lblPodd.Name = "lblPodd";
            lblPodd.Size = new Size(78, 25);
            lblPodd.TabIndex = 4;
            lblPodd.Text = "Podcast:";
            // 
            // txtBoxPodd
            // 
            txtBoxPodd.Location = new Point(82, 129);
            txtBoxPodd.Name = "txtBoxPodd";
            txtBoxPodd.Size = new Size(204, 31);
            txtBoxPodd.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 19);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 2;
            label1.Text = "Sök efter Podd (rss):";
            // 
            // listBoxAvsnitt
            // 
            listBoxAvsnitt.FormattingEnabled = true;
            listBoxAvsnitt.Location = new Point(360, 129);
            listBoxAvsnitt.Name = "listBoxAvsnitt";
            listBoxAvsnitt.Size = new Size(240, 229);
            listBoxAvsnitt.TabIndex = 1;
            // 
            // txtBoxSokRss
            // 
            txtBoxSokRss.Location = new Point(82, 47);
            txtBoxSokRss.Name = "txtBoxSokRss";
            txtBoxSokRss.Size = new Size(204, 31);
            txtBoxSokRss.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageUtforska);
            tabControl1.Controls.Add(tabPageMinaPoddar);
            tabControl1.Controls.Add(tabPageAvsnitt);
            tabControl1.Controls.Add(tabPageKategorier);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(799, 453);
            tabControl1.TabIndex = 0;
            // 
            // tabPageKategorier
            // 
            tabPageKategorier.Controls.Add(lblKategorier);
            tabPageKategorier.Controls.Add(btnSparaAndradKategori);
            tabPageKategorier.Controls.Add(btnTaBortKategori);
            tabPageKategorier.Controls.Add(btnLaggTill);
            tabPageKategorier.Controls.Add(textBoxKategoriNamn);
            tabPageKategorier.Controls.Add(lblKategoriNamn);
            tabPageKategorier.Controls.Add(listBoxKategorier);
            tabPageKategorier.Location = new Point(4, 34);
            tabPageKategorier.Name = "tabPageKategorier";
            tabPageKategorier.Padding = new Padding(3);
            tabPageKategorier.Size = new Size(791, 415);
            tabPageKategorier.TabIndex = 3;
            tabPageKategorier.Text = "Kategorier";
            tabPageKategorier.UseVisualStyleBackColor = true;
            // 
            // lblKategorier
            // 
            lblKategorier.AutoSize = true;
            lblKategorier.Location = new Point(177, 73);
            lblKategorier.Name = "lblKategorier";
            lblKategorier.Size = new Size(93, 25);
            lblKategorier.TabIndex = 7;
            lblKategorier.Text = "Kategorier";
            // 
            // btnSparaAndradKategori
            // 
            btnSparaAndradKategori.Location = new Point(491, 210);
            btnSparaAndradKategori.Name = "btnSparaAndradKategori";
            btnSparaAndradKategori.Size = new Size(181, 34);
            btnSparaAndradKategori.TabIndex = 6;
            btnSparaAndradKategori.Text = "Ändra namn";
            btnSparaAndradKategori.UseVisualStyleBackColor = true;
            btnSparaAndradKategori.Click += btnSparaAndradKategori_Click;
            // 
            // btnTaBortKategori
            // 
            btnTaBortKategori.Location = new Point(491, 311);
            btnTaBortKategori.Name = "btnTaBortKategori";
            btnTaBortKategori.Size = new Size(181, 34);
            btnTaBortKategori.TabIndex = 5;
            btnTaBortKategori.Text = "Ta bort";
            btnTaBortKategori.UseVisualStyleBackColor = true;
            btnTaBortKategori.Click += btnTaBortKategori_Click;
            // 
            // btnLaggTill
            // 
            btnLaggTill.Location = new Point(491, 260);
            btnLaggTill.Name = "btnLaggTill";
            btnLaggTill.Size = new Size(181, 34);
            btnLaggTill.TabIndex = 4;
            btnLaggTill.Text = "Lägg till";
            btnLaggTill.UseVisualStyleBackColor = true;
            btnLaggTill.Click += btnLaggTill_Click;
            // 
            // textBoxKategoriNamn
            // 
            textBoxKategoriNamn.Location = new Point(491, 118);
            textBoxKategoriNamn.Name = "textBoxKategoriNamn";
            textBoxKategoriNamn.Size = new Size(181, 31);
            textBoxKategoriNamn.TabIndex = 3;
            // 
            // lblKategoriNamn
            // 
            lblKategoriNamn.AutoSize = true;
            lblKategoriNamn.Location = new Point(548, 90);
            lblKategoriNamn.Name = "lblKategoriNamn";
            lblKategoriNamn.Size = new Size(64, 25);
            lblKategoriNamn.TabIndex = 2;
            lblKategoriNamn.Text = "Namn:";
            // 
            // listBoxKategorier
            // 
            listBoxKategorier.FormattingEnabled = true;
            listBoxKategorier.Location = new Point(134, 118);
            listBoxKategorier.Name = "listBoxKategorier";
            listBoxKategorier.Size = new Size(196, 204);
            listBoxKategorier.TabIndex = 1;
            listBoxKategorier.SelectedIndexChanged += listBoxKategorier_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabPageAvsnitt.ResumeLayout(false);
            tabPageAvsnitt.PerformLayout();
            tabPageMinaPoddar.ResumeLayout(false);
            tabPageMinaPoddar.PerformLayout();
            tabPageUtforska.ResumeLayout(false);
            tabPageUtforska.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageKategorier.ResumeLayout(false);
            tabPageKategorier.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPageAvsnitt;
        private TabPage tabPageMinaPoddar;
        private TabPage tabPageUtforska;
        private Label label1;
        private ListBox listBoxAvsnitt;
        private TextBox txtBoxSokRss;
        private TabControl tabControl1;
        private Label lblAvsnitt;
        private Label lblPodd;
        private TextBox txtBoxPodd;
        private Button button3;
        private Button btnSparaPodd;
        private Button btnHamta;
        private Label lblValtAvsnitt;
        private ComboBox comboBoxValj;
        private Label lblValjPodd;
        private Label lblDetaljer;
        private Button btnVisaDetaljer;
        private ListBox listBoxValtAvsnitt;
        private RichTextBox rtbDetaljer;
        private Label lblMinaPoddar;
        private ListBox listBoxMinaPoddar;
        private Label lblNamn;
        private TextBox textBoxNamn;
        private Button btnTaBortPodd;
        private Button btnSparaÄndring;
        private TabPage tabPageKategorier;
        private Button btnSparaAndradKategori;
        private Button btnTaBortKategori;
        private Button btnLaggTill;
        private TextBox textBoxKategoriNamn;
        private Label lblKategoriNamn;
        private ListBox listBoxKategorier;
        private Label lblKategorier;
        private Label lblPoddKategori;
        private Button btnTilldela;
        private ComboBox comboBoxPoddKategori;
        private Button btnVisaKategori;
        private ComboBox comboBoxFilterKategori;
        private Label label2;
        private Button btnVisaAlla;
    }
}
