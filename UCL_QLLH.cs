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

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void btnThem_Click(object sender, EventArgs e) { }
        private void btnSua_Click(object sender, EventArgs e) { }
        private void buttonXem_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void cboLop_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}