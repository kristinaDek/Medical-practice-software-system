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
    public partial class FrmPrikaziKarton : Form
    {
        Karton karton = new Karton();

        public FrmPrikaziKarton(Karton karton)
        {
            this.karton = karton;
            InitializeComponent();
        }

        private void FrmPrikaziKarton_Load(object sender, EventArgs e)
        {
            this.Text = "[Oftal k2] Klijentski program";
            txtSifraKartona.Text = karton.SifraKartona.ToString();
            txtJMBG.Text = karton.Jmbg;
            txtIme.Text = karton.ImeIPrezime;
            txtDatumRodjenja.Text = karton.DatumRodjenja.ToString("dd/MM/yyyy");    //.Substring(0, karton.DatumRodjenja.ToString().IndexOf(" "));
        }
    }
}
