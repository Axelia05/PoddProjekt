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
            btnVisaDetaljer = new Button();
            listBoxValtAvsnitt = new ListBox();
            lblDetaljer = new Label();
            lblValtAvsnitt = new Label();
            comboBoxValj = new ComboBox();
            lblValjPodd = new Label();
            tabPage2 = new TabPage();
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
            rtbDetaljer = new RichTextBox();
            tabPage3.SuspendLayout();
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
            // btnVisaDetaljer
            // 
            btnVisaDetaljer.Location = new Point(48, 370);
            btnVisaDetaljer.Name = "btnVisaDetaljer";
            btnVisaDetaljer.Size = new Size(220, 34);
            btnVisaDetaljer.TabIndex = 6;
            btnVisaDetaljer.Text = "Visa avsnittsdetaljer";
            btnVisaDetaljer.UseVisualStyleBackColor = true;
            btnVisaDetaljer.Click += button1_Click;
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
            lblValtAvsnitt.Click += label2_Click;
            // 
            // comboBoxValj
            // 
            comboBoxValj.FormattingEnabled = true;
            comboBoxValj.Location = new Point(145, 32);
            comboBoxValj.Name = "comboBoxValj";
            comboBoxValj.Size = new Size(187, 33);
            comboBoxValj.TabIndex = 1;
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
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(791, 415);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mina Poddar";
            tabPage2.UseVisualStyleBackColor = true;
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
            // rtbDetaljer
            // 
            rtbDetaljer.Location = new Point(396, 130);
            rtbDetaljer.Name = "rtbDetaljer";
            rtbDetaljer.Size = new Size(260, 180);
            rtbDetaljer.TabIndex = 7;
            rtbDetaljer.Text = "";
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
    }
}
