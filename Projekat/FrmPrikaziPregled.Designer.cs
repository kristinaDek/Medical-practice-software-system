namespace Projekat
{
    partial class FrmPrikaziPregled
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.gbrPregled = new System.Windows.Forms.GroupBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblKPP = new System.Windows.Forms.Label();
            this.txtNalazPregled = new System.Windows.Forms.TextBox();
            this.lblNalaz = new System.Windows.Forms.Label();
            this.lblImeDoktora = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.lblpacijent = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.gbrPregled.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.gbrPregled);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 515);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmenjen pregled:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvStavke);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(10, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(730, 201);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista stavki";
            // 
            // dgvStavke
            // 
            this.dgvStavke.AllowUserToAddRows = false;
            this.dgvStavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavke.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dgvStavke.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStavke.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStavke.Location = new System.Drawing.Point(11, 26);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.ReadOnly = true;
            this.dgvStavke.RowHeadersWidth = 51;
            this.dgvStavke.RowTemplate.Height = 24;
            this.dgvStavke.Size = new System.Drawing.Size(713, 169);
            this.dgvStavke.TabIndex = 0;
            // 
            // gbrPregled
            // 
            this.gbrPregled.Controls.Add(this.lblDatum);
            this.gbrPregled.Controls.Add(this.lblKPP);
            this.gbrPregled.Controls.Add(this.txtNalazPregled);
            this.gbrPregled.Controls.Add(this.lblNalaz);
            this.gbrPregled.Controls.Add(this.lblImeDoktora);
            this.gbrPregled.Controls.Add(this.txtNapomena);
            this.gbrPregled.Controls.Add(this.lblNapomena);
            this.gbrPregled.Location = new System.Drawing.Point(10, 22);
            this.gbrPregled.Name = "gbrPregled";
            this.gbrPregled.Size = new System.Drawing.Size(730, 277);
            this.gbrPregled.TabIndex = 36;
            this.gbrPregled.TabStop = false;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(18, 246);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(60, 20);
            this.lblDatum.TabIndex = 32;
            this.lblDatum.Text = "datum";
            // 
            // lblKPP
            // 
            this.lblKPP.AutoSize = true;
            this.lblKPP.Location = new System.Drawing.Point(15, 217);
            this.lblKPP.Name = "lblKPP";
            this.lblKPP.Size = new System.Drawing.Size(66, 20);
            this.lblKPP.TabIndex = 31;
            this.lblKPP.Text = "txtKPP";
            // 
            // txtNalazPregled
            // 
            this.txtNalazPregled.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNalazPregled.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNalazPregled.ForeColor = System.Drawing.Color.DimGray;
            this.txtNalazPregled.Location = new System.Drawing.Point(18, 40);
            this.txtNalazPregled.Multiline = true;
            this.txtNalazPregled.Name = "txtNalazPregled";
            this.txtNalazPregled.ReadOnly = true;
            this.txtNalazPregled.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNalazPregled.Size = new System.Drawing.Size(329, 174);
            this.txtNalazPregled.TabIndex = 30;
            // 
            // lblNalaz
            // 
            this.lblNalaz.AutoSize = true;
            this.lblNalaz.Location = new System.Drawing.Point(15, 19);
            this.lblNalaz.Name = "lblNalaz";
            this.lblNalaz.Size = new System.Drawing.Size(63, 20);
            this.lblNalaz.TabIndex = 26;
            this.lblNalaz.Text = "Nalaz:";
            // 
            // lblImeDoktora
            // 
            this.lblImeDoktora.AutoSize = true;
            this.lblImeDoktora.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblImeDoktora.Location = new System.Drawing.Point(519, 246);
            this.lblImeDoktora.Name = "lblImeDoktora";
            this.lblImeDoktora.Size = new System.Drawing.Size(191, 20);
            this.lblImeDoktora.TabIndex = 22;
            this.lblImeDoktora.Text = "Ime i prezime doktora";
            // 
            // txtNapomena
            // 
            this.txtNapomena.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNapomena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNapomena.ForeColor = System.Drawing.Color.DimGray;
            this.txtNapomena.Location = new System.Drawing.Point(367, 40);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.ReadOnly = true;
            this.txtNapomena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNapomena.Size = new System.Drawing.Size(357, 174);
            this.txtNapomena.TabIndex = 21;
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(372, 19);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(103, 20);
            this.lblNapomena.TabIndex = 20;
            this.lblNapomena.Text = "Napomena:";
            // 
            // lblpacijent
            // 
            this.lblpacijent.AutoSize = true;
            this.lblpacijent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpacijent.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblpacijent.Location = new System.Drawing.Point(19, 9);
            this.lblpacijent.Name = "lblpacijent";
            this.lblpacijent.Size = new System.Drawing.Size(87, 25);
            this.lblpacijent.TabIndex = 34;
            this.lblpacijent.Text = "pacijent";
            // 
            // FrmPrikaziPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(754, 570);
            this.Controls.Add(this.lblpacijent);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmPrikaziPregled";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrikaziPregled";
            this.Load += new System.EventHandler(this.FrmPrikaziPregled_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.gbrPregled.ResumeLayout(false);
            this.gbrPregled.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbrPregled;
        private System.Windows.Forms.TextBox txtNalazPregled;
        private System.Windows.Forms.Label lblNalaz;
        private System.Windows.Forms.Label lblImeDoktora;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.Label lblKPP;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblpacijent;
    }
}