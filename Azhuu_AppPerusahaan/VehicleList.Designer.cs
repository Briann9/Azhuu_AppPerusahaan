namespace Azhuu_AppPerusahaan
{
    partial class VehicleList
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
            this.dgvVList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxV_ID = new System.Windows.Forms.TextBox();
            this.tboxBrand = new System.Windows.Forms.TextBox();
            this.tboxCapacity = new System.Windows.Forms.TextBox();
            this.tboxPlate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.butInsert = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butBack = new System.Windows.Forms.Button();
            this.cboxType = new System.Windows.Forms.ComboBox();
            this.labError = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVList
            // 
            this.dgvVList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVList.Location = new System.Drawing.Point(31, 98);
            this.dgvVList.Name = "dgvVList";
            this.dgvVList.RowHeadersWidth = 51;
            this.dgvVList.Size = new System.Drawing.Size(610, 553);
            this.dgvVList.TabIndex = 0;
            this.dgvVList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVList_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle List";
            // 
            // tboxV_ID
            // 
            this.tboxV_ID.Enabled = false;
            this.tboxV_ID.Location = new System.Drawing.Point(836, 194);
            this.tboxV_ID.Name = "tboxV_ID";
            this.tboxV_ID.Size = new System.Drawing.Size(129, 20);
            this.tboxV_ID.TabIndex = 2;
            // 
            // tboxBrand
            // 
            this.tboxBrand.Location = new System.Drawing.Point(836, 240);
            this.tboxBrand.Name = "tboxBrand";
            this.tboxBrand.Size = new System.Drawing.Size(255, 20);
            this.tboxBrand.TabIndex = 3;
            this.tboxBrand.TextChanged += new System.EventHandler(this.tboxBrand_TextChanged);
            // 
            // tboxCapacity
            // 
            this.tboxCapacity.Location = new System.Drawing.Point(836, 340);
            this.tboxCapacity.Name = "tboxCapacity";
            this.tboxCapacity.Size = new System.Drawing.Size(255, 20);
            this.tboxCapacity.TabIndex = 5;
            this.tboxCapacity.TextChanged += new System.EventHandler(this.tboxCapacity_TextChanged);
            this.tboxCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxCapacity_KeyPress);
            // 
            // tboxPlate
            // 
            this.tboxPlate.Location = new System.Drawing.Point(836, 396);
            this.tboxPlate.Name = "tboxPlate";
            this.tboxPlate.Size = new System.Drawing.Size(255, 20);
            this.tboxPlate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(833, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vehicle ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(833, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(833, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vehicle Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(833, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Capacity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(833, 379);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "License Plate";
            // 
            // butInsert
            // 
            this.butInsert.Location = new System.Drawing.Point(836, 464);
            this.butInsert.Name = "butInsert";
            this.butInsert.Size = new System.Drawing.Size(120, 28);
            this.butInsert.TabIndex = 12;
            this.butInsert.Text = "Insert Vehicle";
            this.butInsert.UseVisualStyleBackColor = true;
            this.butInsert.Click += new System.EventHandler(this.butInsert_Click);
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(968, 464);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(123, 28);
            this.butDelete.TabIndex = 13;
            this.butDelete.Text = "Delete Vehicle";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butBack
            // 
            this.butBack.Location = new System.Drawing.Point(34, 32);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(46, 23);
            this.butBack.TabIndex = 14;
            this.butBack.Text = "<";
            this.butBack.UseVisualStyleBackColor = true;
            // 
            // cboxType
            // 
            this.cboxType.FormattingEnabled = true;
            this.cboxType.Location = new System.Drawing.Point(836, 290);
            this.cboxType.Name = "cboxType";
            this.cboxType.Size = new System.Drawing.Size(255, 21);
            this.cboxType.TabIndex = 15;
            // 
            // labError
            // 
            this.labError.AutoSize = true;
            this.labError.Location = new System.Drawing.Point(833, 432);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(10, 13);
            this.labError.TabIndex = 16;
            this.labError.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Azhuu_AppPerusahaan.Properties.Resources._11551;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1270, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // VehicleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.cboxType);
            this.Controls.Add(this.butBack);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butInsert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxPlate);
            this.Controls.Add(this.tboxCapacity);
            this.Controls.Add(this.tboxBrand);
            this.Controls.Add(this.tboxV_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvVList);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VehicleList";
            this.Text = "VehicleList";
            this.Load += new System.EventHandler(this.VehicleList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxV_ID;
        private System.Windows.Forms.TextBox tboxBrand;
        private System.Windows.Forms.TextBox tboxCapacity;
        private System.Windows.Forms.TextBox tboxPlate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butInsert;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.ComboBox cboxType;
        private System.Windows.Forms.Label labError;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}