namespace kiemtralan4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntaomoi = new System.Windows.Forms.Button();
            this.btntinhtien = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.datengaydat = new System.Windows.Forms.DateTimePicker();
            this.numsl = new System.Windows.Forms.NumericUpDown();
            this.txtnguoidat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pichinh = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lvdanhsach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.txtgiamgia = new System.Windows.Forms.TextBox();
            this.txttienphaitra = new System.Windows.Forms.TextBox();
            this.ckldanhmuc = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ CHO THUÊ ĐỒ DÙNG YOGA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh mục sản phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntaomoi);
            this.groupBox1.Controls.Add(this.btntinhtien);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.datengaydat);
            this.groupBox1.Controls.Add(this.numsl);
            this.groupBox1.Controls.Add(this.txtnguoidat);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pichinh);
            this.groupBox1.Location = new System.Drawing.Point(284, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 304);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đặt hàng";
            // 
            // btntaomoi
            // 
            this.btntaomoi.Location = new System.Drawing.Point(268, 244);
            this.btntaomoi.Name = "btntaomoi";
            this.btntaomoi.Size = new System.Drawing.Size(92, 45);
            this.btntaomoi.TabIndex = 16;
            this.btntaomoi.Text = "Tạo mới";
            this.btntaomoi.UseVisualStyleBackColor = true;
            this.btntaomoi.Click += new System.EventHandler(this.btntaomoi_Click);
            // 
            // btntinhtien
            // 
            this.btntinhtien.Location = new System.Drawing.Point(268, 155);
            this.btntinhtien.Name = "btntinhtien";
            this.btntinhtien.Size = new System.Drawing.Size(92, 45);
            this.btntinhtien.TabIndex = 15;
            this.btntinhtien.Text = "Tính tiền";
            this.btntinhtien.UseVisualStyleBackColor = true;
            this.btntinhtien.Click += new System.EventHandler(this.btntinhtien_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(268, 69);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(92, 45);
            this.btnthem.TabIndex = 14;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // datengaydat
            // 
            this.datengaydat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaydat.Location = new System.Drawing.Point(125, 117);
            this.datengaydat.Name = "datengaydat";
            this.datengaydat.Size = new System.Drawing.Size(130, 30);
            this.datengaydat.TabIndex = 13;
            this.datengaydat.ValueChanged += new System.EventHandler(this.datengaydat_ValueChanged);
            // 
            // numsl
            // 
            this.numsl.Location = new System.Drawing.Point(125, 206);
            this.numsl.Name = "numsl";
            this.numsl.Size = new System.Drawing.Size(130, 30);
            this.numsl.TabIndex = 12;
            this.numsl.ValueChanged += new System.EventHandler(this.numsl_ValueChanged);
            // 
            // txtnguoidat
            // 
            this.txtnguoidat.Location = new System.Drawing.Point(125, 36);
            this.txtnguoidat.Name = "txtnguoidat";
            this.txtnguoidat.Size = new System.Drawing.Size(130, 30);
            this.txtnguoidat.TabIndex = 11;
            this.txtnguoidat.TextChanged += new System.EventHandler(this.txtnguoidat_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Số lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ngày đặt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Người đặt";
            // 
            // pichinh
            // 
            this.pichinh.Location = new System.Drawing.Point(381, 69);
            this.pichinh.Name = "pichinh";
            this.pichinh.Size = new System.Drawing.Size(143, 207);
            this.pichinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pichinh.TabIndex = 0;
            this.pichinh.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh mục sản phẩm";
            // 
            // lvdanhsach
            // 
            this.lvdanhsach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvdanhsach.FullRowSelect = true;
            this.lvdanhsach.GridLines = true;
            this.lvdanhsach.Location = new System.Drawing.Point(16, 446);
            this.lvdanhsach.Name = "lvdanhsach";
            this.lvdanhsach.Size = new System.Drawing.Size(559, 285);
            this.lvdanhsach.TabIndex = 5;
            this.lvdanhsach.UseCompatibleStateImageBehavior = false;
            this.lvdanhsach.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ Tên";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày đặt";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượng";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Đơn giá";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thành tiền";
            this.columnHeader6.Width = 127;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(581, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 568);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giảm giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(578, 662);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tiền phải trả";
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(678, 449);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(136, 30);
            this.txttongtien.TabIndex = 8;
            // 
            // txtgiamgia
            // 
            this.txtgiamgia.Location = new System.Drawing.Point(678, 562);
            this.txtgiamgia.Name = "txtgiamgia";
            this.txtgiamgia.Size = new System.Drawing.Size(136, 30);
            this.txtgiamgia.TabIndex = 9;
            // 
            // txttienphaitra
            // 
            this.txttienphaitra.Location = new System.Drawing.Point(678, 656);
            this.txttienphaitra.Name = "txttienphaitra";
            this.txttienphaitra.Size = new System.Drawing.Size(136, 30);
            this.txttienphaitra.TabIndex = 10;
            // 
            // ckldanhmuc
            // 
            this.ckldanhmuc.FormattingEnabled = true;
            this.ckldanhmuc.Location = new System.Drawing.Point(16, 100);
            this.ckldanhmuc.Name = "ckldanhmuc";
            this.ckldanhmuc.Size = new System.Drawing.Size(262, 279);
            this.ckldanhmuc.TabIndex = 11;
            this.ckldanhmuc.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ckldanhmuc_ItemCheck);
            this.ckldanhmuc.Click += new System.EventHandler(this.ckldanhmuc_Click);
            this.ckldanhmuc.SelectedIndexChanged += new System.EventHandler(this.ckldanhmuc_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 743);
            this.Controls.Add(this.ckldanhmuc);
            this.Controls.Add(this.txttienphaitra);
            this.Controls.Add(this.txtgiamgia);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvdanhsach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pichinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btntinhtien;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DateTimePicker datengaydat;
        private System.Windows.Forms.NumericUpDown numsl;
        private System.Windows.Forms.TextBox txtnguoidat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pichinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvdanhsach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.TextBox txtgiamgia;
        private System.Windows.Forms.TextBox txttienphaitra;
        private System.Windows.Forms.CheckedListBox ckldanhmuc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btntaomoi;
    }
}

