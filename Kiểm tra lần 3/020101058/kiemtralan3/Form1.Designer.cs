namespace kiemtralan3
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
            this.label2 = new System.Windows.Forms.Label();
            this.ckldanhsach = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtnxb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbnxb = new System.Windows.Forms.ComboBox();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.radngaymuon = new System.Windows.Forms.RadioButton();
            this.radchuatra = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txttongsolanmuon = new System.Windows.Forms.TextBox();
            this.lvchitiet = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btncapnhat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CHO MƯỢN SÁCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Các sách trong thư viện";
            // 
            // ckldanhsach
            // 
            this.ckldanhsach.FormattingEnabled = true;
            this.ckldanhsach.Location = new System.Drawing.Point(25, 124);
            this.ckldanhsach.Name = "ckldanhsach";
            this.ckldanhsach.Size = new System.Drawing.Size(171, 279);
            this.ckldanhsach.TabIndex = 2;
            this.ckldanhsach.SelectedIndexChanged += new System.EventHandler(this.ckldanhsach_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnghi);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.txtnxb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbnxb);
            this.groupBox1.Controls.Add(this.txttensach);
            this.groupBox1.Controls.Add(this.txtmasach);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(216, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 300);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong tin sách";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(310, 234);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(101, 37);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnghi
            // 
            this.btnghi.Location = new System.Drawing.Point(170, 234);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(101, 37);
            this.btnghi.TabIndex = 9;
            this.btnghi.Text = "Ghi";
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(37, 234);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(101, 37);
            this.btnthem.TabIndex = 8;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtnxb
            // 
            this.txtnxb.Location = new System.Drawing.Point(350, 43);
            this.txtnxb.Name = "txtnxb";
            this.txtnxb.Size = new System.Drawing.Size(100, 30);
            this.txtnxb.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Năm xuất bản";
            // 
            // cbnxb
            // 
            this.cbnxb.FormattingEnabled = true;
            this.cbnxb.Location = new System.Drawing.Point(131, 174);
            this.cbnxb.Name = "cbnxb";
            this.cbnxb.Size = new System.Drawing.Size(213, 33);
            this.cbnxb.TabIndex = 5;
            // 
            // txttensach
            // 
            this.txttensach.Location = new System.Drawing.Point(131, 115);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(213, 30);
            this.txttensach.TabIndex = 4;
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(131, 43);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(100, 30);
            this.txtmasach.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhà xuất bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(674, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sắp xếp";
            // 
            // radngaymuon
            // 
            this.radngaymuon.AutoSize = true;
            this.radngaymuon.Location = new System.Drawing.Point(678, 138);
            this.radngaymuon.Name = "radngaymuon";
            this.radngaymuon.Size = new System.Drawing.Size(133, 29);
            this.radngaymuon.TabIndex = 9;
            this.radngaymuon.TabStop = true;
            this.radngaymuon.Text = "Ngày mượn";
            this.radngaymuon.UseVisualStyleBackColor = true;
            this.radngaymuon.CheckedChanged += new System.EventHandler(this.radngaymuon_CheckedChanged);
            this.radngaymuon.Click += new System.EventHandler(this.radngaymuon_Click);
            // 
            // radchuatra
            // 
            this.radchuatra.AutoSize = true;
            this.radchuatra.Location = new System.Drawing.Point(678, 184);
            this.radchuatra.Name = "radchuatra";
            this.radchuatra.Size = new System.Drawing.Size(108, 29);
            this.radchuatra.TabIndex = 10;
            this.radchuatra.TabStop = true;
            this.radchuatra.Text = "Chưa trả";
            this.radchuatra.UseVisualStyleBackColor = true;
            this.radchuatra.CheckedChanged += new System.EventHandler(this.radchuatra_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Chi tiết các lần mượn sách";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tổng số lần mượn";
            // 
            // txttongsolanmuon
            // 
            this.txttongsolanmuon.Location = new System.Drawing.Point(502, 436);
            this.txttongsolanmuon.Name = "txttongsolanmuon";
            this.txttongsolanmuon.Size = new System.Drawing.Size(100, 30);
            this.txttongsolanmuon.TabIndex = 11;
            // 
            // lvchitiet
            // 
            this.lvchitiet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvchitiet.FullRowSelect = true;
            this.lvchitiet.GridLines = true;
            this.lvchitiet.Location = new System.Drawing.Point(25, 487);
            this.lvchitiet.Name = "lvchitiet";
            this.lvchitiet.Size = new System.Drawing.Size(771, 228);
            this.lvchitiet.TabIndex = 13;
            this.lvchitiet.UseCompatibleStateImageBehavior = false;
            this.lvchitiet.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ tên";
            this.columnHeader1.Width = 187;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày mượn";
            this.columnHeader2.Width = 162;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày trả";
            this.columnHeader3.Width = 238;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thủ thư";
            this.columnHeader4.Width = 341;
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(685, 358);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(101, 37);
            this.btncapnhat.TabIndex = 11;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 727);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.lvchitiet);
            this.Controls.Add(this.txttongsolanmuon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radchuatra);
            this.Controls.Add(this.radngaymuon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ckldanhsach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox ckldanhsach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtnxb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbnxb;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radngaymuon;
        private System.Windows.Forms.RadioButton radchuatra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttongsolanmuon;
        private System.Windows.Forms.ListView lvchitiet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btncapnhat;
    }
}

