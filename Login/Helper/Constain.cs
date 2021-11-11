using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Helper
{
    
    public class Constain
    {
        public static String connectingString = @"Data Source=DESKTOP-DQ1BOMO\SQLEXPRESS;Initial Catalog=Qly_Nhahang;Integrated Security=True";
        public enum Role
        {
            DANG_NHAP,
            XEM_DANH_SACH_NHAN_VIEN,
        };
        public static Role? getRoleByString (String role)
        {
            switch (role)
            {
                case "DANG_NHAP": return Role.DANG_NHAP;
                case "XEM_DANH_SACH_NHAN_VIEN": return Role.XEM_DANH_SACH_NHAN_VIEN;
                default: return null;
            }
        }
    }
}
