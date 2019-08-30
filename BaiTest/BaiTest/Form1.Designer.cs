namespace BaiTest
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoDem = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnHoDem = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHovaTen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblHoTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHoTen.Location = new System.Drawing.Point(0, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(636, 68);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHoTen.DoubleClick += new System.EventHandler(this.lblHoTen_DoubleClick);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(82, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Đệm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(82, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHoDem
            // 
            this.txtHoDem.Location = new System.Drawing.Point(212, 101);
            this.txtHoDem.Multiline = true;
            this.txtHoDem.Name = "txtHoDem";
            this.txtHoDem.Size = new System.Drawing.Size(244, 38);
            this.txtHoDem.TabIndex = 1;
            this.txtHoDem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(212, 170);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(244, 38);
            this.txtTen.TabIndex = 2;
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnHoDem
            // 
            this.btnHoDem.Location = new System.Drawing.Point(150, 255);
            this.btnHoDem.Name = "btnHoDem";
            this.btnHoDem.Size = new System.Drawing.Size(90, 44);
            this.btnHoDem.TabIndex = 3;
            this.btnHoDem.Text = "&Họ Đệm";
            this.btnHoDem.UseVisualStyleBackColor = true;
            this.btnHoDem.Click += new System.EventHandler(this.btnHoDem_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(286, 255);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(90, 44);
            this.btnTen.TabIndex = 4;
            this.btnTen.Text = "Tên";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHovaTen
            // 
            this.btnHovaTen.Location = new System.Drawing.Point(420, 255);
            this.btnHovaTen.Name = "btnHovaTen";
            this.btnHovaTen.Size = new System.Drawing.Size(90, 44);
            this.btnHovaTen.TabIndex = 5;
            this.btnHovaTen.Text = "Họ và Tên";
            this.btnHovaTen.UseVisualStyleBackColor = true;
            this.btnHovaTen.Click += new System.EventHandler(this.btnHovaTen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(257, 333);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 44);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Thoát Chương Trình";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 406);
            this.Controls.Add(this.btnHovaTen);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHoDem);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtHoDem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHoTen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoDem;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnHoDem;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHovaTen;
        private System.Windows.Forms.Button btnClose;
    }
}

