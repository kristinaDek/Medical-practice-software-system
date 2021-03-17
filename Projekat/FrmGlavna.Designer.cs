namespace Projekat
{
    partial class FrmGlavna
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
            this.Karton = new System.Windows.Forms.GroupBox();
            this.btnBrisanjeKartona = new System.Windows.Forms.Button();
            this.btnPretragaKartona = new System.Windows.Forms.Button();
            this.btnUnosKartona = new System.Windows.Forms.Button();
            this.lbltekst = new System.Windows.Forms.Label();
            this.gbrPregledi = new System.Windows.Forms.GroupBox();
            this.btnBrisanjePregleda = new System.Windows.Forms.Button();
            this.brnPretragaPregleda = new System.Windows.Forms.Button();
            this.btnUnosPregleda = new System.Windows.Forms.Button();
            this.Karton.SuspendLayout();
            this.gbrPregledi.SuspendLayout();
            this.SuspendLayout();
            // 
            // Karton
            // 
            this.Karton.Controls.Add(this.btnBrisanjeKartona);
            this.Karton.Controls.Add(this.btnPretragaKartona);
            this.Karton.Controls.Add(this.btnUnosKartona);
            this.Karton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Karton.ForeColor = System.Drawing.Color.White;
            this.Karton.Location = new System.Drawing.Point(27, 13);
            this.Karton.Name = "Karton";
            this.Karton.Size = new System.Drawing.Size(377, 188);
            this.Karton.TabIndex = 0;
            this.Karton.TabStop = false;
            this.Karton.Text = "Kartoni";
            // 
            // btnBrisanjeKartona
            // 
            this.btnBrisanjeKartona.ForeColor = System.Drawing.Color.White;
            this.btnBrisanjeKartona.Location = new System.Drawing.Point(93, 130);
            this.btnBrisanjeKartona.Name = "btnBrisanjeKartona";
            this.btnBrisanjeKartona.Size = new System.Drawing.Size(178, 47);
            this.btnBrisanjeKartona.TabIndex = 2;
            this.btnBrisanjeKartona.Text = "Brisanje Kartona";
            this.btnBrisanjeKartona.UseVisualStyleBackColor = true;
            this.btnBrisanjeKartona.Click += new System.EventHandler(this.BtnBrisanjeKartona_Click);
            // 
            // btnPretragaKartona
            // 
            this.btnPretragaKartona.ForeColor = System.Drawing.Color.White;
            this.btnPretragaKartona.Location = new System.Drawing.Point(93, 77);
            this.btnPretragaKartona.Name = "btnPretragaKartona";
            this.btnPretragaKartona.Size = new System.Drawing.Size(178, 47);
            this.btnPretragaKartona.TabIndex = 1;
            this.btnPretragaKartona.Text = "Pretraga Kartona";
            this.btnPretragaKartona.UseVisualStyleBackColor = true;
            this.btnPretragaKartona.Click += new System.EventHandler(this.BtnPretragaKartona_Click);
            // 
            // btnUnosKartona
            // 
            this.btnUnosKartona.ForeColor = System.Drawing.Color.White;
            this.btnUnosKartona.Location = new System.Drawing.Point(93, 24);
            this.btnUnosKartona.Name = "btnUnosKartona";
            this.btnUnosKartona.Size = new System.Drawing.Size(178, 47);
            this.btnUnosKartona.TabIndex = 0;
            this.btnUnosKartona.Text = "Unos Kartona";
            this.btnUnosKartona.UseVisualStyleBackColor = true;
            this.btnUnosKartona.Click += new System.EventHandler(this.BtnUnosKartona_Click);
            // 
            // lbltekst
            // 
            this.lbltekst.AutoSize = true;
            this.lbltekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltekst.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lbltekst.Location = new System.Drawing.Point(248, 419);
            this.lbltekst.Name = "lbltekst";
            this.lbltekst.Size = new System.Drawing.Size(50, 20);
            this.lbltekst.TabIndex = 1;
            this.lbltekst.Text = "tekst";
            // 
            // gbrPregledi
            // 
            this.gbrPregledi.Controls.Add(this.btnBrisanjePregleda);
            this.gbrPregledi.Controls.Add(this.brnPretragaPregleda);
            this.gbrPregledi.Controls.Add(this.btnUnosPregleda);
            this.gbrPregledi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrPregledi.ForeColor = System.Drawing.Color.White;
            this.gbrPregledi.Location = new System.Drawing.Point(27, 207);
            this.gbrPregledi.Name = "gbrPregledi";
            this.gbrPregledi.Size = new System.Drawing.Size(377, 209);
            this.gbrPregledi.TabIndex = 3;
            this.gbrPregledi.TabStop = false;
            this.gbrPregledi.Text = "Pregledi";
            // 
            // btnBrisanjePregleda
            // 
            this.btnBrisanjePregleda.ForeColor = System.Drawing.Color.White;
            this.btnBrisanjePregleda.Location = new System.Drawing.Point(93, 134);
            this.btnBrisanjePregleda.Name = "btnBrisanjePregleda";
            this.btnBrisanjePregleda.Size = new System.Drawing.Size(178, 48);
            this.btnBrisanjePregleda.TabIndex = 2;
            this.btnBrisanjePregleda.Text = "Brisanje Pregleda";
            this.btnBrisanjePregleda.UseVisualStyleBackColor = true;
            this.btnBrisanjePregleda.Click += new System.EventHandler(this.BtnBrisanjePregleda_Click);
            // 
            // brnPretragaPregleda
            // 
            this.brnPretragaPregleda.ForeColor = System.Drawing.Color.White;
            this.brnPretragaPregleda.Location = new System.Drawing.Point(93, 80);
            this.brnPretragaPregleda.Name = "brnPretragaPregleda";
            this.brnPretragaPregleda.Size = new System.Drawing.Size(178, 48);
            this.brnPretragaPregleda.TabIndex = 1;
            this.brnPretragaPregleda.Text = "Pretraga Pregleda";
            this.brnPretragaPregleda.UseVisualStyleBackColor = true;
            this.brnPretragaPregleda.Click += new System.EventHandler(this.BrnPretragaPregleda_Click);
            // 
            // btnUnosPregleda
            // 
            this.btnUnosPregleda.ForeColor = System.Drawing.Color.White;
            this.btnUnosPregleda.Location = new System.Drawing.Point(93, 26);
            this.btnUnosPregleda.Name = "btnUnosPregleda";
            this.btnUnosPregleda.Size = new System.Drawing.Size(178, 48);
            this.btnUnosPregleda.TabIndex = 0;
            this.btnUnosPregleda.Text = "Unos Pregleda";
            this.btnUnosPregleda.UseVisualStyleBackColor = true;
            this.btnUnosPregleda.Click += new System.EventHandler(this.BtnUnosPregleda_Click);
            // 
            // FrmGlavna
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(439, 448);
            this.Controls.Add(this.gbrPregledi);
            this.Controls.Add(this.lbltekst);
            this.Controls.Add(this.Karton);
            this.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dobrodošli";
            this.Load += new System.EventHandler(this.FrmGlavna_Load);
            this.Karton.ResumeLayout(false);
            this.gbrPregledi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Karton;
        private System.Windows.Forms.Button btnUnosKartona;
        private System.Windows.Forms.Button btnPretragaKartona;
        private System.Windows.Forms.Label lbltekst;
        private System.Windows.Forms.Button btnBrisanjeKartona;
        private System.Windows.Forms.GroupBox gbrPregledi;
        private System.Windows.Forms.Button brnPretragaPregleda;
        private System.Windows.Forms.Button btnUnosPregleda;
        private System.Windows.Forms.Button btnBrisanjePregleda;
    }
}