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
    public partial class MyMessageBox : Form
    {
        private static MyMessageBox _instance;

        public MyMessageBox()
        {
            InitializeComponent();
        }
        
        public static MyMessageBox Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MyMessageBox();
                return _instance;
            }
        }

        public void Show(string tekst)
        {
            txtTekst.Text = tekst;
            this.ShowDialog();
        }

        

        private void BtnOk_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MyMessageBox_Load(object sender, EventArgs e)
        {
            txtTekst.AutoSize = true;
            
        }

    
    }
}
