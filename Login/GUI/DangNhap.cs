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

namespace Login
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string cnn = @"Data Source=DESKTOP-B125TKI\SQLEXPRESS;Initial Catalog=QlNhaHang;Integrated Security=True";
            SqlConnection con = new SqlConnection(cnn);
            SqlDataAdapter da = new SqlDataAdapter("select * from tblUsers where  sName = N'"+txtTaiKhoan.Text+"'and sPassword = '"+txtMatKhau.Text+"'",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                QuanLy quanly = new QuanLy();
                quanly.Show();
            }
            else
            {

                
                string tk = txtTaiKhoan.Text, mk = txtMatKhau.Text;
                if (tk == "" || mk == "")
                {
                    MessageBox.Show("Vui lòng điền thông tin");
                }
                else
                {
                    errorProvider1.SetError(txtTaiKhoan, "Tên người dùng không đúng");
                    errorProvider1.SetError(txtMatKhau, "Mật khẩu không đúng");
                }
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoiMK dmk = new DoiMK();
            dmk.Show();
        }
    }
}
