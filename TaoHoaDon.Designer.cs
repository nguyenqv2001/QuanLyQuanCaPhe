namespace QuanLyQuanCaPhe
{
    partial class TaoHoaDon
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
            this.comboBoxNhanVien = new System.Windows.Forms.ComboBox();
            this.comboBoxKhachHang = new System.Windows.Forms.ComboBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.dateTimePickerNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.textBoxMaPhieuYeuCau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxNhanVien
            // 
            this.comboBoxNhanVien.FormattingEnabled = true;
            this.comboBoxNhanVien.Location = new System.Drawing.Point(427, 190);
            this.comboBoxNhanVien.Name = "comboBoxNhanVien";
            this.comboBoxNhanVien.Size = new System.Drawing.Size(121, 24);
            this.comboBoxNhanVien.TabIndex = 19;
            // 
            // comboBoxKhachHang
            // 
            this.comboBoxKhachHang.FormattingEnabled = true;
            this.comboBoxKhachHang.Location = new System.Drawing.Point(427, 149);
            this.comboBoxKhachHang.Name = "comboBoxKhachHang";
            this.comboBoxKhachHang.Size = new System.Drawing.Size(121, 24);
            this.comboBoxKhachHang.TabIndex = 18;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(427, 324);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 28);
            this.buttonThem.TabIndex = 17;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerNgayNhap
            // 
            this.dateTimePickerNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayNhap.Location = new System.Drawing.Point(427, 245);
            this.dateTimePickerNgayNhap.Name = "dateTimePickerNgayNhap";
            this.dateTimePickerNgayNhap.Size = new System.Drawing.Size(155, 22);
            this.dateTimePickerNgayNhap.TabIndex = 16;
            // 
            // textBoxMaPhieuYeuCau
            // 
            this.textBoxMaPhieuYeuCau.Location = new System.Drawing.Point(427, 98);
            this.textBoxMaPhieuYeuCau.Name = "textBoxMaPhieuYeuCau";
            this.textBoxMaPhieuYeuCau.Size = new System.Drawing.Size(100, 22);
            this.textBoxMaPhieuYeuCau.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ngày nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã phiếu yêu cầu:";
            // 
            // TaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxNhanVien);
            this.Controls.Add(this.comboBoxKhachHang);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.dateTimePickerNgayNhap);
            this.Controls.Add(this.textBoxMaPhieuYeuCau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaoHoaDon";
            this.Text = "TaoHoaDon";
            this.Load += new System.EventHandler(this.TaoHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBoxNhanVien;
        public System.Windows.Forms.ComboBox comboBoxKhachHang;
        public System.Windows.Forms.Button buttonThem;
        public System.Windows.Forms.DateTimePicker dateTimePickerNgayNhap;
        public System.Windows.Forms.TextBox textBoxMaPhieuYeuCau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}