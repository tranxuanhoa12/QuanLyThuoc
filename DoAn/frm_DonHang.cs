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
    public partial class frm_DonHang : Form
    {
        KetNoi kn=new KetNoi();
        public frm_DonHang()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            String sql = "SELECT * FROM DONHANG";
            dtgv_donhang.DataSource = kn.LoadDaTa(sql);
        }

        private void btn_taodonhang_Click(object sender, EventArgs e)
        {
            if (txt_makhDH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ đơn hàng.");
                return;
            }
            try
            {

                String makh = "SELECT COUNT(*) FROM KHACHHANG WHERE MAKH ='" + txt_makhDH.Text + "' ";
                int kt =(int) kn.laygt(makh);
                if (kt == 0)
                {
                    MessageBox.Show("Mã khách hàng không tồn tại");
                    txt_makhDH.Focus();
                    return;
                }

                String sql = "INSERT INTO DONHANG VALUES(N'" + txt_makhDH.Text + "',Convert(datetime,'" + dtp_ngaydathang.Text + "',103),0)";
                int kq = kn.themsuaxoa(sql);
                if (kq >= 1)
                {
                    MessageBox.Show("Thêm thành công.");
                }
                else
                {
                    MessageBox.Show("Thêm không thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            LoadData();
        }
        

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dtgv_donhang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn Đơn hàng cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_makhDH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ đơn hàng.");
                return;
            }
            string madh = dtgv_donhang.CurrentRow.Cells["MADH"].Value.ToString();
            String query = "UPDATE DONHANG SET MAKH = N'" + txt_makhDH.Text + "',NGAYDATHANG = Convert(datetime,'" + dtp_ngaydathang.Text + "',103) WHERE MADH = '" + madh + "'";
            kn.themsuaxoa(query);
            LoadData();
        }

        private void btn_xoá_Click(object sender, EventArgs e)
        {
            if (dtgv_donhang.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần xóa.");
                return;
            }
            string mathuoc = dtgv_donhang.CurrentRow.Cells["MADH"].Value.ToString();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa đơn hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            String query = "DELETE DONHANG WHERE MADH = '" + mathuoc + "'";
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
            LoadData();
        }

        
        private void btn_xemchitiet_Click(object sender, EventArgs e)
        {
            frm_ChiTietDonHang ctdh=new frm_ChiTietDonHang();
            ctdh.ShowDialog();
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_makhDH.Text = "";
            dtp_ngaydathang.Text = "";
        }

        private void dtgv_donhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_makhDH.Text = dtgv_donhang.CurrentRow.Cells["MAKH"].Value.ToString();
            dtp_ngaydathang.Text = dtgv_donhang.CurrentRow.Cells["NGAYDATHANG"].Value.ToString();
        }
    }
}
