namespace BaiTap1WF
{
    partial class frm_TienDien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dt_NgayChotSo = new System.Windows.Forms.DateTimePicker();
            this.tb_SoThangNay = new System.Windows.Forms.TextBox();
            this.btn_ThemMoi = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.Tb_HoTen = new System.Windows.Forms.TextBox();
            this.tb_SoThangTruoc = new System.Windows.Forms.TextBox();
            this.Tb_DiaChi = new System.Windows.Forms.TextBox();
            this.TB_MaKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_MaKH = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listB_View = new System.Windows.Forms.ListBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dt_NgayChotSo);
            this.groupBox1.Controls.Add(this.tb_SoThangNay);
            this.groupBox1.Controls.Add(this.btn_ThemMoi);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.Tb_HoTen);
            this.groupBox1.Controls.Add(this.tb_SoThangTruoc);
            this.groupBox1.Controls.Add(this.Tb_DiaChi);
            this.groupBox1.Controls.Add(this.TB_MaKH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lb_MaKH);
            this.groupBox1.Location = new System.Drawing.Point(41, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin Khách Hàng  Sử Dụng Điện";
            // 
            // Dt_NgayChotSo
            // 
            this.Dt_NgayChotSo.CustomFormat = "dd/MM/yyyy";
            this.Dt_NgayChotSo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dt_NgayChotSo.Location = new System.Drawing.Point(104, 110);
            this.Dt_NgayChotSo.Name = "Dt_NgayChotSo";
            this.Dt_NgayChotSo.Size = new System.Drawing.Size(142, 21);
            this.Dt_NgayChotSo.TabIndex = 9;
            // 
            // tb_SoThangNay
            // 
            this.tb_SoThangNay.Location = new System.Drawing.Point(104, 167);
            this.tb_SoThangNay.Name = "tb_SoThangNay";
            this.tb_SoThangNay.Size = new System.Drawing.Size(81, 21);
            this.tb_SoThangNay.TabIndex = 6;
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.Location = new System.Drawing.Point(170, 238);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(111, 34);
            this.btn_ThemMoi.TabIndex = 8;
            this.btn_ThemMoi.Text = "Thêm Mới";
            this.btn_ThemMoi.UseVisualStyleBackColor = true;
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(30, 238);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(111, 34);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Thêm Vào DS";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Tb_HoTen
            // 
            this.Tb_HoTen.Location = new System.Drawing.Point(104, 54);
            this.Tb_HoTen.Name = "Tb_HoTen";
            this.Tb_HoTen.Size = new System.Drawing.Size(142, 21);
            this.Tb_HoTen.TabIndex = 2;
            // 
            // tb_SoThangTruoc
            // 
            this.tb_SoThangTruoc.Location = new System.Drawing.Point(104, 140);
            this.tb_SoThangTruoc.Name = "tb_SoThangTruoc";
            this.tb_SoThangTruoc.Size = new System.Drawing.Size(81, 21);
            this.tb_SoThangTruoc.TabIndex = 5;
            this.tb_SoThangTruoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_SoThangTruoc_KeyPress);
            // 
            // Tb_DiaChi
            // 
            this.Tb_DiaChi.Location = new System.Drawing.Point(104, 82);
            this.Tb_DiaChi.Name = "Tb_DiaChi";
            this.Tb_DiaChi.Size = new System.Drawing.Size(142, 21);
            this.Tb_DiaChi.TabIndex = 3;
            // 
            // TB_MaKH
            // 
            this.TB_MaKH.Location = new System.Drawing.Point(104, 28);
            this.TB_MaKH.Name = "TB_MaKH";
            this.TB_MaKH.Size = new System.Drawing.Size(142, 21);
            this.TB_MaKH.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số Tháng Này";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(17, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số Tháng Trước";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Chốt Số";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa Chỉ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_MaKH
            // 
            this.lb_MaKH.Location = new System.Drawing.Point(17, 29);
            this.lb_MaKH.Name = "lb_MaKH";
            this.lb_MaKH.Size = new System.Drawing.Size(95, 20);
            this.lb_MaKH.TabIndex = 0;
            this.lb_MaKH.Text = "Mã Khách Hàng";
            this.lb_MaKH.Click += new System.EventHandler(this.lb_MaKH_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listB_View);
            this.groupBox2.Location = new System.Drawing.Point(379, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 334);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Khách Hàng";
            // 
            // listB_View
            // 
            this.listB_View.FormattingEnabled = true;
            this.listB_View.Location = new System.Drawing.Point(31, 47);
            this.listB_View.Name = "listB_View";
            this.listB_View.Size = new System.Drawing.Size(495, 238);
            this.listB_View.TabIndex = 0;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(688, 397);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(111, 34);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(548, 397);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(111, 34);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // frm_TienDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 493);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_TienDien";
            this.Text = "Tính Tiền Điện";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_MaKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_MaKH;
        private System.Windows.Forms.TextBox Tb_HoTen;
        private System.Windows.Forms.TextBox tb_SoThangTruoc;
        private System.Windows.Forms.TextBox Tb_DiaChi;
        private System.Windows.Forms.ListBox listB_View;
        private System.Windows.Forms.TextBox tb_SoThangNay;
        private System.Windows.Forms.Button btn_ThemMoi;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DateTimePicker Dt_NgayChotSo;
    }
}

