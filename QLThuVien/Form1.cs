using QLThuVien.All_User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLThuVien
{
    public partial class frmQLThuVien : Form
    {
        public frmQLThuVien()
        {
            InitializeComponent();

        }

        private void LoadUserControl(UserControl uc)
        {
            // Xóa control cũ ở cột phải (col=1, row=0)
            var oldControl = tablepanelBody.GetControlFromPosition(1, 0);
            if (oldControl != null) tablepanelBody.Controls.Remove(oldControl);

            // Thêm UserControl mới vào đúng ô (col=1, row=0)
            uc.Dock = DockStyle.Fill;
            tablepanelBody.Controls.Add(uc, 1, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            status1.Text = DateTime.Now.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void tablepanelBody_Paint(object sender, PaintEventArgs e)
        {
          
    }
        //Bắt đầu thêm
        //Biến để giữ lại User control(nếu bạn muốn tái sử dụng, không tạo mới nhiều lần)
        private UC_Author UC_Author;
        private UC_Reader UC_Reader;

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            if(UC_Author == null)
                UC_Author = new UC_Author(); // khởi tạo usercontrol của màn Tác giả
            LoadUserControl(UC_Author); 
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {

        }

        private void btnReader_Click(object sender, EventArgs e)
        {
            if(UC_Reader == null)
                UC_Reader = new UC_Reader(); // khởi tạo usercontrol của màn Độc giả
            LoadUserControl(UC_Reader);
        }

        }

        // >>> BẮT ĐẦU THÊM
        // Biến để giữ lại user control (nếu bạn muốn tái sử dụng, không tạo mới nhiều lần)
        private UCQuanLyMuonTra ucMuonTra;

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            if (ucMuonTra == null)
                ucMuonTra = new UCQuanLyMuonTra(); // Khởi tạo user control của màn Quản lý mượn trả

            LoadUserControl(ucMuonTra); // Gọi hàm đã có sẵn để hiển thị
        }

        private void frmQLThuVien_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // <<< KẾT THÚC THÊM
    }
}
