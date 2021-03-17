namespace Projekat
{
    partial class FrmObrisiKarton
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
            this.gbrKartoni = new System.Windows.Forms.GroupBox();
            this.lbKartoni = new System.Windows.Forms.ListBox();
            this.btnObrisiKarton = new System.Windows.Forms.Button();
            this.gbrKartoni.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbrKartoni
            // 
            this.gbrKartoni.Controls.Add(this.lbKartoni);
            this.gbrKartoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrKartoni.ForeColor = System.Drawing.Color.White;
            this.gbrKartoni.Location = new System.Drawing.Point(10, 12);
            this.gbrKartoni.Name = "gbrKartoni";
            this.gbrKartoni.Size = new System.Drawing.Size(416, 426);
            this.gbrKartoni.TabIndex = 0;
            this.gbrKartoni.TabStop = false;
            this.gbrKartoni.Text = "Postojeći kartoni";
            // 
            // lbKartoni
            // 
            this.lbKartoni.BackColor = System.Drawing.Color.Gainsboro;
            this.lbKartoni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbKartoni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbKartoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKartoni.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lbKartoni.FormattingEnabled = true;
            this.lbKartoni.ItemHeight = 20;
            this.lbKartoni.Location = new System.Drawing.Point(6, 32);
            this.lbKartoni.Name = "lbKartoni";
            this.lbKartoni.Size = new System.Drawing.Size(404, 380);
            this.lbKartoni.TabIndex = 0;
            // 
            // btnObrisiKarton
            // 
            this.btnObrisiKarton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiKarton.ForeColor = System.Drawing.Color.White;
            this.btnObrisiKarton.Location = new System.Drawing.Point(451, 381);
            this.btnObrisiKarton.Name = "btnObrisiKarton";
            this.btnObrisiKarton.Size = new System.Drawing.Size(144, 51);
            this.btnObrisiKarton.TabIndex = 1;
            this.btnObrisiKarton.Text = " Obriši karton";
            this.btnObrisiKarton.UseVisualStyleBackColor = true;
            this.btnObrisiKarton.Click += new System.EventHandler(this.BtnObrisiKarton_Click);
            // 
            // FrmObrisiKarton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(606, 445);
            this.Controls.Add(this.btnObrisiKarton);
            this.Controls.Add(this.gbrKartoni);
            this.Font = new System.Drawing.Font("Gadugi", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmObrisiKarton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obriši Karton";
            this.Load += new System.EventHandler(this.FrmObrisiKarton_Load);
            this.gbrKartoni.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbrKartoni;
        private System.Windows.Forms.ListBox lbKartoni;
        private System.Windows.Forms.Button btnObrisiKarton;
    }
}