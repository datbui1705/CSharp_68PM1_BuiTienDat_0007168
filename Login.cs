using System;
using System.Windows.Forms;

namespace CSharp_68PM1_BuiTienDat_0007168
{
    public partial class Login : Form
    {
        private const string STUDENT_EMAIL = "dat0007168@st.huce.edu.vn"; 
        private const string STUDENT_MSSV = "0007168";               
        

        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == STUDENT_EMAIL && password == STUDENT_MSSV)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm formQL = new MainForm();
                formQL.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Đăng nhập thất bại!\nTên đăng nhập hoặc mật khẩu không đúng.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }
    }
}