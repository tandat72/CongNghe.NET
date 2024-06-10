namespace bai2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbmonchuyen = new System.Windows.Forms.ComboBox();
            this.nummonchuyen = new System.Windows.Forms.NumericUpDown();
            this.btnthongke = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.numanhvan = new System.Windows.Forms.NumericUpDown();
            this.numvan = new System.Windows.Forms.NumericUpDown();
            this.numtoan = new System.Windows.Forms.NumericUpDown();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvdanhsach = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.lvthongke = new System.Windows.Forms.ListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.lbsohsdangky = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nummonchuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numanhvan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numvan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numtoan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(188, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU ĐĂNG KÝ THÔNG TIN XÉT TUYỂN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbmonchuyen);
            this.groupBox1.Controls.Add(this.nummonchuyen);
            this.groupBox1.Controls.Add(this.btnthongke);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.numanhvan);
            this.groupBox1.Controls.Add(this.numvan);
            this.groupBox1.Controls.Add(this.numtoan);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(27, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1213, 259);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // cbmonchuyen
            // 
            this.cbmonchuyen.FormattingEnabled = true;
            this.cbmonchuyen.Location = new System.Drawing.Point(161, 116);
            this.cbmonchuyen.Name = "cbmonchuyen";
            this.cbmonchuyen.Size = new System.Drawing.Size(271, 36);
            this.cbmonchuyen.TabIndex = 13;
            // 
            // nummonchuyen
            // 
            this.nummonchuyen.DecimalPlaces = 2;
            this.nummonchuyen.Location = new System.Drawing.Point(449, 118);
            this.nummonchuyen.Name = "nummonchuyen";
            this.nummonchuyen.Size = new System.Drawing.Size(96, 34);
            this.nummonchuyen.TabIndex = 12;
            // 
            // btnthongke
            // 
            this.btnthongke.Location = new System.Drawing.Point(661, 182);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(150, 57);
            this.btnthongke.TabIndex = 11;
            this.btnthongke.Text = "THỐNG KÊ";
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(375, 182);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(150, 57);
            this.btnthem.TabIndex = 10;
            this.btnthem.Text = "THÊM";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // numanhvan
            // 
            this.numanhvan.DecimalPlaces = 2;
            this.numanhvan.Location = new System.Drawing.Point(766, 118);
            this.numanhvan.Name = "numanhvan";
            this.numanhvan.Size = new System.Drawing.Size(96, 34);
            this.numanhvan.TabIndex = 8;
            this.numanhvan.ValueChanged += new System.EventHandler(this.numanhvan_ValueChanged);
            // 
            // numvan
            // 
            this.numvan.DecimalPlaces = 2;
            this.numvan.Location = new System.Drawing.Point(951, 39);
            this.numvan.Name = "numvan";
            this.numvan.Size = new System.Drawing.Size(96, 34);
            this.numvan.TabIndex = 7;
            // 
            // numtoan
            // 
            this.numtoan.DecimalPlaces = 2;
            this.numtoan.Location = new System.Drawing.Point(766, 39);
            this.numtoan.Name = "numtoan";
            this.numtoan.Size = new System.Drawing.Size(96, 34);
            this.numtoan.TabIndex = 6;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(161, 40);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(384, 34);
            this.txthoten.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(661, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "Anh văn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(883, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 28);
            this.label7.TabIndex = 3;
            this.label7.Text = "Văn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(661, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Toán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Môn chuyên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ tên";
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
            this.lvdanhsach.Location = new System.Drawing.Point(27, 412);
            this.lvdanhsach.Name = "lvdanhsach";
            this.lvdanhsach.Size = new System.Drawing.Size(880, 239);
            this.lvdanhsach.TabIndex = 2;
            this.lvdanhsach.UseCompatibleStateImageBehavior = false;
            this.lvdanhsach.View = System.Windows.Forms.View.Details;
            this.lvdanhsach.SelectedIndexChanged += new System.EventHandler(this.lvdanhsach_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ tên";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Văn";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Toán";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Anh văn";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Môn chuyên";
            this.columnHeader5.Width = 170;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Điểm xét tuyển";
            this.columnHeader6.Width = 170;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(929, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thống kê:";
            // 
            // lvthongke
            // 
            this.lvthongke.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.lvthongke.FullRowSelect = true;
            this.lvthongke.GridLines = true;
            this.lvthongke.Location = new System.Drawing.Point(929, 412);
            this.lvthongke.Name = "lvthongke";
            this.lvthongke.Size = new System.Drawing.Size(311, 239);
            this.lvthongke.TabIndex = 4;
            this.lvthongke.UseCompatibleStateImageBehavior = false;
            this.lvthongke.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Môn chuyên";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tổng số HS";
            this.columnHeader8.Width = 150;
            // 
            // lbsohsdangky
            // 
            this.lbsohsdangky.AutoSize = true;
            this.lbsohsdangky.Location = new System.Drawing.Point(27, 364);
            this.lbsohsdangky.Name = "lbsohsdangky";
            this.lbsohsdangky.Size = new System.Drawing.Size(253, 28);
            this.lbsohsdangky.TabIndex = 5;
            this.lbsohsdangky.Text = "Danh sách học sinh đăng ký";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 663);
            this.Controls.Add(this.lbsohsdangky);
            this.Controls.Add(this.lvthongke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvdanhsach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nummonchuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numanhvan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numvan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numtoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cbmonchuyen;
        private NumericUpDown nummonchuyen;
        private Button btnthongke;
        private Button btnthem;
        private NumericUpDown numanhvan;
        private NumericUpDown numvan;
        private NumericUpDown numtoan;
        private TextBox txthoten;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ListView lvdanhsach;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label3;
        private ListView lvthongke;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Label lbsohsdangky;
    }
}