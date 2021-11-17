namespace QuanLyQuanCaPhe
{
    partial class TimKiemMonAn
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
            this.buttonTim = new System.Windows.Forms.Button();
            this.textBoxDuLieu = new System.Windows.Forms.TextBox();
            this.radioButtonTenMon = new System.Windows.Forms.RadioButton();
            this.radioButtonLoaiMon = new System.Windows.Forms.RadioButton();
            this.dataGridViewTimKiemMonAn = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiemMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonTim);
            this.panel1.Controls.Add(this.textBoxDuLieu);
            this.panel1.Controls.Add(this.radioButtonTenMon);
            this.panel1.Controls.Add(this.radioButtonLoaiMon);
            this.panel1.Location = new System.Drawing.Point(29, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 100);
            this.panel1.TabIndex = 3;
            // 
            // buttonTim
            // 
            this.buttonTim.Location = new System.Drawing.Point(433, 49);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(75, 23);
            this.buttonTim.TabIndex = 3;
            this.buttonTim.Text = "Tìm";
            this.buttonTim.UseVisualStyleBackColor = true;
            // 
            // textBoxDuLieu
            // 
            this.textBoxDuLieu.Location = new System.Drawing.Point(134, 49);
            this.textBoxDuLieu.Name = "textBoxDuLieu";
            this.textBoxDuLieu.Size = new System.Drawing.Size(249, 22);
            this.textBoxDuLieu.TabIndex = 2;
            // 
            // radioButtonTenMon
            // 
            this.radioButtonTenMon.AutoSize = true;
            this.radioButtonTenMon.Location = new System.Drawing.Point(400, 6);
            this.radioButtonTenMon.Name = "radioButtonTenMon";
            this.radioButtonTenMon.Size = new System.Drawing.Size(108, 21);
            this.radioButtonTenMon.TabIndex = 1;
            this.radioButtonTenMon.TabStop = true;
            this.radioButtonTenMon.Text = "Tìm theo tên";
            this.radioButtonTenMon.UseVisualStyleBackColor = true;
            // 
            // radioButtonLoaiMon
            // 
            this.radioButtonLoaiMon.AutoSize = true;
            this.radioButtonLoaiMon.Location = new System.Drawing.Point(134, 6);
            this.radioButtonLoaiMon.Name = "radioButtonLoaiMon";
            this.radioButtonLoaiMon.Size = new System.Drawing.Size(141, 21);
            this.radioButtonLoaiMon.TabIndex = 0;
            this.radioButtonLoaiMon.TabStop = true;
            this.radioButtonLoaiMon.Text = "Tìm theo loại món";
            this.radioButtonLoaiMon.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTimKiemMonAn
            // 
            this.dataGridViewTimKiemMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimKiemMonAn.Location = new System.Drawing.Point(29, 123);
            this.dataGridViewTimKiemMonAn.Name = "dataGridViewTimKiemMonAn";
            this.dataGridViewTimKiemMonAn.RowTemplate.Height = 24;
            this.dataGridViewTimKiemMonAn.Size = new System.Drawing.Size(742, 310);
            this.dataGridViewTimKiemMonAn.TabIndex = 2;
            // 
            // TimKiemMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewTimKiemMonAn);
            this.Name = "TimKiemMonAn";
            this.Text = "TimKiemMonAn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimKiemMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button buttonTim;
        public System.Windows.Forms.TextBox textBoxDuLieu;
        public System.Windows.Forms.RadioButton radioButtonTenMon;
        public System.Windows.Forms.RadioButton radioButtonLoaiMon;
        public System.Windows.Forms.DataGridView dataGridViewTimKiemMonAn;
    }
}