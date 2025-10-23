using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLThuVien
{
        public partial class UCQuanLyMuonTra : UserControl
    {
        private UserControl currentUC;
        public UCQuanLyMuonTra()
        {
            InitializeComponent();
            // Đảm bảo Dock đúng 1 lần duy nhất
            panelMenu.Dock = DockStyle.Top;
            panelNoiDung.Dock = DockStyle.Fill;

            // Gắn sự kiện cho các nút
            btnThuThu.Click += btnThuThu_Click;
            btnPhieuMuon.Click += btnPhieuMuon_Click;
            btnPhieuTra.Click += btnPhieuTra_Click;
            btnPhieuPhat.Click += btnPhieuPhat_Click;
        }
       

        // Hàm dùng chung để nạp UserControl con vào panelNoiDung
        private void LoadUserControl(UserControl uc)
        {
            if (currentUC != null)
                panelNoiDung.Controls.Remove(currentUC);

            currentUC = uc;
            uc.Dock = DockStyle.Fill;
            panelNoiDung.Controls.Add(uc);
        }

        private void panelNoiDung_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPhieuMuon_Click(object sender, EventArgs e)
        {
            // Hiện màn hình "Phiếu mượn"
            LoadUserControl(new UCPhieuMuon());
        }

        private void btnThuThu_Click(object sender, EventArgs e)
        {
            // Hiện màn hình "Thủ thư"
            LoadUserControl(new UCThuThu());
        }

        private void btnPhieuTra_Click(object sender, EventArgs e)
        {
            // Hiện màn hình "Phiếu trả"
            LoadUserControl(new UCPhieuTra());
        }

        private void btnPhieuPhat_Click(object sender, EventArgs e)
        {
            // Hiện màn hình "Phiếu phạt"
            LoadUserControl(new UCPhieuPhat());
        }

        private void panelNoiDung_Paint_1(object sender, PaintEventArgs e)
        {
           

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
          
        }
    }
}
