
namespace QuanLyQuanCaPhe
{
    partial class Form6
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
            this.label6 = new System.Windows.Forms.Label();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnext = new System.Windows.Forms.Button();
            this.btprev = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.tbSdt = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbDiachi = new System.Windows.Forms.TextBox();
            this.tbChucvu = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.picNV = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 309);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 144;
            this.label6.Text = "Link Avatar";
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(228, 304);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(189, 22);
            this.tbLink.TabIndex = 143;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 409);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 310);
            this.dataGridView1.TabIndex = 142;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnext
            // 
            this.btnext.BackColor = System.Drawing.Color.Blue;
            this.btnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnext.ForeColor = System.Drawing.Color.White;
            this.btnext.Location = new System.Drawing.Point(314, 358);
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
            this.btprev.Location = new System.Drawing.Point(250, 358);
            this.btprev.Name = "btprev";
            this.btprev.Size = new System.Drawing.Size(45, 28);
            this.btprev.TabIndex = 140;
            this.btprev.Text = "<<";
            this.btprev.UseVisualStyleBackColor = false;
            this.btprev.Click += new System.EventHandler(this.btprev_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Tomato;
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThoat.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.ForeColor = System.Drawing.Color.Black;
            this.btThoat.Location = new System.Drawing.Point(1023, 16);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(107, 38);
            this.btThoat.TabIndex = 139;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.OliveDrab;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXoa.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.ForeColor = System.Drawing.Color.Transparent;
            this.btXoa.Location = new System.Drawing.Point(939, 146);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(107, 38);
            this.btXoa.TabIndex = 138;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.OliveDrab;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSua.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSua.ForeColor = System.Drawing.Color.Transparent;
            this.btSua.Location = new System.Drawing.Point(808, 213);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(107, 38);
            this.btSua.TabIndex = 137;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.OliveDrab;
            this.btReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btReset.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btReset.ForeColor = System.Drawing.Color.Transparent;
            this.btReset.Location = new System.Drawing.Point(939, 213);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(107, 38);
            this.btReset.TabIndex = 136;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.OliveDrab;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btThem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.ForeColor = System.Drawing.Color.Transparent;
            this.btThem.Location = new System.Drawing.Point(808, 146);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(107, 38);
            this.btThem.TabIndex = 135;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // tbSdt
            // 
            this.tbSdt.Location = new System.Drawing.Point(228, 266);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(189, 22);
            this.tbSdt.TabIndex = 134;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(228, 146);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(189, 22);
            this.tbTen.TabIndex = 133;
            // 
            // tbDiachi
            // 
            this.tbDiachi.Location = new System.Drawing.Point(228, 187);
            this.tbDiachi.Name = "tbDiachi";
            this.tbDiachi.Size = new System.Drawing.Size(189, 22);
            this.tbDiachi.TabIndex = 132;
            // 
            // tbChucvu
            // 
            this.tbChucvu.Location = new System.Drawing.Point(228, 225);
            this.tbChucvu.Name = "tbChucvu";
            this.tbChucvu.Size = new System.Drawing.Size(189, 22);
            this.tbChucvu.TabIndex = 131;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(228, 108);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(189, 22);
            this.tbID.TabIndex = 130;
            // 
            // picNV
            // 
            this.picNV.Location = new System.Drawing.Point(498, 92);
            this.picNV.Name = "picNV";
            this.picNV.Size = new System.Drawing.Size(199, 243);
            this.picNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNV.TabIndex = 129;
            this.picNV.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 228);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 128;
            this.label7.Text = "Chức vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 127;
            this.label5.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 126;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 125;
            this.label3.Text = "SĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 124;
            this.label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(438, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 29);
            this.label1.TabIndex = 123;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 634);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.btprev);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.tbSdt);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbDiachi);
            this.Controls.Add(this.tbChucvu);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.picNV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form quản lý nhân viên";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.Button btprev;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox tbSdt;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbDiachi;
        private System.Windows.Forms.TextBox tbChucvu;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.PictureBox picNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}