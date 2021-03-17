namespace Projekat
{
    partial class FrmPrikaziKarton
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
            this.txtSifraKartona = new System.Windows.Forms.TextBox();
            this.lblSifraKartona = new System.Windows.Forms.Label();
            this.lblDatumRodjenja = new System.Windows.Forms.Label();
            this.txtDatumRodjenja = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.lblJMBG = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSifraKartona);
            this.groupBox1.Controls.Add(this.lblSifraKartona);
            this.groupBox1.Controls.Add(this.lblDatumRodjenja);
            this.groupBox1.Controls.Add(this.txtDatumRodjenja);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.lblIme);
            this.groupBox1.Controls.Add(this.txtJMBG);
            this.groupBox1.Controls.Add(this.lblJMBG);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Karton:";
            // 
            // txtSifraKartona
            // 
            this.txtSifraKartona.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSifraKartona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifraKartona.Enabled = false;
            this.txtSifraKartona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifraKartona.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.txtSifraKartona.Location = new System.Drawing.Point(199, 44);
            this.txtSifraKartona.Name = "txtSifraKartona";
            this.txtSifraKartona.ReadOnly = true;
            this.txtSifraKartona.Size = new System.Drawing.Size(455, 27);
            this.txtSifraKartona.TabIndex = 27;
            this.txtSifraKartona.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSifraKartona
            // 
            this.lblSifraKartona.AutoSize = true;
            this.lblSifraKartona.Location = new System.Drawing.Point(82, 47);
            this.lblSifraKartona.Name = "lblSifraKartona";
            this.lblSifraKartona.Size = new System.Drawing.Size(110, 18);
            this.lblSifraKartona.TabIndex = 26;
            this.lblSifraKartona.Text = "Sifra kartona:";
            // 
            // lblDatumRodjenja
            // 
            this.lblDatumRodjenja.AutoSize = true;
            this.lblDatumRodjenja.Location = new System.Drawing.Point(69, 175);
            this.lblDatumRodjenja.Name = "lblDatumRodjenja";
            this.lblDatumRodjenja.Size = new System.Drawing.Size(123, 18);
            this.lblDatumRodjenja.TabIndex = 25;
            this.lblDatumRodjenja.Text = "Datum rođenja:";
            // 
            // txtDatumRodjenja
            // 
            this.txtDatumRodjenja.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDatumRodjenja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatumRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatumRodjenja.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.txtDatumRodjenja.Location = new System.Drawing.Point(199, 172);
            this.txtDatumRodjenja.Name = "txtDatumRodjenja";
            this.txtDatumRodjenja.ReadOnly = true;
            this.txtDatumRodjenja.Size = new System.Drawing.Size(455, 27);
            this.txtDatumRodjenja.TabIndex = 24;
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.Color.Gainsboro;
            this.txtIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.txtIme.Location = new System.Drawing.Point(199, 129);
            this.txtIme.Multiline = true;
            this.txtIme.Name = "txtIme";
            this.txtIme.ReadOnly = true;
            this.txtIme.Size = new System.Drawing.Size(455, 23);
            this.txtIme.TabIndex = 23;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(7, 132);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(186, 18);
            this.lblIme.TabIndex = 22;
            this.lblIme.Text = "Ime i prezime pacijenta:";
            // 
            // txtJMBG
            // 
            this.txtJMBG.BackColor = System.Drawing.Color.Gainsboro;
            this.txtJMBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtJMBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJMBG.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.txtJMBG.Location = new System.Drawing.Point(199, 87);
            this.txtJMBG.Multiline = true;
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.ReadOnly = true;
            this.txtJMBG.Size = new System.Drawing.Size(455, 23);
            this.txtJMBG.TabIndex = 21;
            // 
            // lblJMBG
            // 
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.Location = new System.Drawing.Point(91, 90);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(101, 18);
            this.lblJMBG.TabIndex = 20;
            this.lblJMBG.Text = "Matični broj:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(500, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Izmenjeni podaci kartona:";
            // 
            // FrmPrikaziKarton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(713, 263);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmPrikaziKarton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prikaz kartona";
            this.Load += new System.EventHandler(this.FrmPrikaziKarton_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSifraKartona;
        private System.Windows.Forms.Label lblSifraKartona;
        private System.Windows.Forms.Label lblDatumRodjenja;
        private System.Windows.Forms.TextBox txtDatumRodjenja;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.Label label1;
    }
}