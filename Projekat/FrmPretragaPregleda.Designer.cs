namespace Projekat
{
    partial class FrmPretragaPregleda
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
            this.btnPretraziPreglede = new System.Windows.Forms.Button();
            this.txtTrazenaVrednost = new System.Windows.Forms.TextBox();
            this.lblTrazenaVrednost = new System.Windows.Forms.Label();
            this.gbPacijenti = new System.Windows.Forms.GroupBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.dgvPregledi = new System.Windows.Forms.DataGridView();
            this.btnX = new System.Windows.Forms.Button();
            this.gbPacijenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPretraziPreglede
            // 
            this.btnPretraziPreglede.ForeColor = System.Drawing.Color.White;
            this.btnPretraziPreglede.Location = new System.Drawing.Point(796, 287);
            this.btnPretraziPreglede.Name = "btnPretraziPreglede";
            this.btnPretraziPreglede.Size = new System.Drawing.Size(171, 65);
            this.btnPretraziPreglede.TabIndex = 10;
            this.btnPretraziPreglede.Text = "Pretraži preglede";
            this.btnPretraziPreglede.UseVisualStyleBackColor = true;
            this.btnPretraziPreglede.Click += new System.EventHandler(this.BtnPretraziPreglede_Click);
            // 
            // txtTrazenaVrednost
            // 
            this.txtTrazenaVrednost.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTrazenaVrednost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrazenaVrednost.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.txtTrazenaVrednost.Location = new System.Drawing.Point(180, 303);
            this.txtTrazenaVrednost.Name = "txtTrazenaVrednost";
            this.txtTrazenaVrednost.Size = new System.Drawing.Size(420, 27);
            this.txtTrazenaVrednost.TabIndex = 9;
            // 
            // lblTrazenaVrednost
            // 
            this.lblTrazenaVrednost.AutoSize = true;
            this.lblTrazenaVrednost.Location = new System.Drawing.Point(13, 305);
            this.lblTrazenaVrednost.Name = "lblTrazenaVrednost";
            this.lblTrazenaVrednost.Size = new System.Drawing.Size(161, 20);
            this.lblTrazenaVrednost.TabIndex = 8;
            this.lblTrazenaVrednost.Text = "Tražena vrednost:";
            // 
            // gbPacijenti
            // 
            this.gbPacijenti.Controls.Add(this.btnX);
            this.gbPacijenti.Controls.Add(this.btnIzmeni);
            this.gbPacijenti.Controls.Add(this.dgvPregledi);
            this.gbPacijenti.Controls.Add(this.btnPretraziPreglede);
            this.gbPacijenti.Controls.Add(this.lblTrazenaVrednost);
            this.gbPacijenti.Controls.Add(this.txtTrazenaVrednost);
            this.gbPacijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPacijenti.ForeColor = System.Drawing.Color.White;
            this.gbPacijenti.Location = new System.Drawing.Point(6, 4);
            this.gbPacijenti.Name = "gbPacijenti";
            this.gbPacijenti.Size = new System.Drawing.Size(1153, 372);
            this.gbPacijenti.TabIndex = 7;
            this.gbPacijenti.TabStop = false;
            this.gbPacijenti.Text = "Podaci o pregledima:";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.ForeColor = System.Drawing.Color.White;
            this.btnIzmeni.Location = new System.Drawing.Point(973, 287);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(171, 65);
            this.btnIzmeni.TabIndex = 11;
            this.btnIzmeni.Text = "Izmeni pregled";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.BtnIzmeni_Click);
            // 
            // dgvPregledi
            // 
            this.dgvPregledi.AllowUserToAddRows = false;
            this.dgvPregledi.AllowUserToDeleteRows = false;
            this.dgvPregledi.AllowUserToResizeColumns = false;
            this.dgvPregledi.AllowUserToResizeRows = false;
            this.dgvPregledi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPregledi.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPregledi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPregledi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPregledi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPregledi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPregledi.Location = new System.Drawing.Point(6, 21);
            this.dgvPregledi.MultiSelect = false;
            this.dgvPregledi.Name = "dgvPregledi";
            this.dgvPregledi.ReadOnly = true;
            this.dgvPregledi.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.NavajoWhite;
            this.dgvPregledi.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPregledi.RowTemplate.Height = 24;
            this.dgvPregledi.Size = new System.Drawing.Size(1138, 255);
            this.dgvPregledi.TabIndex = 0;
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(606, 298);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(34, 34);
            this.btnX.TabIndex = 12;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // FrmPretragaPregleda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1162, 380);
            this.Controls.Add(this.gbPacijenti);
            this.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.Name = "FrmPretragaPregleda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PretragaPregleda";
            this.Load += new System.EventHandler(this.FrmPretragaPregleda_Load);
            this.gbPacijenti.ResumeLayout(false);
            this.gbPacijenti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPretraziPreglede;
        private System.Windows.Forms.TextBox txtTrazenaVrednost;
        private System.Windows.Forms.Label lblTrazenaVrednost;
        private System.Windows.Forms.GroupBox gbPacijenti;
        private System.Windows.Forms.DataGridView dgvPregledi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnX;
    }
}