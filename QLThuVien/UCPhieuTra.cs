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
    public partial class UCPhieuTra : UserControl
    {

        public UCPhieuTra()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbBoxMaPM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmTraSachMuon frm = new frmTraSachMuon();
            frm.ShowDialog(); // Mở dạng hộp thoại
        }

        private void dgvPhieuMuonCanTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInPhieuTra_Click(object sender, EventArgs e)
        {
            frmInPhieuTra frm = new frmInPhieuTra();
            frm.ShowDialog(); // Mở dạng hộp thoại
        }

        private void groupPhieuMuonCanTra_Enter(object sender, EventArgs e)
        {

        }
    }
}
