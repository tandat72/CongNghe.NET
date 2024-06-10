using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt1
{
    public partial class Form1 : Form
    {
        private Dictionary<string, decimal> foods;
        private int serialNumber = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void ckldanhsach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbban.Items.Add("Bàn 1");
            cbban.Items.Add("Bàn 2");
            cbban.Items.Add("Bàn 3");
            cbban.Items.Add("Bàn 4");
            cbban.Items.Add("Bàn 5");
            numsl.Value = 1;
            numsl.Maximum = 10;
            foods = new Dictionary<string, decimal>
            {
                { "Gỏi cuốn", 10000 },
                { "Bánh plan", 20000 },
                { "Bún thịt nướng", 30000 },
                { "Gá hấp chao", 40000 }
            };
            foreach (var product in foods.Keys)
            {
                ckldanhsach.Items.Add(product);
            }
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển trên giao diện
            string ban = cbban.Text;
            int soluong = (int)numsl.Value;

            // Duyệt qua các mục đã chọn trong ckldanhmuc
            foreach (string product in ckldanhsach.CheckedItems)
            {
                decimal tongtien = foods[product];
                decimal thanhtien = tongtien * soluong;

                // Tạo một ListViewItem mới và thêm vào ListView
                var listViewItem = new ListViewItem(serialNumber.ToString());
                listViewItem.SubItems.Add(product.ToString());
                listViewItem.SubItems.Add(ban.ToString());
                listViewItem.SubItems.Add(soluong.ToString());
                listViewItem.SubItems.Add(tongtien.ToString("N0"));
                listViewItem.SubItems.Add(thanhtien.ToString("N0"));

                lvdanhsach.Items.Add(listViewItem);
                serialNumber++;
            }
            // Xóa chọn các mục trong ckldanhmuc
            for (int i = 0; i < ckldanhsach.Items.Count; i++)
            {
                ckldanhsach.SetItemChecked(i, false);
            }
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            float tien = 0;
            for (int i = 0; i < lvdanhsach.Items.Count; i++)
            {
                float parsedValue;
                if (float.TryParse(lvdanhsach.Items[i].SubItems[5].Text, out parsedValue))
                {
                    tien += parsedValue;
                }
            }
            lbltongthanhtien.Text = "Tổng thành tiền là: " + tien;

        }
    }
}
