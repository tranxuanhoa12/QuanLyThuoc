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
    public partial class frm_ChiTietDonHang : Form
    {
        KetNoi kn = new KetNoi();
        public frm_ChiTietDonHang()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            String sql = "SELECT * FROM CHITIETDONHANG";
            dtgv_ctdh.DataSource = kn.LoadDaTa(sql);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_madh.Text == "" || txt_mathuoc.Text == "" || txt_soluong.Text == "" || txt_gia.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            if (!float.TryParse(txt_gia.Text, out float gia))
            {
                MessageBox.Show("Giá phải là số hợp lệ.");
                return;
            }
            if (!int.TryParse(txt_soluong.Text, out int slton))
            {
                MessageBox.Show("Số lượng  phải là số nguyên hợp lệ.");
                return;
            }
            try
            {
                String madh = "SELECT COUNT(*) FROM DONHANG WHERE MADH ='" + txt_madh.Text + "'";
                String mathuoc = "SELECT COUNT(*) FROM THUOC WHERE MATHUOC='" + txt_mathuoc.Text + "'";
                int ktmadh = (int)kn.laygt(madh);
                int ktmathuoc = (int)kn.laygt(mathuoc);
                if (ktmadh == 0)
                {
                    MessageBox.Show("Nhập mã đơn hàng không đúng.");
                    txt_madh.Focus();
                    return;
                }
                if (ktmathuoc == 0)
                {
                    MessageBox.Show("Nhập mã thuốc không đúng.");
                    txt_mathuoc.Focus();
                    return;
                }
                String sql = "INSERT INTO CHITIETDONHANG VALUES(N'" + txt_madh.Text + "',N'" + txt_mathuoc.Text + "',N'" + txt_soluong.Text + "',N'" + txt_gia.Text + "')";
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
           UpdateTongTien(Convert.ToInt32(txt_madh.Text));
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dtgv_ctdh.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn chi tiết đơn hàng cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_madh.Text == "" || txt_mathuoc.Text == "" || txt_soluong.Text == "" || txt_gia.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            else
            {
                string macthd = dtgv_ctdh.CurrentRow.Cells["MACTDH"].Value.ToString();
                String query = "UPDATE CHITIETDONHANG SET MADH = N'" + txt_madh.Text + "',MATHUOC = N'" + txt_mathuoc.Text + "',SOLUONG = N'" + txt_soluong.Text + "',GIA = N'" + txt_gia.Text + "' WHERE MACTDH = '" + macthd + "'";
                int kq = kn.themsuaxoa(query);
                if (kq >= 1)
                {
                    MessageBox.Show("Cập nhật thành công.");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                }
            }
            LoadData();
           UpdateTongTien(Convert.ToInt32(txt_madh.Text));
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

            if (dtgv_ctdh.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn chi tiết đơn hàng cần xóa.");
                return;
            }
            string mactdh = dtgv_ctdh.CurrentRow.Cells["MACTDH"].Value.ToString();
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết đơn hàng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }
            String query = "DELETE CHITIETDONHANG WHERE MACTDH = '" + mactdh + "'";
            try
            {
                int kq = kn.themsuaxoa(query);
                if (kq >= 1)
                {
                    MessageBox.Show("Xóa thành công.");
                    UpdateTongTien(int.Parse(txt_madh.Text));
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
        private void UpdateTongTien(int Madh)
        {
            float tong = 0;
            string sql = "SELECT SOLUONG, GIA FROM CHITIETDONHANG WHERE MADH = '"+txt_madh.Text+"'";
            SqlCommand command = new SqlCommand(sql, kn.Cnn);         
            try
            {
                kn.Cnn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int soluong = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                    float gia = reader.IsDBNull(1) ? 0 : (float)reader.GetDouble(1);
                    tong += soluong * gia;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                kn.Cnn.Close();
            }

            string updateQuery = "UPDATE DONHANG SET TONGTIEN = @TongTien WHERE MADH = @MaDH";
            SqlCommand updateCommand = new SqlCommand(updateQuery, kn.Cnn);
            updateCommand.Parameters.AddWithValue("@TONGTIEN", tong);
            updateCommand.Parameters.AddWithValue("@MADH", Madh);         
            try
            {
                  kn.Cnn.Open();         
               updateCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật tổng tiền: " + ex.Message);
            }
            finally
            {
                kn.Cnn.Close();
            }
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_madh.Text = "";
            txt_mathuoc.Text = "";
            txt_gia.Text = "";
            txt_soluong.Text = "";
        }

        private void dtgv_ctdh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_madh.Text = dtgv_ctdh.CurrentRow.Cells["MADH"].Value.ToString();
            txt_mathuoc.Text = dtgv_ctdh.CurrentRow.Cells["MATHUOC"].Value.ToString();
            txt_soluong.Text = dtgv_ctdh.CurrentRow.Cells["SOLUONG"].Value.ToString();
            txt_gia.Text = dtgv_ctdh.CurrentRow.Cells["GIA"].Value.ToString();
        }
    }
}
