namespace CSharp_68PM1_BuiTienDat_0007168
{
    partial class UC_QLSV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtMaSV = new TextBox();
            label2 = new Label();
            txtHoTen = new TextBox();
            label3 = new Label();
            dtpNgaySinh = new DateTimePicker();
            label4 = new Label();
            cboGioiTinh = new ComboBox();
            label5 = new Label();
            cboLop = new ComboBox();
            panelPhanTrang = new Panel();
            btnFirst = new Button();
            btnPrev = new Button();
            lblPhanTrang = new Label();
            btnNext = new Button();
            btnLast = new Button();
            dgvSinhVien = new DataGridView();
            btnTim = new Button();
            txtTimKiem = new TextBox();
            label6 = new Label();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            btnLamMoi = new Button();
            btnSua = new Button();
            panelPhanTrang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 44);
            label1.Name = "label1";
            label1.Size = new Size(94, 18);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên:";
            // 
            // txtMaSV
            // 
            txtMaSV.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaSV.Location = new Point(18, 75);
            txtMaSV.Margin = new Padding(3, 4, 3, 4);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(360, 26);
            txtMaSV.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 144);
            label2.Name = "label2";
            label2.Size = new Size(75, 18);
            label2.TabIndex = 2;
            label2.Text = "Họ và tên:";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHoTen.Location = new Point(18, 175);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(360, 26);
            txtHoTen.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 250);
            label3.Name = "label3";
            label3.Size = new Size(77, 18);
            label3.TabIndex = 4;
            label3.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(18, 281);
            dtpNgaySinh.Margin = new Padding(3, 4, 3, 4);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(360, 26);
            dtpNgaySinh.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 356);
            label4.Name = "label4";
            label4.Size = new Size(66, 18);
            label4.TabIndex = 6;
            label4.Text = "Giới tính:";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(18, 388);
            cboGioiTinh.Margin = new Padding(3, 4, 3, 4);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(360, 28);
            cboGioiTinh.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 462);
            label5.Name = "label5";
            label5.Size = new Size(37, 18);
            label5.TabIndex = 8;
            label5.Text = "Lớp:";
            // 
            // cboLop
            // 
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(18, 494);
            cboLop.Margin = new Padding(3, 4, 3, 4);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(360, 28);
            cboLop.TabIndex = 9;
            // 
            // panelPhanTrang
            // 
            panelPhanTrang.BorderStyle = BorderStyle.FixedSingle;
            panelPhanTrang.Controls.Add(btnFirst);
            panelPhanTrang.Controls.Add(btnPrev);
            panelPhanTrang.Controls.Add(lblPhanTrang);
            panelPhanTrang.Controls.Add(btnNext);
            panelPhanTrang.Controls.Add(btnLast);
            panelPhanTrang.Location = new Point(493, 723);
            panelPhanTrang.Margin = new Padding(3, 4, 3, 4);
            panelPhanTrang.Name = "panelPhanTrang";
            panelPhanTrang.Size = new Size(790, 62);
            panelPhanTrang.TabIndex = 30;
            // 
            // btnFirst
            // 
            btnFirst.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnFirst.Location = new Point(3, 4);
            btnFirst.Margin = new Padding(3, 4, 3, 4);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(60, 52);
            btnFirst.TabIndex = 0;
            btnFirst.Text = "<<";
            btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            btnPrev.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnPrev.Location = new Point(69, 4);
            btnPrev.Margin = new Padding(3, 4, 3, 4);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(60, 52);
            btnPrev.TabIndex = 1;
            btnPrev.Text = "<";
            btnPrev.UseVisualStyleBackColor = true;
            // 
            // lblPhanTrang
            // 
            lblPhanTrang.Font = new Font("Microsoft Sans Serif", 10F);
            lblPhanTrang.Location = new Point(135, 4);
            lblPhanTrang.Name = "lblPhanTrang";
            lblPhanTrang.Size = new Size(520, 52);
            lblPhanTrang.TabIndex = 2;
            lblPhanTrang.Text = "Trang 1/1  |  3 bản ghi";
            lblPhanTrang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnNext.Location = new Point(661, 4);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(60, 52);
            btnNext.TabIndex = 3;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            btnLast.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnLast.Location = new Point(727, 4);
            btnLast.Margin = new Padding(3, 4, 3, 4);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(60, 52);
            btnLast.TabIndex = 4;
            btnLast.Text = ">>";
            btnLast.UseVisualStyleBackColor = true;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.BackgroundColor = Color.White;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(493, 129);
            dgvSinhVien.Margin = new Padding(3, 4, 3, 4);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.RowTemplate.Height = 24;
            dgvSinhVien.Size = new Size(790, 581);
            dgvSinhVien.TabIndex = 29;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(44, 62, 80);
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnTim.ForeColor = Color.White;
            btnTim.Location = new Point(868, 55);
            btnTim.Margin = new Padding(3, 4, 3, 4);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(110, 45);
            btnTim.TabIndex = 28;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 11F);
            txtTimKiem.Location = new Point(493, 60);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(360, 28);
            txtTimKiem.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label6.Location = new Point(489, 23);
            label6.Name = "label6";
            label6.Size = new Size(264, 20);
            label6.TabIndex = 26;
            label6.Text = "Tìm kiếm (Tên / Mã SV / Lớp):";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(231, 76, 60);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(44, 723);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(190, 62);
            btnXoa.TabIndex = 24;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(52, 152, 219);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(44, 642);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(190, 62);
            btnThem.TabIndex = 22;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMaSV);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboGioiTinh);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboLop);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(44, 23);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(394, 600);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.DarkGray;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(247, 723);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(190, 62);
            btnLamMoi.TabIndex = 25;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(46, 204, 113);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(247, 642);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(190, 62);
            btnSua.TabIndex = 23;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // UC_QLSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelPhanTrang);
            Controls.Add(dgvSinhVien);
            Controls.Add(btnTim);
            Controls.Add(txtTimKiem);
            Controls.Add(label6);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            Controls.Add(btnLamMoi);
            Controls.Add(btnSua);
            Name = "UC_QLSV";
            Size = new Size(1305, 818);
            panelPhanTrang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Panel panelPhanTrang;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblPhanTrang;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
    }
}