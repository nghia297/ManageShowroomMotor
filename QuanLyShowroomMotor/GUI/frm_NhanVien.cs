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
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
            BllNHANVIEN = new BLL.bllNhanVien(this);
        }
        BLL.bllNhanVien BllNHANVIEN;
        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            BllNHANVIEN.BllLoadData();
        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\";

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_MaNV.Text.Trim() == "" || txt_HoTen.Text.Trim() == "")
                MessageBox.Show("Ma nhan vien hoac ho ten khong duoc de trong");
            else
            {
                BllNHANVIEN.BllThem();
                try
                {
                    pictureBox1.Image.Save(duongdan + txt_TenAnhNhanVien.Text);
                }
                catch
                {

                }
                LoadData();
            }
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            BllNHANVIEN.BllXoa();
            try
            {
                File.Delete(duongdan + txt_TenAnhNhanVien.Text);
            }
            catch
            {

            }
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            BllNHANVIEN.BllSua();
            try
            {
                pictureBox1.Image.Save(duongdan + txt_TenAnhNhanVien.Text);
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

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            BllNHANVIEN.BllTimKiem();
        }

        private void btn_Dem_Click(object sender, EventArgs e)
        {
            BllNHANVIEN.BllDem();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_HoTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_CCCD.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_QueQuan.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_TenAnhNhanVien.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            pictureBox1.ImageLocation = duongdan + txt_TenAnhNhanVien.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Hãy chọn ảnh";
            OFD.Filter = "Tất cả đuôi ảnh|*.*|JPG|*.jpg|PNG|*.png|JPEG|*.jpeg";
            if (OFD.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(OFD.FileName);
        }

        private void frm_NhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban chac chan muon thoat khong", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
