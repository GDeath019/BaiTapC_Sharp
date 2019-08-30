namespace Bai9WF
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ADD = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.tb_TongTien = new System.Windows.Forms.TextBox();
            this.tb_gia = new System.Windows.Forms.TextBox();
            this.tb_SoLunog = new System.Windows.Forms.TextBox();
            this.tb_GiamGia = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rdo_TienMat = new System.Windows.Forms.RadioButton();
            this.rdo_ATM = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.DtG_View = new System.Windows.Forms.DataGridView();
            this.cl_TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtG_View)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.tb_SoLunog);
            this.groupBox1.Controls.Add(this.tb_gia);
            this.groupBox1.Location = new System.Drawing.Point(33, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rdo_ATM);
            this.groupBox2.Controls.Add(this.rdo_TienMat);
            this.groupBox2.Controls.Add(this.tb_GiamGia);
            this.groupBox2.Location = new System.Drawing.Point(348, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phương thức thanh toán";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DtG_View);
            this.groupBox3.Controls.Add(this.tb_TongTien);
            this.groupBox3.Controls.Add(this.btn_Delete);
            this.groupBox3.Controls.Add(this.btn_sum);
            this.groupBox3.Location = new System.Drawing.Point(90, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 179);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sách đã mua";
            // 
            // btn_ADD
            // 
            this.btn_ADD.Location = new System.Drawing.Point(261, 244);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(100, 34);
            this.btn_ADD.TabIndex = 3;
            this.btn_ADD.Text = "Thêm";
            this.btn_ADD.UseVisualStyleBackColor = true;
            this.btn_ADD.Click += new System.EventHandler(this.btn_ADD_Click);
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(65, 139);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(126, 34);
            this.btn_sum.TabIndex = 4;
            this.btn_sum.Text = "Tính Tổng Tiền";
            this.btn_sum.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(6, 139);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(53, 34);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // tb_TongTien
            // 
            this.tb_TongTien.Enabled = false;
            this.tb_TongTien.Location = new System.Drawing.Point(218, 147);
            this.tb_TongTien.Name = "tb_TongTien";
            this.tb_TongTien.Size = new System.Drawing.Size(158, 20);
            this.tb_TongTien.TabIndex = 6;
            // 
            // tb_gia
            // 
            this.tb_gia.Enabled = false;
            this.tb_gia.Location = new System.Drawing.Point(74, 72);
            this.tb_gia.Name = "tb_gia";
            this.tb_gia.Size = new System.Drawing.Size(120, 20);
            this.tb_gia.TabIndex = 0;
            // 
            // tb_SoLunog
            // 
            this.tb_SoLunog.Location = new System.Drawing.Point(74, 112);
            this.tb_SoLunog.Name = "tb_SoLunog";
            this.tb_SoLunog.Size = new System.Drawing.Size(120, 20);
            this.tb_SoLunog.TabIndex = 1;
            // 
            // tb_GiamGia
            // 
            this.tb_GiamGia.Enabled = false;
            this.tb_GiamGia.Location = new System.Drawing.Point(80, 112);
            this.tb_GiamGia.Name = "tb_GiamGia";
            this.tb_GiamGia.Size = new System.Drawing.Size(114, 20);
            this.tb_GiamGia.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tin Đại Cương",
            "Tiếng Anh F2",
            "Giải Tích F1",
            "Đại Số Tuyến Tính"});
            this.comboBox1.Location = new System.Drawing.Point(74, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rdo_TienMat
            // 
            this.rdo_TienMat.AutoSize = true;
            this.rdo_TienMat.Location = new System.Drawing.Point(22, 34);
            this.rdo_TienMat.Name = "rdo_TienMat";
            this.rdo_TienMat.Size = new System.Drawing.Size(66, 17);
            this.rdo_TienMat.TabIndex = 1;
            this.rdo_TienMat.TabStop = true;
            this.rdo_TienMat.Text = "Tiền mặt";
            this.rdo_TienMat.UseVisualStyleBackColor = true;
            this.rdo_TienMat.CheckedChanged += new System.EventHandler(this.rdo_TienMat_CheckedChanged);
            // 
            // rdo_ATM
            // 
            this.rdo_ATM.AutoSize = true;
            this.rdo_ATM.Location = new System.Drawing.Point(139, 34);
            this.rdo_ATM.Name = "rdo_ATM";
            this.rdo_ATM.Size = new System.Drawing.Size(48, 17);
            this.rdo_ATM.TabIndex = 2;
            this.rdo_ATM.TabStop = true;
            this.rdo_ATM.Text = "ATM";
            this.rdo_ATM.UseVisualStyleBackColor = true;
            this.rdo_ATM.CheckedChanged += new System.EventHandler(this.rdo_ATM_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giảm Giá";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(530, 497);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "T&hoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DtG_View
            // 
            this.DtG_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtG_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_TenSach,
            this.cl_Gia,
            this.cl_SoLuong,
            this.thanhtien});
            this.DtG_View.Location = new System.Drawing.Point(32, 41);
            this.DtG_View.Name = "DtG_View";
            this.DtG_View.Size = new System.Drawing.Size(344, 58);
            this.DtG_View.TabIndex = 7;
            // 
            // cl_TenSach
            // 
            this.cl_TenSach.HeaderText = "Tên Sách";
            this.cl_TenSach.Name = "cl_TenSach";
            // 
            // cl_Gia
            // 
            this.cl_Gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cl_Gia.FillWeight = 50F;
            this.cl_Gia.HeaderText = "Giá";
            this.cl_Gia.Name = "cl_Gia";
            this.cl_Gia.Width = 50;
            // 
            // cl_SoLuong
            // 
            this.cl_SoLuong.HeaderText = "Số Lượng";
            this.cl_SoLuong.Name = "cl_SoLuong";
            this.cl_SoLuong.Width = 50;
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Thành Tiền";
            this.thanhtien.Name = "thanhtien";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 543);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_ADD);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtG_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tb_SoLunog;
        private System.Windows.Forms.TextBox tb_gia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdo_ATM;
        private System.Windows.Forms.RadioButton rdo_TienMat;
        private System.Windows.Forms.TextBox tb_GiamGia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_TongTien;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_ADD;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView DtG_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
    }
}

