namespace Projekat
{
    partial class FrmObrisiPregled
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
            this.gbrKartoni = new System.Windows.Forms.GroupBox();
            this.dgvPregl = new System.Windows.Forms.DataGridView();
            this.btnObisi = new System.Windows.Forms.Button();
            this.gbrKartoni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregl)).BeginInit();
            this.SuspendLayout();
            // 
            // gbrKartoni
            // 
            this.gbrKartoni.BackColor = System.Drawing.Color.MediumAquamarine;
            this.gbrKartoni.Controls.Add(this.dgvPregl);
            this.gbrKartoni.Controls.Add(this.btnObisi);
            this.gbrKartoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrKartoni.ForeColor = System.Drawing.Color.White;
            this.gbrKartoni.Location = new System.Drawing.Point(4, 1);
            this.gbrKartoni.Name = "gbrKartoni";
            this.gbrKartoni.Size = new System.Drawing.Size(1429, 285);
            this.gbrKartoni.TabIndex = 1;
            this.gbrKartoni.TabStop = false;
            this.gbrKartoni.Text = "Postojeći pregledi";
            // 
            // dgvPregl
            // 
            this.dgvPregl.AllowUserToAddRows = false;
            this.dgvPregl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPregl.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.dgvPregl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPregl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPregl.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPregl.Location = new System.Drawing.Point(6, 21);
            this.dgvPregl.Name = "dgvPregl";
            this.dgvPregl.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPregl.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPregl.RowHeadersWidth = 51;
            this.dgvPregl.RowTemplate.Height = 24;
            this.dgvPregl.Size = new System.Drawing.Size(1417, 201);
            this.dgvPregl.TabIndex = 2;
            // 
            // btnObisi
            // 
            this.btnObisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObisi.ForeColor = System.Drawing.Color.White;
            this.btnObisi.Location = new System.Drawing.Point(163, 226);
            this.btnObisi.Name = "btnObisi";
            this.btnObisi.Size = new System.Drawing.Size(153, 48);
            this.btnObisi.TabIndex = 1;
            this.btnObisi.Text = "Obriši";
            this.btnObisi.UseVisualStyleBackColor = true;
            this.btnObisi.Click += new System.EventHandler(this.BtnObisi_Click);
            // 
            // FrmObrisiPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1435, 287);
            this.Controls.Add(this.gbrKartoni);
            this.Name = "FrmObrisiPregled";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obriši Pregled";
            this.Load += new System.EventHandler(this.FrmObrisiPregled_Load);
            this.gbrKartoni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbrKartoni;
        private System.Windows.Forms.Button btnObisi;
        private System.Windows.Forms.DataGridView dgvPregl;
    }
}