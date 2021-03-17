namespace Projekat
{
    partial class FrmUnosPregleda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbrPregled = new System.Windows.Forms.GroupBox();
            this.txtNalazPregled = new System.Windows.Forms.TextBox();
            this.chbPrviPregled = new System.Windows.Forms.CheckBox();
            this.chbKontrola = new System.Windows.Forms.CheckBox();
            this.lblNalaz = new System.Windows.Forms.Label();
            this.lblImeDoktora = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSifraKartona = new System.Windows.Forms.TextBox();
            this.lblSifraKartona = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.txtDatumRodjenja = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.lblJMBG = new System.Windows.Forms.Label();
            this.gbrStavkaPregleda = new System.Windows.Forms.GroupBox();
            this.txtNalazStavka = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cmbDijagnoza = new System.Windows.Forms.ComboBox();
            this.lblDijagnoza = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNapomenaStavka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSacuvajPregled = new System.Windows.Forms.Button();
            this.gbrPregled.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbrStavkaPregleda.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbrPregled
            // 
            this.gbrPregled.Controls.Add(this.txtNalazPregled);
            this.gbrPregled.Controls.Add(this.chbPrviPregled);
            this.gbrPregled.Controls.Add(this.chbKontrola);
            this.gbrPregled.Controls.Add(this.lblNalaz);
            this.gbrPregled.Controls.Add(this.lblImeDoktora);
            this.gbrPregled.Controls.Add(this.txtNapomena);
            this.gbrPregled.Controls.Add(this.lblNapomena);
            this.gbrPregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrPregled.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbrPregled.Location = new System.Drawing.Point(12, 3);
            this.gbrPregled.Name = "gbrPregled";
            this.gbrPregled.Size = new System.Drawing.Size(585, 258);
            this.gbrPregled.TabIndex = 28;
            this.gbrPregled.TabStop = false;
            this.gbrPregled.Text = "Pregled:";
            // 
            // txtNalazPregled
            // 
            this.txtNalazPregled.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNalazPregled.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNalazPregled.ForeColor = System.Drawing.Color.DimGray;
            this.txtNalazPregled.Location = new System.Drawing.Point(127, 15);
            this.txtNalazPregled.Multiline = true;
            this.txtNalazPregled.Name = "txtNalazPregled";
            this.txtNalazPregled.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNalazPregled.Size = new System.Drawing.Size(441, 90);
            this.txtNalazPregled.TabIndex = 30;
            // 
            // chbPrviPregled
            // 
            this.chbPrviPregled.AutoSize = true;
            this.chbPrviPregled.Location = new System.Drawing.Point(174, 208);
            this.chbPrviPregled.Name = "chbPrviPregled";
            this.chbPrviPregled.Size = new System.Drawing.Size(119, 22);
            this.chbPrviPregled.TabIndex = 29;
            this.chbPrviPregled.Text = "Prvi pregled";
            this.chbPrviPregled.UseVisualStyleBackColor = true;
            // 
            // chbKontrola
            // 
            this.chbKontrola.AutoSize = true;
            this.chbKontrola.Location = new System.Drawing.Point(9, 208);
            this.chbKontrola.Name = "chbKontrola";
            this.chbKontrola.Size = new System.Drawing.Size(94, 22);
            this.chbKontrola.TabIndex = 28;
            this.chbKontrola.Text = "Kontrola";
            this.chbKontrola.UseVisualStyleBackColor = true;
            // 
            // lblNalaz
            // 
            this.lblNalaz.AutoSize = true;
            this.lblNalaz.Location = new System.Drawing.Point(15, 18);
            this.lblNalaz.Name = "lblNalaz";
            this.lblNalaz.Size = new System.Drawing.Size(56, 18);
            this.lblNalaz.TabIndex = 26;
            this.lblNalaz.Text = "Nalaz:";
            // 
            // lblImeDoktora
            // 
            this.lblImeDoktora.AutoSize = true;
            this.lblImeDoktora.Location = new System.Drawing.Point(395, 230);
            this.lblImeDoktora.Name = "lblImeDoktora";
            this.lblImeDoktora.Size = new System.Drawing.Size(172, 18);
            this.lblImeDoktora.TabIndex = 22;
            this.lblImeDoktora.Text = "Ime i prezime doktora";
            // 
            // txtNapomena
            // 
            this.txtNapomena.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNapomena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNapomena.ForeColor = System.Drawing.Color.DimGray;
            this.txtNapomena.Location = new System.Drawing.Point(127, 114);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNapomena.Size = new System.Drawing.Size(441, 90);
            this.txtNapomena.TabIndex = 21;
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(15, 111);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(94, 18);
            this.lblNapomena.TabIndex = 20;
            this.lblNapomena.Text = "Napomena:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDodajStavku);
            this.groupBox3.Controls.Add(this.btnObrisiStavku);
            this.groupBox3.Controls.Add(this.dgvStavke);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Location = new System.Drawing.Point(12, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(585, 240);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista stavki";
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.ForeColor = System.Drawing.Color.White;
            this.btnDodajStavku.Location = new System.Drawing.Point(141, 175);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(121, 47);
            this.btnDodajStavku.TabIndex = 3;
            this.btnDodajStavku.Text = "Dodaj Stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.BtnDodajStavku_Click);
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.ForeColor = System.Drawing.Color.White;
            this.btnObrisiStavku.Location = new System.Drawing.Point(6, 175);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(129, 47);
            this.btnObrisiStavku.TabIndex = 1;
            this.btnObrisiStavku.Text = "Obriši Stavku";
            this.btnObrisiStavku.UseVisualStyleBackColor = true;
            this.btnObrisiStavku.Click += new System.EventHandler(this.BtnObrisiStavku_Click);
            // 
            // dgvStavke
            // 
            this.dgvStavke.AllowUserToAddRows = false;
            this.dgvStavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavke.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvStavke.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStavke.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStavke.Location = new System.Drawing.Point(11, 21);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.RowHeadersWidth = 51;
            this.dgvStavke.RowTemplate.Height = 24;
            this.dgvStavke.Size = new System.Drawing.Size(556, 138);
            this.dgvStavke.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSifraKartona);
            this.groupBox1.Controls.Add(this.lblSifraKartona);
            this.groupBox1.Controls.Add(this.lblDatumRodjenja);
            this.groupBox1.Controls.Add(this.txtDatumRodjenja);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.lblIme);
            this.groupBox1.Controls.Add(this.txtJMBG);
            this.groupBox1.Controls.Add(this.lblJMBG);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Location = new System.Drawing.Point(615, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 172);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Karton:";
            // 
            // txtSifraKartona
            // 
            this.txtSifraKartona.BackColor = System.Drawing.Color.White;
            this.txtSifraKartona.Enabled = false;
            this.txtSifraKartona.ForeColor = System.Drawing.Color.NavajoWhite;
            this.txtSifraKartona.Location = new System.Drawing.Point(188, 16);
            this.txtSifraKartona.Name = "txtSifraKartona";
            this.txtSifraKartona.ReadOnly = true;
            this.txtSifraKartona.Size = new System.Drawing.Size(355, 24);
            this.txtSifraKartona.TabIndex = 27;
            this.txtSifraKartona.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSifraKartona
            // 
            this.lblSifraKartona.AutoSize = true;
            this.lblSifraKartona.Location = new System.Drawing.Point(72, 19);
            this.lblSifraKartona.Name = "lblSifraKartona";
            this.lblSifraKartona.Size = new System.Drawing.Size(110, 18);
            this.lblSifraKartona.TabIndex = 26;
            this.lblSifraKartona.Text = "Sifra kartona:";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(59, 132);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(123, 18);
            this.lblDatumRodjenja.TabIndex = 25;
            this.lblDatumRodjenja.Text = "Datum rođenja:";
            // 
            // txtDatumRodjenja
            // 
            this.txtDatumRodjenja.BackColor = System.Drawing.Color.White;
            this.txtDatumRodjenja.Enabled = false;
            this.txtDatumRodjenja.ForeColor = System.Drawing.Color.NavajoWhite;
            this.txtDatumRodjenja.Location = new System.Drawing.Point(188, 129);
            this.txtDatumRodjenja.Name = "txtDatumRodjenja";
            this.txtDatumRodjenja.ReadOnly = true;
            this.txtDatumRodjenja.Size = new System.Drawing.Size(355, 24);
            this.txtDatumRodjenja.TabIndex = 24;
            this.txtDatumRodjenja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.Color.White;
            this.txtIme.Enabled = false;
            this.txtIme.ForeColor = System.Drawing.Color.NavajoWhite;
            this.txtIme.Location = new System.Drawing.Point(188, 89);
            this.txtIme.Multiline = true;
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(355, 22);
            this.txtIme.TabIndex = 23;
            this.txtIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(6, 93);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(186, 18);
            this.lblIme.TabIndex = 22;
            this.lblIme.Text = "Ime i prezime pacijenta:";
            // 
            // txtJMBG
            // 
            this.txtJMBG.BackColor = System.Drawing.Color.White;
            this.txtJMBG.Enabled = false;
            this.txtJMBG.ForeColor = System.Drawing.Color.NavajoWhite;
            this.txtJMBG.Location = new System.Drawing.Point(188, 49);
            this.txtJMBG.Multiline = true;
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.ReadOnly = true;
            this.txtJMBG.Size = new System.Drawing.Size(355, 22);
            this.txtJMBG.TabIndex = 21;
            this.txtJMBG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblJMBG
            // 
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.Location = new System.Drawing.Point(81, 54);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(101, 18);
            this.lblJMBG.TabIndex = 20;
            this.lblJMBG.Text = "Matični broj:";
            // 
            // gbrStavkaPregleda
            // 
            this.gbrStavkaPregleda.Controls.Add(this.txtNalazStavka);
            this.gbrStavkaPregleda.Controls.Add(this.btnDodaj);
            this.gbrStavkaPregleda.Controls.Add(this.cmbDijagnoza);
            this.gbrStavkaPregleda.Controls.Add(this.lblDijagnoza);
            this.gbrStavkaPregleda.Controls.Add(this.label1);
            this.gbrStavkaPregleda.Controls.Add(this.txtNapomenaStavka);
            this.gbrStavkaPregleda.Controls.Add(this.label3);
            this.gbrStavkaPregleda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrStavkaPregleda.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbrStavkaPregleda.Location = new System.Drawing.Point(615, 181);
            this.gbrStavkaPregleda.Name = "gbrStavkaPregleda";
            this.gbrStavkaPregleda.Size = new System.Drawing.Size(549, 326);
            this.gbrStavkaPregleda.TabIndex = 32;
            this.gbrStavkaPregleda.TabStop = false;
            this.gbrStavkaPregleda.Text = "Stavka pregleda:";
            this.gbrStavkaPregleda.Visible = false;
            // 
            // txtNalazStavka
            // 
            this.txtNalazStavka.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNalazStavka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNalazStavka.ForeColor = System.Drawing.Color.DimGray;
            this.txtNalazStavka.Location = new System.Drawing.Point(115, 31);
            this.txtNalazStavka.Multiline = true;
            this.txtNalazStavka.Name = "txtNalazStavka";
            this.txtNalazStavka.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNalazStavka.Size = new System.Drawing.Size(426, 86);
            this.txtNalazStavka.TabIndex = 32;
            // 
            // btnDodaj
            // 
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(260, 256);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(200, 54);
            this.btnDodaj.TabIndex = 31;
            this.btnDodaj.Text = "Dodaj stavku";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // cmbDijagnoza
            // 
            this.cmbDijagnoza.BackColor = System.Drawing.Color.Gainsboro;
            this.cmbDijagnoza.ForeColor = System.Drawing.Color.DimGray;
            this.cmbDijagnoza.FormattingEnabled = true;
            this.cmbDijagnoza.Location = new System.Drawing.Point(115, 226);
            this.cmbDijagnoza.Name = "cmbDijagnoza";
            this.cmbDijagnoza.Size = new System.Drawing.Size(426, 26);
            this.cmbDijagnoza.TabIndex = 30;
            // 
            // lblDijagnoza
            // 
            this.lblDijagnoza.AutoSize = true;
            this.lblDijagnoza.Location = new System.Drawing.Point(21, 229);
            this.lblDijagnoza.Name = "lblDijagnoza";
            this.lblDijagnoza.Size = new System.Drawing.Size(88, 18);
            this.lblDijagnoza.TabIndex = 29;
            this.lblDijagnoza.Text = "Dijagnoza:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nalaz:";
            // 
            // txtNapomenaStavka
            // 
            this.txtNapomenaStavka.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNapomenaStavka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNapomenaStavka.ForeColor = System.Drawing.Color.DimGray;
            this.txtNapomenaStavka.Location = new System.Drawing.Point(115, 124);
            this.txtNapomenaStavka.Multiline = true;
            this.txtNapomenaStavka.Name = "txtNapomenaStavka";
            this.txtNapomenaStavka.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNapomenaStavka.Size = new System.Drawing.Size(427, 96);
            this.txtNapomenaStavka.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Napomena:";
            // 
            // btnSacuvajPregled
            // 
            this.btnSacuvajPregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajPregled.ForeColor = System.Drawing.Color.White;
            this.btnSacuvajPregled.Location = new System.Drawing.Point(449, 513);
            this.btnSacuvajPregled.Name = "btnSacuvajPregled";
            this.btnSacuvajPregled.Size = new System.Drawing.Size(320, 44);
            this.btnSacuvajPregled.TabIndex = 4;
            this.btnSacuvajPregled.Text = "Sačuvaj Pregled";
            this.btnSacuvajPregled.UseVisualStyleBackColor = true;
            this.btnSacuvajPregled.Click += new System.EventHandler(this.BtnSacuvajPregled_Click);
            // 
            // FrmUnosPregleda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1169, 559);
            this.Controls.Add(this.btnSacuvajPregled);
            this.Controls.Add(this.gbrStavkaPregleda);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbrPregled);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmUnosPregleda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos Pregleda";
            this.Load += new System.EventHandler(this.FrmUnosPregleda_Load);
            this.gbrPregled.ResumeLayout(false);
            this.gbrPregled.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbrStavkaPregleda.ResumeLayout(false);
            this.gbrStavkaPregleda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbrPregled;
        private System.Windows.Forms.Label lblNalaz;
        private System.Windows.Forms.Label lblImeDoktora;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.CheckBox chbPrviPregled;
        private System.Windows.Forms.CheckBox chbKontrola;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSifraKartona;
        private System.Windows.Forms.Label lblSifraKartona;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.TextBox txtDatumRodjenja;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.GroupBox gbrStavkaPregleda;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cmbDijagnoza;
        private System.Windows.Forms.Label lblDijagnoza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNapomenaStavka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNalazPregled;
        private System.Windows.Forms.TextBox txtNalazStavka;
        private System.Windows.Forms.Button btnSacuvajPregled;
        private System.Windows.Forms.Button btnObrisiStavku;
    }
}