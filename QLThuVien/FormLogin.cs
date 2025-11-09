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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "adminqltv" && txtPassword.Text == "123456")
            {
                lblError.Visible = false;
                frmQLThuVien ds = new frmQLThuVien();
                this.Hide();
                ds.Show();
            }
            else
            {
                lblError.Visible = true;
                txtPassword.Clear();

            }
        }
    }
}