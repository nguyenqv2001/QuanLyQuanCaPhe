
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
            this.SuspendLayout();
            // 
            // buttonThongKeDoanhThu
            // 
            this.buttonThongKeDoanhThu.Location = new System.Drawing.Point(216, 118);
            this.buttonThongKeDoanhThu.Name = "buttonThongKeDoanhThu";
            this.buttonThongKeDoanhThu.Size = new System.Drawing.Size(103, 73);
            this.buttonThongKeDoanhThu.TabIndex = 0;
            this.buttonThongKeDoanhThu.Text = "Thống kê doanh thu";
            this.buttonThongKeDoanhThu.UseVisualStyleBackColor = true;
            this.buttonThongKeDoanhThu.Click += new System.EventHandler(this.buttonThongKeDoanhThu_Click);
            // 
            // buttonThongKeThucPham
            // 
            this.buttonThongKeThucPham.Location = new System.Drawing.Point(469, 118);
            this.buttonThongKeThucPham.Name = "buttonThongKeThucPham";
            this.buttonThongKeThucPham.Size = new System.Drawing.Size(103, 73);
            this.buttonThongKeThucPham.TabIndex = 1;
            this.buttonThongKeThucPham.Text = "Thống kê thực phẩm";
            this.buttonThongKeThucPham.UseVisualStyleBackColor = true;
            this.buttonThongKeThucPham.Click += new System.EventHandler(this.buttonThongKeThucPham_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonThongKeThucPham);
            this.Controls.Add(this.buttonThongKeDoanhThu);
            this.Name = "Form9";
            this.Text = "Form9";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button buttonThongKeDoanhThu;
        public System.Windows.Forms.Button buttonThongKeThucPham;
    }
}