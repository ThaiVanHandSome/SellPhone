using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellPhone
{
    public partial class AddEmploy : Form
    {
        public AddEmploy()
        {
            InitializeComponent();
        }
        SqlConnectionManager conn = new SqlConnectionManager();
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_SDT.Text != "" || txt_HoTen.Text!= "" || (txt_GioiTinh.Text != "1" || txt_GioiTinh.Text != "0") || datetimePicker_NgaySinh.Value < DateTime.Now ||datetimePicker_NgayTuyenDung.Value <DateTime.Now)
            {
                conn.add_NhanVien(txt_HoTen.Text, txt_SDT.Text, datetimePicker_NgaySinh.Value, Convert.ToInt32(txt_GioiTinh.Text), datetimePicker_NgayTuyenDung.Value, txt_DiaChi.Text);

            }
            else
            {
                MessageBox.Show("Không thể thêm dữ liệu, vui lòng thực hiện lại!",
                    "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
