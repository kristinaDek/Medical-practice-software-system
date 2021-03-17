namespace Projekat
{
    partial class FrmUnosKartona
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltekst = new System.Windows.Forms.Label();
            this.txtDatumRodjenja = new System.Windows.Forms.TextBox();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.lblJMBG = new System.Windows.Forms.Label();
            this.btnUnesiKarton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltekst);
            this.groupBox1.Controls.Add(this.txtDatumRodjenja);
            this.groupBox1.Controls.Add(this.lblDatumRodjenja);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.lblIme);
            this.groupBox1.Controls.Add(this.txtJMBG);
            this.groupBox1.Controls.Add(this.lblJMBG);
            this.groupBox1.Controls.Add(this.btnUnesiKarton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(4, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(817, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o pacijentu";
            // 
            // lbltekst
            // 
            this.lbltekst.AutoSize = true;
            this.lbltekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltekst.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lbltekst.Location = new System.Drawing.Point(625, 200);
            this.lbltekst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltekst.Name = "lbltekst";
            this.lbltekst.Size = new System.Drawing.Size(180, 20);
            this.lbltekst.TabIndex = 21;
            this.lbltekst.Text = "*format: dd/MM/yyyy";
            this.lbltekst.Visible = false;
            // 
            // txtDatumRodjenja
            // 
            this.txtDatumRodjenja.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDatumRodjenja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatumRodjenja.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.txtDatumRodjenja.Location = new System.Drawing.Point(311, 169);
            this.txtDatumRodjenja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDatumRodjenja.Multiline = true;
            this.txtDatumRodjenja.Name = "txtDatumRodjenja";
            this.txtDatumRodjenja.Size = new System.Drawing.Size(494, 27);
            this.txtDatumRodjenja.TabIndex = 18;
            this.txtDatumRodjenja.TextChanged += new System.EventHandler(this.TxtDatumRodjenja_TextChanged);
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.ForeColor = System.Drawing.Color.White;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(160, 171);
            this.lblDatumRodjenja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(143, 20);
            this.lblDatumRodjenja.TabIndex = 17;
            this.lblDatumRodjenja.Text = "Datum rodjenja:";
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIme.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.txtIme.Location = new System.Drawing.Point(311, 114);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIme.Multiline = true;
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(494, 27);
            this.txtIme.TabIndex = 13;
            this.txtIme.TextChanged += new System.EventHandler(this.TxtIme_TextChanged);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.ForeColor = System.Drawing.Color.White;
            this.lblIme.Location = new System.Drawing.Point(92, 116);
            this.lblIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(211, 20);
            this.lblIme.TabIndex = 12;
            this.lblIme.Text = "Ime i prezime pacijenta:";
            // 
            // txtJMBG
            // 
            this.txtJMBG.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtJMBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJMBG.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.txtJMBG.Location = new System.Drawing.Point(311, 64);
            this.txtJMBG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJMBG.Multiline = true;
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(494, 27);
            this.txtJMBG.TabIndex = 11;
            this.txtJMBG.TextChanged += new System.EventHandler(this.TxtJMBG_TextChanged);
            // 
            // lblJMBG
            // 
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.ForeColor = System.Drawing.Color.White;
            this.lblJMBG.Location = new System.Drawing.Point(189, 66);
            this.lblJMBG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(114, 20);
            this.lblJMBG.TabIndex = 10;
            this.lblJMBG.Text = "Maticni broj:";
            // 
            // btnUnesiKarton
            // 
            this.btnUnesiKarton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnesiKarton.ForeColor = System.Drawing.Color.White;
            this.btnUnesiKarton.Location = new System.Drawing.Point(250, 235);
            this.btnUnesiKarton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUnesiKarton.Name = "btnUnesiKarton";
            this.btnUnesiKarton.Size = new System.Drawing.Size(296, 66);
            this.btnUnesiKarton.TabIndex = 9;
            this.btnUnesiKarton.Text = "Unesi Karton";
            this.btnUnesiKarton.UseVisualStyleBackColor = true;
            this.btnUnesiKarton.Click += new System.EventHandler(this.BtnUnesiKarton_Click);
            // 
            // FrmUnosKartona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(826, 344);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmUnosKartona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos novog kartona";
            this.Load += new System.EventHandler(this.FrmUnosKartona_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.Button btnUnesiKarton;
        private System.Windows.Forms.TextBox txtDatumRodjenja;
        private System.Windows.Forms.Label lbltekst;
    }
}