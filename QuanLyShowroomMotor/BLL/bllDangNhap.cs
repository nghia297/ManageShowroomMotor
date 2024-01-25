using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShowroomMotor.BLL
{
    class bllDangNhap
    {
        DAL.dalDangNhap dalDN;
        frm_DangNhap dn;
        public bllDangNhap(frm_DangNhap fDN)
        {
            dalDN = new DAL.dalDangNhap();
            dn = fDN;
        }
        public bool bllLogin()
        {
            int kq = dalDN.dalLogin(dn.txt_TenDangNhap.Text, dn.txt_MatKhau.Text);
            if (kq >= 1)
            {
                frm_QuanLy sv = new frm_QuanLy();
                dn.Visible = false;
                sv.ShowDialog();
                dn.Visible = true;
            }
            else
            {
                MessageBox.Show("Sai ten dang nhap hoac mat khau");
                return false;
            } 
            return true;
        }
    }
}
