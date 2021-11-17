namespace QuanLyQuanCaPhe
{
    partial class FormNCC
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnext = new System.Windows.Forms.Button();
            this.btprev = new System.Windows.Forms.Button();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.picNcc = new System.Windows.Forms.PictureBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbDiachi = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNcc)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 72;
            // 
            // btnext
            // 
            this.btnext.BackColor = System.Drawing.Color.Blue;
            this.btnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnext.ForeColor = System.Drawing.Color.White;
            this.btnext.Location = new System.Drawing.Point(817, 285);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(45, 28);
            this.btnext.TabIndex = 141;
            this.btnext.Text = ">>";
            this.btnext.UseVisualStyleBackColor = false;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // btprev
            // 
            this.btprev.BackColor = System.Drawing.Color.Blue;
            this.btprev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btprev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btprev.ForeColor = System.Drawing.Color.White;
            this.btprev.Location = new System.Drawing.Point(753, 285);
            this.btprev.Name = "btprev";
            this.btprev.Size = new System.Drawing.Size(45, 28);
            this.btprev.TabIndex = 140;
            this.btprev.Text = "<<";
            this.btprev.UseVisualStyleBackColor = false;
            this.btprev.Click += new System.EventHandler(this.btprev_Click);
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(453, 254);
            this.tbLink.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(198, 22);
            this.tbLink.TabIndex = 139;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 138;
            this.label7.Text = "Link Avatar";
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Green;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.Location = new System.Drawing.Point(706, 138);
            this.btThem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(96, 44);
            this.btThem.TabIndex = 137;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Tomato;
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.ForeColor = System.Drawing.Color.Black;
            this.btThoat.Location = new System.Drawing.Point(896, 15);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(96, 44);
            this.btThoat.TabIndex = 136;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Green;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.Location = new System.Drawing.Point(817, 138);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(96, 44);
            this.btXoa.TabIndex = 135;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.Green;
            this.btReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btReset.ForeColor = System.Drawing.Color.White;
            this.btReset.Location = new System.Drawing.Point(817, 208);
            this.btReset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(96, 44);
            this.btReset.TabIndex = 134;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.Green;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSua.ForeColor = System.Drawing.Color.White;
            this.btSua.Location = new System.Drawing.Point(706, 207);
            this.btSua.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(96, 44);
            this.btSua.TabIndex = 133;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 350);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(935, 379);
            this.dataGridView1.TabIndex = 132;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // picNcc
            // 
            this.picNcc.Location = new System.Drawing.Point(43, 63);
            this.picNcc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picNcc.Name = "picNcc";
            this.picNcc.Size = new System.Drawing.Size(198, 228);
            this.picNcc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNcc.TabIndex = 131;
            this.picNcc.TabStop = false;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(453, 127);
            this.tbTen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(198, 22);
            this.tbTen.TabIndex = 130;
            // 
            // tbDiachi
            // 
            this.tbDiachi.Location = new System.Drawing.Point(453, 171);
            this.tbDiachi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbDiachi.Name = "tbDiachi";
            this.tbDiachi.Size = new System.Drawing.Size(198, 22);
            this.tbDiachi.TabIndex = 129;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(453, 216);
            this.tbSDT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(198, 22);
            this.tbSDT.TabIndex = 128;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(453, 82);
            this.tbID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(198, 22);
            this.tbID.TabIndex = 127;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 126;
            this.label6.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 125;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 124;
            this.label4.Text = "Tên nhà cung cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 123;
            this.label1.Text = "Mã nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(316, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 30);
            this.label2.TabIndex = 122;
            this.label2.Text = "THÔNG TIN NHÀ CUNG CẤP";
            // 
            // FormNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 636);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.btprev);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.picNcc);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbDiachi);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "FormNCC";
            this.Text = "THÔNG TIN NHÀ CUNG CẤP";
            this.Load += new System.EventHandler(this.FormNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNcc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.Button btprev;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox picNcc;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbDiachi;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}