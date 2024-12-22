using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAn
{
    internal class KetNoi
    {
        SqlConnection cnn = new SqlConnection();

        public SqlConnection Cnn { get => cnn; set => cnn = value; }
        public KetNoi() {
            cnn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\test\DoAn\DoAn\DoAn\QUANLYBANTHUOC.mdf;Integrated Security=True";
        }
        public int themsuaxoa(String sql)
        {
            SqlCommand cmd = new SqlCommand(sql,cnn);
            cnn.Open();
            int kq=cmd.ExecuteNonQuery();
            cnn.Close();
        return kq; 
        }
        public object laygt(String sql)
        {
            SqlCommand cmd = new SqlCommand(sql,cnn);
            cnn.Open();
            object kq=cmd.ExecuteScalar();
            cnn.Close();
            return kq;
        }
        public DataTable LoadDaTa(String sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            da.Fill(dt);
            return dt;   
        }
        
    }
}
