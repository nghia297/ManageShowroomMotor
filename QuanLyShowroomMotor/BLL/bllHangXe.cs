using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShowroomMotor.BLL
{
    class bllHangXe
    {
        DAL.dalHangXe dalHANGXE;
        frm_HangXe hangXe;

        public bllHangXe(frm_HangXe fHX)
        {
            dalHANGXE = new DAL.dalHangXe();
            hangXe = fHX;
        }
        public void BllLoadData()
        {
            hangXe.dataGridView1.DataSource = dalHANGXE.DalLoad();
        }
        public void BllThem()
        {
            dalHANGXE.DalThem(hangXe.txt_MaHangXe.Text, hangXe.txt_TenHangXe.Text, hangXe.txt_TenAnhHangXe.Text);
        }
        public void BllXoa()
        {
            dalHANGXE.DalXoa(hangXe.txt_MaHangXe.Text);
        }
        public void BllSua()
        {
            dalHANGXE.DalSua(hangXe.txt_MaHangXe.Text, hangXe.txt_TenHangXe.Text, hangXe.txt_TenAnhHangXe.Text);
        }
        public void BllTimKiem()
        {
            hangXe.dataGridView1.DataSource = dalHANGXE.DalTimKiem(hangXe.txt_TimKiem.Text);
        }
        public void BllDem()
        {
            hangXe.txt_Dem.Text = dalHANGXE.DalDem();
        }
    }
}
