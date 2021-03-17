namespace Projekat
{
    partial class FrmPretragaKartona
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbPacijenti = new System.Windows.Forms.GroupBox();
            this.dgvKartoni = new System.Windows.Forms.DataGridView();
            this.lblTrazenaVrednost = new System.Windows.Forms.Label();
            this.txtTrazenaVrednost = new System.Windows.Forms.TextBox();
            this.btnPretraziKartone = new System.Windows.Forms.Button();
            this.btnIzmeniKarton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.gbPacijenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKartoni)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPacijenti
            // 
            this.gbPacijenti.Controls.Add(this.dgvKartoni);
            this.gbPacijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPacijenti.ForeColor = System.Drawing.Color.White;
            this.gbPacijenti.Location = new System.Drawing.Point(12, 13);
            this.gbPacijenti.Name = "gbPacijenti";
            this.gbPacijenti.Size = new System.Drawing.Size(767, 261);
            this.gbPacijenti.TabIndex = 0;
            this.gbPacijenti.TabStop = false;
            this.gbPacijenti.Text = "Podaci o pacijentima:";
            // 
            // dgvKartoni
            // 
            this.dgvKartoni.AllowUserToAddRows = false;
            this.dgvKartoni.AllowUserToDeleteRows = false;
            this.dgvKartoni.AllowUserToResizeColumns = false;
            this.dgvKartoni.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.NavajoWhite;
            this.dgvKartoni.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKartoni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKartoni.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dgvKartoni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.NavajoWhite;
            this.dgvKartoni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKartoni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKartoni.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKartoni.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvKartoni.Location = new System.Drawing.Point(16, 23);
            this.dgvKartoni.Name = "dgvKartoni";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.NavajoWhite;
            this.dgvKartoni.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKartoni.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.NavajoWhite;
            this.dgvKartoni.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvKartoni.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvKartoni.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvKartoni.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKartoni.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKartoni.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvKartoni.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.LightSteelBlue;
            this.dgvKartoni.RowTemplate.Height = 24;
            this.dgvKartoni.Size = new System.Drawing.Size(734, 215);
            this.dgvKartoni.TabIndex = 0;
            // 
            // lblTrazenaVrednost
            // 
            this.lblTrazenaVrednost.AutoSize = true;
            this.lblTrazenaVrednost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrazenaVrednost.ForeColor = System.Drawing.Color.White;
            this.lblTrazenaVrednost.Location = new System.Drawing.Point(25, 284);
            this.lblTrazenaVrednost.Name = "lblTrazenaVrednost";
            this.lblTrazenaVrednost.Size = new System.Drawing.Size(161, 20);
            this.lblTrazenaVrednost.TabIndex = 3;
            this.lblTrazenaVrednost.Text = "Tražena vrednost:";
            // 
            // txtTrazenaVrednost
            // 
            this.txtTrazenaVrednost.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTrazenaVrednost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrazenaVrednost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrazenaVrednost.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.txtTrazenaVrednost.Location = new System.Drawing.Point(183, 280);
            this.txtTrazenaVrednost.Name = "txtTrazenaVrednost";
            this.txtTrazenaVrednost.Size = new System.Drawing.Size(381, 27);
            this.txtTrazenaVrednost.TabIndex = 4;
            this.txtTrazenaVrednost.TextChanged += new System.EventHandler(this.TxtTrazenaVrednost_TextChanged);
            // 
            // btnPretraziKartone
            // 
            this.btnPretraziKartone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraziKartone.ForeColor = System.Drawing.Color.White;
            this.btnPretraziKartone.Location = new System.Drawing.Point(793, 36);
            this.btnPretraziKartone.Name = "btnPretraziKartone";
            this.btnPretraziKartone.Size = new System.Drawing.Size(172, 48);
            this.btnPretraziKartone.TabIndex = 5;
            this.btnPretraziKartone.Text = "Pretraži kartone";
            this.btnPretraziKartone.UseVisualStyleBackColor = true;
            this.btnPretraziKartone.Click += new System.EventHandler(this.BtnPretraziKartone_Click);
            // 
            // btnIzmeniKarton
            // 
            this.btnIzmeniKarton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmeniKarton.ForeColor = System.Drawing.Color.White;
            this.btnIzmeniKarton.Location = new System.Drawing.Point(793, 90);
            this.btnIzmeniKarton.Name = "btnIzmeniKarton";
            this.btnIzmeniKarton.Size = new System.Drawing.Size(172, 48);
            this.btnIzmeniKarton.TabIndex = 6;
            this.btnIzmeniKarton.Text = "Izmeni karton";
            this.btnIzmeniKarton.UseVisualStyleBackColor = true;
            this.btnIzmeniKarton.Click += new System.EventHandler(this.BtnIzmeniKarton_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(793, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Prikaži preglede";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnX
            // 
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(570, 278);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(34, 34);
            this.btnX.TabIndex = 13;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // FrmPretragaKartona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(981, 332);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIzmeniKarton);
            this.Controls.Add(this.btnPretraziKartone);
            this.Controls.Add(this.txtTrazenaVrednost);
            this.Controls.Add(this.lblTrazenaVrednost);
            this.Controls.Add(this.gbPacijenti);
            this.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmPretragaKartona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraži kartone";
            this.Load += new System.EventHandler(this.FrmPretragaKartona_Load);
            this.gbPacijenti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKartoni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPacijenti;
        private System.Windows.Forms.DataGridView dgvKartoni;
        private System.Windows.Forms.Label lblTrazenaVrednost;
        private System.Windows.Forms.TextBox txtTrazenaVrednost;
        private System.Windows.Forms.Button btnPretraziKartone;
        private System.Windows.Forms.Button btnIzmeniKarton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnX;
    }
}