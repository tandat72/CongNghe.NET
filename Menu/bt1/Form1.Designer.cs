namespace bt1
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
            this.ckldanhsach = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbban = new System.Windows.Forms.ComboBox();
            this.numsl = new System.Windows.Forms.NumericUpDown();
            this.btnthem = new System.Windows.Forms.Button();
            this.btntinh = new System.Windows.Forms.Button();
            this.lbltongthanhtien = new System.Windows.Forms.Label();
            this.lvdanhsach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.numsl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỰC ĐƠN MÓN ĂN";
            // 
            // ckldanhsach
            // 
            this.ckldanhsach.FormattingEnabled = true;
            this.ckldanhsach.Location = new System.Drawing.Point(40, 78);
            this.ckldanhsach.Name = "ckldanhsach";
            this.ckldanhsach.Size = new System.Drawing.Size(281, 529);
            this.ckldanhsach.TabIndex = 1;
            this.ckldanhsach.SelectedIndexChanged += new System.EventHandler(this.ckldanhsach_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bàn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng :";
            // 
            // cbban
            // 
            this.cbban.FormattingEnabled = true;
            this.cbban.Location = new System.Drawing.Point(556, 70);
            this.cbban.Name = "cbban";
            this.cbban.Size = new System.Drawing.Size(305, 33);
            this.cbban.TabIndex = 4;
            // 
            // numsl
            // 
            this.numsl.Location = new System.Drawing.Point(556, 145);
            this.numsl.Name = "numsl";
            this.numsl.Size = new System.Drawing.Size(305, 30);
            this.numsl.TabIndex = 5;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(556, 206);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(139, 44);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(568, 619);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(139, 44);
            this.btntinh.TabIndex = 7;
            this.btntinh.Text = "Tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // lbltongthanhtien
            // 
            this.lbltongthanhtien.AutoSize = true;
            this.lbltongthanhtien.Location = new System.Drawing.Point(737, 638);
            this.lbltongthanhtien.Name = "lbltongthanhtien";
            this.lbltongthanhtien.Size = new System.Drawing.Size(64, 25);
            this.lbltongthanhtien.TabIndex = 8;
            this.lbltongthanhtien.Text = "label4";
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
            this.lvdanhsach.Location = new System.Drawing.Point(397, 267);
            this.lvdanhsach.Name = "lvdanhsach";
            this.lvdanhsach.Size = new System.Drawing.Size(920, 337);
            this.lvdanhsach.TabIndex = 9;
            this.lvdanhsach.UseCompatibleStateImageBehavior = false;
            this.lvdanhsach.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên món ăn";
            this.columnHeader2.Width = 147;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Bàn";
            this.columnHeader3.Width = 136;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số lượng";
            this.columnHeader4.Width = 169;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Đơn giá";
            this.columnHeader5.Width = 137;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thành tiền";
            this.columnHeader6.Width = 294;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 694);
            this.Controls.Add(this.lvdanhsach);
            this.Controls.Add(this.lbltongthanhtien);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.numsl);
            this.Controls.Add(this.cbban);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckldanhsach);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numsl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox ckldanhsach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbban;
        private System.Windows.Forms.NumericUpDown numsl;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.Label lbltongthanhtien;
        private System.Windows.Forms.ListView lvdanhsach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

