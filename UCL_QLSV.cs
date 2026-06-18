using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_68PM1_BuiTienDat_0007168
{
    public partial class UC_QLSV : UserControl
    {
        public UC_QLSV()
        {
            InitializeComponent();
            this.Load += UC_QLSV_Load;
        }
        private void LoadComboBoxLop()
        {
            string query = "SELECT MaLop, TenLop FROM LopHoc";
            DataTable dt = Database.GetData(query);

            if (dt == null || dt.Rows.Count == 0) return;

            cboLop.DataSource = dt;
            cboLop.DisplayMember = "TenLop";
            cboLop.ValueMember = "MaLop";
        }

        private void LoadDataSinhVien()
        {
            string query = "SELECT * FROM SinhVien";
            dgvSinhVien.DataSource = Database.GetData(query);
        }

        private void UC_QLSV_Load(object sender, EventArgs e)
        {
            LoadComboBoxLop();
            LoadDataSinhVien();
        }
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

            txtMaSV.Text = row.Cells["MaSV"].Value?.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
            if (DateTime.TryParse(row.Cells["NgaySinh"].Value?.ToString(), out DateTime ngaySinh))
                dtpNgaySinh.Value = ngaySinh;
            cboGioiTinh.SelectedItem = row.Cells["GioiTinh"].Value?.ToString();
            cboLop.SelectedValue = row.Cells["MaLop"].Value?.ToString();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Today;
            cboGioiTinh.SelectedIndex = -1;
            cboLop.SelectedIndex = -1;
            txtTimKiem.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, MaLop) VALUES (@MaSV, @HoTen, @NgaySinh, @GioiTinh, @MaLop)";
            var p = new Microsoft.Data.SqlClient.SqlParameter[]
            {
        new("@MaSV", txtMaSV.Text.Trim()),
        new("@HoTen", txtHoTen.Text.Trim()),
        new("@NgaySinh", dtpNgaySinh.Value.Date),
        new("@GioiTinh", cboGioiTinh.SelectedItem?.ToString() ?? ""),
        new("@MaLop", cboLop.SelectedValue?.ToString() ?? "")
            };
            if (Database.ExecuteNonQuery(query, p) > 0)
            {
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataSinhVien();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "UPDATE SinhVien SET HoTen=@HoTen, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, MaLop=@MaLop WHERE MaSV=@MaSV";
            var p = new Microsoft.Data.SqlClient.SqlParameter[]
            {
        new("@HoTen", txtHoTen.Text.Trim()),
        new("@NgaySinh", dtpNgaySinh.Value.Date),
        new("@GioiTinh", cboGioiTinh.SelectedItem?.ToString() ?? ""),
        new("@MaLop", cboLop.SelectedValue?.ToString() ?? ""),
        new("@MaSV", txtMaSV.Text.Trim())
            };
            if (Database.ExecuteNonQuery(query, p) > 0)
            {
                MessageBox.Show("Cập nhật sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataSinhVien();
            }
        }
    }
}