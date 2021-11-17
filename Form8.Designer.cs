
namespace QuanLyQuanCaPhe
{
    partial class Form8
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
            this.buttonTimKiemKhachHang = new System.Windows.Forms.Button();
            this.buttonTimKiemMonAn = new System.Windows.Forms.Button();
            this.buttonTimKiemThucPham = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTimKiemKhachHang
            // 
            this.buttonTimKiemKhachHang.Location = new System.Drawing.Point(125, 89);
            this.buttonTimKiemKhachHang.Name = "buttonTimKiemKhachHang";
            this.buttonTimKiemKhachHang.Size = new System.Drawing.Size(127, 69);
            this.buttonTimKiemKhachHang.TabIndex = 2;
            this.buttonTimKiemKhachHang.Text = "Tìm kiếm khách hàng";
            this.buttonTimKiemKhachHang.UseVisualStyleBackColor = true;
            this.buttonTimKiemKhachHang.Click += new System.EventHandler(this.buttonTimKiemKhachHang_Click);
            // 
            // buttonTimKiemMonAn
            // 
            this.buttonTimKiemMonAn.Location = new System.Drawing.Point(538, 89);
            this.buttonTimKiemMonAn.Name = "buttonTimKiemMonAn";
            this.buttonTimKiemMonAn.Size = new System.Drawing.Size(127, 69);
            this.buttonTimKiemMonAn.TabIndex = 3;
            this.buttonTimKiemMonAn.Text = "Tìm kiếm món ăn";
            this.buttonTimKiemMonAn.UseVisualStyleBackColor = true;
            this.buttonTimKiemMonAn.Click += new System.EventHandler(this.buttonTimKiemMonAn_Click);
            // 
            // buttonTimKiemThucPham
            // 
            this.buttonTimKiemThucPham.Location = new System.Drawing.Point(327, 283);
            this.buttonTimKiemThucPham.Name = "buttonTimKiemThucPham";
            this.buttonTimKiemThucPham.Size = new System.Drawing.Size(127, 69);
            this.buttonTimKiemThucPham.TabIndex = 4;
            this.buttonTimKiemThucPham.Text = "Tìm kiếm thực phẩm";
            this.buttonTimKiemThucPham.UseVisualStyleBackColor = true;
            this.buttonTimKiemThucPham.Click += new System.EventHandler(this.buttonTimKiemThucPham_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 530);
            this.Controls.Add(this.buttonTimKiemThucPham);
            this.Controls.Add(this.buttonTimKiemMonAn);
            this.Controls.Add(this.buttonTimKiemKhachHang);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button buttonTimKiemKhachHang;
        public System.Windows.Forms.Button buttonTimKiemMonAn;
        public System.Windows.Forms.Button buttonTimKiemThucPham;
    }
}