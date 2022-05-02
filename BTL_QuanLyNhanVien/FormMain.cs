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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dao.Const.NewEmploy = null;

            Form fNhanVien = new FormThemNhanVien();
            fNhanVien.FormClosed += FNhanVien_FormClosed;
            fNhanVien.ShowDialog();
        }

        private void FNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListEmployee.Instance.ListEmploy.Add(Dao.Const.NewEmploy);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dtgvDanhSachNhanVien.DataSource = Dao.Const.NewEmploy;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form fDangNhap = new FormDangNhap();
            this.Close();
            fDangNhap.Show();  
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form fDangNhap = new FormDangNhap();
            fDangNhap.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Form fNhanVien = new FormThemNhanVien();
            fNhanVien.ShowDialog();

        }
    }
}
