
namespace QuanLyQuanCaPhe
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbHD = new System.Windows.Forms.TextBox();
            this.tbKH = new System.Windows.Forms.TextBox();
            this.tbTong = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btThanhtoan = new System.Windows.Forms.Button();
            this.btnHuyHoaDon = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(942, 86);
            this.label1.TabIndex = 3;
            this.label1.Text = "HOÁ ĐƠN BÁN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(-7, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 86);
            this.panel2.TabIndex = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(801, 553);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 48);
            this.button1.TabIndex = 129;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbHD);
            this.groupBox2.Controls.Add(this.tbKH);
            this.groupBox2.Controls.Add(this.tbTong);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btThanhtoan);
            this.groupBox2.Controls.Add(this.btnHuyHoaDon);
            this.groupBox2.Controls.Add(this.btnInHoaDon);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btTimKiem);
            this.groupBox2.Location = new System.Drawing.Point(13, 105);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(906, 428);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hoá đơn";
            // 
            // tbHD
            // 
            this.tbHD.Location = new System.Drawing.Point(158, 64);
            this.tbHD.Margin = new System.Windows.Forms.Padding(4);
            this.tbHD.Name = "tbHD";
            this.tbHD.Size = new System.Drawing.Size(161, 22);
            this.tbHD.TabIndex = 33;
            // 
            // tbKH
            // 
            this.tbKH.Location = new System.Drawing.Point(158, 33);
            this.tbKH.Margin = new System.Windows.Forms.Padding(4);
            this.tbKH.Name = "tbKH";
            this.tbKH.Size = new System.Drawing.Size(161, 22);
            this.tbKH.TabIndex = 32;
            // 
            // tbTong
            // 
            this.tbTong.Location = new System.Drawing.Point(683, 351);
            this.tbTong.Margin = new System.Windows.Forms.Padding(4);
            this.tbTong.Name = "tbTong";
            this.tbTong.ReadOnly = true;
            this.tbTong.Size = new System.Drawing.Size(197, 22);
            this.tbTong.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(603, 354);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "Tổng tiền:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 35);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "Mã Khách Hàng:\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 67);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Mã Hóa Đơn:";
            // 
            // btThanhtoan
            // 
            this.btThanhtoan.Location = new System.Drawing.Point(373, 59);
            this.btThanhtoan.Margin = new System.Windows.Forms.Padding(4);
            this.btThanhtoan.Name = "btThanhtoan";
            this.btThanhtoan.Size = new System.Drawing.Size(138, 32);
            this.btThanhtoan.TabIndex = 4;
            this.btThanhtoan.Text = "Thanh toán";
            this.btThanhtoan.UseVisualStyleBackColor = true;
            this.btThanhtoan.Click += new System.EventHandler(this.btThanhtoan_Click);
            // 
            // btnHuyHoaDon
            // 
            this.btnHuyHoaDon.Location = new System.Drawing.Point(511, 388);
            this.btnHuyHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyHoaDon.Name = "btnHuyHoaDon";
            this.btnHuyHoaDon.Size = new System.Drawing.Size(164, 32);
            this.btnHuyHoaDon.TabIndex = 5;
            this.btnHuyHoaDon.Text = "Huỷ hoá đơn";
            this.btnHuyHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(708, 388);
            this.btnInHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(164, 32);
            this.btnInHoaDon.TabIndex = 6;
            this.btnInHoaDon.Text = "In hoá đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 105);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(906, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // btTimKiem
            // 
            this.btTimKiem.Location = new System.Drawing.Point(373, 23);
            this.btTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(138, 32);
            this.btTimKiem.TabIndex = 3;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 614);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "Form hóa đơn thanh toán";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbHD;
        private System.Windows.Forms.TextBox tbKH;
        private System.Windows.Forms.TextBox tbTong;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btThanhtoan;
        private System.Windows.Forms.Button btnHuyHoaDon;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btTimKiem;
    }
}