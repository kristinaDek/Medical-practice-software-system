namespace Projekat
{
    partial class FrmIzmeniKarton
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltekst = new System.Windows.Forms.Label();
            this.txtSifraKartona = new System.Windows.Forms.TextBox();
            this.lblSifraKartona = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.txtdatum = new System.Windows.Forms.TextBox();
            this.txtiip = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtjmbg = new System.Windows.Forms.TextBox();
            this.lblJMBG = new System.Windows.Forms.Label();
            this.btnZapamtiIzmene = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltekst);
            this.groupBox1.Controls.Add(this.txtSifraKartona);
            this.groupBox1.Controls.Add(this.lblSifraKartona);
            this.groupBox1.Controls.Add(this.lblDatumRodjenja);
            this.groupBox1.Controls.Add(this.txtdatum);
            this.groupBox1.Controls.Add(this.txtiip);
            this.groupBox1.Controls.Add(this.lblIme);
            this.groupBox1.Controls.Add(this.txtjmbg);
            this.groupBox1.Controls.Add(this.lblJMBG);
            this.groupBox1.Controls.Add(this.btnZapamtiIzmene);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 390);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o pacijentu";
            // 
            // lbltekst
            // 
            this.lbltekst.AutoSize = true;
            this.lbltekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltekst.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lbltekst.Location = new System.Drawing.Point(353, 216);
            this.lbltekst.Name = "lbltekst";
            this.lbltekst.Size = new System.Drawing.Size(180, 20);
            this.lbltekst.TabIndex = 20;
            this.lbltekst.Text = "*format: dd/MM/yyyy";
            this.lbltekst.Visible = false;
            // 
            // txtSifraKartona
            // 
            this.txtSifraKartona.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSifraKartona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifraKartona.Enabled = false;
            this.txtSifraKartona.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.txtSifraKartona.Location = new System.Drawing.Point(211, 69);
            this.txtSifraKartona.Name = "txtSifraKartona";
            this.txtSifraKartona.ReadOnly = true;
            this.txtSifraKartona.Size = new System.Drawing.Size(322, 24);
            this.txtSifraKartona.TabIndex = 19;
            this.txtSifraKartona.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSifraKartona
            // 
            this.lblSifraKartona.AutoSize = true;
            this.lblSifraKartona.Location = new System.Drawing.Point(94, 71);
            this.lblSifraKartona.Name = "lblSifraKartona";
            this.lblSifraKartona.Size = new System.Drawing.Size(110, 18);
            this.lblSifraKartona.TabIndex = 18;
            this.lblSifraKartona.Text = "Sifra kartona:";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(81, 191);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(123, 18);
            this.lblDatumRodjenja.TabIndex = 17;
            this.lblDatumRodjenja.Text = "Datum rođenja:";
            // 
            // txtdatum
            // 
            this.txtdatum.BackColor = System.Drawing.Color.Gainsboro;
            this.txtdatum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdatum.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.txtdatum.Location = new System.Drawing.Point(211, 189);
            this.txtdatum.Name = "txtdatum";
            this.txtdatum.Size = new System.Drawing.Size(322, 24);
            this.txtdatum.TabIndex = 16;
            // 
            // txtiip
            // 
            this.txtiip.BackColor = System.Drawing.Color.Gainsboro;
            this.txtiip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtiip.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.txtiip.Location = new System.Drawing.Point(211, 145);
            this.txtiip.Multiline = true;
            this.txtiip.Name = "txtiip";
            this.txtiip.Size = new System.Drawing.Size(322, 23);
            this.txtiip.TabIndex = 13;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(18, 150);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(186, 18);
            this.lblIme.TabIndex = 12;
            this.lblIme.Text = "Ime i prezime pacijenta:";
            // 
            // txtjmbg
            // 
            this.txtjmbg.BackColor = System.Drawing.Color.Gainsboro;
            this.txtjmbg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtjmbg.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.txtjmbg.Location = new System.Drawing.Point(211, 104);
            this.txtjmbg.Multiline = true;
            this.txtjmbg.Name = "txtjmbg";
            this.txtjmbg.Size = new System.Drawing.Size(322, 23);
            this.txtjmbg.TabIndex = 11;
            // 
            // lblJMBG
            // 
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.Location = new System.Drawing.Point(103, 110);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(101, 18);
            this.lblJMBG.TabIndex = 10;
            this.lblJMBG.Text = "Matični broj:";
            // 
            // btnZapamtiIzmene
            // 
            this.btnZapamtiIzmene.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZapamtiIzmene.ForeColor = System.Drawing.Color.White;
            this.btnZapamtiIzmene.Location = new System.Drawing.Point(127, 269);
            this.btnZapamtiIzmene.Name = "btnZapamtiIzmene";
            this.btnZapamtiIzmene.Size = new System.Drawing.Size(322, 58);
            this.btnZapamtiIzmene.TabIndex = 9;
            this.btnZapamtiIzmene.Text = "Zapamti izmene";
            this.btnZapamtiIzmene.UseVisualStyleBackColor = true;
            this.btnZapamtiIzmene.Click += new System.EventHandler(this.BtnZapamtiIzmene_Click);
            // 
            // FrmIzmeniKarton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(570, 401);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmIzmeniKarton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmena kartona";
            this.Load += new System.EventHandler(this.FrmIzmeniKarton_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSifraKartona;
        private System.Windows.Forms.Label lblSifraKartona;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.TextBox txtdatum;
        private System.Windows.Forms.TextBox txtiip;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtjmbg;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.Button btnZapamtiIzmene;
        private System.Windows.Forms.Label lbltekst;
    }
}