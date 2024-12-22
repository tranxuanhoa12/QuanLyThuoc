using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void quảnLýKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frm_KhachHang"] == null)
            {
                frm_KhachHang kh = new frm_KhachHang();
                kh.MdiParent = this;
                kh.Show();
            }
            else
                Application.OpenForms["frm_KhachHang"].Activate();

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýThuốcToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frm_qlThuoc"] == null)
            {
                frm_qlThuoc qlt = new frm_qlThuoc();
                qlt.MdiParent = this;
                qlt.Show();
            }
            else
                Application.OpenForms["frm_qlThuoc"].Activate();
        }

        private void quảnLýĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DonHang"] == null)
            {
                frm_DonHang dh = new frm_DonHang();
                dh.MdiParent = this;
                dh.Show();
            }
            else
                Application.OpenForms["frm_DonHang"].Activate();

        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Hỏi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
