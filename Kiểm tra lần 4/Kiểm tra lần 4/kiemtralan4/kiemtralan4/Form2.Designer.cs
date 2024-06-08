namespace kiemtralan4
{
    partial class Form2
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
            this.ckldanhmuc = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.txttenvitri = new System.Windows.Forms.TextBox();
            this.txtmavitri = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvdanhsach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.radgiam = new System.Windows.Forms.RadioButton();
            this.radtang = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.pichinh = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pichinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN VỊ TRÍ VIỆC LÀM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh mục vị trí việc làm";
            // 
            // ckldanhmuc
            // 
            this.ckldanhmuc.FormattingEnabled = true;
            this.ckldanhmuc.Location = new System.Drawing.Point(12, 91);
            this.ckldanhmuc.Name = "ckldanhmuc";
            this.ckldanhmuc.Size = new System.Drawing.Size(182, 254);
            this.ckldanhmuc.TabIndex = 2;
            this.ckldanhmuc.Click += new System.EventHandler(this.ckldanhmuc_Click);
            this.ckldanhmuc.SelectedIndexChanged += new System.EventHandler(this.ckldanhmuc_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncapnhat);
            this.groupBox1.Controls.Add(this.btnghi);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.txtluong);
            this.groupBox1.Controls.Add(this.txttenvitri);
            this.groupBox1.Controls.Add(this.txtmavitri);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(213, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 256);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(231, 184);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(123, 40);
            this.btncapnhat.TabIndex = 8;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnghi
            // 
            this.btnghi.Location = new System.Drawing.Point(231, 119);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(123, 40);
            this.btnghi.TabIndex = 7;
            this.btnghi.Text = "Ghi";
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(231, 45);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(123, 40);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(98, 178);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(100, 30);
            this.txtluong.TabIndex = 5;
            // 
            // txttenvitri
            // 
            this.txttenvitri.Location = new System.Drawing.Point(98, 108);
            this.txttenvitri.Name = "txttenvitri";
            this.txttenvitri.Size = new System.Drawing.Size(100, 30);
            this.txttenvitri.TabIndex = 4;
            // 
            // txtmavitri
            // 
            this.txtmavitri.Location = new System.Drawing.Point(98, 45);
            this.txtmavitri.Name = "txtmavitri";
            this.txtmavitri.Size = new System.Drawing.Size(100, 30);
            this.txtmavitri.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Lương";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên vị trí";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã vị trí";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Liệt kê nhân viên theo vị trí việc làm";
            // 
            // lvdanhsach
            // 
            this.lvdanhsach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvdanhsach.FullRowSelect = true;
            this.lvdanhsach.GridLines = true;
            this.lvdanhsach.Location = new System.Drawing.Point(16, 393);
            this.lvdanhsach.Name = "lvdanhsach";
            this.lvdanhsach.Size = new System.Drawing.Size(525, 253);
            this.lvdanhsach.TabIndex = 0;
            this.lvdanhsach.UseCompatibleStateImageBehavior = false;
            this.lvdanhsach.View = System.Windows.Forms.View.Details;
            this.lvdanhsach.SelectedIndexChanged += new System.EventHandler(this.lvdanhsach_SelectedIndexChanged);
            this.lvdanhsach.Click += new System.EventHandler(this.lvdanhsach_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 109;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phòng ban";
            this.columnHeader3.Width = 171;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lương";
            this.columnHeader4.Width = 183;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.radgiam);
            this.groupBox2.Controls.Add(this.radtang);
            this.groupBox2.Location = new System.Drawing.Point(616, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 244);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sắp xếp theo lương";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(29, 172);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(123, 40);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = " ";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // radgiam
            // 
            this.radgiam.AutoSize = true;
            this.radgiam.Location = new System.Drawing.Point(6, 123);
            this.radgiam.Name = "radgiam";
            this.radgiam.Size = new System.Drawing.Size(217, 29);
            this.radgiam.TabIndex = 7;
            this.radgiam.TabStop = true;
            this.radgiam.Text = "Theo lương giảm dần";
            this.radgiam.UseVisualStyleBackColor = true;
            this.radgiam.CheckedChanged += new System.EventHandler(this.radgiam_CheckedChanged);
            // 
            // radtang
            // 
            this.radtang.AutoSize = true;
            this.radtang.Location = new System.Drawing.Point(10, 49);
            this.radtang.Name = "radtang";
            this.radtang.Size = new System.Drawing.Size(213, 29);
            this.radtang.TabIndex = 6;
            this.radtang.TabStop = true;
            this.radtang.Text = "Theo lương tăng dần";
            this.radtang.UseVisualStyleBackColor = true;
            this.radtang.CheckedChanged += new System.EventHandler(this.radtang_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(612, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ảnh minh họa";
            // 
            // pichinh
            // 
            this.pichinh.Location = new System.Drawing.Point(576, 393);
            this.pichinh.Name = "pichinh";
            this.pichinh.Size = new System.Drawing.Size(221, 253);
            this.pichinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pichinh.TabIndex = 7;
            this.pichinh.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 658);
            this.Controls.Add(this.pichinh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lvdanhsach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ckldanhmuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox ckldanhmuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.TextBox txttenvitri;
        private System.Windows.Forms.TextBox txtmavitri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvdanhsach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radgiam;
        private System.Windows.Forms.RadioButton radtang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pichinh;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnxoa;
    }
}