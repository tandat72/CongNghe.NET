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
namespace kiemtralan2
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
            listdanhsach.Items.Clear();
            string sql = "select * FROM XE";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            for (int i = 0; i < dt.Rows.Count; i++)
                listdanhsach.Items.Add(dt.Rows[i][0].ToString());
        }
        void hienthilistview()
        {
            lvchitiet.Items.Clear();
            string sql = "select P.SoPhieu, H.Hoten, H.MaKH, P.Ngaydk FROM PHIEUDK P, KHACHHANG H where P.MaKH = H.MaKH and Bienso='" + txtbienso.Text +"'";
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
            cn = new SqlConnection(@"Data Source=LAPTOP-VC5IF5QK;Initial Catalog =DANGKIEM; Integrated Security=True");
            cn.Open();
            hienthi();
            cbkh.Items.Add("039245678");
            cbkh.Items.Add("090456178");
            cbkh.Items.Add("0989297790");

        }

        private void listdanhsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select Bienso, Ngayhethan, MaKH from Xe where Bienso like N'" + listdanhsach.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtbienso.Text = dr.GetString(0);
                datengayhethan.Value = (dr.GetDateTime(1));
                cbkh.Text = dr.GetString(2);

            }
            dr.Close();
            try
            {
                pichinhanh.Load(txtbienso.Text + ".jpg");
            }
            catch (Exception ex)
            {
                pichinhanh.Image = null;
            }
            hienthilistview();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtbienso.Clear();
            datengayhethan.ResetText();
            cbkh.ResetText();

        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            string ngayhethan;
            ngayhethan = String.Format("{0:MM/dd/yyyy}", datengayhethan.Value);
            string sql = "Insert into XE (Bienso, Ngayhethan, MaKH) values ('" +
                txtbienso.Text + "',N'" + ngayhethan + "',N'" + cbkh.Text + "')";
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
            string sql = "Delete From XE where Bienso='" + txtbienso.Text + "'";
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

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            string ngayhethan;
            ngayhethan = String.Format("{0:MM/dd/yyyy}", datengayhethan.Value);
            string sql = "Update XE set Ngayhethan='" + ngayhethan +"',MaKH='" + cbkh.Text + "' where Bienso = '" + txtbienso.Text +"'";
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

        private void lvchitiet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
