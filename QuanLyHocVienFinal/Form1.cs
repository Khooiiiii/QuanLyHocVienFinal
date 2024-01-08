namespace QuanLyHocVienFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ToolStripMenuItemHocKy_Click(object sender, EventArgs e)
        {
            Form form = new Form4();
            form.Show();
            this.Hide();
        }

        private void ToolStripMenuItemNamHoc_Click(object sender, EventArgs e)
        {
            //open form 3 and close this
            Form form = new Form3();
            form.Show();
            this.Hide();
        }

        private void ToolStripMenuItemMonHoc_Click(object sender, EventArgs e)
        {
            Form form = new Form5();
            form.Show();
            this.Hide();
        }

        private void ToolStripMenuItemHocVien_Click(object sender, EventArgs e)
        {
            Form form = new Form6();
            form.Show();
            this.Hide();
        }

        private void ToolStripMenuItemGiaoVien_Click(object sender, EventArgs e)
        {
            Form form = new Form7();
            form.Show();
            this.Hide();
        }

        private void ToolStripMenuItemPhongDaoTao_Click(object sender, EventArgs e)
        {
            Form form = new Form8();
            form.Show();
            this.Hide();
        }

        private void ToolStripMenuItemSoDiem_Click(object sender, EventArgs e)
        {
            Form form = new Form9();
            form.Show();
            this.Hide();
        }

        private void ToolStripMenuItemLop_Click(object sender, EventArgs e)
        {
            Form form = new Form10();
            form.Show();
            this.Hide();
        }

        private void ToolStripMenuItemPhuHuynh_Click(object sender, EventArgs e)
        {
            Form form = new Form11();
            form.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
