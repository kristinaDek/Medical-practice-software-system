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
    public partial class FrmPretragaKartona : Form
    {
        List<Karton> kartoni = new List<Karton>();
        BindingList<Karton> listaKartona = new BindingList<Karton>();
        
        public FrmPretragaKartona()
        {
            InitializeComponent();
        }

        private void FrmPretragaKartona_Load(object sender, EventArgs e)
        {
            this.Text = "[Oftal k2] Klijentski program";
            try
            {
                listaKartona = new BindingList<Karton>( Komunikacija.Instance.VratiSveKartone());
                dgvKartoni.DataSource = listaKartona;
            
            }
            catch (Exception ex)
            {
                MyMessageBox.Instance.Show(ex.Message);
            }

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
            listaKartona = new BindingList<Karton>((List<Karton>)Komunikacija.Instance.VratiSveKartone());
           
            string k = VratiUslov();
            if (k != null)
            {
                res = new BindingList<Karton>(Komunikacija.Instance.VratiKartoneKriterijum(k));
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

       

        private void BtnIzmeniKarton_Click_1(object sender, EventArgs e)
        {
            try
            {
                Karton k = (Karton)dgvKartoni.CurrentRow.DataBoundItem;

                FrmIzmeniKarton izmeni = new FrmIzmeniKarton(k);
                izmeni.ShowDialog();
                this.Close();
            }
            catch (Exception)
            {
                MyMessageBox.Instance.Show("Morate izabrati karton\n koji zelite da menjate!");
            }         

           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Karton k = (Karton)dgvKartoni.CurrentRow.DataBoundItem;
            FrmObrisiPregled obrisi = new FrmObrisiPregled(k);
            obrisi.ShowDialog();
        }

        private void TxtTrazenaVrednost_TextChanged(object sender, EventArgs e)
        {
            txtTrazenaVrednost.BackColor = Color.LightGray;
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            txtTrazenaVrednost.BackColor = Color.LightGray;
            txtTrazenaVrednost.Clear();
            dgvKartoni.DataSource = listaKartona;
            return;
        }
    }
        
}





