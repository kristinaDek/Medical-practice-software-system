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
    public partial class FrmIzmeniPregled : Form
    {
        Pregled pr;
        int broj = 0;
        BindingList<StavkaPregleda> listaStavke = new BindingList<StavkaPregleda>();
        BindingList<StavkaPregleda> listaProvera = new BindingList<StavkaPregleda>();
        public FrmIzmeniPregled(Pregled p) 
        {
            this.pr = p;
            InitializeComponent();
        }

        private void FrmIzmeniPregled_Load(object sender, EventArgs e)
        {
            this.Text = "[Oftal k2] Klijentski program";
            listaStavke = new BindingList<StavkaPregleda>(Komunikacija.Instance.vratiSveStavke(pr));
            listaProvera = new BindingList<StavkaPregleda>(Komunikacija.Instance.vratiSveStavke(pr));
            dgvStavke.DataSource = listaStavke;
            txtNalazPregled.Text = pr.Nalaz;
            txtNapomena.Text = pr.Napomena;
            if (pr.Kontrola)
                chbKontrola.Checked = true;
            if (pr.PrviPregled)
                chbPrviPregled.Checked = true;
            
            lblImeDoktora.Text = "Doktor: " + Sesija.Instance.Korisnik.ToString();
            label2.Text = "Pacijent: " + pr.Karton.ImeIPrezime;
            label4.Text = "jmbg: " + pr.Karton.Jmbg;
            label5.Text = "Broj kartona: " + pr.Karton.SifraKartona;
            label6.Text = "Godište: "+pr.Karton.DatumRodjenja.Date.Year+".";
            broj = listaStavke.Count();
        }

        private void BtnIzmeniStavku_Click(object sender, EventArgs e)
        {
            if (listaStavke.Count > 0)
            {
                gbrStavkaPregleda.Visible = true;

                StavkaPregleda sp = (StavkaPregleda)dgvStavke.CurrentRow.DataBoundItem;
                txtNalazStavka.Text = sp.Nalaz;
                txtNapomenaStavka.Text = sp.Napomena;

                cmbDijagnoza.DataSource = Komunikacija.Instance.VratiSveDijagnoze();
                if (vratiDijagnozu(sp) > 0)
                    cmbDijagnoza.SelectedIndex = vratiDijagnozu(sp);
            }
            if (listaStavke.Count <= 0)
            {
                MyMessageBox.Instance.Show("Ne postoje stavke ovog pregleda!");
                return;
            }
        }

        private int vratiDijagnozu(StavkaPregleda sp)
        {
            List<Dijagnoza> dijagnoze = Komunikacija.Instance.VratiSveDijagnoze();
            for(int i = 0; i < dijagnoze.Count; i++)
            {
                if (dijagnoze[i].SifraDijagnoze == sp.Dijagnoza.SifraDijagnoze)
                {
                    return i;
                }
            }
            return -1;
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
            pregled.Karton = pr.Karton;
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

            if (chbKontrola.Checked == false && chbPrviPregled.Checked == false)
            {
                chbKontrola.Focus();
                chbPrviPregled.Focus();
                MyMessageBox.Instance.Show("Morate odabrati jednu vrednost\n Kontrola ili prvi pregled!");
                validacija = false;
            }
            else
            {
                if (chbKontrola.Checked == true)
                {
                    pregled.Kontrola = true;
                }
                else if (chbPrviPregled.Checked == true)
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
            StavkaPregleda stavka = (StavkaPregleda)dgvStavke.CurrentRow.DataBoundItem;

            if (cmbDijagnoza.SelectedItem != null)
            {
                stavka.Dijagnoza = (Dijagnoza)cmbDijagnoza.SelectedItem;
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

        //private void BtnIzmeni_Click(object sender, EventArgs e)
        //{
        //    StavkaPregleda sk = VratiStavku();
             
        //    StavkaPregleda sp = (StavkaPregleda)dgvStavke.CurrentRow.DataBoundItem;
        //    sk.RbStavke = sp.RbStavke;

        //    if (!sk.Equals(sp))
        //    {
        //        sp = sk;
                
        //        bool izmena = Komunikacija.Instance.UpdateStavka(pr, sp);

        //        if (izmena)
        //        {
        //            listaStavke = new BindingList<StavkaPregleda>(Komunikacija.Instance.vratiSveStavke(pr));
        //            dgvStavke.DataSource = listaStavke;
        //            MyMessageBox.Instance.Show($"Izabrana stavka pregleda pacijenta\n {pr.Karton.ImeIPrezime} je izmenjena");
                    
        //            return;
        //        }
        //        else
        //        {
        //            MyMessageBox.Instance.Show($"Greska! \nIzabrana stavka pregleda pacijenta {pr.Karton.ImeIPrezime}\n nije mogla biti izmenjena");
        //            return;
        //        }
        //    }
        //    else
        //    {
        //        MyMessageBox.Instance.Show($"Morate izmeniti vrednosti za izabranu stavku\n pregleda pacijenta  {pr.Karton.ImeIPrezime} \n kako bi bila izmenjena");
        //        return;
        //    }
        //}

        private void BtnIzmeniPregled_Click(object sender, EventArgs e)
        {
            bool tr = true;
            Pregled sk = VratiPregled();
            foreach (StavkaPregleda s in listaStavke)
            {
                sk.ListaStavki.Add(s);
            }

            if (listaProvera.Count() == listaStavke.Count())
            {
                for (int i = 0; i < listaProvera.Count(); i++)
                {
                    for (int j = 0; j < listaStavke.Count(); j++)
                    {
                        if (!listaProvera[i].Equals(listaStavke[j]))
                        {
                            tr = false;
                            break;
                        }
                    }
                }
            }
            else tr = false;

            sk.RbPregleda = pr.RbPregleda;
         
            if (!sk.Equals(pr) || !tr)
            {
                pr = sk;
             
                Pregled pr1 = Komunikacija.Instance.IzmeniPregled(pr);
                
                if (pr.Equals(pr1))
                {
                    
                    dgvStavke.DataSource = listaStavke;
                    MyMessageBox.Instance.Show($"Izabran pregled pacijenta\n {pr.Karton.ImeIPrezime} je izmenjen");
                    FrmPrikaziPregled prikazi = new FrmPrikaziPregled(pr);
                    prikazi.ShowDialog();
                    this.Close();
                    return;
                }
                else
                {
                    MyMessageBox.Instance.Show($"Greska! \nIzabran pregled pacijenta {pr.Karton.ImeIPrezime} \n nije mogao biti izmenjen");
                    return;
                }
            }
            else
            {
                MyMessageBox.Instance.Show($"Morate izmeniti vrednosti\n za izabrani pregled pacijenta  {pr.Karton.ImeIPrezime}\n kako bi bio izmenjen");
                return;
            }
        }

        private void BtnObrišiStavku_Click(object sender, EventArgs e)
        {
            if (dgvStavke.SelectedRows.Count > 0)
            {
                listaStavke.Remove((StavkaPregleda)dgvStavke.CurrentRow.DataBoundItem);
            }
        }

        private void BtnIzmeni_Click(object sender, EventArgs e)
        {
            StavkaPregleda stavka = VratiStavku();
            if (stavka != null)
            {              
                stavka.Dijagnoza = (Dijagnoza)cmbDijagnoza.SelectedItem;
                for (int j = 0; j < listaStavke.Count(); j++)
                {
                    if (listaStavke[j].RbStavke == stavka.RbStavke)
                        listaStavke.Remove(listaStavke[j]);
                }
                listaStavke.Add(stavka);
                dgvStavke.Refresh();
            }
        }

        private void TxtNalazStavka_TextChanged(object sender, EventArgs e)
        {
            txtNapomenaStavka.BackColor = Color.LightGray;
        }

        private void TxtNapomenaStavka_TextChanged(object sender, EventArgs e)
        {
            txtNapomenaStavka.BackColor = Color.LightGray;
        }

        private void TxtNapomena_TextChanged(object sender, EventArgs e)
        {
            txtNapomenaStavka.BackColor = Color.LightGray;
        }

        private void TxtNalazPregled_TextChanged(object sender, EventArgs e)
        {
            txtNapomenaStavka.BackColor = Color.LightGray;
        }
    }
}
