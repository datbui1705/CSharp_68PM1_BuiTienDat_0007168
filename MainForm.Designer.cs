namespace CSharp_68PM1_BuiTienDat_0007168
{
    partial class MainForm

    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuQLSV = new ToolStripMenuItem();
            menuQLLopHoc = new ToolStripMenuItem();
            menuDangXuat = new ToolStripMenuItem();
            panelContainer = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            //
            // menuStrip1
            //
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuQLSV, menuQLLopHoc, menuDangXuat });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1307, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            //
            // menuQLSV
            //
            menuQLSV.Name = "menuQLSV";
            menuQLSV.Size = new Size(138, 24);
            menuQLSV.Text = "Quản lý Sinh Viên";
            menuQLSV.Click += menuQLSV_Click;
            //
            // menuQLLopHoc
            //
            menuQLLopHoc.Name = "menuQLLopHoc";
            menuQLLopHoc.Size = new Size(133, 24);
            menuQLLopHoc.Text = "Quản lý Lớp Học";
            menuQLLopHoc.Click += menuQLLopHoc_Click;
            //
            // menuDangXuat
            //
            menuDangXuat.Name = "menuDangXuat";
            menuDangXuat.Size = new Size(91, 24);
            menuDangXuat.Text = "Đăng xuất";
            menuDangXuat.Click += btnDangXuat_Click;
            //
            // panelContainer
            //
            panelContainer.BackColor = Color.White;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 28);
            panelContainer.Margin = new Padding(3, 4, 3, 4);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1307, 825);
            panelContainer.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = false; // Tắt AutoSize đi để không bị bóp nghẹt Form
            this.ClientSize = new System.Drawing.Size(1300, 850); // Cho to sẵn từ đầu
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle; // Khóa viền cố định
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Đào Tạo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuQLSV;
        private System.Windows.Forms.ToolStripMenuItem menuQLLopHoc;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.Panel panelContainer;
    }
}