using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BTL_QuanLyNhanVien.Dao
{
    public class DataProvider
    {
        private static DataProvider instance; // Ctrl + R + E

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        static string connectionSTR = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyNhanVien;Integrated Security=True";

        SqlConnection conn = new SqlConnection(connectionSTR);

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            data.Load(reader);
            conn.Close();
            return data;

        }
        public void ThemDuLieuNhanVien(string query,Employee employee)
        {
            DataTable data = new DataTable();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Hoten", employee.HoTen);
            cmd.Parameters.AddWithValue("@NgaySinh", employee.NgaySinh);
            cmd.Parameters.AddWithValue("@DiaChi", employee.DiaChi);
            cmd.Parameters.AddWithValue("@Email", employee.Email);
            cmd.Parameters.AddWithValue("@GioiTinh", employee.GioiTinh);
            cmd.Parameters.AddWithValue("@DiDong", employee.DiDong);
            cmd.Parameters.AddWithValue("@ChuyenMon", employee.ChuyenMon);
            cmd.Parameters.AddWithValue("@MaNhanVien", employee.MaNhanVien);
            cmd.Parameters.AddWithValue("@ChucVu", employee.ChucVu);
            cmd.Parameters.AddWithValue("@LuongCoBan", employee.LuongCoBan);
            cmd.Parameters.AddWithValue("@PhongBan", employee.PhongBan);
            cmd.Parameters.AddWithValue("@HeSoLuong", employee.HeSoLuong);
            cmd.Parameters.AddWithValue("@PhuCap", employee.PhuCap);
            cmd.Parameters.AddWithValue("@CCCD", employee.CCCD);


            cmd.ExecuteNonQuery();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            conn.Close();
        }

        internal void ExecuteQuery(string query, Employee employee)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Hoten", employee.HoTen);
            cmd.Parameters.AddWithValue("@NgaySinh", employee.NgaySinh);
            cmd.Parameters.AddWithValue("@DiaChi", employee.DiaChi);
            cmd.Parameters.AddWithValue("@Email", employee.Email);
            cmd.Parameters.AddWithValue("@GioiTinh", employee.GioiTinh);
            cmd.Parameters.AddWithValue("@DiDong", employee.DiDong);
            cmd.Parameters.AddWithValue("@ChuyenMon", employee.ChuyenMon);
            cmd.Parameters.AddWithValue("@MaNhanVien", employee.MaNhanVien);
            cmd.Parameters.AddWithValue("@ChucVu", employee.ChucVu);
            cmd.Parameters.AddWithValue("@LuongCoBan", employee.LuongCoBan);
            cmd.Parameters.AddWithValue("@PhongBan", employee.PhongBan);
            cmd.Parameters.AddWithValue("@HeSoLuong", employee.HeSoLuong);
            cmd.Parameters.AddWithValue("@PhuCap", employee.PhuCap);
            cmd.Parameters.AddWithValue("@CCCD", employee.CCCD);


            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            conn.Close();
        }
    }
}
