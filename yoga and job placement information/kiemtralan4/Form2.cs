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

namespace kiemtralan4
{
    public partial class Form2 : Form
    {
        SqlConnection cn;
        public Form2()
        {
            InitializeComponent();
        }
        void hienthi()
        {
            ckldanhmuc.Items.Clear();
            string sql = "select Tenvitri from VITRIVL";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            for (int i = 0; i < dt.Rows.Count; i++)
                ckldanhmuc.Items.Add(dt.Rows[i][0].ToString());
        }
        void hienthilistview()
        {
            lvdanhsach.Items.Clear();
            string sql = "select Hoten, Tenphong, luong from NHANVIEN NV, PHONGBAN PB, PHANCONG PC where NV.MaNV = PC.MaNV and NV.MaPhong = PB.MaPhong and MaVT ='"+txtmavitri.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                lvdanhsach.Items.Add(item);

            }
            dr.Close();
        }
        void tangdan()
        {
            lvdanhsach.Items.Clear();
            string sql = "select Hoten, Tenphong, luong from NHANVIEN NV, PHONGBAN PB, PHANCONG PC where NV.MaNV = PC.MaNV and NV.MaPhong = PB.MaPhong order by Luong asc";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                lvdanhsach.Items.Add(item);
            }
            dr.Close();
        }
        void giamdan()
        {
            lvdanhsach.Items.Clear();
            string sql = "select Hoten, Tenphong, luong from NHANVIEN NV, PHONGBAN PB, PHANCONG PC where NV.MaNV = PC.MaNV and NV.MaPhong = PB.MaPhong order by Luong desc";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                lvdanhsach.Items.Add(item);
            }
            dr.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=LAPTOP-VC5IF5QK;Initial Catalog=QLNV;Integrated Security=True");
            cn.Open();
            hienthi();
        }

        private void ckldanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ckldanhmuc_Click(object sender, EventArgs e)
        {
            string sql = "Select MaVT, Tenvitri, Mucluong From VITRIVL where Tenvitri like N'" + ckldanhmuc.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtmavitri.Text = dr.GetString(0);
                txttenvitri.Text = dr.GetString(1);
                txtluong.Text = dr[2].ToString();

            }
            dr.Close();
            
            hienthilistview();
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            string sql = "Insert into VITRIVL (MaVT, Tenvitri, Mucluong) values (N'" +
               txtmavitri.Text + "',N'" + txttenvitri.Text + "',N'" + txtluong.Text + "')";
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

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            string sql = "Update VITRIVL set MaVT=N'" + txtmavitri.Text + "',Tenvitri=N'" + txttenvitri.Text + "' ,Mucluong=N'" + txtluong.Text + "' where MaVT=N'" + txtmavitri.Text + "'";
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtmavitri.Clear();
            txttenvitri.Clear();
            txtluong.Clear();
        }

        private void radgiam_CheckedChanged(object sender, EventArgs e)
        {
            giamdan();
        }

        private void lvdanhsach_Click(object sender, EventArgs e)
        {
            //dùng trim loại bỏ khoản trắng
            string mavitri = txtmavitri.Text.Trim();
            if (lvdanhsach.SelectedItems.Count > 0)
            {

                try
                {
                    pichinh.Load(mavitri + ".jpg");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tìm thấy hình ảnh.");
                    pichinh.Image = null;
                }
            }
        }

        private void radtang_CheckedChanged(object sender, EventArgs e)
        {
            tangdan();
        }

        private void lvdanhsach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete From VITRIVL where Tenvitri='" + txttenvitri.Text + "'";
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
    }
}
