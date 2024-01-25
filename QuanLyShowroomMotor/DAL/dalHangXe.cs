using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShowroomMotor.DAL
{
    class dalHangXe
    {
        KetNoi kn;
        public dalHangXe()
        {
            kn = new KetNoi();
        }
        public DataTable DalLoad()
        {
            String sqlLoad = "Select * from HANGXE";
            return kn.LoadData(sqlLoad);
        }
        public void DalThem(String maHangXe, String tenHangXe, String tenAnhHangXe)
        {
            String sqlThem = "Insert into HANGXE values('" + maHangXe + "', N'" + tenHangXe + "', '" + tenAnhHangXe + "')";
            kn.Nonquery(sqlThem);
        }
        public void DalXoa(String maHangXe)
        {
            String sqlXoa = "delete from HANGXE where MaHangXe = '" + maHangXe + "'";
            kn.Nonquery(sqlXoa);
        }
        public void DalSua(String maHangXe, String tenHangXe, String tenAnhHangXe)
        {
            String sqlSua = "update HANGXE set TenHangXe = N'" + tenHangXe + "'," +
                " TenAnhHangXe = '" + tenAnhHangXe + "'where MaHangXe = '" + maHangXe + "'";
            kn.Nonquery(sqlSua);
        }
        public string DalDem()
        {
            String sqlDem = " select COUNT(*) From HANGXE";
            return kn.Scalar(sqlDem).ToString();
        }
        public DataTable DalTimKiem(String timKiem)
        {
            String sqlTimKiem = "select * from HANGXE where MaHangXe like '%" + timKiem + "%' or TenHangXe like N'%" + timKiem + "%'";
            return kn.LoadData(sqlTimKiem);
        }
    }
}
