using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace pong
{
    public class DatabaseControler
    {
        private static string datasource = "Server=LEVINNT;Database=PingPong(userpass);Trusted_Connection=True;";
        private static SqlConnection connection;
        private static SqlCommand cmd;
        private DatabaseControler ()
        {
            connection = new SqlConnection(datasource);
      
            cmd= new SqlCommand();
            cmd.Connection = connection;
 
        }
        private static DatabaseControler instance;
        public static DatabaseControler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseControler();
                }
                return instance;
            }
        }
        public void insert(string value,string cot,string bang)// them ten nguoi choi vào cột người chơi
        {
            connection.Open();
            try
            {

                string query = "insert into +"+bang+"("+cot+") values ('"+value+"')";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            connection.Close();
        }
        public void insertpoint (int point,string time, string taikhoan)//thêm điểm của người chơi với máy
        {
            connection.Open();
            try
            {

                string query = "insert into choivoimay values('"+taikhoan+ "','" + time +"',"+point+")";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            connection.Close();
        }
        public void update(string value,string taikhoan)//update ten nguoi dung
        {
            connection.Open();
            try
            {

                string query = "update userpass set ten='" + value + "' where taikhoan='" + taikhoan + "'";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            connection.Close();
        }
        public void updateHighscore(string value, string taikhoan)//update diem so cao nhat
        {
            connection.Open();
            try
            {

                string query = "update userpass set highscore=" + value + " where taikhoan='" + taikhoan + "'";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            connection.Close();
        }
        public string select(string value,string taikhoan) // lấy dữ liệu value
        {
            string res="";
            connection.Open();
            try
            {
                string query = "select " + value + " from userpass where taikhoan='" + taikhoan + "'";
                cmd.CommandText = query;
                SqlDataReader dataReader = cmd.ExecuteReader();//ExecuteReader dùng khi cần lấy giá trị trả về
                dataReader.Read();
                res = dataReader[value].ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            connection.Close();
            return res;
        }
        public string showlichsu(string taikhoan)//hiển thị lịch sử của người chơi
        {
            string res = "";
            connection.Open();
            try
            {
                string query = "select thoigian,point from choivoimay where taikhoan='" + taikhoan + "'";
                cmd.CommandText = query;
                SqlDataReader dataReader = cmd.ExecuteReader();
                while(dataReader.Read())
                {
                    res=res+dataReader[0].ToString() +"         "+ dataReader[1].ToString()+"\n";
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            connection.Close();
            return res;
        }
        public void xoalichsu (string taikhoan) // xóa lịch sử người chơi
        {
            connection.Open();
            try
            {
                string query = "delete  from choivoimay where taikhoan='" + taikhoan + "'";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            connection.Close();
        }
        public bool checktaikhoan (string taikhoan)//kiểm tra xem có tồn tại tài khoản đó chưa
        {
            bool kiemtra;
            connection.Open();
            string query = "select * from userpass where taikhoan='" + taikhoan + "'";
            cmd.CommandText = query;
            SqlDataReader reader= cmd.ExecuteReader();
            kiemtra = reader.Read();// kiemtra= true là có dữ liệu, = false là không có dữ liệu                   
            reader.Close();
            connection.Close();
            return kiemtra;
        }
        public bool checkpass(string pass)//kiểm tra mật khẩu đăng nhập đúng không
        {
            bool kiemtra;
            connection.Open();
            string query = "select * from userpass where matkhau='" + pass + "'";
            cmd.CommandText = query;
            SqlDataReader reader = cmd.ExecuteReader();
            kiemtra = reader.Read();// kiemtra= true là có dữ liệu, = false là không có dữ liệu                   
            reader.Close();
            connection.Close();
            return kiemtra;
        }
        public void insertuser(string user,string pass,string name,string time)//thêm thông tin tài khoản
        {
            connection.Open();
            try
            {

                string query = "insert into userpass values('" + user + "','" + pass + "','" + time +"','"+name+"',0" +")";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            connection.Close();
        }
    }

}
