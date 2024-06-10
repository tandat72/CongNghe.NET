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

namespace bt3
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
            lvdanhsach.Items.Clear();
            string sql = "SELECT * FROM CHITIET";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                lvdanhsach.Items.Add(item);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
            cn = new SqlConnection(@"Data Source=LAPTOP-VC5IF5QK;Initial Catalog =THUEPHONG; Integrated Security=True");
            cn.Open();
            LoadMaPhong();
            hienthi();

        }
        private void LoadMaPhong()
        {
            string sql = "SELECT MaPhong FROM PHONG";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbmaphong.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }
        private void LoadSOHDs(string maPhong)
        {
            lvdanhsach.Items.Clear();
            string sql = "SELECT SOHD, Hoten, CMND, Ngaynhan, Ngaytra FROM CHITIET WHERE MaPhong = @MaPhong";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@MaPhong", maPhong);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["SOHD"].ToString());
                item.SubItems.Add(dr["Hoten"].ToString());
                item.SubItems.Add(dr["CMND"].ToString());
                item.SubItems.Add(dr["Ngaynhan"].ToString());
                item.SubItems.Add(dr["Ngaytra"].ToString());
                lvdanhsach.Items.Add(item);
            }
            dr.Close();
        }
        
        private void cbmaphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT Dongia FROM PHONG WHERE MaPhong = @MaPhong";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@MaPhong", cbmaphong.SelectedItem.ToString());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                txtdongia.Text = dr[0].ToString();
            dr.Close();

            // Load SOHDs for selected MaPhong
            LoadSOHDs(cbmaphong.SelectedItem.ToString());
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txthoten.Text = "";
            txtcmnd.Text = "";
            datengaynhan.Text = "";
            datengaytra.Text = "";

            btnghi.Enabled = true;
            btnkhong.Enabled = true;
            btnthem.Enabled = false;
            btnthoat.Enabled = false;

            txthoten.Enabled = true;
            txtcmnd.Enabled = true;
            datengaynhan.Enabled = true;
            datengaytra.Enabled = true;
        }

        private void txtdongia_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtdongia.Text))
            {
                try
                {
                    string imagePath = txtdongia.Text + ".jpg";
                    pichinh.Load(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tìm thấy hình ảnh.");
                    pichinh.Image = null;
                }
            }
        }

        private void btnkhong_Click(object sender, EventArgs e)
        {
            btnghi.Enabled = false;
            btnkhong.Enabled = false;
            btnthem.Enabled = true;
            btnthoat.Enabled = true;

            txthoten.Enabled = false;
            txtcmnd.Enabled = false;
            datengaynhan.Enabled = false;
            datengaytra.Enabled = false;
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO CHITIET (MaPhong, Hoten, CMND, Ngaynhan, Ngaytra) VALUES (@MaPhong, @Hoten, @CMND, @Ngaynhan, @Ngaytra)";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@MaPhong", cbmaphong.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Hoten", txthoten.Text);
            cmd.Parameters.AddWithValue("@CMND", txtcmnd.Text);
            cmd.Parameters.AddWithValue("@Ngaynhan", DateTime.Parse(datengaynhan.Text));
            cmd.Parameters.AddWithValue("@Ngaytra", DateTime.Parse(datengaytra.Text));
            cmd.ExecuteNonQuery();

            btnghi.Enabled = false;
            btnkhong.Enabled = false;
            btnthem.Enabled = true;
            btnthoat.Enabled = true;

            txthoten.Enabled = false;
            txtcmnd.Enabled = false;
            datengaynhan.Enabled = false;
            datengaytra.Enabled = false;

            hienthi();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lvdanhsach.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string selectedSOHD = lvdanhsach.SelectedItems[0].Text;
                    XoaSOHD(selectedSOHD);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void XoaSOHD(string sohd)
        {
            string sql = "DELETE FROM CHITIET WHERE SOHD = @SOHD";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@SOHD", sohd);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Xóa dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Sau khi xóa dòng, cập nhật lại ListView
                LoadSOHDs(cbmaphong.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Không thể xóa dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvdanhsach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvdanhsach.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvdanhsach.SelectedItems[0];
                txthoten.Text = selectedItem.SubItems[1].Text;
                txtcmnd.Text = selectedItem.SubItems[2].Text;
                datengaynhan.Text = selectedItem.SubItems[3].Text;
                datengaytra.Text = selectedItem.SubItems[4].Text;
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            string ngaynhan, ngaytra;
            ngaynhan = datengaynhan.Value.ToString("MM/dd/yyyy");
            ngaytra = datengaytra.Value.ToString("MM/dd/yyyy");

            string sql = "UPDATE CHITIET SET Hoten = @Hoten, CMND = @CMND, Ngaynhan = @Ngaynhan, Ngaytra = @Ngaytra WHERE SOHD = @SOHD";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@Hoten", txthoten.Text);
                cmd.Parameters.AddWithValue("@CMND", txtcmnd.Text);
                cmd.Parameters.AddWithValue("@Ngaynhan", ngaynhan);
                cmd.Parameters.AddWithValue("@Ngaytra", ngaytra);
                cmd.Parameters.AddWithValue("@SOHD", lvdanhsach.SelectedItems[0].Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thành công.");
                    // Sau khi cập nhật thành công, cập nhật lại ListView
                    LoadSOHDs(cbmaphong.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Không có dòng nào được cập nhật.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
