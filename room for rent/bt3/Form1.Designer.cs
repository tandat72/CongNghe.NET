namespace bt3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datengaytra = new System.Windows.Forms.DateTimePicker();
            this.datengaynhan = new System.Windows.Forms.DateTimePicker();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbmaphong = new System.Windows.Forms.ComboBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.pichinh = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lvdanhsach = new System.Windows.Forms.ListView();
            this.txtsohd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnthem = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnkhong = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pichinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU ĐĂNG KÝ THUÊ PHÒNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datengaytra);
            this.groupBox1.Controls.Add(this.datengaynhan);
            this.groupBox1.Controls.Add(this.txtcmnd);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(58, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 270);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // datengaytra
            // 
            this.datengaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaytra.Location = new System.Drawing.Point(238, 228);
            this.datengaytra.Name = "datengaytra";
            this.datengaytra.Size = new System.Drawing.Size(247, 30);
            this.datengaytra.TabIndex = 7;
            // 
            // datengaynhan
            // 
            this.datengaynhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengaynhan.Location = new System.Drawing.Point(238, 183);
            this.datengaynhan.Name = "datengaynhan";
            this.datengaynhan.Size = new System.Drawing.Size(247, 30);
            this.datengaynhan.TabIndex = 6;
            // 
            // txtcmnd
            // 
            this.txtcmnd.Location = new System.Drawing.Point(238, 118);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(247, 30);
            this.txtcmnd.TabIndex = 5;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(238, 53);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(247, 30);
            this.txthoten.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày nhận";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "CMND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbmaphong);
            this.groupBox2.Controls.Add(this.txtdongia);
            this.groupBox2.Controls.Add(this.pichinh);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(753, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 363);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phòng";
            // 
            // cbmaphong
            // 
            this.cbmaphong.FormattingEnabled = true;
            this.cbmaphong.Location = new System.Drawing.Point(167, 45);
            this.cbmaphong.Name = "cbmaphong";
            this.cbmaphong.Size = new System.Drawing.Size(247, 33);
            this.cbmaphong.TabIndex = 14;
            this.cbmaphong.SelectedIndexChanged += new System.EventHandler(this.cbmaphong_SelectedIndexChanged);
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(167, 113);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(247, 30);
            this.txtdongia.TabIndex = 13;
            this.txtdongia.TextChanged += new System.EventHandler(this.txtdongia_TextChanged);
            // 
            // pichinh
            // 
            this.pichinh.Location = new System.Drawing.Point(167, 174);
            this.pichinh.Name = "pichinh";
            this.pichinh.Size = new System.Drawing.Size(247, 171);
            this.pichinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pichinh.TabIndex = 12;
            this.pichinh.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Hình";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Phòng";
            // 
            // lvdanhsach
            // 
            this.lvdanhsach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.txtsohd,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvdanhsach.FullRowSelect = true;
            this.lvdanhsach.GridLines = true;
            this.lvdanhsach.Location = new System.Drawing.Point(57, 494);
            this.lvdanhsach.Name = "lvdanhsach";
            this.lvdanhsach.Size = new System.Drawing.Size(1200, 188);
            this.lvdanhsach.TabIndex = 3;
            this.lvdanhsach.UseCompatibleStateImageBehavior = false;
            this.lvdanhsach.View = System.Windows.Forms.View.Details;
            this.lvdanhsach.SelectedIndexChanged += new System.EventHandler(this.lvdanhsach_SelectedIndexChanged);
            // 
            // txtsohd
            // 
            this.txtsohd.Text = "Số HĐ";
            this.txtsohd.Width = 161;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 247;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CMND";
            this.columnHeader3.Width = 245;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày nhận";
            this.columnHeader4.Width = 302;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày trả";
            this.columnHeader5.Width = 226;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(58, 405);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(121, 59);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnghi
            // 
            this.btnghi.Location = new System.Drawing.Point(240, 405);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(121, 59);
            this.btnghi.TabIndex = 5;
            this.btnghi.Text = "Ghi";
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // btnkhong
            // 
            this.btnkhong.Location = new System.Drawing.Point(422, 405);
            this.btnkhong.Name = "btnkhong";
            this.btnkhong.Size = new System.Drawing.Size(121, 59);
            this.btnkhong.TabIndex = 6;
            this.btnkhong.Text = "Không";
            this.btnkhong.UseVisualStyleBackColor = true;
            this.btnkhong.Click += new System.EventHandler(this.btnkhong_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(595, 405);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(121, 59);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(628, 143);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(102, 56);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(628, 259);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(102, 56);
            this.btncapnhat.TabIndex = 9;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 708);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnkhong);
            this.Controls.Add(this.btnghi);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.lvdanhsach);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pichinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datengaytra;
        private System.Windows.Forms.DateTimePicker datengaynhan;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pichinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvdanhsach;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnkhong;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ColumnHeader txtsohd;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox cbmaphong;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btncapnhat;
    }
}

