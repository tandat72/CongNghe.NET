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
namespace QLphongtro
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
            ckldiachi.Items.Clear();
            string sql = "Select Diachi from PHONGTRO";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            for (int i = 0; i < dt.Rows.Count; i++)
                ckldiachi.Items.Add(dt.Rows[i][0].ToString());
        }
        void hienthilistview()
        {
            lvdanhsach.Items.Clear();
            string sql = "select TB.IdMaTB , TenTB, Soluong, Trigia from TRANGBI TB, THIETBI TBI where TB.IdMaTB=TBI.IdMaTB and TB.IdMaPT='" + txtma.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lvdanhsach.Items.Add(dt.Rows[i][0].ToString());
                lvdanhsach.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
                lvdanhsach.Items[i].SubItems.Add(dt.Rows[i][2].ToString());
                lvdanhsach.Items[i].SubItems.Add(dt.Rows[i][3].ToString());
            }
            dr.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbkhuvuc.Items.Add("KV001");
            cbkhuvuc.Items.Add("KV002");
            cbkhuvuc.Items.Add("KV003");
            cbkhuvuc.Items.Add("KV004");
            cbkhuvuc.Items.Add("KV005");
            cn = new SqlConnection(@"Data Source=LAPTOP-VC5IF5QK;Initial Catalog=QLPHONGTRO;Integrated Security=True");
            cn.Open();
            hienthi();
        }

        private void ckldiachi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select IdMaPT, Diachi, TenKV from PHONGTRO P, KHUVUC K where P.IdMaKV=K.IdMaKV and P.Diachi like N'" + ckldiachi.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtma.Text = dr.GetString(0);
                txtdiachi.Text = dr.GetString(1);
                cbkhuvuc.Text = dr.GetString(2);
            }
            dr.Close();
            try
            {
                pichinhanh.Load(txtma.Text + ".jpg");
            }
            catch (Exception ex)
            {
                pichinhanh.Image = null;
            }
            hienthilistview();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtma.Clear();
            txtdiachi.Clear();
            cbkhuvuc.ResetText();
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
           
            string sql = "Insert into PHONGTRO (IdMaPT, Diachi, IdMaKV) values ('" +
                txtma.Text + "',N'" + txtdiachi.Text + "',N'" + cbkhuvuc.Text + "')";
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

        private void btnhuy_Click(object sender, EventArgs e)
        {
            string sql = "Delete From PHONGTRO where IdMaPT='" + txtma.Text + "'";
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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            string sql = "update PHONGTRO set Diachi=N'" + txtdiachi.Text + "',IDMaKV='" + cbkhuvuc.Text + "' where IdMaPT='" + txtma.Text + "'";
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
