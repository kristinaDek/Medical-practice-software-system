using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat
{
    public partial class FrmPretragaPregleda : Form
    {
        Pregled p;
        BindingList<Pregled> listaPregleda = new BindingList<Pregled>();
        BindingList<Karton> listaKartona = new BindingList<Karton>();
        public FrmPretragaPregleda()
        {            
            InitializeComponent();
        }

        private void BtnIzmeni_Click(object sender, EventArgs e)
        {
            p = (Pregled)dgvPregledi.CurrentRow.DataBoundItem;
            FrmIzmeniPregled izm = new FrmIzmeniPregled(p);
            izm.ShowDialog();
            listaPregleda = new BindingList<Pregled>(Komunikacija.Instance.vratiSvePreglede());
            dgvPregledi.DataSource = listaPregleda;
        }

        private void FrmPretragaPregleda_Load(object sender, EventArgs e)
        {
            this.Text = "[Oftal k2] Klijentski program";
            listaPregleda = new BindingList<Pregled>( (List<Pregled>)Komunikacija.Instance.vratiSvePreglede()); 

            dgvPregledi.DataSource = listaPregleda;
        }

    

        private void BtnPretraziPreglede_Click(object sender, EventArgs e)
        {
            BindingList<Pregled> res = new BindingList<Pregled>();
            listaPregleda = new BindingList<Pregled>(Komunikacija.Instance.vratiSvePreglede());

            string k = VratiPregled();
            if (k != null)
            {
                res = new BindingList<Pregled>(Komunikacija.Instance.VratiPregledeKriterijum(k));
                dgvPregledi.DataSource = res;
                if (res.Count == 0)
                {
                    MyMessageBox.Instance.Show($"Pregled za uneti kriterijum\n {txtTrazenaVrednost.Text} ne postoji.");
                    dgvPregledi.DataSource = listaPregleda;
                    return;
                }
                MyMessageBox.Instance.Show($"Sistem je pronašao preglede pacijenata po zadatom kriterijumu.");
                return;
            }
            else
            {
                dgvPregledi.DataSource = listaPregleda;
                MyMessageBox.Instance.Show($"Morate uneti vrednost!");
                return;
            }            
        }

        private string VratiPregled()
        {
            string vrati = "WHERE ";
            bool validacija2 = true;
            Pregled pregled = new Pregled();
            
            txtTrazenaVrednost.BackColor = Color.LightGray;

            if (string.IsNullOrEmpty(txtTrazenaVrednost.Text))
            {
                txtTrazenaVrednost.BackColor = Color.LightCoral;
                validacija2 = false;
            }
            else
            {
                txtTrazenaVrednost.BackColor = Color.LightGray;

                String provera = txtTrazenaVrednost.Text;
                if (!long.TryParse(provera, out long broj) && !DateTime.TryParseExact(txtTrazenaVrednost.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime datum))
                {
                    vrati += $"k.ImeIPrezime like '%{provera}%' ";
                }
                else if (!long.TryParse(provera, out broj) && DateTime.TryParseExact(txtTrazenaVrednost.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out datum))
                {
                    vrati += $"pr.DatumPregleda= '"+datum.ToString()+"' ";
                }
                else
                {
                    if (broj.ToString().Length != 13)  
                    {
                        vrati += "pr.RBPregleda= " + provera + " ";
                    }
                    else if (broj.ToString().Length == 13)
                    {
                        vrati += "k.JMBG= " + provera + " ";
                    }
                }

            }

            if (validacija2)
            {
                return vrati;
            }
            else
            {

                return null;
            }
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            txtTrazenaVrednost.Clear();
            txtTrazenaVrednost.BackColor = Color.LightGray;
            dgvPregledi.DataSource = listaPregleda;            
            return;
        }
    }
}
