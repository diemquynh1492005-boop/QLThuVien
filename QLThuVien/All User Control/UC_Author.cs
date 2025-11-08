using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien.All_User_Control
{
    public partial class UC_Author : UserControl
    {
        public UC_Author()
        {
            InitializeComponent();
            //Gắn sự kiện cho các nút
            btntacgia.Click += guna2Button2_Click;
        }


        //Hàm dùng chung để nạp Usercontrol vào panel nội dung
    private void LoadUserControl(UserControl uc)
        {
            // Xóa control cũ ở cột phải (col=1, row=0)
            var oldControl = tablepanelbody.GetControlFromPosition(1, 0);
            if (oldControl != null) tablepanelbody.Controls.Remove(oldControl);

            // Thêm UserControl mới vào đúng ô (col=1, row=0)
            uc.Dock = DockStyle.Fill;
            tablepanelbody.Controls.Add(uc, 1, 0);



        }
        private UC_TacGia UC_TacGia; //Kha  i báo biến toàn cục cho UC_TacGia
        private UC_TacGiaSach UC_TacGiaSach; //Khai báo biến toàn cục cho UC_TacGiaSach
        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {

        }

        private void btntacgia_Click(object sender, EventArgs e)
        {
            if(UC_TacGia == null)
                UC_TacGia = new UC_TacGia(); //Khởi tạo UC_TacGia nếu chưa có
                LoadUserControl(UC_TacGia); //Nạp UC_TacGia vào panel nội dung
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(UC_TacGiaSach == null)
                UC_TacGiaSach = new UC_TacGiaSach(); //Khởi tạo UC_TacGiaSach nếu chưa có
                LoadUserControl(UC_TacGiaSach); //Nạp UC_TacGiaSach vào panel nội dung
        }

        private void pnltop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
