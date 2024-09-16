namespace QuanLyQuanCaPhe
{
    partial class TimKiemThucPham
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
            this.radioButtonNCC = new System.Windows.Forms.RadioButton();
            this.textBoxDuLieu = new System.Windows.Forms.TextBox();
            this.radioButtonTen = new System.Windows.Forms.RadioButton();
            this.radioButtonID = new System.Windows.Forms.RadioButton();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.dataGridViewDuLieu = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonNCC);
            this.panel1.Controls.Add(this.textBoxDuLieu);
            this.panel1.Controls.Add(this.radioButtonTen);
            this.panel1.Controls.Add(this.radioButtonID);
            this.panel1.Controls.Add(this.buttonCheck);
            this.panel1.Location = new System.Drawing.Point(28, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 98);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // radioButtonNCC
            // 
            this.radioButtonNCC.AutoSize = true;
            this.radioButtonNCC.Location = new System.Drawing.Point(423, 13);
            this.radioButtonNCC.Name = "radioButtonNCC";
            this.radioButtonNCC.Size = new System.Drawing.Size(174, 21);
            this.radioButtonNCC.TabIndex = 6;
            this.radioButtonNCC.TabStop = true;
            this.radioButtonNCC.Text = "Tìm theo nhà cung cấp";
            this.radioButtonNCC.UseVisualStyleBackColor = true;
            // 
            // textBoxDuLieu
            // 
            this.textBoxDuLieu.Location = new System.Drawing.Point(149, 50);
            this.textBoxDuLieu.Name = "textBoxDuLieu";
            this.textBoxDuLieu.Size = new System.Drawing.Size(236, 22);
            this.textBoxDuLieu.TabIndex = 5;
            // 
            // radioButtonTen
            // 
            this.radioButtonTen.AutoSize = true;
            this.radioButtonTen.Location = new System.Drawing.Point(260, 13);
            this.radioButtonTen.Name = "radioButtonTen";
            this.radioButtonTen.Size = new System.Drawing.Size(108, 21);
            this.radioButtonTen.TabIndex = 4;
            this.radioButtonTen.TabStop = true;
            this.radioButtonTen.Text = "Tìm theo tên";
            this.radioButtonTen.UseVisualStyleBackColor = true;
            // 
            // radioButtonID
            // 
            this.radioButtonID.AutoSize = true;
            this.radioButtonID.Location = new System.Drawing.Point(102, 13);
            this.radioButtonID.Name = "radioButtonID";
            this.radioButtonID.Size = new System.Drawing.Size(101, 21);
            this.radioButtonID.TabIndex = 3;
            this.radioButtonID.TabStop = true;
            this.radioButtonID.Text = "Tìm theo ID";
            this.radioButtonID.UseVisualStyleBackColor = true;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(651, 31);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 25);
            this.buttonCheck.TabIndex = 2;
            this.buttonCheck.Text = "Tìm";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click_1);
            // 
            // dataGridViewDuLieu
            // 
            this.dataGridViewDuLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDuLieu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewDuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDuLieu.Location = new System.Drawing.Point(28, 164);
            this.dataGridViewDuLieu.Name = "dataGridViewDuLieu";
            this.dataGridViewDuLieu.RowHeadersWidth = 51;
            this.dataGridViewDuLieu.RowTemplate.Height = 24;
            this.dataGridViewDuLieu.Size = new System.Drawing.Size(745, 288);
            this.dataGridViewDuLieu.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(698, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimKiemThucPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewDuLieu);
            this.Name = "TimKiemThucPham";
            this.Text = "TimKiemThucPham";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDuLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RadioButton radioButtonNCC;
        public System.Windows.Forms.TextBox textBoxDuLieu;
        public System.Windows.Forms.RadioButton radioButtonTen;
        public System.Windows.Forms.RadioButton radioButtonID;
        public System.Windows.Forms.Button buttonCheck;
        public System.Windows.Forms.DataGridView dataGridViewDuLieu;
        public System.Windows.Forms.Button button1;
    }
}