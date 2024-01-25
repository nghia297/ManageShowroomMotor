using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShowroomMotor.BLL
{
    class bllNhanVien
    {
        DAL.dalNhanVien dalNV;
        frm_NhanVien nv;

        public bllNhanVien(frm_NhanVien fnv)
        {
            dalNV = new DAL.dalNhanVien();
            nv = fnv;
        }
        public void BllLoadData()
        {
            nv.dataGridView1.DataSource = dalNV.DalLoad();
        }
        public void BllThem()
        {
            dalNV.DalThem(nv.txt_MaNV.Text, nv.txt_HoTen.Text, nv.dateTimePicker1.Value, nv.txt_CCCD.Text,
                nv.txt_QueQuan.Text, nv.txt_TenAnhNhanVien.Text);
        }
        public void BllXoa()
        {
            dalNV.DalXoa(nv.txt_MaNV.Text);
        }
        public void BllSua()
        {
            dalNV.DalSua(nv.txt_MaNV.Text, nv.txt_HoTen.Text, nv.dateTimePicker1.Value, nv.txt_CCCD.Text,
                nv.txt_QueQuan.Text, nv.txt_TenAnhNhanVien.Text);
        }
        public void BllTimKiem()
        {
            nv.dataGridView1.DataSource = dalNV.DalTimKiem(nv.txt_TimKiem.Text);
        }
        public void BllDem()
        {
            nv.txt_Dem.Text = dalNV.DalDem();
        }
    }
}
