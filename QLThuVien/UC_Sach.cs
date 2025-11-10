using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.TextEditController.Utils;
using QLThuVien;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static DevExpress.Utils.Svg.CommonSvgImages;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace QLThuVien
{
    public partial class UC_Sach : UserControl
    {
        public event EventHandler ShowTraCuu;
        public event EventHandler ShowCuonSach;
        public event EventHandler ShowDauSach;
        public UC_Sach()
        {
            InitializeComponent();
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTraCuu?.Invoke(this, EventArgs.Empty);
        }

        private void đầuSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDauSach?.Invoke(this, EventArgs.Empty);
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCuonSach?.Invoke(this, EventArgs.Empty);
        }

        private void UC_Sach_Load(object sender, EventArgs e)
        {
            LoadDanhSachSach();

            PictureBox[] arrPic = { picSach1, picSach2, picSach3, picSach4, picSach5 };
            foreach (var pic in arrPic)
            {
                pic.Click += picSach_Click;
            }
        }
        private DataTable LayTop5DauSachGanDay(string keyword = "")
        {
            string query = string.IsNullOrEmpty(keyword)
                ? "SELECT TOP 5 ds.MaDauSach, ds.TenDauSach, ks.TenKho, COUNT(cs.MaSach) AS TongSo, " +
                  "SUM(CASE WHEN cs.TinhTrang = N'Còn' THEN 1 ELSE 0 END) AS SoConTot, " +
                  "SUM(CASE WHEN cs.TinhTrang IN (N'Mất', N'Hư hỏng') THEN 1 ELSE 0 END) AS SoHuHong " +
                  "FROM DauSach ds " +
                  "LEFT JOIN CuonSach cs ON ds.MaDauSach = cs.MaDauSach " +
                  "LEFT JOIN KhoSach ks ON ds.MaKho = ks.MaKho " +
                  "GROUP BY ds.MaDauSach, ds.TenDauSach, ks.TenKho " +
                  "ORDER BY ds.MaDauSach DESC"
                : "SELECT TOP 5 ds.MaDauSach, ds.TenDauSach, ks.TenKho, COUNT(cs.MaSach) AS TongSo, " +
                  "SUM(CASE WHEN cs.TinhTrang = N'Còn' THEN 1 ELSE 0 END) AS SoConTot, " +
                  "SUM(CASE WHEN cs.TinhTrang IN (N'Mất', N'Hư hỏng') THEN 1 ELSE 0 END) AS SoHuHong " +
                  "FROM DauSach ds " +
                  "LEFT JOIN CuonSach cs ON ds.MaDauSach = cs.MaDauSach " +
                  "LEFT JOIN KhoSach ks ON ds.MaKho = ks.MaKho " +
                  $"WHERE ds.TenDauSach LIKE N'%{keyword}%' " +
                  "GROUP BY ds.MaDauSach, ds.TenDauSach, ks.TenKho";

            return DatabaseHelper.GetData(query);
        }
        private string LayTrangThaiDauSach(string maDauSach)
        {
            string query = @"
        SELECT COUNT(*) 
        FROM CuonSach 
        WHERE MaDauSach = @MaDauSach AND TinhTrang = N'Còn'";
            SqlParameter[] parameters = { new SqlParameter("@MaDauSach", maDauSach) };
            int soLuongCon = DatabaseHelper.ExecuteScalar(query, parameters);

            return soLuongCon > 0 ? "Còn sách" : "Hết sách";
        }
        private void LoadDanhSachSach()
        {
            DataTable dt = LayTop5DauSachGanDay();

            // Tạo mảng control để dễ lặp
            Label[] arrTenSach = { lblTenSach1, lblTenSach2, lblTenSach3, lblTenSach4, lblTenSach5 };
            Label[] arrKho = { lblKhoSach1, lblKhoSach2, lblKhoSach3, lblKhoSach4, lblKhoSach5 };
            Label[] arrTrangThai = { lblTrangThaiSach1, lblTrangThaiSach2, lblTrangThaiSach3, lblTrangThaiSach4, lblTrangThaiSach5 };
            PictureBox[] arrPic = { picSach1, picSach2, picSach3, picSach4, picSach5 };

            for (int i = 0; i < arrTenSach.Length; i++)
            {
                if (i < dt.Rows.Count)
                {
                    string maDauSach = dt.Rows[i]["MaDauSach"].ToString();
                    arrTenSach[i].Text = dt.Rows[i]["TenDauSach"].ToString();
                    arrKho[i].Text = "Kho: " + dt.Rows[i]["TenKho"].ToString();
                    arrTrangThai[i].Text = LayTrangThaiDauSach(maDauSach);



                    // Lưu mã đầu sách vào Tag để dùng khi click
                    arrPic[i].Tag = maDauSach;
                }
                else
                {
                    // Nếu không đủ 5 sách
                    arrTenSach[i].Text = "";
                    arrKho[i].Text = "";
                    arrTrangThai[i].Text = "";
                    arrPic[i].Image = null;
                }
            }
        }
        private void picSach_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic != null && pic.Tag != null)
            {
                string maDauSach = pic.Tag.ToString();
                LoadDanhSachCuonSach(maDauSach);
            }
        }
        private void LoadDanhSachCuonSach(string maDauSach)
        {
            string query = @"
        SELECT MaSach, TinhTrang, MoTa
        FROM CuonSach
        WHERE MaDauSach = @MaDauSach";
            SqlParameter[] parameters = { new SqlParameter("@MaDauSach", maDauSach) };
            DataTable dt = DatabaseHelper.GetData(query, parameters);

            dgvCuonSach.DataSource = dt;
        }
    }
}
