using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShowroomMotor
{
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
            bllDN = new BLL.bllDangNhap(this);
        }
        BLL.bllDangNhap bllDN;
        int count = 0;
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (txt_TenDangNhap.Text.Trim() == "" || txt_MatKhau.Text.Trim() == "")
                MessageBox.Show("Ten dang nhap hoac mat khau khong duoc de trong");
            else
            {
                if (bllDN.bllLogin() == true)
                    count = 0;
                else
                {
                    count += 1;
                    if (count < 3)
                        MessageBox.Show("Ban da nhap sai " + count + " lan. Sai 3 lan se thoat!!!");
                    else
                    {
                        MessageBox.Show("Ban da nhap sai 3 lan. Thoat!!!");
                        thoat = 1;
                        Application.Exit();
                    }
                }
            }
        }
        int thoat = 0;
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban chac chan muon thoat", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                thoat = 1;
                Application.Exit();
            }
        }

        private void frm_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thoat == 0)
            {
                DialogResult r = MessageBox.Show("Ban chac chan muon thoat Form khong", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
