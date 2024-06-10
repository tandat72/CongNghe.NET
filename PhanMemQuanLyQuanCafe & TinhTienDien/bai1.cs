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
    public partial class bai1 : Form
    {
        string ten;
        string hinh;
        float dg;
        int sohoadon = 0;
        public bai1()
        {
            InitializeComponent();
        }

        private void btnbanhmi_Click(object sender, EventArgs e)
        {
            hinh = "banhmi.jpg";
            ten = "Bành mì";
            dg = 45;
            pichinh.Load(hinh);
        }

        private void btnpastry_Click(object sender, EventArgs e)
        {
            hinh = "pastry.jpg";
            ten = "Pastry";
            dg = 32;
            pichinh.Load(hinh);
        }
        private void btnmuffin_Click(object sender, EventArgs e)
        {
            hinh = "muffin.jpg";
            ten = "Muffin";
            dg = 35;
            pichinh.Load(hinh);
        }
        private void btncake_Click(object sender, EventArgs e)
        {
            hinh = "cheesecake.jpg";
            ten = "Cheesecake";
            dg = 35;
            pichinh.Load(hinh);
        }

        private void btnpizza_Click(object sender, EventArgs e)
        {
            hinh = "pizza.jpg";
            ten = "Pizza";
            dg = 65;
            pichinh.Load(hinh);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hinh = "phinsuada.jpg";
            ten = "Phin sữa đá";
            dg = 28;
            pichinh.Load(hinh);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hinh = "bacxiu.jpg";
            ten = "Bạc xỉu";
            dg = 35;
            pichinh.Load(hinh);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hinh = "espresso.jpg";
            ten = "Espresso";
            dg = 28;
            pichinh.Load(hinh);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hinh = "latte.jpg";
            ten = "Latte";
            dg = 30;
            pichinh.Load(hinh);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hinh = "capuccino.jpg";
            ten = "Capuccino";
            dg = 38;
            pichinh.Load(hinh);
        }
        int ktra(string ten)
        {
            for (int i = 0; i < lvdanhsach.Items.Count; i++)
                if (ten == lvdanhsach.Items[i].SubItems[1].Text)
                    return i;
            return -1;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int n = lvdanhsach.Items.Count;
            if (ktra(ten) == -1)
            {
                lvdanhsach.Items.Add((n + 1).ToString());
                lvdanhsach.Items[n].SubItems.Add(ten);
                lvdanhsach.Items[n].SubItems.Add("1");
                lvdanhsach.Items[n].SubItems.Add(dg.ToString());
                lvdanhsach.Items[n].SubItems.Add(dg.ToString());
            }
            else
            {
                int i = ktra(ten);
                int sl = int.Parse(lvdanhsach.Items[i].SubItems[2].Text);
                float dg = float.Parse(lvdanhsach.Items[i].SubItems[3].Text);
                sl++;
                float tt = sl * dg;
                lvdanhsach.Items[i].SubItems[2].Text = sl.ToString();
                lvdanhsach.Items[i].SubItems[3].Text = dg.ToString();
                lvdanhsach.Items[i].SubItems[4].Text = tt.ToString();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lvdanhsach.SelectedItems.Count > 0)
            {
                for (int i = lvdanhsach.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem selectedItem = lvdanhsach.SelectedItems[i];
                    lvdanhsach.Items.Remove(selectedItem);
                }
            }
        }

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            sohoadon++;
            string masohoadon = "HD" + sohoadon.ToString("D3");
            txtsohoadon.Text = masohoadon;

            lvdanhsach.Items.Clear();
            txtthanhtien.Clear();
            txtgiamgia.Clear();
            txtsotienphaitra.Clear();

            txtgiovao.Text = DateTime.Now.ToShortTimeString();
        }

        private void btntinhtien_Click(object sender, EventArgs e)
        {
            float tongTien = 0;
            float giamGia = 0;
            float soTienPhaiTra = 0;

            // Tính tổng tiền của các món trong ListView
            foreach (ListViewItem item in lvdanhsach.Items)
            {
                float donGia = float.Parse(item.SubItems[2].Text.Replace(",", ""));
                int soLuong = int.Parse(item.SubItems[3].Text);
                float thanhTien = float.Parse(item.SubItems[4].Text.Replace(",", ""));

                tongTien += thanhTien;
            }
            if (tongTien > 100)
            {
                giamGia = tongTien * 0.05f;
            }
            soTienPhaiTra = tongTien - giamGia;
            txtthanhtien.Text = tongTien.ToString("#,###");
            txtgiamgia.Text = giamGia.ToString("#,###");
            txtsotienphaitra.Text = soTienPhaiTra.ToString("#,###");

            txtgiora.Text = DateTime.Now.ToShortTimeString();
        }

        
    }
}
