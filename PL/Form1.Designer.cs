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
            tabPage3 = new TabPage();
            rtbDetaljer = new RichTextBox();
            btnVisaDetaljer = new Button();
            listBoxValtAvsnitt = new ListBox();
            lblDetaljer = new Label();
            lblValtAvsnitt = new Label();
            comboBoxValj = new ComboBox();
            lblValjPodd = new Label();
            tabPage2 = new TabPage();
            btnTaBortPodd = new Button();
            btnSparaÄndring = new Button();
            comboBoxKategori = new ComboBox();
            textBoxNamn = new TextBox();
            lblKategori = new Label();
            lblNamn = new Label();
            listBoxMinaPoddar = new ListBox();
            lblMinaPoddar = new Label();
            tabPage1 = new TabPage();
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
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(rtbDetaljer);
            tabPage3.Controls.Add(btnVisaDetaljer);
            tabPage3.Controls.Add(listBoxValtAvsnitt);
            tabPage3.Controls.Add(lblDetaljer);
            tabPage3.Controls.Add(lblValtAvsnitt);
            tabPage3.Controls.Add(comboBoxValj);
            tabPage3.Controls.Add(lblValjPodd);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(791, 415);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Avsnitt";
            tabPage3.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            tabPage2.Controls.Add(btnTaBortPodd);
            tabPage2.Controls.Add(btnSparaÄndring);
            tabPage2.Controls.Add(comboBoxKategori);
            tabPage2.Controls.Add(textBoxNamn);
            tabPage2.Controls.Add(lblKategori);
            tabPage2.Controls.Add(lblNamn);
            tabPage2.Controls.Add(listBoxMinaPoddar);
            tabPage2.Controls.Add(lblMinaPoddar);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(791, 415);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mina Poddar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnTaBortPodd
            // 
            btnTaBortPodd.Location = new Point(616, 313);
            btnTaBortPodd.Name = "btnTaBortPodd";
            btnTaBortPodd.Size = new Size(150, 34);
            btnTaBortPodd.TabIndex = 7;
            btnTaBortPodd.Text = "Ta bort podcast";
            btnTaBortPodd.UseVisualStyleBackColor = true;
            btnTaBortPodd.Click += btnTaBortPodd_Click;
            // 
            // btnSparaÄndring
            // 
            btnSparaÄndring.Location = new Point(460, 313);
            btnSparaÄndring.Name = "btnSparaÄndring";
            btnSparaÄndring.Size = new Size(150, 34);
            btnSparaÄndring.TabIndex = 6;
            btnSparaÄndring.Text = "Spara ändringar";
            btnSparaÄndring.UseVisualStyleBackColor = true;
            // 
            // comboBoxKategori
            // 
            comboBoxKategori.FormattingEnabled = true;
            comboBoxKategori.Location = new Point(518, 186);
            comboBoxKategori.Name = "comboBoxKategori";
            comboBoxKategori.Size = new Size(182, 33);
            comboBoxKategori.TabIndex = 5;
            // 
            // textBoxNamn
            // 
            textBoxNamn.Location = new Point(518, 109);
            textBoxNamn.Name = "textBoxNamn";
            textBoxNamn.Size = new Size(182, 31);
            textBoxNamn.TabIndex = 4;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(566, 158);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(82, 25);
            lblKategori.TabIndex = 3;
            lblKategori.Text = "Kategori:";
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(566, 81);
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
            // tabPage1
            // 
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(btnSparaPodd);
            tabPage1.Controls.Add(btnHamta);
            tabPage1.Controls.Add(lblAvsnitt);
            tabPage1.Controls.Add(lblPodd);
            tabPage1.Controls.Add(txtBoxPodd);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(listBoxAvsnitt);
            tabPage1.Controls.Add(txtBoxSokRss);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(791, 415);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Utforska";
            tabPage1.UseVisualStyleBackColor = true;
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
            lblAvsnitt.Location = new Point(360, 91);
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
            listBoxAvsnitt.Size = new Size(208, 129);
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
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(799, 453);
            tabControl1.TabIndex = 0;
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
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage3;
        private TabPage tabPage2;
        private TabPage tabPage1;
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
        private Label lblKategori;
        private Label lblNamn;
        private ComboBox comboBoxKategori;
        private TextBox textBoxNamn;
        private Button btnTaBortPodd;
        private Button btnSparaÄndring;
    }
}
