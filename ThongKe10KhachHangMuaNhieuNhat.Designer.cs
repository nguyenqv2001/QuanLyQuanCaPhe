namespace QuanLyQuanCaPhe
{
    partial class ThongKe10KhachHangMuaNhieuNhat
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewThongKe10KhachHang = new System.Windows.Forms.DataGridView();
            this.chartThongKe10KhachHang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKe10KhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe10KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewThongKe10KhachHang
            // 
            this.dataGridViewThongKe10KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewThongKe10KhachHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewThongKe10KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongKe10KhachHang.Location = new System.Drawing.Point(42, 420);
            this.dataGridViewThongKe10KhachHang.Name = "dataGridViewThongKe10KhachHang";
            this.dataGridViewThongKe10KhachHang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewThongKe10KhachHang.RowTemplate.Height = 24;
            this.dataGridViewThongKe10KhachHang.Size = new System.Drawing.Size(717, 247);
            this.dataGridViewThongKe10KhachHang.TabIndex = 6;
            // 
            // chartThongKe10KhachHang
            // 
            chartArea1.Name = "ChartArea1";
            this.chartThongKe10KhachHang.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartThongKe10KhachHang.Legends.Add(legend1);
            this.chartThongKe10KhachHang.Location = new System.Drawing.Point(42, 66);
            this.chartThongKe10KhachHang.Name = "chartThongKe10KhachHang";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Thống Kê Khách Hàng";
            this.chartThongKe10KhachHang.Series.Add(series1);
            this.chartThongKe10KhachHang.Size = new System.Drawing.Size(717, 320);
            this.chartThongKe10KhachHang.TabIndex = 5;
            this.chartThongKe10KhachHang.Text = "chart1";
            // 
            // ThongKe10KhachHangMuaNhieuNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 706);
            this.Controls.Add(this.dataGridViewThongKe10KhachHang);
            this.Controls.Add(this.chartThongKe10KhachHang);
            this.Name = "ThongKe10KhachHangMuaNhieuNhat";
            this.Text = "ThongKe10KhachHangMuaNhieuNhat";
            this.Load += new System.EventHandler(this.ThongKe10KhachHangMuaNhieuNhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKe10KhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKe10KhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewThongKe10KhachHang;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartThongKe10KhachHang;
    }
}