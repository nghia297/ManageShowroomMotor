using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShowroomMotor.DAL
{
    class dalDangNhap
    {
        KetNoi kn;
        public dalDangNhap()
        {
            kn = new KetNoi();
        }
        public int dalLogin(String tenDangNhap, String matKhau)
        {
            String sqlDangNhap = "select count (*) from TAIKHOAN where TenDangNhap = '" + tenDangNhap
                + "' and MatKhau = '" + matKhau + "'";
            return (int)kn.Scalar(sqlDangNhap);
        }
    }
}
