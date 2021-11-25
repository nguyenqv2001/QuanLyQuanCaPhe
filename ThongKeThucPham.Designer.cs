namespace QuanLyQuanCaPhe
{
    partial class ThongKeThucPham
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewThongKeThucPhamBanChay = new System.Windows.Forms.DataGridView();
            this.chartThongKeThucPhamBanChay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKeThucPhamBanChay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKeThucPhamBanChay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bảng doanh thu thực phẩm";
            // 
            // dataGridViewThongKeThucPhamBanChay
            // 
            this.dataGridViewThongKeThucPhamBanChay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewThongKeThucPhamBanChay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewThongKeThucPhamBanChay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongKeThucPhamBanChay.Location = new System.Drawing.Point(140, 382);
            this.dataGridViewThongKeThucPhamBanChay.Name = "dataGridViewThongKeThucPhamBanChay";
            this.dataGridViewThongKeThucPhamBanChay.RowTemplate.Height = 24;
            this.dataGridViewThongKeThucPhamBanChay.Size = new System.Drawing.Size(532, 245);
            this.dataGridViewThongKeThucPhamBanChay.TabIndex = 4;
            // 
            // chartThongKeThucPhamBanChay
            // 
            chartArea2.Name = "ChartArea1";
            this.chartThongKeThucPhamBanChay.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartThongKeThucPhamBanChay.Legends.Add(legend2);
            this.chartThongKeThucPhamBanChay.Location = new System.Drawing.Point(42, 23);
            this.chartThongKeThucPhamBanChay.Name = "chartThongKeThucPhamBanChay";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Thống Kê Thực Phẩm Bán Chạy";
            this.chartThongKeThucPhamBanChay.Series.Add(series2);
            this.chartThongKeThucPhamBanChay.Size = new System.Drawing.Size(724, 300);
            this.chartThongKeThucPhamBanChay.TabIndex = 3;
            this.chartThongKeThucPhamBanChay.Text = "chart1";
            // 
            // ThongKeThucPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 657);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewThongKeThucPhamBanChay);
            this.Controls.Add(this.chartThongKeThucPhamBanChay);
            this.Name = "ThongKeThucPham";
            this.Text = "ThongKeThucPham";
            this.Load += new System.EventHandler(this.ThongKeThucPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKeThucPhamBanChay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKeThucPhamBanChay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridViewThongKeThucPhamBanChay;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartThongKeThucPhamBanChay;
    }
}