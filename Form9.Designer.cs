
namespace QuanLyQuanCaPhe
{
    partial class Form9
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
            this.buttonThongKeDoanhThu = new System.Windows.Forms.Button();
            this.buttonThongKeThucPham = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonThongKeDoanhThuTheoNgay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonThongKeDoanhThu
            // 
            this.buttonThongKeDoanhThu.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonThongKeDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThongKeDoanhThu.Location = new System.Drawing.Point(134, 250);
            this.buttonThongKeDoanhThu.Name = "buttonThongKeDoanhThu";
            this.buttonThongKeDoanhThu.Size = new System.Drawing.Size(530, 82);
            this.buttonThongKeDoanhThu.TabIndex = 0;
            this.buttonThongKeDoanhThu.Text = "Thống kê 10 khách hàng thân thiết";
            this.buttonThongKeDoanhThu.UseVisualStyleBackColor = false;
            this.buttonThongKeDoanhThu.Click += new System.EventHandler(this.buttonThongKeDoanhThu_Click);
            // 
            // buttonThongKeThucPham
            // 
            this.buttonThongKeThucPham.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonThongKeThucPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThongKeThucPham.Location = new System.Drawing.Point(134, 135);
            this.buttonThongKeThucPham.Name = "buttonThongKeThucPham";
            this.buttonThongKeThucPham.Size = new System.Drawing.Size(530, 85);
            this.buttonThongKeThucPham.TabIndex = 1;
            this.buttonThongKeThucPham.Text = "Thống kê 10 thực phẩm bán chạy";
            this.buttonThongKeThucPham.UseVisualStyleBackColor = false;
            this.buttonThongKeThucPham.Click += new System.EventHandler(this.buttonThongKeThucPham_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(675, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thống Kê Tìm Kiếm";
            // 
            // buttonThongKeDoanhThuTheoNgay
            // 
            this.buttonThongKeDoanhThuTheoNgay.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonThongKeDoanhThuTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThongKeDoanhThuTheoNgay.Location = new System.Drawing.Point(134, 369);
            this.buttonThongKeDoanhThuTheoNgay.Name = "buttonThongKeDoanhThuTheoNgay";
            this.buttonThongKeDoanhThuTheoNgay.Size = new System.Drawing.Size(530, 82);
            this.buttonThongKeDoanhThuTheoNgay.TabIndex = 9;
            this.buttonThongKeDoanhThuTheoNgay.Text = "Thống kê doanh thu theo ngày";
            this.buttonThongKeDoanhThuTheoNgay.UseVisualStyleBackColor = false;
            this.buttonThongKeDoanhThuTheoNgay.Click += new System.EventHandler(this.buttonThongKeDoanhThuTheoNgay_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.buttonThongKeDoanhThuTheoNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonThongKeThucPham);
            this.Controls.Add(this.buttonThongKeDoanhThu);
            this.Name = "Form9";
            this.Text = "Form Thống kê báo cáo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button buttonThongKeDoanhThu;
        public System.Windows.Forms.Button buttonThongKeThucPham;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button buttonThongKeDoanhThuTheoNgay;
    }
}