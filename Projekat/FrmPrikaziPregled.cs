using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class FrmPrikaziPregled : Form
    {
        Pregled pregled;
        BindingList<StavkaPregleda> listaStavke = new BindingList<StavkaPregleda>();
        public FrmPrikaziPregled(Pregled pregled)
        {
            this.pregled = pregled;
            InitializeComponent();
        }

        private void FrmPrikaziPregled_Load(object sender, EventArgs e)
        {
            this.Text = "[Oftal k2] Klijentski program";
            if (pregled.Kontrola)
                lblKPP.Text = "Kontrolni pregled.";
            if (pregled.PrviPregled)
                lblKPP.Text = "Prvi pregled.";

            listaStavke = new BindingList<StavkaPregleda>(Komunikacija.Instance.vratiSveStavke(pregled));
            dgvStavke.DataSource = listaStavke;

            txtNalazPregled.Text = pregled.Nalaz;
            txtNapomena.Text = pregled.Napomena;
            lblDatum.Text = pregled.DatumPregleda.ToString("dd/MM/yyyy");
            lblImeDoktora.Text = "Doktor: " + Sesija.Instance.Korisnik.ToString();
            lblpacijent.Text = "Pacijent: " + pregled.Pacijent;
        }
    }
}
