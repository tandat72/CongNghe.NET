using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiemtra
{
    public partial class bai2 : Form
    {

        public bai2()
        {
            InitializeComponent();
        }

        private void bai2_Load(object sender, EventArgs e)
        {
            lvbanggia.Items.Add("Bậc 1");
            lvbanggia.Items[0].SubItems.Add("Từ 0-50kw");
            lvbanggia.Items[0].SubItems.Add("1.806 đồng/kWh");

            lvbanggia.Items.Add("Bậc 2");
            lvbanggia.Items[1].SubItems.Add("Từ 51-100kw");
            lvbanggia.Items[1].SubItems.Add("1.866 đồng/kWh");

            lvbanggia.Items.Add("Bậc 3");
            lvbanggia.Items[2].SubItems.Add("Từ 101-200kw");
            lvbanggia.Items[2].SubItems.Add("2.167 đồng/kWh");

            lvbanggia.Items.Add("Bậc 4");
            lvbanggia.Items[3].SubItems.Add("Từ 201-300kw");
            lvbanggia.Items[3].SubItems.Add("2.729 đồng/kWh");

            lvbanggia.Items.Add("Bậc 5");
            lvbanggia.Items[4].SubItems.Add("Từ 301-400kw");
            lvbanggia.Items[4].SubItems.Add("3.050 đồng/kWh");

            lvbanggia.Items.Add("Bậc 6");
            lvbanggia.Items[5].SubItems.Add("Trên 400 kwh");
            lvbanggia.Items[5].SubItems.Add("3.151 đồng/kWh");
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            // Lấy số kWh từ TextBox
            double soKw;
            if (!double.TryParse(txtsokw.Text, out soKw))
            {
                MessageBox.Show("Số kWh nhập không hợp lệ");
                return;
            }

            // Tính toán và hiển thị bảng kê chi tiết
            double tongThanhTien = 0;
            double remainingKw = soKw;

            foreach (ListViewItem item in lvbanggia.Items)
            {
                string khoangCach = item.SubItems[1].Text;
                double donGia = double.Parse(item.SubItems[2].Text.Replace(" đồng/kWh", "").Replace(".", ""));
                int khoangCachDau = 0, khoangCachCuoi = int.MaxValue;

                if (khoangCach.StartsWith("Từ"))
                {
                    string[] range = khoangCach.Replace("Từ ", "").Replace("kw", "").Split('-');
                    khoangCachDau = int.Parse(range[0]);
                    khoangCachCuoi = int.Parse(range[1]);

                    if (remainingKw > 0)
                    {
                        int maxKw = khoangCachCuoi - khoangCachDau + 1;

                        // Điều chỉnh giá trị maxKw cho bậc 1
                        if (khoangCachDau == 0 && khoangCachCuoi == 50)
                        {
                            maxKw = 50; // Đảm bảo sản lượng tối đa cho bậc 1 là 50
                        }

                        int usedKw = (int)Math.Min(remainingKw, maxKw);
                        remainingKw -= usedKw;

                        ListViewItem newItem = new ListViewItem(item.Text);
                        newItem.SubItems.Add(donGia.ToString());
                        newItem.SubItems.Add(usedKw.ToString());
                        double thanhTien = usedKw * donGia;
                        newItem.SubItems.Add(thanhTien.ToString());
                        lvdanhsach.Items.Add(newItem);
                        tongThanhTien += thanhTien;
                    }
                }
                else if (khoangCach.StartsWith("Trên"))
                {
                    khoangCachDau = int.Parse(khoangCach.Replace("Trên ", "").Replace(" kwh", "").Trim());

                    if (remainingKw > 0 && soKw > khoangCachDau)
                    {
                        ListViewItem newItem = new ListViewItem(item.Text);
                        newItem.SubItems.Add(donGia.ToString());
                        newItem.SubItems.Add(remainingKw.ToString());
                        double thanhTien = remainingKw * donGia;
                        newItem.SubItems.Add(thanhTien.ToString());
                        lvdanhsach.Items.Add(newItem);
                        tongThanhTien += thanhTien;
                        break;
                    }
                }
            }

            // Tính thuế GTGT và tổng cộng tiền thanh toán
            double thueGTGT = tongThanhTien * 0.08;
            double tongCongTienThanhToan = tongThanhTien + thueGTGT;

            // Hiển thị kết quả trên các TextBox
            txttongthanhtien.Text = tongThanhTien.ToString();
            txtthue.Text = thueGTGT.ToString();
            txttongtienthanhtoan.Text = tongCongTienThanhToan.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtsokw.Clear();
            lvdanhsach.Items.Clear();
            txttongthanhtien.Clear();
            txttongtienthanhtoan.Clear();
            txtthue.Clear();
        }
    }
}
