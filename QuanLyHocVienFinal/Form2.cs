namespace QuanLyHocVienFinal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.inpUser.Text == "abc") && (this.inpPass.Text == "abc"))
            {
                Form form = new Form1();
                this.Hide();
                form.Show();
            }

            else
            {
                MessageBox.Show("Không đúng tên người dùng / mật khẩu !!!", "Thông báo");
                this.inpUser.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();

        }
    }
}
