namespace kiemtralan2
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
            this.listdanhsach = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbkh = new System.Windows.Forms.ComboBox();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.datengayhethan = new System.Windows.Forms.DateTimePicker();
            this.txtbienso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pichinhanh = new System.Windows.Forms.PictureBox();
            this.lvchitiet = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnxoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pichinhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ ĐĂNG KIỂM XE CƠ GIỚI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách các xe";
            // 
            // listdanhsach
            // 
            this.listdanhsach.FormattingEnabled = true;
            this.listdanhsach.ItemHeight = 25;
            this.listdanhsach.Location = new System.Drawing.Point(30, 115);
            this.listdanhsach.Name = "listdanhsach";
            this.listdanhsach.Size = new System.Drawing.Size(131, 229);
            this.listdanhsach.TabIndex = 2;
            this.listdanhsach.SelectedIndexChanged += new System.EventHandler(this.listdanhsach_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbkh);
            this.groupBox1.Controls.Add(this.btncapnhat);
            this.groupBox1.Controls.Add(this.btnghi);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.datengayhethan);
            this.groupBox1.Controls.Add(this.txtbienso);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(188, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 244);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết của xe";
            // 
            // cbkh
            // 
            this.cbkh.FormattingEnabled = true;
            this.cbkh.Location = new System.Drawing.Point(121, 148);
            this.cbkh.Name = "cbkh";
            this.cbkh.Size = new System.Drawing.Size(278, 33);
            this.cbkh.TabIndex = 9;
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(281, 196);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(101, 42);
            this.btncapnhat.TabIndex = 8;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnghi
            // 
            this.btnghi.Location = new System.Drawing.Point(148, 196);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(101, 42);
            this.btnghi.TabIndex = 7;
            this.btnghi.Text = "Ghi";
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(24, 196);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(101, 42);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // datengayhethan
            // 
            this.datengayhethan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datengayhethan.Location = new System.Drawing.Point(121, 88);
            this.datengayhethan.Name = "datengayhethan";
            this.datengayhethan.Size = new System.Drawing.Size(278, 30);
            this.datengayhethan.TabIndex = 4;
            // 
            // txtbienso
            // 
            this.txtbienso.Location = new System.Drawing.Point(121, 29);
            this.txtbienso.Name = "txtbienso";
            this.txtbienso.Size = new System.Drawing.Size(278, 30);
            this.txtbienso.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày hết hạn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Biển số";
            // 
            // pichinhanh
            // 
            this.pichinhanh.Location = new System.Drawing.Point(608, 115);
            this.pichinhanh.Name = "pichinhanh";
            this.pichinhanh.Size = new System.Drawing.Size(204, 244);
            this.pichinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pichinhanh.TabIndex = 4;
            this.pichinhanh.TabStop = false;
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
            this.lvchitiet.Location = new System.Drawing.Point(31, 379);
            this.lvchitiet.Name = "lvchitiet";
            this.lvchitiet.Size = new System.Drawing.Size(563, 172);
            this.lvchitiet.TabIndex = 5;
            this.lvchitiet.UseCompatibleStateImageBehavior = false;
            this.lvchitiet.View = System.Windows.Forms.View.Details;
            this.lvchitiet.SelectedIndexChanged += new System.EventHandler(this.lvchitiet_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Số Phiếu";
            this.columnHeader1.Width = 137;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên KH";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MaKH";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày đăng kiểm";
            this.columnHeader4.Width = 136;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(638, 425);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(101, 42);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 576);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.lvchitiet);
            this.Controls.Add(this.pichinhanh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listdanhsach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pichinhanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listdanhsach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DateTimePicker datengayhethan;
        private System.Windows.Forms.TextBox txtbienso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pichinhanh;
        private System.Windows.Forms.ListView lvchitiet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.ComboBox cbkh;
    }
}

