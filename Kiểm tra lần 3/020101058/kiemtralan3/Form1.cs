using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kiemtralan3
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        public Form1()
        {
            InitializeComponent();
        }
        void hienthi()
        {
            ckldanhsach.Items.Clear();
            string sql = "Select TenSach from SACH";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            for (int i = 0; i < dt.Rows.Count; i++)
                ckldanhsach.Items.Add(dt.Rows[i][0].ToString());
        }
        void hienthilistview()
        {
            lvchitiet.Items.Clear();
            string sql = "Select Hoten, Ngaymuon, Ngaytra,Quanlythuvien From MUONSACH M, SINHVIEN S where M.MaSV=S.maSV and Masach='" + txtmasach.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lvchitiet.Items.Add(dt.Rows[i][0].ToString());
                lvchitiet.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                lvchitiet.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                lvchitiet.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
            }
            dr.Close();
        }
        void hienthichuatra()
        {
            lvchitiet.Items.Clear();
            string sql = "Select Hoten, Ngaymuon, Ngaytra,Quanlythuvien From MUONSACH M, SINHVIEN S where M.MaSV=S.maSV and Ngaytra is null";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lvchitiet.Items.Add(dt.Rows[i][0].ToString());
                lvchitiet.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                lvchitiet.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                lvchitiet.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
            }
            dr.Close();
        }
        void hienthingaymuon()
        {
            lvchitiet.Items.Clear();
            string sql = "Select Hoten, Ngaymuon, Ngaytra, Quanlythuvien From SINHVIEN S, MUONSACH V where S.MaSV = V.MaSV order by Ngaymuon desc";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lvchitiet.Items.Add(dt.Rows[i][0].ToString());
                lvchitiet.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                lvchitiet.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                lvchitiet.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
            }
            dr.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbnxb.Items.Add("Đại học Bách Khoa Hà Nội");
            cbnxb.Items.Add("Đại học Sư Phạm");
            cbnxb.Items.Add("Đại học Kinh tế quốc dân");
            cbnxb.Items.Add("Học viện chính trị quốc gia");
            cbnxb.Items.Add("Học viện Bưu chính viễn thông");
            cbnxb.Items.Add("Đại học Kinh tế quốc dân");
            cbnxb.Items.Add("Đại học Sư Phạm");
            cn = new SqlConnection(@"Data Source=LAPTOP-VC5IF5QK;Initial Catalog=QLTHUVIEN;Integrated Security=True");
            cn.Open();
            hienthi();
        }

        private void ckldanhsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "Select MaSach, TenSach, Namxb, Nhaxb From SACH where Tensach like N'" + ckldanhsach.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtmasach.Text = dr.GetString(0);
                txttensach.Text = dr.GetString(1);
                txtnxb.Text = dr.GetInt32(2).ToString();
                cbnxb.Text = dr.GetString(3);
            }
            dr.Close();
           
            hienthilistview();
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            string sql = "Insert into SACH (MaSach, TenSach, Namxb, Nhaxb) values ('" +
                txtmasach.Text + "', '" + txttensach.Text + "','" + txtnxb.Text + "',N'" + cbnxb.Text + "')";
            MessageBox.Show(sql);
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nhập được rồi");
                hienthi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không được rồi");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete From SACH where TenSach='" + txttensach.Text + "'";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Nhập được rồi");
                hienthi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không được rồi");
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmasach.Clear();
            txttensach.Clear();
            txtnxb.Clear();
            cbnxb.ResetText();
        }

        private void radngaymuon_CheckedChanged(object sender, EventArgs e)
        {
            hienthingaymuon();
        }

        private void radngaymuon_Click(object sender, EventArgs e)
        {

        }

        private void radchuatra_CheckedChanged(object sender, EventArgs e)
        {
            hienthichuatra();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            
            string sql = "Update SACH set TenSach=N'"+txttensach.Text+"',Namxb=N'"+txtnxb.Text+"' ,Nhaxb=N'"+cbnxb.Text+"' where Masach=N'"+txtmasach.Text+"'";
            MessageBox.Show(sql);
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật được rồi");
                hienthi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không được rồi");
            }
        }
    }
}
