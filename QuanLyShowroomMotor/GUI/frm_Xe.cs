using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShowroomMotor
{
    public partial class frm_Xe : Form
    {
        public frm_Xe()
        {
            InitializeComponent();
            BllXE = new BLL.bllXe(this);
        }
        BLL.bllXe BllXE;
        private void frm_Xe_Load(object sender, EventArgs e)
        {
            LoadComboHangXe();
            LoadData();
        }
        public void LoadData()
        {
            BllXE.BllLoadData();
        }
        public void LoadComboHangXe()
        {
            BllXE.BllLoadHangXe();
        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\";
        int check = 0;
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_MaXe.Text.Trim() == "" || txt_TenXe.Text.Trim() == "")
                MessageBox.Show("Ma xe hoac ten xe khong duoc de trong");
            else
            {
                BllXE.BllThem();
                try
                {
                    pictureBox1.Image.Save(duongdan + txt_TenAnhXe.Text);
                }
                catch
                {

                }
                LoadData();
            }
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            BllXE.BllXoa();
            try
            {
                File.Delete(duongdan + txt_TenAnhXe.Text);
            }
            catch
            {
                
            }
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            BllXE.BllSua();
            try
            {
                pictureBox1.Image.Save(duongdan + txt_TenAnhXe.Text);
            }
            catch
            {

            }
            LoadData();
        }

        private void btn_LoadLai_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Dem_Click(object sender, EventArgs e)
        {
            BllXE.BllDem();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            BllXE.BllTimKiem();
        }

        private void cb_HangXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (check == 0)
                BllXE.BllCbHangXe();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Hãy chọn ảnh";
            OFD.Filter = "Tất cả đuôi ảnh|*.*|JPG|*.jpg|PNG|*.png|JPEG|*.jpeg";
            if (OFD.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(OFD.FileName);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaXe.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_TenXe.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_TenAnhXe.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            check = 1;
            cb_HangXe.SelectedValue = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            check = 0;
            txt_GiaXe.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_TenAnhXe.Text;
        }

        private void frm_Xe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban chac chan muon thoat khong", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
