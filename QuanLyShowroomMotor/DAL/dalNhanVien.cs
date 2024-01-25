using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShowroomMotor.DAL
{
    class dalNhanVien
    {
        KetNoi kn;

        public dalNhanVien()
        {
            kn = new KetNoi();
        }
        public DataTable DalLoad()
        {
            String sqlLoadGrid = "Select * from NHANVIEN";
            return kn.LoadData(sqlLoadGrid);
        }
        public void DalThem(String maNV, String hoTen, DateTime ngaySinh, String CCCD, String queQuan, String tenAnhNhanVien)
        {
            String sqlThem = "Insert into NHANVIEN values('" + maNV
                + "', N'" + hoTen 
                + "', Convert(DateTime, '"
                + ngaySinh + "', 103), '" 
                + CCCD + "', N'" + queQuan + "', '" + tenAnhNhanVien + "')";
            kn.Nonquery(sqlThem);
        }
        public void DalXoa(String maNV)
        {
            String sqlXoa = "delete from NHANVIEN where MaNV = '" + maNV + "'";
            kn.Nonquery(sqlXoa);
        }
        public void DalSua(String maNV, String hoTen, DateTime ngaySinh, String CCCD, String queQuan, String tenAnhNhanVien)
        {
            String sqlSua = "update NHANVIEN set HoTen = N'" + hoTen
                + "', NgaySinh = Convert(DateTime, '" + ngaySinh
                + "', 103), CCCD = '" + CCCD + "', QueQuan = N'" + queQuan
                + "', TenAnhNhanVien = '" + tenAnhNhanVien + "' where MaNV = '" + maNV + "'";
            kn.Nonquery(sqlSua);
        }
        public string DalDem()
        {
            String sqlDem = " select COUNT(*) From NHANVIEN";
            return kn.Scalar(sqlDem).ToString();
        }
        public DataTable DalTimKiem(String timKiem)
        {
            String sqlTimKiem = "select * from NHANVIEN where MaNV like '%" + timKiem + "%' or HoTen like N'%" + timKiem + "%'";
            return kn.LoadData(sqlTimKiem);
        }
    }
}
