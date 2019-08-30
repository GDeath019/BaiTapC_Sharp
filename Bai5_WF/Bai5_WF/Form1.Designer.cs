namespace Bai5_WF
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_max = new System.Windows.Forms.Button();
            this.btn_refersh = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lb_sum = new System.Windows.Forms.Label();
            this.lb_max = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(96, 144);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(128, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Thêm vào danh sách";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(589, 202);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Thoát";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(96, 173);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(128, 23);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Xóa khỏi danh sách";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(589, 144);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(75, 23);
            this.btn_sum.TabIndex = 1;
            this.btn_sum.Text = "Tính tổng";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_max
            // 
            this.btn_max.Location = new System.Drawing.Point(589, 173);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(75, 23);
            this.btn_max.TabIndex = 1;
            this.btn_max.Text = "Tính Max";
            this.btn_max.UseVisualStyleBackColor = true;
            this.btn_max.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_refersh
            // 
            this.btn_refersh.Location = new System.Drawing.Point(96, 202);
            this.btn_refersh.Name = "btn_refersh";
            this.btn_refersh.Size = new System.Drawing.Size(128, 23);
            this.btn_refersh.TabIndex = 1;
            this.btn_refersh.Text = "Làm mới";
            this.btn_refersh.UseVisualStyleBackColor = true;
            this.btn_refersh.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(299, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 233);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dãy số";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 173);
            this.listBox1.TabIndex = 0;
            // 
            // lb_sum
            // 
            this.lb_sum.AutoSize = true;
            this.lb_sum.ForeColor = System.Drawing.Color.Red;
            this.lb_sum.Location = new System.Drawing.Point(678, 149);
            this.lb_sum.Name = "lb_sum";
            this.lb_sum.Size = new System.Drawing.Size(46, 13);
            this.lb_sum.TabIndex = 5;
            this.lb_sum.Text = "Tổng là:";
            this.lb_sum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_max
            // 
            this.lb_max.AutoSize = true;
            this.lb_max.ForeColor = System.Drawing.Color.Red;
            this.lb_max.Location = new System.Drawing.Point(678, 178);
            this.lb_max.Name = "lb_max";
            this.lb_max.Size = new System.Drawing.Size(41, 13);
            this.lb_max.TabIndex = 5;
            this.lb_max.Text = "Max là:";
            this.lb_max.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_max);
            this.Controls.Add(this.lb_sum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_refersh);
            this.Controls.Add(this.btn_max);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_max;
        private System.Windows.Forms.Button btn_refersh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lb_sum;
        private System.Windows.Forms.Label lb_max;
    }
}

