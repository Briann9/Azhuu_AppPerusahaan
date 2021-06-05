namespace Azhuu_AppPerusahaan
{
    partial class UpcomingTrip
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
            this.dgvUpcomingTrip = new System.Windows.Forms.DataGridView();
            this.butBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingTrip)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUpcomingTrip
            // 
            this.dgvUpcomingTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpcomingTrip.Location = new System.Drawing.Point(34, 67);
            this.dgvUpcomingTrip.Name = "dgvUpcomingTrip";
            this.dgvUpcomingTrip.Size = new System.Drawing.Size(579, 587);
            this.dgvUpcomingTrip.TabIndex = 0;
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(34, 23);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(75, 23);
            this.butBack.TabIndex = 1;
            this.butBack.Text = "<";
            this.butBack.UseVisualStyleBackColor = true;
            // 
            // UpcomingTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.dgvUpcomingTrip);
            this.Name = "UpcomingTrip";
            this.Text = "UpcomingTrip";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingTrip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUpcomingTrip;
        private System.Windows.Forms.Button butBack;
    }
}