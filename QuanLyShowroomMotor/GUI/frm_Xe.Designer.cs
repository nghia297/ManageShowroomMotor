namespace QuanLyShowroomMotor
{
    partial class frm_Xe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Xe));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_MaXe = new System.Windows.Forms.TextBox();
            this.txt_TenXe = new System.Windows.Forms.TextBox();
            this.txt_GiaXe = new System.Windows.Forms.TextBox();
            this.cb_HangXe = new System.Windows.Forms.ComboBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_TenAnhXe = new System.Windows.Forms.TextBox();
            this.btn_Dem = new System.Windows.Forms.Button();
            this.txt_Dem = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_LoadLai = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin motor tại showroom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên xe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sản xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên hãng xe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giá xe";
            // 
            // txt_MaXe
            // 
            this.txt_MaXe.Location = new System.Drawing.Point(167, 80);
            this.txt_MaXe.Name = "txt_MaXe";
            this.txt_MaXe.Size = new System.Drawing.Size(158, 22);
            this.txt_MaXe.TabIndex = 6;
            // 
            // txt_TenXe
            // 
            this.txt_TenXe.Location = new System.Drawing.Point(167, 131);
            this.txt_TenXe.Name = "txt_TenXe";
            this.txt_TenXe.Size = new System.Drawing.Size(158, 22);
            this.txt_TenXe.TabIndex = 7;
            // 
            // txt_GiaXe
            // 
            this.txt_GiaXe.Location = new System.Drawing.Point(167, 239);
            this.txt_GiaXe.Name = "txt_GiaXe";
            this.txt_GiaXe.Size = new System.Drawing.Size(158, 22);
            this.txt_GiaXe.TabIndex = 10;
            // 
            // cb_HangXe
            // 
            this.cb_HangXe.FormattingEnabled = true;
            this.cb_HangXe.Location = new System.Drawing.Point(525, 80);
            this.cb_HangXe.Name = "cb_HangXe";
            this.cb_HangXe.Size = new System.Drawing.Size(158, 24);
            this.cb_HangXe.TabIndex = 11;
            this.cb_HangXe.SelectedIndexChanged += new System.EventHandler(this.cb_HangXe_SelectedIndexChanged);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(841, 80);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(158, 22);
            this.txt_TimKiem.TabIndex = 12;
            this.txt_TimKiem.Text = "Tìm theo mã hoặc tên xe";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(751, 79);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(84, 24);
            this.btn_TimKiem.TabIndex = 13;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(933, 258);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(751, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_TenAnhXe
            // 
            this.txt_TenAnhXe.Location = new System.Drawing.Point(751, 305);
            this.txt_TenAnhXe.Name = "txt_TenAnhXe";
            this.txt_TenAnhXe.Size = new System.Drawing.Size(248, 22);
            this.txt_TenAnhXe.TabIndex = 16;
            this.txt_TenAnhXe.Text = "tenXe.jpg";
            // 
            // btn_Dem
            // 
            this.btn_Dem.Location = new System.Drawing.Point(435, 130);
            this.btn_Dem.Name = "btn_Dem";
            this.btn_Dem.Size = new System.Drawing.Size(84, 24);
            this.btn_Dem.TabIndex = 17;
            this.btn_Dem.Text = "Đếm";
            this.btn_Dem.UseVisualStyleBackColor = true;
            this.btn_Dem.Click += new System.EventHandler(this.btn_Dem_Click);
            // 
            // txt_Dem
            // 
            this.txt_Dem.Location = new System.Drawing.Point(525, 131);
            this.txt_Dem.Name = "txt_Dem";
            this.txt_Dem.Size = new System.Drawing.Size(158, 22);
            this.txt_Dem.TabIndex = 18;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(66, 290);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(84, 24);
            this.btn_Them.TabIndex = 19;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(345, 290);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(84, 24);
            this.btn_Xoa.TabIndex = 20;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(615, 290);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(84, 24);
            this.btn_Sua.TabIndex = 21;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_LoadLai
            // 
            this.btn_LoadLai.Location = new System.Drawing.Point(435, 185);
            this.btn_LoadLai.Name = "btn_LoadLai";
            this.btn_LoadLai.Size = new System.Drawing.Size(84, 24);
            this.btn_LoadLai.TabIndex = 22;
            this.btn_LoadLai.Text = "Load Lại";
            this.btn_LoadLai.UseVisualStyleBackColor = true;
            this.btn_LoadLai.Click += new System.EventHandler(this.btn_LoadLai_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 22);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // frm_Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 648);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_LoadLai);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_Dem);
            this.Controls.Add(this.btn_Dem);
            this.Controls.Add(this.txt_TenAnhXe);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.cb_HangXe);
            this.Controls.Add(this.txt_GiaXe);
            this.Controls.Add(this.txt_TenXe);
            this.Controls.Add(this.txt_MaXe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Xe";
            this.Text = "Frm_Xe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Xe_FormClosing);
            this.Load += new System.EventHandler(this.frm_Xe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_MaXe;
        public System.Windows.Forms.TextBox txt_TenXe;
        public System.Windows.Forms.TextBox txt_GiaXe;
        public System.Windows.Forms.ComboBox cb_HangXe;
        public System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txt_TenAnhXe;
        private System.Windows.Forms.Button btn_Dem;
        public System.Windows.Forms.TextBox txt_Dem;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_LoadLai;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}