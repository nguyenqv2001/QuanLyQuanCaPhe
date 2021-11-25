namespace QuanLyQuanCaPhe
{
    partial class ThongKeDoanhThuTheoNgay
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerThongKeDoanhThuTheoNgay = new System.Windows.Forms.DateTimePicker();
            this.buttonKiemTra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewThongKeDoanhThuTheoNgay = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKeDoanhThuTheoNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePickerThongKeDoanhThuTheoNgay);
            this.panel1.Controls.Add(this.buttonKiemTra);
            this.panel1.Location = new System.Drawing.Point(56, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 96);
            this.panel1.TabIndex = 3;
            // 
            // dateTimePickerThongKeDoanhThuTheoNgay
            // 
            this.dateTimePickerThongKeDoanhThuTheoNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerThongKeDoanhThuTheoNgay.Location = new System.Drawing.Point(285, 31);
            this.dateTimePickerThongKeDoanhThuTheoNgay.Name = "dateTimePickerThongKeDoanhThuTheoNgay";
            this.dateTimePickerThongKeDoanhThuTheoNgay.Size = new System.Drawing.Size(115, 22);
            this.dateTimePickerThongKeDoanhThuTheoNgay.TabIndex = 1;
            // 
            // buttonKiemTra
            // 
            this.buttonKiemTra.Location = new System.Drawing.Point(472, 17);
            this.buttonKiemTra.Name = "buttonKiemTra";
            this.buttonKiemTra.Size = new System.Drawing.Size(120, 55);
            this.buttonKiemTra.TabIndex = 0;
            this.buttonKiemTra.Text = "Kiểm tra";
            this.buttonKiemTra.UseVisualStyleBackColor = true;
            this.buttonKiemTra.Click += new System.EventHandler(this.buttonKiemTra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bảng doanh thu theo ngày";
            // 
            // dataGridViewThongKeDoanhThuTheoNgay
            // 
            this.dataGridViewThongKeDoanhThuTheoNgay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewThongKeDoanhThuTheoNgay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewThongKeDoanhThuTheoNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongKeDoanhThuTheoNgay.Location = new System.Drawing.Point(56, 238);
            this.dataGridViewThongKeDoanhThuTheoNgay.Name = "dataGridViewThongKeDoanhThuTheoNgay";
            this.dataGridViewThongKeDoanhThuTheoNgay.RowTemplate.Height = 24;
            this.dataGridViewThongKeDoanhThuTheoNgay.Size = new System.Drawing.Size(840, 381);
            this.dataGridViewThongKeDoanhThuTheoNgay.TabIndex = 4;
            // 
            // ThongKeDoanhThuTheoNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 670);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewThongKeDoanhThuTheoNgay);
            this.Name = "ThongKeDoanhThuTheoNgay";
            this.Text = "ThongKeDoanhThu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKeDoanhThuTheoNgay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DateTimePicker dateTimePickerThongKeDoanhThuTheoNgay;
        public System.Windows.Forms.Button buttonKiemTra;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridViewThongKeDoanhThuTheoNgay;
    }
}