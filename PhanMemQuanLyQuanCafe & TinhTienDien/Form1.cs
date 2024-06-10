namespace kiemtra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbai1_Click(object sender, EventArgs e)
        {
            bai1 vd = new bai1();
            vd.Show();
        }

        private void btnbai2_Click(object sender, EventArgs e)
        {
            bai2 vd = new bai2();
            vd.Show();
        }
    }
}