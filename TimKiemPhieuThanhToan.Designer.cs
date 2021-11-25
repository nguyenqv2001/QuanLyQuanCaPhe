namespace QuanLyQuanCaPhe
{
    partial class TimKiemPhieuThanhToan
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTimPhieuThanhToan = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimPhieuThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonTim);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePickerTo);
            this.panel1.Controls.Add(this.dateTimePickerFrom);
            this.panel1.Location = new System.Drawing.Point(57, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 100);
            this.panel1.TabIndex = 2;
            // 
            // buttonTim
            // 
            this.buttonTim.Location = new System.Drawing.Point(530, 33);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(75, 23);
            this.buttonTim.TabIndex = 4;
            this.buttonTim.Text = "Tìm";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo.Location = new System.Drawing.Point(306, 33);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(129, 22);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(97, 34);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(129, 22);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // dataGridViewTimPhieuThanhToan
            // 
            this.dataGridViewTimPhieuThanhToan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTimPhieuThanhToan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewTimPhieuThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimPhieuThanhToan.Location = new System.Drawing.Point(57, 155);
            this.dataGridViewTimPhieuThanhToan.Name = "dataGridViewTimPhieuThanhToan";
            this.dataGridViewTimPhieuThanhToan.RowTemplate.Height = 24;
            this.dataGridViewTimPhieuThanhToan.Size = new System.Drawing.Size(687, 291);
            this.dataGridViewTimPhieuThanhToan.TabIndex = 3;
            // 
            // TimKiemPhieuThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewTimPhieuThanhToan);
            this.Name = "TimKiemPhieuThanhToan";
            this.Text = "TimKiemPhieuThanhToan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimPhieuThanhToan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePickerTo;
        public System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        public System.Windows.Forms.DataGridView dataGridViewTimPhieuThanhToan;
    }
}