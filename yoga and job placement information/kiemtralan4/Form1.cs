using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kiemtralan4
{
    public partial class Form1 : Form
    {
        //khai báo biến và thuộc tính
        private Dictionary<string, decimal> productPrices;
        private int serialNumber = 1;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numsl.Value = 1;
            productPrices = new Dictionary<string, decimal>
            {
                { "Bộ đồ Alibaba", 250 },
                { "Quần", 150 },
                { "Áo", 120 },
                { "Vòng", 400 },
                { "Thảm", 220 },
                { "Dây", 100 },
                { "Thảm lót", 240 },
                { "Bóng tập", 380 }
            };
            foreach (var product in productPrices.Keys)
            {
                ckldanhmuc.Items.Add(product);
            }
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển trên giao diện
            string nguoidat = txtnguoidat.Text;
            DateTime ngaydat = datengaydat.Value;
            int soluong = (int)numsl.Value;

            // Duyệt qua các mục đã chọn trong ckldanhmuc
            foreach (string product in ckldanhmuc.CheckedItems)
            {
                decimal tongtien = productPrices[product];
                decimal thanhtien = tongtien * soluong;

                // Tạo một ListViewItem mới và thêm vào ListView
                var listViewItem = new ListViewItem(serialNumber.ToString());
                listViewItem.SubItems.Add($"{nguoidat}_{product}");
                listViewItem.SubItems.Add(ngaydat.ToShortDateString());
                listViewItem.SubItems.Add(soluong.ToString());
                listViewItem.SubItems.Add(tongtien.ToString("N0"));
                listViewItem.SubItems.Add(thanhtien.ToString("N0"));

                lvdanhsach.Items.Add(listViewItem);
                serialNumber++;
            }
            // Xóa chọn các mục trong ckldanhmuc
            for (int i = 0; i < ckldanhmuc.Items.Count; i++)
            {
                ckldanhmuc.SetItemChecked(i, false);
            }
        }

        private void txtnguoidat_TextChanged(object sender, EventArgs e)
        {

        }

        private void datengaydat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numsl_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ckldanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tensanpham = ckldanhmuc.SelectedItem.ToString();
            if (ckldanhmuc.SelectedItems.Count > 0)
            {
                try
                {
                    pichinh.Load(tensanpham + ".jpg");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tìm thấy hình ảnh.");
                    pichinh.Image = null;
                }
            }
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            txtnguoidat.Clear();
            txttongtien.Clear();
            txttienphaitra.Clear();
            txtgiamgia.Clear();
            lvdanhsach.Clear();
            numsl.Value = 1;
        }

        private void btntinhtien_Click(object sender, EventArgs e)
        {
            // Tính tổng tiền của tất cả các đơn hàng trong lvdanhsach
            decimal tongtien = 0;
            foreach (ListViewItem item in lvdanhsach.Items)
            {
                tongtien += decimal.Parse(item.SubItems[5].Text.Replace(",", ""));
            }
            // Áp dụng giảm giá dựa trên tổng tiền
            decimal tienphaitra = 0;
            if (tongtien > 10000)
            {
                tienphaitra = tongtien * 0.08m;
            }
            else if (tongtien >= 5000)
            {
                tienphaitra = tongtien * 0.03m;
            }
            // Hiển thị tổng tiền, giảm giá và số tiền phải trả lên các TextBox
            txttongtien.Text = tongtien.ToString("N0");
            txtgiamgia.Text = tienphaitra.ToString("N0");
            txttienphaitra.Text = (tongtien - tienphaitra).ToString("N0");
        }

        private void ckldanhmuc_Click(object sender, EventArgs e)
        {
            
        }

        private void ckldanhmuc_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }
    }
}
