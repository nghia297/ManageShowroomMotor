using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShowroomMotor.BLL
{
    class bllXe
    {
        DAL.dalXe dalXE;
        DAL.dalHangXe dalHANGXE;
        frm_Xe xe;

        public bllXe(frm_Xe fXe)
        {
            dalXE = new DAL.dalXe();
            dalHANGXE = new DAL.dalHangXe();
            xe = fXe;
        }
        public void BllLoadData()
        {
            xe.dataGridView1.DataSource = dalXE.DalLoad();
        }
        public void BllLoadHangXe()
        {
            xe.cb_HangXe.DataSource = dalHANGXE.DalLoad();
            xe.cb_HangXe.DisplayMember = "TenHangXe";
            xe.cb_HangXe.ValueMember = "MaHangXe";
        }
        public void BllThem()
        {
            dalXE.DalThem(xe.txt_MaXe.Text, xe.txt_TenXe.Text, xe.dateTimePicker1.Value, xe.txt_TenAnhXe.Text,
                xe.cb_HangXe.SelectedValue.ToString(), xe.txt_GiaXe.Text);
        }
        public void BllXoa()
        {
            dalXE.DalXoa(xe.txt_MaXe.Text);
        }
        public void BllSua()
        {
            dalXE.DalSua(xe.txt_MaXe.Text, xe.txt_TenXe.Text, xe.dateTimePicker1.Value, xe.txt_TenAnhXe.Text,
                xe.cb_HangXe.SelectedValue.ToString(), xe.txt_GiaXe.Text);
        }
        public void BllTimKiem()
        {
            xe.dataGridView1.DataSource = dalXE.DalTimKiem(xe.txt_TimKiem.Text);
        }
        public void BllDem()
        {
            xe.txt_Dem.Text = dalXE.DalDem();
        }
        public void BllCbHangXe()
        {
            xe.dataGridView1.DataSource = dalXE.DalCbHangXe(xe.cb_HangXe.SelectedValue.ToString());
        }
    }
}
