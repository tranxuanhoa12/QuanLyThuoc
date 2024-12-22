using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class frm_KhachHang : Form
    {
        KetNoi kn = new KetNoi();
        public frm_KhachHang()
        {
            InitializeComponent();
            Loaddata();
        }
        public void Loaddata()
        {
            String sql = "SELECT * FROM KHACHHANG";
            dt_kh.DataSource = kn.LoadDaTa(sql);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_hoten.Text == "" || txt_sodt.Text == "" || txt_diachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.");
                return;
            }
            else
            {
                String sql = "INSERT INTO KHACHHANG VALUES(N'" + txt_hoten.Text + "',N'" + txt_sodt.Text + "',N'" + txt_diachi.Text + "')";
                int kq = kn.themsuaxoa(sql);
                if (kq >= 1)
                {
                    MessageBox.Show("Thêm Khách hàng thành công.");
                    Loaddata();
                }
                else
                {
                    MessageBox.Show("Thêm Không thành công.");
                }
            }
           
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dt_kh.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn Khách hàng cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_hoten.Text == "" || txt_sodt.Text == "" || txt_diachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng.");
                return;
            }
            string makh = dt_kh.CurrentRow.Cells["MAKH"].Value.ToString();
                String query = "UPDATE KHACHHANG SET HOTEN = N'" + txt_hoten.Text + "',SODIENTHOAI = N'" + txt_sodt.Text + "',DIACHI = N'" + txt_diachi.Text + "' WHERE MAKH = '" + makh + "'";
               int kq= kn.themsuaxoa(query);
                if(kq >= 1)
            {
                MessageBox.Show("Cập nhật thành công.");
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công.");
            }
                Loaddata();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dt_kh.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.");
                return;
            }
            string makh = dt_kh.CurrentRow.Cells["MAKH"].Value.ToString();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
           // string makh = dt_kh.CurrentRow.Cells["MAKH"].Value.ToString();
            String query = "DELETE KHACHHANG WHERE MAKH = '"+makh+"'";
            try
            {
                int kq = kn.themsuaxoa(query);                         
                    if (kq >= 1)
                    {
                        MessageBox.Show("Xóa thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công.");
                    }
                }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            Loaddata();
        }
        

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_hoten.Text = "";
            txt_diachi.Text = "";
            txt_sodt.Text = "";
        }

        private void dt_kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_hoten.Text = dt_kh.CurrentRow.Cells["HOTEN"].Value.ToString();
            txt_sodt.Text = dt_kh.CurrentRow.Cells["SODIENTHOAI"].Value.ToString();
            txt_diachi.Text = dt_kh.CurrentRow.Cells["DIACHI"].Value.ToString();
        }
    }
}
