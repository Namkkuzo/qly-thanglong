using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class QuanLy : Form
    {
        
        public QuanLy()
        {
            InitializeComponent();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.Show();
            this.Hide();
        }
    }
}
