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
    public partial class FrmPretragaUnos : Form
    {
        List<Karton> kartoni = new List<Karton>();
        BindingList<Karton> listaKartona = new BindingList<Karton>();
        BindingList<String> listaCmb = new BindingList<string>() { "sifraKartona", "jmbg", "imeIPrezime" };
        public FrmPretragaUnos()
        {
            InitializeComponent();
        }

        private void FrmPretragaUnos_Load(object sender, EventArgs e)
        {
            this.Text = "[Oftal k2] Klijentski program";
            kartoni = Komunikacija.Instance.VratiSveKartone();
          
            listaKartona = new BindingList<Karton>(kartoni);
            dgvKartoni.DataSource = listaKartona;
        }

        private string VratiUslov()
        {
            string vrati = "WHERE ";
            bool validacija2 = true;
            Karton karton = new Karton();
        
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
                if (!long.TryParse(provera, out long broj))
                {
                    vrati += $"ImeIPrezime like '%{provera}%' ";
                }
                else
                {
                    if (broj.ToString().Length != 13) 
                    {
                        vrati += "SifraKartona= " + provera + " ";
                    }
                    else
                    {
                        vrati += "JMBG= '" + provera + "' ";
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

        private void BtnPretraziKartone_Click(object sender, EventArgs e)
        {
            BindingList<Karton> res = new BindingList<Karton>();

            string k = VratiUslov();
            if (k != null)
            {
                res = new BindingList<Karton>( Komunikacija.Instance.VratiKartoneKriterijum(k));
                dgvKartoni.DataSource = res;
                if (res.Count == 0)
                {

                    MyMessageBox.Instance.Show($"Karton za uneti kriterijum\n {txtTrazenaVrednost.Text} ne postoji.");
                    dgvKartoni.DataSource = listaKartona;
                    return;
                }
                MyMessageBox.Instance.Show($"Sistem je pronašao kartone pacijenata po zadatom kriterijumu.");
                return;
            }
            else
            {
                dgvKartoni.DataSource = listaKartona;
                MyMessageBox.Instance.Show($"Morate uneti vrednost!");
                return;
            }                                

            //dgvKartoni.DataSource = res;    
        }

        private void BtnUnesiPregled_Click(object sender, EventArgs e)
        {
            try
            {
                Karton k = (Karton)dgvKartoni.CurrentRow.DataBoundItem;

                FrmUnosPregleda unesi = new FrmUnosPregleda(k);
                unesi.ShowDialog();
            }
            catch (Exception ex)
            {
                MyMessageBox.Instance.Show("Morate izabrati  u koji\n zelite uneti pregled!\n"+ ex.Message);
            }
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            txtTrazenaVrednost.Clear();
            txtTrazenaVrednost.BackColor = Color.LightGray;
            dgvKartoni.DataSource = listaKartona;
            return;
        }
    }
}
