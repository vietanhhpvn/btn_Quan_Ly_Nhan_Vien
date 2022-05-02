using BTL_QuanLyNhanVien.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyNhanVien.AccountDao
{
    public class AccountDao
    {
        private static AccountDao instance;
        private AccountDao() { }

        public static AccountDao Instance
        {
            get 
            {
                if (instance == null) 
                    instance = new AccountDao();
                return instance;
            }
            private set { instance = value; }
        }

        public bool Login(string taikhoan, string matkhau)
        {
            string query = "SELECT * FROM dbo.QuanLyTaiKhoan WHERE TaiKhoan = N'" + taikhoan + "' and MatKhau = N'" + matkhau + "' ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public void ThemNhanVien( Employee NhanVien)
        {
            string query = "insert into dbo.BanHang values( @Hoten ,@NgaySinh ,@DiaChi ,@Email ,@GioiTinh,@DiDong ,@ChuyenMon,@MaNhanVien ,@ChucVu ,@ LuongCoBan, @PhongBan,@HeSoLuong ,@PhuCap ,@CCCD";
            Console.WriteLine(query);
            DataProvider.Instance.ThemDuLieuNhanVien(query, NhanVien);
            //Dao.DataProvider.Instance.ExecuteQuery(query, NhanVien);

        }
    }
}