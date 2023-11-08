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

namespace SellPhone
{
    public partial class BillControl : UserControl
    {
        public BillControl()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QLCHDT;Integrated Security=True");

        public void insertBill()
        {
            string sql = "TaoHoaDon";
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    this.conn.Open();
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter HoTen = new SqlParameter("@HoTen", SqlDbType.NVarChar);
                HoTen.Value = txtHoTen.Text.ToString();
                cmd.Parameters.Add(HoTen);

                SqlParameter SDT = new SqlParameter("@SDT", SqlDbType.Char);
                SDT.Value = txtSDT.Text;    
                cmd.Parameters.Add(SDT);

                SqlParameter CCCD = new SqlParameter("@CCCD", SqlDbType.Char);
                CCCD.Value = txtCCCD.Text;
                cmd.Parameters.Add(CCCD);

                SqlParameter MaNV = new SqlParameter("@MaNV", SqlDbType.Int);
                MaNV.Value = int.Parse(txtMaNV.Text);
                cmd.Parameters.Add(MaNV);

                SqlParameter PhuongThucTT = new SqlParameter("@PhuongThucTT", SqlDbType.Int);
                if (cbPhuongThucTT.Checked)
                {
                    PhuongThucTT.Value = 1;
                }
                else
                {
                    PhuongThucTT.Value = 0;
                }
                cmd.Parameters.Add(PhuongThucTT);

                SqlParameter MaSP = new SqlParameter("@MaSP", SqlDbType.Int);
                MaSP.Value = int.Parse(txtMaSP.Text);
                cmd.Parameters.Add(MaSP);

                SqlParameter TongSL = new SqlParameter("@TongSL", SqlDbType.Int);
                TongSL.Value = int.Parse(txtTongSL.Text.ToString());
                cmd.Parameters.Add(TongSL);

                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    this.conn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void LoadBill()
        {
            DataTable dt = new DataTable();
            string sql = "select * from HoaDon";
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    this.conn.Open();
                }
                SqlCommand cmd = new SqlCommand(sql, this.conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                dgvHoaDon.DataSource = dt;
                if (conn.State == ConnectionState.Open)
                {
                    this.conn.Close();
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                insertBill();
                LoadBill();
                MessageBox.Show("Thêm Hóa Đơn Thành Công!");
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (ex.Message.Contains("Check_KhachHang_SDT"))
                {
                    message = "Số Điện Thoại Không Hợp Lệ";
                }
                else if(ex.Message.Contains("FK_HoaDon_MaNV"))
                {
                    message = "Mã Nhân Viên Không Hợp Lệ";
                }
                MessageBox.Show(message);
            }
          
            
        }

        private void BillControl_Load(object sender, EventArgs e)
        {
            LoadBill();
        }
    }
}
