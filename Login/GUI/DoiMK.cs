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
    public partial class DoiMK : Form
    {
        public DoiMK()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            string cnn = @"Data Source=DESKTOP-B125TKI\SQLEXPRESS;Initial Catalog=QlNhaHang;Integrated Security=True";
            SqlConnection con = new SqlConnection(cnn);
            SqlDataAdapter da = new SqlDataAdapter("select * from tblUsers where  sName = N'" + txtTK.Text + "'and sPassword = '" + txtMK.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            errorProvider1.Clear();
            if (dt.Rows[0][0].ToString() == "1")
            {
                if(txtMKM.Text == txtRMKM.Text)
                {
                    SqlDataAdapter da1 = new SqlDataAdapter("update tblUser set sPassword = '" + txtMKM + "' where sName = N'" + txtTK.Text + "' and sPassword= '" + txtMK.Text+  "'",con);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    MessageBox.Show("Đổi Mk thành công");
                }
                else
                {
                    errorProvider1.SetError(txtMKM, "Bạn chưa điền mật khẩu mới");
                    errorProvider1.SetError(txtRMKM, "Mật khẩu mới chưa đúng");

                }
            }
            else
            {
                errorProvider1.SetError(txtTK, "Tên người dùng không đúng");
                errorProvider1.SetError(txtMK, "Mật khẩu cũ không đúng");

            }
        }
    }
}
