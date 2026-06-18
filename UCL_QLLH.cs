using System;
using System.Data;
using System.Windows.Forms;

namespace CSharp_68PM1_BuiTienDat_0007168
{
    public partial class UC_QLLH : UserControl
    {
        public UC_QLLH()
        {
            InitializeComponent();
            this.Load += UC_QLLH_Load;
        }

        private void UC_QLLH_Load(object sender, EventArgs e)
        {
            LoadDataLopHoc();
        }

        private void LoadDataLopHoc()
        {
            try
            {
                string query = "SELECT * FROM LopHoc";
                dgvSinhVien.DataSource = Database.GetData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu lớp học: " + ex.Message);
            }
        }
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

            txtMaSV.Text = row.Cells["MaID"].Value?.ToString();
            txtHoTen.Text = row.Cells["MaLop"].Value?.ToString();
            cboLop.Text = row.Cells["TenLop"].Value?.ToString();
            textBox1.Text = row.Cells["GhiChu"].Value?.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            cboLop.SelectedIndex = -1;
            textBox1.Clear();
            txtTimKiem.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã lớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "INSERT INTO LopHoc (MaLop, TenLop, GhiChu) VALUES (@MaLop, @TenLop, @GhiChu)";
            var p = new Microsoft.Data.SqlClient.SqlParameter[]
            {
        new("@MaLop", txtHoTen.Text.Trim()),
        new("@TenLop", cboLop.Text.Trim()),
        new("@GhiChu", textBox1.Text.Trim())
            };
            if (Database.ExecuteNonQuery(query, p) > 0)
            {
                MessageBox.Show("Thêm lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataLopHoc();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp học cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "UPDATE LopHoc SET MaLop=@MaLop, TenLop=@TenLop, GhiChu=@GhiChu WHERE MaID=@MaID";
            var p = new Microsoft.Data.SqlClient.SqlParameter[]
            {
        new("@MaLop", txtHoTen.Text.Trim()),
        new("@TenLop", cboLop.Text.Trim()),
        new("@GhiChu", textBox1.Text.Trim()),
        new("@MaID", txtMaSV.Text.Trim())
            };
            if (Database.ExecuteNonQuery(query, p) > 0)
            {
                MessageBox.Show("Cập nhật lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataLopHoc();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp học cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa lớp học này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "DELETE FROM LopHoc WHERE MaID=@MaID";
                var p = new Microsoft.Data.SqlClient.SqlParameter[] { new("@MaID", txtMaSV.Text.Trim()) };
                if (Database.ExecuteNonQuery(query, p) > 0)
                {
                    MessageBox.Show("Xóa lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataLopHoc();
                    btnLamMoi_Click(null, null);
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            string query = "SELECT * FROM LopHoc WHERE CAST(MaID AS NVARCHAR) LIKE @kw OR MaLop LIKE @kw OR TenLop LIKE @kw";
            var p = new Microsoft.Data.SqlClient.SqlParameter[] { new("@kw", $"%{keyword}%") };
            dgvSinhVien.DataSource = Database.GetData(query, p);
        }
        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void cboLop_SelectedIndexChanged(object sender, EventArgs e) { }
        private void buttonXem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp học!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maLop = txtHoTen.Text.Trim();
            string tenLop = cboLop.Text.Trim();

            string query = "SELECT * FROM SinhVien WHERE MaLop = @MaLop";
            var p = new Microsoft.Data.SqlClient.SqlParameter[] { new("@MaLop", maLop) };
            DataTable dt = Database.GetData(query, p);

            Form formXem = new Form();
            formXem.Text = $"Danh sách sinh viên lớp {tenLop}";
            formXem.Size = new System.Drawing.Size(800, 500);
            formXem.StartPosition = FormStartPosition.CenterScreen;

            DataGridView dgv = new DataGridView();
            dgv.Dock = DockStyle.Fill;
            dgv.DataSource = dt;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;

            formXem.Controls.Add(dgv);
            formXem.ShowDialog();
        }
    }
}