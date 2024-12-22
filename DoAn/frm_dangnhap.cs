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
    public partial class frm_dangnhap : Form
    {
        KetNoi kn=new KetNoi();
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát không?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String select = "SELECT COUNT(*) FROM DANGNHAP WHERE TENDANGNHAP = '" + txt_dangnhap.Text + "' AND MATKHAU = '" + txt_matkhau.Text + "'";
            int kq=(int)kn.laygt(select);
            if (txt_dangnhap.Text == "" || txt_matkhau.Text == "")
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được để trống.");
            }
            else
            {
                if (kq == 1)
                {
                    MessageBox.Show("Đăng Nhập Thành Công.");
                    frm_Main main = new frm_Main();
                    this.Hide();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập không thành công.");
                }
            }
        }
    }
}
