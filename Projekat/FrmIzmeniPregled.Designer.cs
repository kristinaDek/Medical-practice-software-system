namespace Projekat
{
    partial class FrmIzmeniPregled
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbrStavkaPregleda = new System.Windows.Forms.GroupBox();
            this.txtNalazStavka = new System.Windows.Forms.TextBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.cmbDijagnoza = new System.Windows.Forms.ComboBox();
            this.lblDijagnoza = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNapomenaStavka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnObrišiStavku = new System.Windows.Forms.Button();
            this.btnIzmeniStavku = new System.Windows.Forms.Button();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.gbrPregled = new System.Windows.Forms.GroupBox();
            this.txtNalazPregled = new System.Windows.Forms.TextBox();
            this.chbPrviPregled = new System.Windows.Forms.CheckBox();
            this.chbKontrola = new System.Windows.Forms.CheckBox();
            this.lblNalaz = new System.Windows.Forms.Label();
            this.lblImeDoktora = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.btnIzmeniPregled = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbrStavkaPregleda.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.gbrPregled.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbrStavkaPregleda
            // 
            this.gbrStavkaPregleda.Controls.Add(this.txtNalazStavka);
            this.gbrStavkaPregleda.Controls.Add(this.btnIzmeni);
            this.gbrStavkaPregleda.Controls.Add(this.cmbDijagnoza);
            this.gbrStavkaPregleda.Controls.Add(this.lblDijagnoza);
            this.gbrStavkaPregleda.Controls.Add(this.label1);
            this.gbrStavkaPregleda.Controls.Add(this.txtNapomenaStavka);
            this.gbrStavkaPregleda.Controls.Add(this.label3);
            this.gbrStavkaPregleda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrStavkaPregleda.ForeColor = System.Drawing.Color.White;
            this.gbrStavkaPregleda.Location = new System.Drawing.Point(324, 329);
            this.gbrStavkaPregleda.Name = "gbrStavkaPregleda";
            this.gbrStavkaPregleda.Size = new System.Drawing.Size(612, 364);
            this.gbrStavkaPregleda.TabIndex = 33;
            this.gbrStavkaPregleda.TabStop = false;
            this.gbrStavkaPregleda.Text = "Stavka pregleda:";
            this.gbrStavkaPregleda.Visible = false;
            // 
            // txtNalazStavka
            // 
            this.txtNalazStavka.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNalazStavka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNalazStavka.ForeColor = System.Drawing.Color.DimGray;
            this.txtNalazStavka.Location = new System.Drawing.Point(128, 26);
            this.txtNalazStavka.Multiline = true;
            this.txtNalazStavka.Name = "txtNalazStavka";
            this.txtNalazStavka.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNalazStavka.Size = new System.Drawing.Size(477, 92);
            this.txtNalazStavka.TabIndex = 32;
            this.txtNalazStavka.TextChanged += new System.EventHandler(this.TxtNalazStavka_TextChanged);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.ForeColor = System.Drawing.Color.White;
            this.btnIzmeni.Location = new System.Drawing.Point(150, 288);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(330, 66);
            this.btnIzmeni.TabIndex = 31;
            this.btnIzmeni.Text = "Izmeni stavku";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.BtnIzmeni_Click);
            // 
            // cmbDijagnoza
            // 
            this.cmbDijagnoza.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbDijagnoza.ForeColor = System.Drawing.Color.DimGray;
            this.cmbDijagnoza.FormattingEnabled = true;
            this.cmbDijagnoza.Location = new System.Drawing.Point(127, 244);
            this.cmbDijagnoza.Name = "cmbDijagnoza";
            this.cmbDijagnoza.Size = new System.Drawing.Size(478, 28);
            this.cmbDijagnoza.TabIndex = 30;
            // 
            // lblDijagnoza
            // 
            this.lblDijagnoza.AutoSize = true;
            this.lblDijagnoza.Location = new System.Drawing.Point(4, 245);
            this.lblDijagnoza.Name = "lblDijagnoza";
            this.lblDijagnoza.Size = new System.Drawing.Size(99, 20);
            this.lblDijagnoza.TabIndex = 29;
            this.lblDijagnoza.Text = "Dijagnoza:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nalaz:";
            // 
            // txtNapomenaStavka
            // 
            this.txtNapomenaStavka.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNapomenaStavka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNapomenaStavka.ForeColor = System.Drawing.Color.DimGray;
            this.txtNapomenaStavka.Location = new System.Drawing.Point(129, 125);
            this.txtNapomenaStavka.Multiline = true;
            this.txtNapomenaStavka.Name = "txtNapomenaStavka";
            this.txtNapomenaStavka.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNapomenaStavka.Size = new System.Drawing.Size(477, 102);
            this.txtNapomenaStavka.TabIndex = 21;
            this.txtNapomenaStavka.TextChanged += new System.EventHandler(this.TxtNapomenaStavka_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Napomena:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnObrišiStavku);
            this.groupBox3.Controls.Add(this.btnIzmeniStavku);
            this.groupBox3.Controls.Add(this.dgvStavke);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(324, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(612, 273);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista stavki";
            // 
            // btnObrišiStavku
            // 
            this.btnObrišiStavku.ForeColor = System.Drawing.Color.White;
            this.btnObrišiStavku.Location = new System.Drawing.Point(128, 185);
            this.btnObrišiStavku.Name = "btnObrišiStavku";
            this.btnObrišiStavku.Size = new System.Drawing.Size(111, 67);
            this.btnObrišiStavku.TabIndex = 4;
            this.btnObrišiStavku.Text = "Obriši Stavku";
            this.btnObrišiStavku.UseVisualStyleBackColor = true;
            this.btnObrišiStavku.Click += new System.EventHandler(this.BtnObrišiStavku_Click);
            // 
            // btnIzmeniStavku
            // 
            this.btnIzmeniStavku.ForeColor = System.Drawing.Color.White;
            this.btnIzmeniStavku.Location = new System.Drawing.Point(11, 185);
            this.btnIzmeniStavku.Name = "btnIzmeniStavku";
            this.btnIzmeniStavku.Size = new System.Drawing.Size(111, 67);
            this.btnIzmeniStavku.TabIndex = 3;
            this.btnIzmeniStavku.Text = "Izmeni Stavku";
            this.btnIzmeniStavku.UseVisualStyleBackColor = true;
            this.btnIzmeniStavku.Click += new System.EventHandler(this.BtnIzmeniStavku_Click);
            // 
            // dgvStavke
            // 
            this.dgvStavke.AllowUserToAddRows = false;
            this.dgvStavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavke.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dgvStavke.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStavke.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStavke.GridColor = System.Drawing.Color.DimGray;
            this.dgvStavke.Location = new System.Drawing.Point(11, 22);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.RowHeadersWidth = 51;
            this.dgvStavke.RowTemplate.Height = 24;
            this.dgvStavke.Size = new System.Drawing.Size(594, 157);
            this.dgvStavke.TabIndex = 0;
            // 
            // gbrPregled
            // 
            this.gbrPregled.Controls.Add(this.txtNalazPregled);
            this.gbrPregled.Controls.Add(this.chbPrviPregled);
            this.gbrPregled.Controls.Add(this.chbKontrola);
            this.gbrPregled.Controls.Add(this.lblNalaz);
            this.gbrPregled.Controls.Add(this.lblImeDoktora);
            this.gbrPregled.Controls.Add(this.txtNapomena);
            this.gbrPregled.Controls.Add(this.lblNapomena);
            this.gbrPregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrPregled.ForeColor = System.Drawing.Color.White;
            this.gbrPregled.Location = new System.Drawing.Point(12, 139);
            this.gbrPregled.Name = "gbrPregled";
            this.gbrPregled.Size = new System.Drawing.Size(306, 462);
            this.gbrPregled.TabIndex = 35;
            this.gbrPregled.TabStop = false;
            this.gbrPregled.Text = "Pregled:";
            // 
            // txtNalazPregled
            // 
            this.txtNalazPregled.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNalazPregled.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNalazPregled.ForeColor = System.Drawing.Color.DimGray;
            this.txtNalazPregled.Location = new System.Drawing.Point(18, 49);
            this.txtNalazPregled.Multiline = true;
            this.txtNalazPregled.Name = "txtNalazPregled";
            this.txtNalazPregled.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNalazPregled.Size = new System.Drawing.Size(271, 117);
            this.txtNalazPregled.TabIndex = 30;
            this.txtNalazPregled.TextChanged += new System.EventHandler(this.TxtNalazPregled_TextChanged);
            // 
            // chbPrviPregled
            // 
            this.chbPrviPregled.AutoSize = true;
            this.chbPrviPregled.Location = new System.Drawing.Point(183, 346);
            this.chbPrviPregled.Name = "chbPrviPregled";
            this.chbPrviPregled.Size = new System.Drawing.Size(119, 22);
            this.chbPrviPregled.TabIndex = 29;
            this.chbPrviPregled.Text = "Prvi pregled";
            this.chbPrviPregled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbPrviPregled.UseVisualStyleBackColor = true;
            // 
            // chbKontrola
            // 
            this.chbKontrola.AutoSize = true;
            this.chbKontrola.Location = new System.Drawing.Point(18, 346);
            this.chbKontrola.Name = "chbKontrola";
            this.chbKontrola.Size = new System.Drawing.Size(94, 22);
            this.chbKontrola.TabIndex = 28;
            this.chbKontrola.Text = "Kontrola";
            this.chbKontrola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbKontrola.UseVisualStyleBackColor = true;
            // 
            // lblNalaz
            // 
            this.lblNalaz.AutoSize = true;
            this.lblNalaz.Location = new System.Drawing.Point(15, 28);
            this.lblNalaz.Name = "lblNalaz";
            this.lblNalaz.Size = new System.Drawing.Size(56, 18);
            this.lblNalaz.TabIndex = 26;
            this.lblNalaz.Text = "Nalaz:";
            // 
            // lblImeDoktora
            // 
            this.lblImeDoktora.AutoSize = true;
            this.lblImeDoktora.ForeColor = System.Drawing.Color.NavajoWhite;
            this.lblImeDoktora.Location = new System.Drawing.Point(117, 432);
            this.lblImeDoktora.Name = "lblImeDoktora";
            this.lblImeDoktora.Size = new System.Drawing.Size(172, 18);
            this.lblImeDoktora.TabIndex = 22;
            this.lblImeDoktora.Text = "Ime i prezime doktora";
            // 
            // txtNapomena
            // 
            this.txtNapomena.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNapomena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNapomena.ForeColor = System.Drawing.Color.DimGray;
            this.txtNapomena.Location = new System.Drawing.Point(18, 214);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNapomena.Size = new System.Drawing.Size(271, 117);
            this.txtNapomena.TabIndex = 21;
            this.txtNapomena.TextChanged += new System.EventHandler(this.TxtNapomena_TextChanged);
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(15, 193);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(94, 18);
            this.lblNapomena.TabIndex = 20;
            this.lblNapomena.Text = "Napomena:";
            // 
            // btnIzmeniPregled
            // 
            this.btnIzmeniPregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniPregled.ForeColor = System.Drawing.Color.White;
            this.btnIzmeniPregled.Location = new System.Drawing.Point(12, 607);
            this.btnIzmeniPregled.Name = "btnIzmeniPregled";
            this.btnIzmeniPregled.Size = new System.Drawing.Size(306, 86);
            this.btnIzmeniPregled.TabIndex = 33;
            this.btnIzmeniPregled.Text = "Izmeni pregled";
            this.btnIzmeniPregled.UseVisualStyleBackColor = true;
            this.btnIzmeniPregled.Click += new System.EventHandler(this.BtnIzmeniPregled_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label2.Location = new System.Drawing.Point(25, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 32);
            this.label2.TabIndex = 36;
            this.label2.Text = "Pacijent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(332, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "maticni broj";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 38;
            this.label5.Text = "broj kartona";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 39;
            this.label6.Text = "datRodj";
            // 
            // FrmIzmeniPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(948, 701);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIzmeniPregled);
            this.Controls.Add(this.gbrPregled);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbrStavkaPregleda);
            this.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmIzmeniPregled";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izmena pregleda";
            this.Load += new System.EventHandler(this.FrmIzmeniPregled_Load);
            this.gbrStavkaPregleda.ResumeLayout(false);
            this.gbrStavkaPregleda.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.gbrPregled.ResumeLayout(false);
            this.gbrPregled.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbrStavkaPregleda;
        private System.Windows.Forms.TextBox txtNalazStavka;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.ComboBox cmbDijagnoza;
        private System.Windows.Forms.Label lblDijagnoza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNapomenaStavka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnIzmeniStavku;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.GroupBox gbrPregled;
        private System.Windows.Forms.TextBox txtNalazPregled;
        private System.Windows.Forms.CheckBox chbPrviPregled;
        private System.Windows.Forms.CheckBox chbKontrola;
        private System.Windows.Forms.Label lblNalaz;
        private System.Windows.Forms.Label lblImeDoktora;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.Button btnIzmeniPregled;
        private System.Windows.Forms.Button btnObrišiStavku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}