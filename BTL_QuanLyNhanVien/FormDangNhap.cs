using BTL_QuanLyNhanVien.AccountDao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyNhanVien
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tk = txbTaiKhoan.Text;
            string mk = txbMatKhau.Text;
            if (Login(tk, mk))
            {
                Form fMain = new FormMain();
                this.Hide();
                fMain.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }

        }
        bool Login(string tk, string mk)
        {
            return AccountDao.AccountDao.Instance.Login(tk, mk);
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
