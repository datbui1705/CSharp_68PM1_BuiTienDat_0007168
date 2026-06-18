namespace CSharp_68PM1_BuiTienDat_0007168
{
    partial class UC_QLLH
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
            dgvSinhVien = new DataGridView();
            btnTim = new Button();
            txtTimKiem = new TextBox();
            label6 = new Label();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            txtMaSV = new TextBox();
            label2 = new Label();
            txtHoTen = new TextBox();
            label5 = new Label();
            cboLop = new ComboBox();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnFirst = new Button();
            btnPrev = new Button();
            lblPhanTrang = new Label();
            btnNext = new Button();
            btnLast = new Button();
            panelPhanTrang = new Panel();
            buttonXem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            groupBox1.SuspendLayout();
            panelPhanTrang.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.BackgroundColor = Color.White;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(482, 134);
            dgvSinhVien.Margin = new Padding(3, 4, 3, 4);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.RowTemplate.Height = 24;
            dgvSinhVien.Size = new Size(790, 581);
            dgvSinhVien.TabIndex = 39;
            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
            // 
            // btnTim
            // 
            btnTim.BackColor = Color.FromArgb(44, 62, 80);
            btnTim.FlatStyle = FlatStyle.Flat;
            btnTim.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnTim.ForeColor = Color.White;
            btnTim.Location = new Point(857, 60);
            btnTim.Margin = new Padding(3, 4, 3, 4);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(110, 45);
            btnTim.TabIndex = 38;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = false;
            btnTim.Click += btnTim_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 11F);
            txtTimKiem.Location = new Point(482, 65);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(360, 28);
            txtTimKiem.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label6.Location = new Point(477, 28);
            label6.Name = "label6";
            label6.Size = new Size(315, 20);
            label6.TabIndex = 36;
            label6.Text = "Tìm kiếm (Mã ID / Mã lớp / Tên lớp):";
            label6.Click += label6_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(231, 76, 60);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(32, 604);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(190, 62);
            btnXoa.TabIndex = 34;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(52, 152, 219);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(32, 523);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(190, 62);
            btnThem.TabIndex = 32;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtMaSV);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboLop);
            groupBox1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(32, 28);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(394, 463);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin lớp học";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 355);
            label3.Name = "label3";
            label3.Size = new Size(63, 18);
            label3.TabIndex = 10;
            label3.Text = "Ghi chú:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(19, 386);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 26);
            textBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 44);
            label1.Name = "label1";
            label1.Size = new Size(51, 18);
            label1.TabIndex = 0;
            label1.Text = "Mã ID:";
            label1.Click += label1_Click;
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
            label2.Size = new Size(57, 18);
            label2.TabIndex = 2;
            label2.Text = "Mã lớp:";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 250);
            label5.Name = "label5";
            label5.Size = new Size(61, 18);
            label5.TabIndex = 8;
            label5.Text = "Tên lớp:";
            label5.Click += label5_Click;
            // 
            // cboLop
            // 
            cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLop.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(18, 276);
            cboLop.Margin = new Padding(3, 4, 3, 4);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(360, 28);
            cboLop.TabIndex = 9;
            cboLop.SelectedIndexChanged += cboLop_SelectedIndexChanged;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.DarkGray;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(236, 604);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(190, 62);
            btnLamMoi.TabIndex = 35;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(46, 204, 113);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(236, 523);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(190, 62);
            btnSua.TabIndex = 33;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
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
            // panelPhanTrang
            // 
            panelPhanTrang.BorderStyle = BorderStyle.FixedSingle;
            panelPhanTrang.Controls.Add(btnFirst);
            panelPhanTrang.Controls.Add(btnPrev);
            panelPhanTrang.Controls.Add(lblPhanTrang);
            panelPhanTrang.Controls.Add(btnNext);
            panelPhanTrang.Controls.Add(btnLast);
            panelPhanTrang.Location = new Point(482, 728);
            panelPhanTrang.Margin = new Padding(3, 4, 3, 4);
            panelPhanTrang.Name = "panelPhanTrang";
            panelPhanTrang.Size = new Size(790, 62);
            panelPhanTrang.TabIndex = 40;
            // 
            // buttonXem
            // 
            buttonXem.BackColor = Color.FromArgb(44, 62, 80);
            buttonXem.FlatStyle = FlatStyle.Flat;
            buttonXem.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonXem.ForeColor = Color.White;
            buttonXem.Location = new Point(32, 689);
            buttonXem.Margin = new Padding(3, 4, 3, 4);
            buttonXem.Name = "buttonXem";
            buttonXem.Size = new Size(394, 45);
            buttonXem.TabIndex = 41;
            buttonXem.Text = "Xem danh sách sinh viên";
            buttonXem.UseVisualStyleBackColor = false;
            buttonXem.Click += buttonXem_Click;
            // 
            // UC_QLLH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonXem);
            Controls.Add(dgvSinhVien);
            Controls.Add(btnTim);
            Controls.Add(txtTimKiem);
            Controls.Add(label6);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            Controls.Add(btnLamMoi);
            Controls.Add(btnSua);
            Controls.Add(panelPhanTrang);
            Name = "UC_QLLH";
            Size = new Size(1305, 818);
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelPhanTrang.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblPhanTrang;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Panel panelPhanTrang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonXem;
    }
}