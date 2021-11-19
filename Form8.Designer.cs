
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTimKiemKhachHang
            // 
            this.buttonTimKiemKhachHang.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonTimKiemKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiemKhachHang.Location = new System.Drawing.Point(109, 171);
            this.buttonTimKiemKhachHang.Name = "buttonTimKiemKhachHang";
            this.buttonTimKiemKhachHang.Size = new System.Drawing.Size(613, 69);
            this.buttonTimKiemKhachHang.TabIndex = 2;
            this.buttonTimKiemKhachHang.Text = "Tìm kiếm khách hàng";
            this.buttonTimKiemKhachHang.UseVisualStyleBackColor = false;
            this.buttonTimKiemKhachHang.Click += new System.EventHandler(this.buttonTimKiemKhachHang_Click);
            // 
            // buttonTimKiemMonAn
            // 
            this.buttonTimKiemMonAn.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonTimKiemMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiemMonAn.Location = new System.Drawing.Point(109, 271);
            this.buttonTimKiemMonAn.Name = "buttonTimKiemMonAn";
            this.buttonTimKiemMonAn.Size = new System.Drawing.Size(613, 69);
            this.buttonTimKiemMonAn.TabIndex = 3;
            this.buttonTimKiemMonAn.Text = "Tìm kiếm món ăn";
            this.buttonTimKiemMonAn.UseVisualStyleBackColor = false;
            this.buttonTimKiemMonAn.Click += new System.EventHandler(this.buttonTimKiemMonAn_Click);
            // 
            // buttonTimKiemThucPham
            // 
            this.buttonTimKiemThucPham.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonTimKiemThucPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiemThucPham.Location = new System.Drawing.Point(109, 373);
            this.buttonTimKiemThucPham.Name = "buttonTimKiemThucPham";
            this.buttonTimKiemThucPham.Size = new System.Drawing.Size(613, 69);
            this.buttonTimKiemThucPham.TabIndex = 4;
            this.buttonTimKiemThucPham.Text = "Tìm kiếm thực phẩm";
            this.buttonTimKiemThucPham.UseVisualStyleBackColor = false;
            this.buttonTimKiemThucPham.Click += new System.EventHandler(this.buttonTimKiemThucPham_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(714, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hỗ Trợ Tìm Kiếm";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonTimKiemThucPham);
            this.Controls.Add(this.buttonTimKiemMonAn);
            this.Controls.Add(this.buttonTimKiemKhachHang);
            this.Name = "Form8";
            this.Text = "Form hỗ trợ tìm kiếm";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button buttonTimKiemKhachHang;
        public System.Windows.Forms.Button buttonTimKiemMonAn;
        public System.Windows.Forms.Button buttonTimKiemThucPham;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}