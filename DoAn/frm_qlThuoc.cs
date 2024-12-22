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
    public partial class frm_qlThuoc : Form
    {
        KetNoi kn=new KetNoi(); 
        public frm_qlThuoc()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            String sql = "SELECT * FROM THUOC";
            dt_qlthuoc.DataSource = kn.LoadDaTa(sql);
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_tendangnhap.Text == "" || txt_loai.Text == "" || txt_gia.Text == "" || txt_slton.Text == "" || txt_nhasx.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            if (!float.TryParse(txt_gia.Text, out float gia))
            {
                MessageBox.Show("Giá phải là số hợp lệ.");
                return;
            }
            if (!int.TryParse(txt_slton.Text, out int slton))
            {
                MessageBox.Show("Số lượng tồn phải là số nguyên hợp lệ.");
                return;
            }
            else
            {
                String sql = "INSERT INTO THUOC VALUES(N'" + txt_tenthuoc.Text + "',N'" + txt_loai.Text + "',N'" + txt_gia.Text + "',N'" + txt_slton.Text + "',N'" + txt_nhasx.Text + "',Convert(datetime,'" + dtp_han.Text + "',103))";
              int kq = kn.themsuaxoa(sql);
                if (kq >= 1)
                {
                    MessageBox.Show("Thêm thông tin thuốc thành công.");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại.");
                }
                LoadData();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dt_qlthuoc.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn Thông Tin Thuốc cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_tendangnhap.Text == "" || txt_loai.Text == "" || txt_gia.Text == "" || txt_slton.Text == "" || txt_nhasx.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            string mathuoc = dt_qlthuoc.CurrentRow.Cells["MATHUOC"].Value.ToString();
            String query = "UPDATE THUOC SET TENTHUOC = N'" + txt_tenthuoc.Text + "',LOAI = N'" + txt_loai.Text + "',GIA = N'" + txt_gia.Text + "',SOLUONGTON = '" + txt_slton.Text + "',NHASANXUAT = N'" + txt_nhasx.Text + "',HANSUDUNG = Convert(datetime,'" + dtp_han.Text + "',103) WHERE MATHUOC = '" + mathuoc + "'";
           int kq = kn.themsuaxoa(query);

            if (kq >= 1)
            {
                MessageBox.Show("Sửa thông tin thuốc thành công.");
                LoadData();
            }
            else
            {
                MessageBox.Show("Sửa thông tin thuốc thất bại.");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dt_qlthuoc.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa.");
                return;
            }
            string mathuoc= dt_qlthuoc.CurrentRow.Cells["MATHUOC"].Value.ToString();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa Thuốc này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            String query = "DELETE THUOC WHERE MATHUOC = '" + mathuoc + "'";
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

       

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_tenthuoc.Text = "";
            txt_loai.Text = "";
            txt_gia.Text = "";
            txt_slton.Text = "";
            txt_nhasx.Text = "";
            dtp_han.Text = "";
        }

        private void dt_qlthuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_tenthuoc.Text = dt_qlthuoc.CurrentRow.Cells["TENTHUOC"].Value.ToString();
            txt_loai.Text = dt_qlthuoc.CurrentRow.Cells["LOAI"].Value.ToString();
            txt_gia.Text = dt_qlthuoc.CurrentRow.Cells["GIA"].Value.ToString();
            txt_slton.Text = dt_qlthuoc.CurrentRow.Cells["SOLUONGTON"].Value.ToString();
            txt_nhasx.Text = dt_qlthuoc.CurrentRow.Cells["NHASANXUAT"].Value.ToString();
            dtp_han.Text = dt_qlthuoc.CurrentRow.Cells["HANSUDUNG"].Value.ToString();
        }
    }
}
