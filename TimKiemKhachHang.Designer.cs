namespace QuanLyQuanCaPhe
{
    partial class TimKiemKhachHang
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
            this.textBoxDuLieu = new System.Windows.Forms.TextBox();
            this.buttonTim = new System.Windows.Forms.Button();
            this.radioButtonTen = new System.Windows.Forms.RadioButton();
            this.radioButtonID = new System.Windows.Forms.RadioButton();
            this.dataGridViewDuLieu = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxDuLieu);
            this.panel1.Controls.Add(this.buttonTim);
            this.panel1.Controls.Add(this.radioButtonTen);
            this.panel1.Controls.Add(this.radioButtonID);
            this.panel1.Location = new System.Drawing.Point(30, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 114);
            this.panel1.TabIndex = 2;
            // 
            // textBoxDuLieu
            // 
            this.textBoxDuLieu.Location = new System.Drawing.Point(144, 55);
            this.textBoxDuLieu.Name = "textBoxDuLieu";
            this.textBoxDuLieu.Size = new System.Drawing.Size(236, 22);
            this.textBoxDuLieu.TabIndex = 3;
            // 
            // buttonTim
            // 
            this.buttonTim.Location = new System.Drawing.Point(434, 54);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(75, 23);
            this.buttonTim.TabIndex = 2;
            this.buttonTim.Text = "Tìm";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click_1);
            // 
            // radioButtonTen
            // 
            this.radioButtonTen.AutoSize = true;
            this.radioButtonTen.Location = new System.Drawing.Point(411, 16);
            this.radioButtonTen.Name = "radioButtonTen";
            this.radioButtonTen.Size = new System.Drawing.Size(108, 21);
            this.radioButtonTen.TabIndex = 1;
            this.radioButtonTen.TabStop = true;
            this.radioButtonTen.Text = "Tìm theo tên";
            this.radioButtonTen.UseVisualStyleBackColor = true;
            // 
            // radioButtonID
            // 
            this.radioButtonID.AutoSize = true;
            this.radioButtonID.Location = new System.Drawing.Point(144, 16);
            this.radioButtonID.Name = "radioButtonID";
            this.radioButtonID.Size = new System.Drawing.Size(101, 21);
            this.radioButtonID.TabIndex = 0;
            this.radioButtonID.TabStop = true;
            this.radioButtonID.Text = "Tìm theo ID";
            this.radioButtonID.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDuLieu
            // 
            this.dataGridViewDuLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDuLieu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewDuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDuLieu.Location = new System.Drawing.Point(30, 208);
            this.dataGridViewDuLieu.Name = "dataGridViewDuLieu";
            this.dataGridViewDuLieu.RowTemplate.Height = 24;
            this.dataGridViewDuLieu.Size = new System.Drawing.Size(741, 375);
            this.dataGridViewDuLieu.TabIndex = 3;
            // 
            // TimKiemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDuLieu);
            this.Name = "TimKiemKhachHang";
            this.Text = "TimKiemKhachHang";
            this.Load += new System.EventHandler(this.TimKiemKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox textBoxDuLieu;
        public System.Windows.Forms.Button buttonTim;
        public System.Windows.Forms.RadioButton radioButtonTen;
        public System.Windows.Forms.RadioButton radioButtonID;
        public System.Windows.Forms.DataGridView dataGridViewDuLieu;
    }
}