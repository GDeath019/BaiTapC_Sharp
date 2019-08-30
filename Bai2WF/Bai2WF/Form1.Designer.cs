namespace Bai2WF
{
    partial class frm_Main
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
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_ThemMoi = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.Tb_HoTen = new System.Windows.Forms.TextBox();
            this.Tb_DiaChi = new System.Windows.Forms.TextBox();
            this.TB_MaKH = new System.Windows.Forms.TextBox();
            this.listB_View = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_MaKH = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdb_PhatLoc = new System.Windows.Forms.RadioButton();
            this.radio_Thuong = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_timeGui = new System.Windows.Forms.ComboBox();
            this.Dt_NgayGui = new System.Windows.Forms.DateTimePicker();
            this.Tb_SoTienGui = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(534, 421);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(111, 34);
            this.btn_TimKiem.TabIndex = 5;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.Location = new System.Drawing.Point(174, 270);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(111, 34);
            this.btn_ThemMoi.TabIndex = 8;
            this.btn_ThemMoi.Text = "Thêm Mới";
            this.btn_ThemMoi.UseVisualStyleBackColor = true;
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(34, 270);
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
            // listB_View
            // 
            this.listB_View.FormattingEnabled = true;
            this.listB_View.Location = new System.Drawing.Point(32, 44);
            this.listB_View.Name = "listB_View";
            this.listB_View.Size = new System.Drawing.Size(495, 238);
            this.listB_View.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listB_View);
            this.groupBox2.Location = new System.Drawing.Point(365, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 334);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Khách Hàng";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thời Gian Gửi";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(17, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Gửi";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(674, 421);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(111, 34);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số Tiền Gửi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_timeGui);
            this.groupBox1.Controls.Add(this.Dt_NgayGui);
            this.groupBox1.Controls.Add(this.Tb_SoTienGui);
            this.groupBox1.Controls.Add(this.btn_ThemMoi);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.Tb_HoTen);
            this.groupBox1.Controls.Add(this.Tb_DiaChi);
            this.groupBox1.Controls.Add(this.TB_MaKH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lb_MaKH);
            this.groupBox1.Location = new System.Drawing.Point(27, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 325);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng gửi tiết kiệm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdb_PhatLoc);
            this.groupBox3.Controls.Add(this.radio_Thuong);
            this.groupBox3.Location = new System.Drawing.Point(42, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 43);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại Tiết Kiệm";
            // 
            // rdb_PhatLoc
            // 
            this.rdb_PhatLoc.AutoSize = true;
            this.rdb_PhatLoc.Location = new System.Drawing.Point(136, 20);
            this.rdb_PhatLoc.Name = "rdb_PhatLoc";
            this.rdb_PhatLoc.Size = new System.Drawing.Size(66, 17);
            this.rdb_PhatLoc.TabIndex = 1;
            this.rdb_PhatLoc.TabStop = true;
            this.rdb_PhatLoc.Text = "Phát Lộc";
            this.rdb_PhatLoc.UseVisualStyleBackColor = true;
            // 
            // radio_Thuong
            // 
            this.radio_Thuong.AutoSize = true;
            this.radio_Thuong.Location = new System.Drawing.Point(16, 20);
            this.radio_Thuong.Name = "radio_Thuong";
            this.radio_Thuong.Size = new System.Drawing.Size(62, 17);
            this.radio_Thuong.TabIndex = 0;
            this.radio_Thuong.TabStop = true;
            this.radio_Thuong.Text = "Thường";
            this.radio_Thuong.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(175, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "(tháng)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(252, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "(VNĐ)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_timeGui
            // 
            this.cb_timeGui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_timeGui.FormattingEnabled = true;
            this.cb_timeGui.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "12"});
            this.cb_timeGui.Location = new System.Drawing.Point(104, 167);
            this.cb_timeGui.Name = "cb_timeGui";
            this.cb_timeGui.Size = new System.Drawing.Size(65, 21);
            this.cb_timeGui.TabIndex = 11;
            // 
            // Dt_NgayGui
            // 
            this.Dt_NgayGui.CustomFormat = "dd/MM/yyyy";
            this.Dt_NgayGui.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dt_NgayGui.Location = new System.Drawing.Point(104, 139);
            this.Dt_NgayGui.Name = "Dt_NgayGui";
            this.Dt_NgayGui.Size = new System.Drawing.Size(142, 21);
            this.Dt_NgayGui.TabIndex = 10;
            // 
            // Tb_SoTienGui
            // 
            this.Tb_SoTienGui.Location = new System.Drawing.Point(104, 109);
            this.Tb_SoTienGui.Name = "Tb_SoTienGui";
            this.Tb_SoTienGui.Size = new System.Drawing.Size(142, 21);
            this.Tb_SoTienGui.TabIndex = 9;
            this.Tb_SoTienGui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_SoTienGui_KeyPress);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 540);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Main";
            this.Text = "Tính lãi suất tiền gửi tiết kiệm";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_Main_KeyUp);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Button btn_ThemMoi;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox Tb_HoTen;
        private System.Windows.Forms.TextBox Tb_DiaChi;
        private System.Windows.Forms.TextBox TB_MaKH;
        private System.Windows.Forms.ListBox listB_View;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_MaKH;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdb_PhatLoc;
        private System.Windows.Forms.RadioButton radio_Thuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_timeGui;
        private System.Windows.Forms.DateTimePicker Dt_NgayGui;
        private System.Windows.Forms.TextBox Tb_SoTienGui;
    }
}

