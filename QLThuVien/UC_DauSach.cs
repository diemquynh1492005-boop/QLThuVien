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
    public partial class UC_DauSach : UserControl
    {
        public event EventHandler ShowTraCuu;
        public event EventHandler ShowCuonSach;
        public event EventHandler ShowDauSach;

        public UC_DauSach()
        {
            InitializeComponent();
        }
        // --- HÀM CHỌN DÒNG TRÊN DATAGRIDVIEW THEO MÃ ---
        private void SelectRowByMaDauSach(string ma)
        {
            for (int i = 0; i < dgvDauSach.Rows.Count; i++)
            {
                if (dgvDauSach.Rows[i].Cells["MaDauSach"].Value != null &&
                    dgvDauSach.Rows[i].Cells["MaDauSach"].Value.ToString() == ma)
                {
                    dgvDauSach.ClearSelection();
                    dgvDauSach.Rows[i].Selected = true;
                    dgvDauSach.CurrentCell = dgvDauSach.Rows[i].Cells[0];
                    dgvDauSach.FirstDisplayedScrollingRowIndex = i;
                    break;
                }
            }
        }
        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

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
        private void LoadComboBoxData()
        {
            string queryLoai = "SELECT MaLoaiSach, TenLoaiSach FROM LoaiSach";
            string queryChuDe = "SELECT MaChuDe, TenChuDe FROM ChuDe";
            string queryNXB = "SELECT MaNXB, TenNXB FROM NXB";
            string queryKho = "SELECT MaKho, TenKho FROM KhoSach";

            cboLoaiSach.DataSource = DatabaseHelper.GetData(queryLoai);
            cboLoaiSach.DisplayMember = "TenLoaiSach";
            cboLoaiSach.ValueMember = "MaLoaiSach";

            cboChuDe.DataSource = DatabaseHelper.GetData(queryChuDe);
            cboChuDe.DisplayMember = "TenChuDe";
            cboChuDe.ValueMember = "MaChuDe";

            cboNXB.DataSource = DatabaseHelper.GetData(queryNXB);
            cboNXB.DisplayMember = "TenNXB";
            cboNXB.ValueMember = "MaNXB";

            cboKho.DataSource = DatabaseHelper.GetData(queryKho);
            cboKho.DisplayMember = "TenKho";
            cboKho.ValueMember = "MaKho";
        }

        private void UC_DauSach_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            LoadDataGrid();
        }
        private void txtNamXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtGiaBia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSoTrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private bool isAdding = false;
        private bool isEditing = false;

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string maLoai = cboLoaiSach.SelectedValue.ToString();

            string query = $"SELECT MaDauSach FROM DauSach WHERE MaDauSach LIKE '{maLoai}%'";
            DataTable dt = DatabaseHelper.GetData(query);

            int maxIndex = 0;
            foreach (DataRow row in dt.Rows)
            {
                string ma = row["MaDauSach"].ToString();
                string numberPart = new string(ma.SkipWhile(c => !char.IsDigit(c)).ToArray());
                if (int.TryParse(numberPart, out int num))
                    maxIndex = Math.Max(maxIndex, num);
            }

            string newMa = $"{maLoai}{maxIndex + 1:D2}";
            txtMaDauSach.Text = newMa;
            ClearInputs();
            txtTenSach.Focus();
            isAdding = true;
            isEditing = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEditing) // 👉 Đang sửa
                {
                    string ma = txtMaDauSach.Text.Trim();
                    string query = $@"
                UPDATE DauSach
                SET TenDauSach = N'{txtTenSach.Text}',
                    NamXuatBan = {txtNamXB.Text},
                    GiaBia = {txtGiaBia.Text},
                    SoTrang = {txtSoTrang.Text},
                    MaLoaiSach = N'{cboLoaiSach.SelectedValue}',
                    MaChuDe = N'{cboChuDe.SelectedValue}',
                    MaNXB = N'{cboNXB.SelectedValue}',
                    MaKho = N'{cboKho.SelectedValue}'
                WHERE MaDauSach = N'{ma}'";

                    DatabaseHelper.ExecuteNonQuery(query);
                    MessageBox.Show("Đã cập nhật thông tin đầu sách!");
                    LoadDataGrid();
                    SelectRowByMaDauSach(ma);
                }
                else // 👉 Đang thêm mới
                {
                    string query = $@"
                INSERT INTO DauSach (MaDauSach, TenDauSach, NamXuatBan, GiaBia, SoTrang, MaLoaiSach, MaChuDe, MaNXB, MaKho)
                VALUES (N'{txtMaDauSach.Text}', N'{txtTenSach.Text}', {txtNamXB.Text}, {txtGiaBia.Text},
                        {txtSoTrang.Text}, N'{cboLoaiSach.SelectedValue}', N'{cboChuDe.SelectedValue}',
                        N'{cboNXB.SelectedValue}', N'{cboKho.SelectedValue}')";

                    DatabaseHelper.ExecuteNonQuery(query);
                    MessageBox.Show("Đã thêm đầu sách mới!");
                    LoadDataGrid();
                    SelectRowByMaDauSach(txtMaDauSach.Text);
                }

                ClearInputs();
                isEditing = false; // reset lại
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa bản ghi này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    string ma = dgvDauSach.CurrentRow.Cells["MaDauSach"].Value.ToString();
                    string query = $"DELETE FROM DauSach WHERE MaDauSach = N'{ma}'";
                    DatabaseHelper.ExecuteNonQuery(query);
                    MessageBox.Show("Đã xóa thành công!");
                    LoadDataGrid();
                }
                catch
                {
                    MessageBox.Show("Không thể xóa vì dữ liệu đang được liên kết với bảng khác!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDauSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa trong danh sách!");
                return;
            }

            // Lấy dòng hiện tại
            DataGridViewRow row = dgvDauSach.CurrentRow;

            // Đổ dữ liệu dòng đó lên form
            txtMaDauSach.Text = row.Cells["MaDauSach"].Value.ToString();
            txtTenSach.Text = row.Cells["TenDauSach"].Value.ToString();
            txtNamXB.Text = row.Cells["NamXuatBan"].Value.ToString();
            txtGiaBia.Text = row.Cells["GiaBia"].Value.ToString();
            txtSoTrang.Text = row.Cells["SoTrang"].Value.ToString();
            cboLoaiSach.SelectedValue = row.Cells["MaLoaiSach"].Value.ToString();
            cboChuDe.SelectedValue = row.Cells["MaChuDe"].Value.ToString();
            cboNXB.SelectedValue = row.Cells["MaNXB"].Value.ToString();
            cboKho.SelectedValue = row.Cells["MaKho"].Value.ToString();

            // Bật chế độ sửa
            isEditing = true;
            isAdding = false;
        }
        private void LoadDataGrid()
        {
            string query = @"SELECT MaDauSach, TenDauSach, NamXuatBan, GiaBia, SoTrang, 
                            MaLoaiSach, MaChuDe, MaNXB, MaKho
                     FROM DauSach";
            dgvDauSach.DataSource = DatabaseHelper.GetData(query);
        }
        private void ClearInputs()
        {
            txtMaDauSach.Clear();
            txtTenSach.Clear();
            txtNamXB.Clear();
            txtGiaBia.Clear();
            txtSoTrang.Clear();

            if (cboLoaiSach.Items.Count > 0) cboLoaiSach.SelectedIndex = 0;
            if (cboChuDe.Items.Count > 0) cboChuDe.SelectedIndex = 0;
            if (cboNXB.Items.Count > 0) cboNXB.SelectedIndex = 0;
            if (cboKho.Items.Count > 0) cboKho.SelectedIndex = 0;
        }
        

        private void dgvDauSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvDauSach.Rows[e.RowIndex].Selected = true;
            }
        }

    }
}
