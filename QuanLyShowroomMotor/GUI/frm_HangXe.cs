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
    public partial class frm_HangXe : Form
    {
        public frm_HangXe()
        {
            InitializeComponent();
            BllHANGXE = new BLL.bllHangXe(this);
        }
        BLL.bllHangXe BllHANGXE;
        private void frm_HangXe_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            BllHANGXE.BllLoadData();
        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\";

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaHangXe.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_TenHangXe.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_TenAnhHangXe.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_TenAnhHangXe.Text;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Hãy chọn ảnh";
            OFD.Filter = "Tất cả đuôi ảnh|*.*|JPG|*.jpg|PNG|*.png|JPEG|*.jpeg";
            if (OFD.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(OFD.FileName);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_MaHangXe.Text.Trim() == "" || txt_TenHangXe.Text.Trim() == "")
                MessageBox.Show("Ma hang xe hoac ten hang xe khong duoc de trong");
            else
            {
                BllHANGXE.BllThem();
                try
                {
                    pictureBox1.Image.Save(duongdan + txt_TenAnhHangXe.Text);
                }
                catch
                {

                }
                LoadData();

            }
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            BllHANGXE.BllXoa();
            try
            {
                File.Delete(duongdan + txt_TenAnhHangXe.Text);
            }
            catch
            {

            }
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            BllHANGXE.BllSua();
            try
            {
                pictureBox1.Image.Save(duongdan + txt_TenAnhHangXe.Text);
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
            BllHANGXE.BllDem();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            BllHANGXE.BllTimKiem();
        }

        private void frm_HangXe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban chac chan muon thoat khong", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
