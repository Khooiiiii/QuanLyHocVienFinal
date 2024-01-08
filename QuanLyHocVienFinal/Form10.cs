using System.Data;
using System.Data.SqlClient;

namespace QuanLyHocVienFinal
{
    public partial class Form10 : Form
    {
        Boolean add;
        public Form10()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string connectionString = "Data Source=KHOOIIIII\\SQLEXPRESS;Initial Catalog=quanlyhocvien;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnReturn.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string sql = "select * from lop";
                SqlCommand command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                dataGridView1.Refresh();
                dataGridView1.DataSource = table;
                connection.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung");
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void Form10_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = new Form1();
            form.Show();
            this.Hide();

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add = true;
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnReturn.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            textBox1.Focus();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            add = false;
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString()?.Trim();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString()?.Trim();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString()?.Trim();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString()?.Trim();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString()?.Trim();
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnReturn.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            textBox1.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=KHOOIIIII\\SQLEXPRESS;Initial Catalog=quanlyhocvien;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string sql;
            if (add)
            {
                try
                {
                    sql = "insert into lop values(@MaLop,@MaGv,@MaHV,@TenLop,@SiSo)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MaLop", textBox1.Text);
                    command.Parameters.AddWithValue("@MaGv", textBox2.Text);
                    command.Parameters.AddWithValue("@MaHV", textBox3.Text);
                    command.Parameters.AddWithValue("@TenLop", textBox4.Text);
                    command.Parameters.AddWithValue("@SiSo", textBox5.Text);
                    command.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã thêm xong");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được");
                }
            }
            if (!add)
            {
                try
                {
                    sql = "update lop set MaLop=@MaLop,MaGv=@MaGv,MaHV=@MaHV,TenLop=@TenLop,SiSo=@SiSo where MaLop=@MaLopData";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MaLop", textBox1.Text);
                    command.Parameters.AddWithValue("@MaGv", textBox2.Text);
                    command.Parameters.AddWithValue("@MaHV", textBox3.Text);
                    command.Parameters.AddWithValue("@TenLop", textBox4.Text);
                    command.Parameters.AddWithValue("@SiSo", textBox5.Text);
                    command.Parameters.AddWithValue("@MaLopData", dataGridView1.CurrentRow.Cells[0].Value.ToString()?.Trim());
                    command.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã sửa xong");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được");
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=KHOOIIIII\\SQLEXPRESS;Initial Catalog=quanlyhocvien;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string sql;
            try
            {
                sql = "delete from lop where MaLop=@MaLop";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@MaLop", dataGridView1.CurrentRow.Cells[0].Value.ToString()?.Trim());
                command.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Đã xóa xong");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được");
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.Show();
            this.Hide();

        }
    }
}
