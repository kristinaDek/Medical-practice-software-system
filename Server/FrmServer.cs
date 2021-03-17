using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Projekat;

namespace Server
{
    public partial class FrmServer : Form
    {
        private Server s;
        public FrmServer()
        {
            InitializeComponent();
            btnPokreni.Enabled = true;
            
            btnZaustavi.Enabled = false;
            
        }

        private void BtnPokreni_Click(object sender, EventArgs e)
        {
            s = new Server();
            if(s.PokreniServer())
            {
                Thread nit = new Thread(s.Osluskuj);
                nit.IsBackground = true;
                nit.Start();
                MyMessageBox.Instance.Show("Server je pokrenut.");
                btnPokreni.Enabled = false;
                
                btnZaustavi.Enabled = true;
            }
            else
            {
                MyMessageBox.Instance.Show("Server nije pokrenut!");
            }
        }

        private void BtnZaustavi_Click(object sender, EventArgs e)
        {          
            
            if (s.Zaustavi())
            {        
                btnPokreni.Enabled = true;                
                btnZaustavi.Enabled = false;
               
                MyMessageBox.Instance.Show("Server je zaustavljen.");
                
            }
            else
            {
                MyMessageBox.Instance.Show("Server nije zaustavljen!");
            }
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            this.Text = "[Oftal k2] Serverski program";
        }
    }
}
