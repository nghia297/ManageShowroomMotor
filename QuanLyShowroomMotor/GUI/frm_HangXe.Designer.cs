namespace QuanLyShowroomMotor
{
    partial class frm_HangXe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HangXe));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaHangXe = new System.Windows.Forms.TextBox();
            this.txt_TenHangXe = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_TenAnhHangXe = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_LoadLai = new System.Windows.Forms.Button();
            this.btn_Dem = new System.Windows.Forms.Button();
            this.txt_Dem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hãng xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hãng xe";
            // 
            // txt_MaHangXe
            // 
            this.txt_MaHangXe.Location = new System.Drawing.Point(214, 71);
            this.txt_MaHangXe.Name = "txt_MaHangXe";
            this.txt_MaHangXe.Size = new System.Drawing.Size(169, 22);
            this.txt_MaHangXe.TabIndex = 2;
            // 
            // txt_TenHangXe
            // 
            this.txt_TenHangXe.Location = new System.Drawing.Point(214, 117);
            this.txt_TenHangXe.Name = "txt_TenHangXe";
            this.txt_TenHangXe.Size = new System.Drawing.Size(169, 22);
            this.txt_TenHangXe.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(441, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_TenAnhHangXe
            // 
            this.txt_TenAnhHangXe.Location = new System.Drawing.Point(441, 257);
            this.txt_TenAnhHangXe.Name = "txt_TenAnhHangXe";
            this.txt_TenAnhHangXe.Size = new System.Drawing.Size(131, 22);
            this.txt_TenAnhHangXe.TabIndex = 5;
            this.txt_TenAnhHangXe.Text = "tenHangXe.png";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(135, 208);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(135, 257);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(283, 208);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(107, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(503, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(500, 39);
            this.label3.TabIndex = 10;
            this.label3.Text = "Thông tin hãng xe tại showroom";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(214, 163);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(169, 22);
            this.txt_TimKiem.TabIndex = 11;
            this.txt_TimKiem.Text = "Tìm theo mã hoặc tên hãng xe";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(107, 163);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 12;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_LoadLai
            // 
            this.btn_LoadLai.Location = new System.Drawing.Point(283, 257);
            this.btn_LoadLai.Name = "btn_LoadLai";
            this.btn_LoadLai.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadLai.TabIndex = 13;
            this.btn_LoadLai.Text = "Load lại";
            this.btn_LoadLai.UseVisualStyleBackColor = true;
            this.btn_LoadLai.Click += new System.EventHandler(this.btn_LoadLai_Click);
            // 
            // btn_Dem
            // 
            this.btn_Dem.Location = new System.Drawing.Point(441, 71);
            this.btn_Dem.Name = "btn_Dem";
            this.btn_Dem.Size = new System.Drawing.Size(75, 23);
            this.btn_Dem.TabIndex = 14;
            this.btn_Dem.Text = "Đếm";
            this.btn_Dem.UseVisualStyleBackColor = true;
            this.btn_Dem.Click += new System.EventHandler(this.btn_Dem_Click);
            // 
            // txt_Dem
            // 
            this.txt_Dem.Location = new System.Drawing.Point(542, 71);
            this.txt_Dem.Name = "txt_Dem";
            this.txt_Dem.Size = new System.Drawing.Size(68, 22);
            this.txt_Dem.TabIndex = 15;
            // 
            // frm_HangXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 490);
            this.Controls.Add(this.txt_Dem);
            this.Controls.Add(this.btn_Dem);
            this.Controls.Add(this.btn_LoadLai);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_TenAnhHangXe);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_TenHangXe);
            this.Controls.Add(this.txt_MaHangXe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_HangXe";
            this.Text = "Frm_HangXe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_HangXe_FormClosing);
            this.Load += new System.EventHandler(this.frm_HangXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_MaHangXe;
        public System.Windows.Forms.TextBox txt_TenHangXe;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txt_TenAnhHangXe;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_LoadLai;
        private System.Windows.Forms.Button btn_Dem;
        public System.Windows.Forms.TextBox txt_Dem;
    }
}