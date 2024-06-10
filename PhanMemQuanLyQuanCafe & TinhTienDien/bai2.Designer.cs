namespace kiemtra
{
    partial class bai2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvbanggia = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.lvdanhsach = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtsokw = new System.Windows.Forms.TextBox();
            this.datethang = new System.Windows.Forms.DateTimePicker();
            this.txttongthanhtien = new System.Windows.Forms.TextBox();
            this.txtthue = new System.Windows.Forms.TextBox();
            this.txttongtienthanhtoan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(145, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU TÍNH TIỀN ĐIỆN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bảng đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bảng kê chi tiết";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(603, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thông tin khách hàng";
            // 
            // lvbanggia
            // 
            this.lvbanggia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvbanggia.FullRowSelect = true;
            this.lvbanggia.GridLines = true;
            this.lvbanggia.Location = new System.Drawing.Point(12, 106);
            this.lvbanggia.Name = "lvbanggia";
            this.lvbanggia.Size = new System.Drawing.Size(564, 242);
            this.lvbanggia.TabIndex = 5;
            this.lvbanggia.UseCompatibleStateImageBehavior = false;
            this.lvbanggia.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mức";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Khoảng";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 150;
            // 
            // lvdanhsach
            // 
            this.lvdanhsach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvdanhsach.FullRowSelect = true;
            this.lvdanhsach.GridLines = true;
            this.lvdanhsach.Location = new System.Drawing.Point(12, 406);
            this.lvdanhsach.Name = "lvdanhsach";
            this.lvdanhsach.Size = new System.Drawing.Size(564, 252);
            this.lvdanhsach.TabIndex = 6;
            this.lvdanhsach.UseCompatibleStateImageBehavior = false;
            this.lvdanhsach.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bậc thang";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Đơn giá";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Sản lượng";
            this.columnHeader6.Width = 130;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Thành tiền";
            this.columnHeader7.Width = 130;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(603, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Họ tên khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(603, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã KH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(603, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(603, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 28);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tháng";
            // 
            // btnghi
            // 
            this.btnghi.Location = new System.Drawing.Point(672, 363);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(132, 60);
            this.btnghi.TabIndex = 11;
            this.btnghi.Text = "Ghi DL";
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(861, 363);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(132, 60);
            this.btnthem.TabIndex = 12;
            this.btnthem.Text = "Thêm mới";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(603, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 28);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tổng thành tiền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(603, 524);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 28);
            this.label10.TabIndex = 14;
            this.label10.Text = "Thuế GTGT(8%)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(603, 588);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(244, 28);
            this.label11.TabIndex = 15;
            this.label11.Text = "Tổng cộng tiền thanh toán";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(861, 320);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 28);
            this.label12.TabIndex = 16;
            this.label12.Text = "Số kw";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(800, 124);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(288, 34);
            this.txthoten.TabIndex = 17;
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(680, 187);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(408, 34);
            this.txtmakh.TabIndex = 18;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(680, 254);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(408, 34);
            this.txtdiachi.TabIndex = 19;
            // 
            // txtsokw
            // 
            this.txtsokw.Location = new System.Drawing.Point(931, 314);
            this.txtsokw.Name = "txtsokw";
            this.txtsokw.Size = new System.Drawing.Size(146, 34);
            this.txtsokw.TabIndex = 20;
            // 
            // datethang
            // 
            this.datethang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datethang.Location = new System.Drawing.Point(675, 314);
            this.datethang.Name = "datethang";
            this.datethang.Size = new System.Drawing.Size(172, 34);
            this.datethang.TabIndex = 21;
            // 
            // txttongthanhtien
            // 
            this.txttongthanhtien.Location = new System.Drawing.Point(759, 446);
            this.txttongthanhtien.Name = "txttongthanhtien";
            this.txttongthanhtien.Size = new System.Drawing.Size(329, 34);
            this.txttongthanhtien.TabIndex = 22;
            // 
            // txtthue
            // 
            this.txtthue.Location = new System.Drawing.Point(759, 518);
            this.txtthue.Name = "txtthue";
            this.txtthue.Size = new System.Drawing.Size(329, 34);
            this.txtthue.TabIndex = 23;
            // 
            // txttongtienthanhtoan
            // 
            this.txttongtienthanhtoan.Location = new System.Drawing.Point(844, 582);
            this.txttongtienthanhtoan.Name = "txttongtienthanhtoan";
            this.txttongtienthanhtoan.Size = new System.Drawing.Size(244, 34);
            this.txttongtienthanhtoan.TabIndex = 24;
            // 
            // bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 627);
            this.Controls.Add(this.txttongtienthanhtoan);
            this.Controls.Add(this.txtthue);
            this.Controls.Add(this.txttongthanhtien);
            this.Controls.Add(this.datethang);
            this.Controls.Add(this.txtsokw);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtmakh);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnghi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvdanhsach);
            this.Controls.Add(this.lvbanggia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "bai2";
            this.Text = "bai2cs";
            this.Load += new System.EventHandler(this.bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListView lvbanggia;
        private ListView lvdanhsach;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnghi;
        private Button btnthem;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txthoten;
        private TextBox txtmakh;
        private TextBox txtdiachi;
        private TextBox txtsokw;
        private DateTimePicker datethang;
        private TextBox txttongthanhtien;
        private TextBox txtthue;
        private TextBox txttongtienthanhtoan;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}