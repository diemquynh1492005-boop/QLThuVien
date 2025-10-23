using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class UC_Tracuubooks : UserControl
    {
        public event EventHandler ShowDauSach; // khai báo event
        public event EventHandler ShowCuonSach;
        public event EventHandler ShowTraCuu;
        public UC_Tracuubooks()
        {
            InitializeComponent();
        }

        private static readonly string connectionString =
    ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            clbTheLoai.Visible = !clbTheLoai.Visible;
            pnlTheLoai.Height = clbTheLoai.Visible ? 160 : 36;
            btnTheLoai.Text = clbTheLoai.Visible ? "Thể loại  ▲" : "Thể loại  ▼";
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChitiet_Click(object sender, EventArgs e)
        {
            if (dgvKetQua.CurrentRow != null)
            {
                string maDauSach = dgvKetQua.CurrentRow.Cells["Mã đầu sách"].Value.ToString();
                frmChiTietSach frm = new frmChiTietSach(maDauSach);
                frm.ShowDialog();
            }
        }

        private void đầuSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDauSach?.Invoke(this, EventArgs.Empty);
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCuonSach?.Invoke(this, EventArgs.Empty);
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTraCuu?.Invoke(this, EventArgs.Empty);
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            clbTacGia.Visible = !clbTacGia.Visible;
            pnlTacGia.Height = clbTacGia.Visible ? 160 : 36;
            btnTacGia.Text = clbTacGia.Visible ? "Tác giả  ▲" : "Tác giả  ▼";
        }

        private void btnChuDe_Click(object sender, EventArgs e)
        {
            clbChuDe.Visible = !clbChuDe.Visible;
            pnlChuDe.Height = clbChuDe.Visible ? 160 : 36;
            btnChuDe.Text = clbChuDe.Visible ? "Chủ đề  ▲" : "Chủ đề  ▼";
        }

        private void btnNXB_Click(object sender, EventArgs e)
        {
            clbNXB.Visible = !clbNXB.Visible;
            pnlNXB.Height = clbNXB.Visible ? 160 : 36;
            btnNXB.Text = clbNXB.Visible ? "Nhà xuất bản  ▲" : "Nhà xuất bản  ▼";
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            clbKho.Visible = !clbKho.Visible;
            pnlKho.Height = clbKho.Visible ? 160 : 36;
            btnKho.Text = clbKho.Visible ? "Kho  ▲" : "Kho  ▼";
        }

        private void UC_TraCuuBooks_Load(object sender, EventArgs e)
        {
            LoadTheLoai();
            LoadTacGia();
            LoadChuDe();
            LoadNXB();
            LoadKho();
        }

        private void LoadTheLoai()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TenLoaiSach FROM LoaiSach", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    clbTheLoai.Items.Add(reader["TenLoaiSach"].ToString());
            }
        }

        private void LoadTacGia()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TenTG FROM TacGia", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    clbTacGia.Items.Add(reader["TenTG"].ToString());
            }
        }

        private void LoadChuDe()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TenChuDe FROM ChuDe", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    clbChuDe.Items.Add(reader["TenChuDe"].ToString());
            }
        }

        private void LoadNXB()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TenNXB FROM NXB", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    clbNXB.Items.Add(reader["TenNXB"].ToString());
            }
        }
        private void LoadKho()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TenKho FROM KhoSach", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    clbKho.Items.Add(reader["TenKho"].ToString());
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtSearch.Text.Trim();

            List<string> dsTheLoai = clbTheLoai.CheckedItems.Cast<string>().ToList();
            List<string> dsTacGia = clbTacGia.CheckedItems.Cast<string>().ToList();
            List<string> dsChuDe = clbChuDe.CheckedItems.Cast<string>().ToList();
            List<string> dsNXB = clbNXB.CheckedItems.Cast<string>().ToList();
            List<string> dsKho = clbKho.CheckedItems.Cast<string>().ToList();

            string query = @"
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
            WHERE 1=1
            ";

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                query += $" AND (ds.TenDauSach LIKE N'%{tuKhoa}%' " +
                         $"OR tg.TenTG LIKE N'%{tuKhoa}%' " +
                         $"OR ls.TenLoaiSach LIKE N'%{tuKhoa}%' " +
                         $"OR cd.TenChuDe LIKE N'%{tuKhoa}%' " +
                         $"OR ks.TenKho LIKE N'%{tuKhoa}%' " +
                         $"OR nxb.TenNXB LIKE N'%{tuKhoa}%')";

            }

            if (dsTheLoai.Count > 0)
                query += $" AND ls.TenLoaiSach IN (N'{string.Join("',N'", dsTheLoai)}')";
            if (dsTacGia.Count > 0)
                query += $" AND tg.TenTG IN (N'{string.Join("',N'", dsTacGia)}')";
            if (dsChuDe.Count > 0)
                query += $" AND cd.TenChuDe IN (N'{string.Join("',N'", dsChuDe)}')";
            if (dsNXB.Count > 0)
                query += $" AND nxb.TenNXB IN (N'{string.Join("',N'", dsNXB)}')";
            if (dsKho.Count > 0)
                query += $" AND ks.TenKho IN ('{string.Join("','", dsKho)}')";

            LoadData(query);
        }

        private void LoadData(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKetQua.DataSource = dt;
            }
        }
    }
}
