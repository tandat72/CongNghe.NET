using System.Xml.Linq;

namespace bai2
{
    public partial class Form1 : Form
    {
        string ten, monchuyen;
        float toan, anhvan, van, diemxettuyen;

        private void numanhvan_ValueChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            // Xóa bất kỳ mục nào trong ListView thống kê trước khi thêm mới
            lvthongke.Items.Clear();

            // Duyệt qua danh sách sinh viên và thống kê số học sinh của từng môn chuyên
            foreach (ListViewItem item in lvdanhsach.Items)
            {
                string monChuyen = item.SubItems[4].Text.Split('_')[0]; // Lấy tên môn chuyên từ dòng "môn chuyên_điểm"
                bool monChuyenDaThongKe = false;

                // Kiểm tra xem môn chuyên đã được thống kê chưa
                foreach (ListViewItem thongKeItem in lvthongke.Items)
                {
                    if (thongKeItem.SubItems[0].Text == monChuyen)
                    {
                        // Tăng số học sinh cho môn chuyên đã tồn tại trong ListView thống kê
                        int soHocSinh = int.Parse(thongKeItem.SubItems[1].Text);
                        soHocSinh++;
                        thongKeItem.SubItems[1].Text = soHocSinh.ToString();
                        monChuyenDaThongKe = true;
                        break;
                    }
                }

                // Nếu môn chuyên chưa được thống kê, thêm một mục mới vào ListView thống kê
                if (!monChuyenDaThongKe)
                {
                    string[] row = { monChuyen, "1" };
                    ListViewItem lvi = new ListViewItem(row);
                    lvthongke.Items.Add(lvi);
                }
            }
        }

        private void lvdanhsach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbmonchuyen.Items.Add("Toán");
            cbmonchuyen.Items.Add("Anh văn");
            cbmonchuyen.Items.Add("Hóa");
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

            ten = txthoten.Text;
            van = (float)numvan.Value;
            toan = (float)numtoan.Value;
            anhvan = (float)numanhvan.Value;
            monchuyen = cbmonchuyen.SelectedItem.ToString();
            float diemMonChuyen = (float)nummonchuyen.Value;
            diemxettuyen = (van + toan) * 2 + anhvan;

            int n = lvdanhsach.Items.Count;
            if (ktra(ten) == -1)
            {
                ListViewItem item = new ListViewItem(new string[] { ten, van.ToString("0.00"), toan.ToString("0.00"), anhvan.ToString("0.00"), $"{monchuyen}_{diemMonChuyen}", diemxettuyen.ToString() });
                lvdanhsach.Items.Add(item);
                lbsohsdangky.Text = "Danh sách học sinh đăng ký: " + lvdanhsach.Items.Count;
            }
            else
            {
                int i = ktra(ten);
                int sl = int.Parse(lvdanhsach.Items[i].SubItems[2].Text);
                sl++;
                lvdanhsach.Items[i].SubItems[2].Text = sl.ToString();
                lvdanhsach.Items[i].SubItems[5].Text = (sl * diemxettuyen).ToString();
            }
        }
    }
}