using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShowroomMotor
{
    public partial class frm_QuanLy : Form
    {
        public frm_QuanLy()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void xeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Xe"] == null)
            {
                frm_Xe con = new frm_Xe();
                this.Visible = false;
                con.ShowDialog();
                this.Visible = true;
            }
            else
                Application.OpenForms["frm_Xe"].Activate();
        }

        private void hangXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_HangXe"] == null)
            {
                frm_HangXe con = new frm_HangXe();
                this.Visible = false;
                con.ShowDialog();
                this.Visible = true;
            }
            else
                Application.OpenForms["frm_HangXe"].Activate();
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_NhanVien"] == null)
            {
                frm_NhanVien con = new frm_NhanVien();
                this.Visible = false;
                con.ShowDialog();
                this.Visible = true;
            }
            else
                Application.OpenForms["frm_NhanVien"].Activate();
        }

        private void frm_QuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban chac chan muon thoat khong", "Thoat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
