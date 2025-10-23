using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class frmChiTietSach : Form
    {
        private string maDauSach;
        public frmChiTietSach(string maDauSach)
        {
            InitializeComponent();
            this.maDauSach = maDauSach;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChiTietSach_Load(object sender, EventArgs e)
        {
            string query = $@"
            SELECT 
                ds.MaDauSach AS [Mã đầu sách],
                ds.TenDauSach AS [Tên đầu sách],
                tg.TenTG AS [Tác giả],
                ds.NamXuatBan AS [Năm XB],
                ds.GiaBia AS [Giá bìa],
                ds.SoTrang AS [Số trang],
                ls.TenLoaiSach AS [Loại sách],
                cd.TenChuDe AS [Chủ đề],
                nxb.TenNXB AS [NXB],
                ks.TenKho AS [Kho]
            FROM DauSach ds
            LEFT JOIN LoaiSach ls ON ds.MaLoaiSach = ls.MaLoaiSach
            LEFT JOIN ChuDe cd ON ds.MaChuDe = cd.MaChuDe
            LEFT JOIN NXB nxb ON ds.MaNXB = nxb.MaNXB
            LEFT JOIN KhoSach ks ON ds.MaKho = ks.MaKho
            LEFT JOIN DauSach_TacGia dstg ON ds.MaDauSach = dstg.MaDauSach
            LEFT JOIN TacGia tg ON dstg.MaTG = tg.MaTG
            WHERE ds.MaDauSach = '{maDauSach}'";
            DataTable dt = DatabaseHelper.GetData(query);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtMaDauSach.Text = row["Mã đầu sách"].ToString();
                txtTenDauSach.Text = row["Tên đầu sách"].ToString();
                txtTacGia.Text = row["tác giả"].ToString();
                txtNamXB.Text = row["Năm XB"].ToString();
                txtGiaBia.Text = row["Giá bìa"].ToString();
                txtSoTrang.Text = row["Số trang"].ToString();
                txtLoaiSach.Text = row["Loại sách"].ToString();
                txtChuDe.Text = row["Chủ đề"].ToString();
                txtNXB.Text = row["NXB"].ToString();
                txtKho.Text = row["Kho"].ToString();
            }
        }
    }
}
