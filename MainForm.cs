using System;
using System.Windows.Forms;
namespace CSharp_68PM1_BuiTienDat_0007168
{
    public partial class MainForm : Form
    {
        // Khởi tạo sẵn 2 màn hình con (UserControl)
        private UC_QLSV uc_qlsv = new UC_QLSV();
        private UC_QLLH uc_qllh = new UC_QLLH();
        public MainForm()
        {
            InitializeComponent();
        }
        // Sự kiện chạy ngay khi MainForm vừa mở lên (Sau khi Login thành công)
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set mặc định hiển thị luôn giao diện Quản lý Sinh viên
            ShowUserControl(uc_qlsv);
        }
        // Hàm xử lý dọn màn hình cũ, nạp màn hình mới vào khung chứa
        private void ShowUserControl(UserControl uc)

        {
            panelContainer.Controls.Clear(); // Xóa sạch control đang hiển thị hiện tại
            uc.Dock = DockStyle.Fill; // Cấu hình cho mảnh giao diện con tràn đầy khung
            panelContainer.Controls.Add(uc); // Thêm mảnh giao diện mới vào
        }

        // Khi click vào danh mục Quản lý Sinh viên trên MenuStrip

        private void menuQLSV_Click(object sender, EventArgs e)
        {
            ShowUserControl(uc_qlsv);
        }
        // Khi click vào danh mục Quản lý Lớp học trên MenuStrip

        private void menuQLLopHoc_Click(object sender, EventArgs e)
        {
            ShowUserControl(uc_qllh);

        }

        // Xử lý sự kiện Đăng xuất hệ thống

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
            "Bạn có chắc muốn đăng xuất?",
            "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                this.Close(); // Đóng MainForm, ứng dụng quay lại hoặc thoát dựa trên Program.cs

            }
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}