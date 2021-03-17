using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;

namespace Projekat
{
    public partial class FrmUnosPregleda : Form
    {
        private Karton karton;
        
        BindingList<StavkaPregleda> listaStavke = new BindingList<StavkaPregleda>();

        public FrmUnosPregleda()
        {
            InitializeComponent();
        }

        public FrmUnosPregleda(Karton k)
        {
            this.karton = k;
            InitializeComponent();
        }

        private void FrmUnosPregleda_Load(object sender, EventArgs e)
        {
            this.Text = "[Oftal k2] Klijentski program";
            txtSifraKartona.Text = karton.SifraKartona.ToString();
            txtJMBG.Text = karton.Jmbg;
            txtIme.Text = karton.ImeIPrezime;
            txtDatumRodjenja.Text = karton.DatumRodjenja.ToString("dd/MM/yyyy");
            lblImeDoktora.Text = "Doktor: " + Sesija.Instance.Korisnik.ToString();
            
            cmbDijagnoza.DataSource = new BindingList<Dijagnoza>((List<Dijagnoza>)Komunikacija.Instance.VratiSveDijagnoze()); 
            cmbDijagnoza.Text = "Izaberite dijagnozu";
            dgvStavke.DataSource = listaStavke;
        }

        private void BtnDodajStavku_Click(object sender, EventArgs e)
        {
            gbrStavkaPregleda.Visible = true;
            this.Refresh();
        }

        private Pregled VratiPregled()
        {
            bool validacija = true;
            Pregled pregled = new Pregled();
            Doktor d = vratiDoktora(Sesija.Instance.Korisnik.ToString());
            if (d == null)
            {
                MyMessageBox.Instance.Show("Greska u sistemu.");
                this.Close();
            }
            pregled.Doktor = d;
            pregled.Karton = karton;
            if (string.IsNullOrEmpty(txtNalazPregled.Text))
            {
                txtNalazPregled.BackColor = Color.LightCoral;
                validacija = false;
            }
            else
            {
                pregled.Nalaz = txtNalazPregled.Text;
            }
            if (string.IsNullOrEmpty(txtNapomena.Text))
            {
                txtNapomena.BackColor = Color.LightCoral;
                validacija = false;
            }
            else
            {
                pregled.Napomena = txtNapomena.Text;
            }

            if ((chbKontrola.Checked == false && chbPrviPregled.Checked == false) || (chbKontrola.Checked == true && chbPrviPregled.Checked == true))
            {
                chbKontrola.Focus();
                chbPrviPregled.Focus();
                MyMessageBox.Instance.Show("Morate odabrati jednu vrednost:\n kontrola ili prvi pregled!");
                validacija = false;
            }
            else
            {
                if (chbKontrola.Checked == true)
                {
                    pregled.Kontrola = true;
                }
                else if(chbPrviPregled.Checked == true)
                {
                    pregled.PrviPregled = true;
                }
                else
                {
                    pregled.Kontrola = false;
                    pregled.PrviPregled = false;
                }
            }


            if (validacija)
            {
                return pregled;
            }
            else
            {
                return null;
            }
        }

        private StavkaPregleda VratiStavku()
        {
            bool validacija = true;
            StavkaPregleda stavka = new StavkaPregleda();

            
            if (cmbDijagnoza.SelectedItem != null)
            {
                if (string.IsNullOrEmpty(txtNalazStavka.Text))
                {
                    txtNalazStavka.BackColor = Color.LightCoral;
                    validacija = false;
                }
                else
                {
                    stavka.Nalaz = txtNalazStavka.Text;
                }
                if (string.IsNullOrEmpty(txtNapomenaStavka.Text))
                {
                    txtNapomenaStavka.BackColor = Color.LightCoral;
                    validacija = false;
                }
                else
                {
                    stavka.Napomena = txtNapomenaStavka.Text;
                }
            }
            else
            {
                cmbDijagnoza.Focus();
                MyMessageBox.Instance.Show("Odaberite dijagnozu!");
                validacija = false;
                
            }
            if (validacija)
            {
                return stavka;
            }
            else
            {
                return null;
            }
        }

        private Doktor vratiDoktora(string v)
        {
            List<Doktor> listaDoktora = Komunikacija.Instance.VratiSveDoktoreSortirano();
            foreach (Doktor d in listaDoktora)
            {
                if (d.ToString().Equals(v))
                    return d;
            }
            return null;
        }

        private void BtnSacuvajPregled_Click(object sender, EventArgs e)
        {
            Pregled pregled = VratiPregled();
            if (pregled == null)
            {
                MyMessageBox.Instance.Show("Neispravan unos podataka.");
                return;
            }

            foreach (StavkaPregleda stavka in listaStavke)
            {
                pregled.ListaStavki.Add(stavka);
            }
            
          
            Pregled izmena = Komunikacija.Instance.SacuvajPregled(pregled);

            if (izmena != null)
            {
                MyMessageBox.Instance.Show($"Pregled pacijenta\n {pregled.Karton.ImeIPrezime}\n je sacuvan");

                return;
            }
            else
            {
                MyMessageBox.Instance.Show($"Greska! \nPregled pacijenta {pregled.Karton.ImeIPrezime}\n nije mogao biti sacuvan");
                return;
            }  
            
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            StavkaPregleda stavka = VratiStavku();
            if (stavka != null)
            {               
                stavka.RbStavke = listaStavke.Count + 1;
                stavka.Dijagnoza = (Dijagnoza)cmbDijagnoza.SelectedItem;
                listaStavke.Add(stavka);
                dgvStavke.Refresh();
            }
        }

        private void BtnObrisiStavku_Click(object sender, EventArgs e)
        {
            if (dgvStavke.SelectedRows.Count > 0)
            {
                listaStavke.Remove((StavkaPregleda)dgvStavke.CurrentRow.DataBoundItem);                
            }
        }

    }
}
