using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShowroomMotor.DAL
{
    class dalXe
    {
        KetNoi kn;

        public dalXe()
        {
            kn = new KetNoi();
        }
        public DataTable DalLoad()
        {
            String sqlLoadGrid = "Select * from XE";
            return kn.LoadData(sqlLoadGrid);
        }
        public void DalThem(String maXe, String tenXe, DateTime ngaySanXuat, String tenAnhXe, String maHangXe, String giaXe)
        {
            String sqlThem = "Insert into XE values('" + maXe
                + "', N'" + tenXe
                + "', Convert(DateTime, '"
                + ngaySanXuat + "', 103), '"
                + tenAnhXe + "', '" + maHangXe + "', '" + giaXe + "')";
            kn.Nonquery(sqlThem);
        }
        public void DalXoa(String maXe)
        {
            String sqlXoa = "delete from XE where MaXe = '" + maXe + "'";
            kn.Nonquery(sqlXoa);
        }
        public void DalSua(String maXe, String tenXe, DateTime ngaySanXuat, String tenAnhXe, String maHangXe, String giaXe)
        {
            String sqlSua = "update XE set TenXe = N'" + tenXe
                + "', NgaySanXuat = Convert(DateTime, '" + ngaySanXuat
                + "', 103), TenAnhXe = '" + tenAnhXe + "', MaHangXe = '" + maHangXe
                + "', GiaXe = '" + giaXe + "' where MaXe = '" + maXe + "'";
            kn.Nonquery(sqlSua);
        }
        public string DalDem()
        {
            String sqlDem = " select COUNT(*) From XE";
            return kn.Scalar(sqlDem).ToString();
        }
        public DataTable DalTimKiem(String timKiem)
        {
            String sqlTimKiem = "select * from XE where MaXe like '%" + timKiem + "%' or TenXe like N'%" + timKiem + "%'";
            return kn.LoadData(sqlTimKiem);
        }
        public DataTable DalCbHangXe(String maHangXe)
        {
            String sqlLoadCb = "select * from XE where MaHangXe = '" + maHangXe + "'";
            return kn.LoadData(sqlLoadCb);
        }
    }
}
