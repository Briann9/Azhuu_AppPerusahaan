
namespace Azhuu_AppPerusahaan
{
    partial class FormTransaksiTerlaris
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
            this.dgvTerlaris = new System.Windows.Forms.DataGridView();
            this.butBack = new System.Windows.Forms.Button();
            this.butTT = new System.Windows.Forms.Button();
            this.but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerlaris)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTerlaris
            // 
            this.dgvTerlaris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTerlaris.Location = new System.Drawing.Point(12, 85);
            this.dgvTerlaris.Name = "dgvTerlaris";
            this.dgvTerlaris.Size = new System.Drawing.Size(761, 343);
            this.dgvTerlaris.TabIndex = 0;
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(12, 12);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(75, 23);
            this.butBack.TabIndex = 1;
            this.butBack.Text = "<";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // butTT
            // 
            this.butTT.Location = new System.Drawing.Point(12, 56);
            this.butTT.Name = "butTT";
            this.butTT.Size = new System.Drawing.Size(113, 23);
            this.butTT.TabIndex = 4;
            this.butTT.Text = "Transaksi Terlaris";
            this.butTT.UseVisualStyleBackColor = true;
            this.butTT.Click += new System.EventHandler(this.butTT_Click);
            // 
            // but
            // 
            this.but.Location = new System.Drawing.Point(158, 56);
            this.but.Name = "but";
            this.but.Size = new System.Drawing.Size(179, 23);
            this.but.TabIndex = 3;
            this.but.Text = "Kapasitas Airport Maksimal Saat ini";
            this.but.UseVisualStyleBackColor = true;
            this.but.Click += new System.EventHandler(this.but_Click);
            // 
            // FormTransaksiTerlaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butTT);
            this.Controls.Add(this.but);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.dgvTerlaris);
            this.Name = "FormTransaksiTerlaris";
            this.Text = "Transaksi Terlaris Hokyaa!";
            this.Load += new System.EventHandler(this.FormTransaksiTerlaris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerlaris)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTerlaris;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button butTT;
        private System.Windows.Forms.Button but;
    }
}