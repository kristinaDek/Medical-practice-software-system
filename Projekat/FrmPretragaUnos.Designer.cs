namespace Projekat
{
    partial class FrmPretragaUnos
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
            this.btnUnesiPregled = new System.Windows.Forms.Button();
            this.btnPretraziKartone = new System.Windows.Forms.Button();
            this.txtTrazenaVrednost = new System.Windows.Forms.TextBox();
            this.lblTrazenaVrednost = new System.Windows.Forms.Label();
            this.gbPacijenti = new System.Windows.Forms.GroupBox();
            this.dgvKartoni = new System.Windows.Forms.DataGridView();
            this.btnX = new System.Windows.Forms.Button();
            this.gbPacijenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKartoni)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnesiPregled
            // 
            this.btnUnesiPregled.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUnesiPregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnesiPregled.ForeColor = System.Drawing.Color.White;
            this.btnUnesiPregled.Location = new System.Drawing.Point(823, 396);
            this.btnUnesiPregled.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnesiPregled.Name = "btnUnesiPregled";
            this.btnUnesiPregled.Size = new System.Drawing.Size(236, 56);
            this.btnUnesiPregled.TabIndex = 11;
            this.btnUnesiPregled.Text = "Unesi pregled";
            this.btnUnesiPregled.UseVisualStyleBackColor = false;
            this.btnUnesiPregled.Click += new System.EventHandler(this.BtnUnesiPregled_Click);
            // 
            // btnPretraziKartone
            // 
            this.btnPretraziKartone.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPretraziKartone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretraziKartone.ForeColor = System.Drawing.Color.White;
            this.btnPretraziKartone.Location = new System.Drawing.Point(823, 333);
            this.btnPretraziKartone.Margin = new System.Windows.Forms.Padding(4);
            this.btnPretraziKartone.Name = "btnPretraziKartone";
            this.btnPretraziKartone.Size = new System.Drawing.Size(236, 56);
            this.btnPretraziKartone.TabIndex = 10;
            this.btnPretraziKartone.Text = "Pretraži kartone";
            this.btnPretraziKartone.UseVisualStyleBackColor = false;
            this.btnPretraziKartone.Click += new System.EventHandler(this.BtnPretraziKartone_Click);
            // 
            // txtTrazenaVrednost
            // 
            this.txtTrazenaVrednost.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTrazenaVrednost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrazenaVrednost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrazenaVrednost.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.txtTrazenaVrednost.Location = new System.Drawing.Point(225, 363);
            this.txtTrazenaVrednost.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrazenaVrednost.Multiline = true;
            this.txtTrazenaVrednost.Name = "txtTrazenaVrednost";
            this.txtTrazenaVrednost.Size = new System.Drawing.Size(405, 26);
            this.txtTrazenaVrednost.TabIndex = 9;
            // 
            // lblTrazenaVrednost
            // 
            this.lblTrazenaVrednost.AutoSize = true;
            this.lblTrazenaVrednost.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lblTrazenaVrednost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrazenaVrednost.ForeColor = System.Drawing.Color.White;
            this.lblTrazenaVrednost.Location = new System.Drawing.Point(56, 365);
            this.lblTrazenaVrednost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrazenaVrednost.Name = "lblTrazenaVrednost";
            this.lblTrazenaVrednost.Size = new System.Drawing.Size(161, 20);
            this.lblTrazenaVrednost.TabIndex = 8;
            this.lblTrazenaVrednost.Text = "Tražena vrednost:";
            // 
            // gbPacijenti
            // 
            this.gbPacijenti.BackColor = System.Drawing.Color.MediumAquamarine;
            this.gbPacijenti.Controls.Add(this.dgvKartoni);
            this.gbPacijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPacijenti.ForeColor = System.Drawing.Color.White;
            this.gbPacijenti.Location = new System.Drawing.Point(16, 15);
            this.gbPacijenti.Margin = new System.Windows.Forms.Padding(4);
            this.gbPacijenti.Name = "gbPacijenti";
            this.gbPacijenti.Padding = new System.Windows.Forms.Padding(4);
            this.gbPacijenti.Size = new System.Drawing.Size(1067, 307);
            this.gbPacijenti.TabIndex = 7;
            this.gbPacijenti.TabStop = false;
            this.gbPacijenti.Text = "Podaci o pacijentima:";
            // 
            // dgvKartoni
            // 
            this.dgvKartoni.AllowUserToAddRows = false;
            this.dgvKartoni.AllowUserToDeleteRows = false;
            this.dgvKartoni.AllowUserToResizeColumns = false;
            this.dgvKartoni.AllowUserToResizeRows = false;
            this.dgvKartoni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKartoni.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dgvKartoni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.NavajoWhite;
            this.dgvKartoni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKartoni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKartoni.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKartoni.Location = new System.Drawing.Point(8, 27);
            this.dgvKartoni.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKartoni.Name = "dgvKartoni";
            this.dgvKartoni.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.NavajoWhite;
            this.dgvKartoni.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKartoni.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.NavajoWhite;
            this.dgvKartoni.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKartoni.RowTemplate.Height = 24;
            this.dgvKartoni.Size = new System.Drawing.Size(1051, 253);
            this.dgvKartoni.TabIndex = 0;
            // 
            // btnX
            // 
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(637, 358);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(34, 34);
            this.btnX.TabIndex = 13;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // FrmPretragaUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1096, 462);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnUnesiPregled);
            this.Controls.Add(this.btnPretraziKartone);
            this.Controls.Add(this.txtTrazenaVrednost);
            this.Controls.Add(this.lblTrazenaVrednost);
            this.Controls.Add(this.gbPacijenti);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPretragaUnos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pretraga Unos";
            this.Load += new System.EventHandler(this.FrmPretragaUnos_Load);
            this.gbPacijenti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKartoni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnesiPregled;
        private System.Windows.Forms.Button btnPretraziKartone;
        private System.Windows.Forms.TextBox txtTrazenaVrednost;
        private System.Windows.Forms.Label lblTrazenaVrednost;
        private System.Windows.Forms.GroupBox gbPacijenti;
        private System.Windows.Forms.DataGridView dgvKartoni;
        private System.Windows.Forms.Button btnX;
    }
}