using Login.Helper;
using Login.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Service
{
    class LoginService
    {

        List<Constain.Role> getRoleUser (Int32 id)
        {
            SqlConnection cnn = new SqlConnection(Constain.connectingString);
            using (SqlCommand cmd = new SqlCommand("login", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cnn.Open();

                List<Constain.Role> listRole = new List<Constain.Role>();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        if (Constain.getRoleByString(row[1].ToString()) != null )
                        listRole.Add(Constain.getRoleByString(row[1].ToString())?? Constain.Role.DANG_NHAP);
                    }   
                    
                }
                catch
                {
                    
                }
                cnn.Close();
                return listRole;
            }
        }

        SortedDictionary<String ,dynamic> Login(int id , String password)
        {
            SortedDictionary<String, dynamic> result = new SortedDictionary<String, dynamic>();
            SqlConnection cnn = new  SqlConnection(Constain.connectingString);
            DataTable table = new DataTable();
            using (SqlCommand cmd = new SqlCommand("login", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cnn.Open();
                
                User user = new  User();
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        user.id = Convert.ToInt32(table.Rows[0].Table.Columns["pass"]);
                        user.id = Convert.ToInt32(table.Rows[0].Table.Columns["pass"]);
                        user.id = Convert.ToInt32(table.Rows[0].Table.Columns["pass"]);
                        user.id = Convert.ToInt32(table.Rows[0].Table.Columns["pass"]);
                        user.id = Convert.ToInt32(table.Rows[0].Table.Columns["pass"]);
                        user.id = Convert.ToInt32(table.Rows[0].Table.Columns["pass"]);
                        user.id = Convert.ToInt32(table.Rows[0].Table.Columns["pass"]);
                        user.id = Convert.ToInt32(table.Rows[0].Table.Columns["pass"]);
                        user.id = Convert.ToInt32(table.Rows[0].Table.Columns["pass"]);
                        user.listRole = getRoleUser(id);

                        // check pass ở đây , hash pass
                        if (Extention.hashCode(password) != table.Rows[0].Table.Columns["pass"].ToString())

                        result.Add("message", "đang nhập thành công");
                        result.Add("user", user);
                    }
                    else
                    {
                        result.Add("message", "Sai tên đang nhập");
                        result.Add("user", null);
                    }
                    
                }
                catch
                {
                    
                }
                cnn.Close();
                return result;
            }
            
        }
    }
}
