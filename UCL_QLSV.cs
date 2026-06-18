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

    }
}