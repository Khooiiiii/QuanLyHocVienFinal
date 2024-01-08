using System.Data;
using System.Data.SqlClient;

namespace QuanLyHocVienFinal
{
    public partial class Form5 : Form
    {
        Boolean add;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadData();
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
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string sql = "select * from MonHoc";
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
            int r = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
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
            if (add)
            {
                string connectionString = "Data Source=KHOOIIIII\\SQLEXPRESS;Initial Catalog=quanlyhocvien;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    string sql = "insert into MonHoc values(@MaMonHoc,@MaGV,@MaHk,@TenMH)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MaMonHoc", textBox1.Text);
                    command.Parameters.AddWithValue("@MaGV", textBox2.Text);
                    command.Parameters.AddWithValue("@MaHk", textBox3.Text);
                    command.Parameters.AddWithValue("@TenMH", textBox4.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    LoadData();
                    MessageBox.Show("Thêm thành công");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được");
                }
            }
            else
            {
                string connectionString = "Data Source=KHOOIIIII\\SQLEXPRESS;Initial Catalog=quanlyhocvien;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    string sql = "update MonHoc set MaGV=@MaGV,MaHk=@MaHk,TenMH=@TenMH, MaMH=@MaMonHoc where MaMH=@MaMonHocData";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MaMonHoc", textBox1.Text);
                    command.Parameters.AddWithValue("@MaGV", textBox2.Text);
                    command.Parameters.AddWithValue("@MaHk", textBox3.Text);
                    command.Parameters.AddWithValue("@TenMH", textBox4.Text);
                    command.Parameters.AddWithValue("@MaMonHocData", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()?.Trim());
                    command.ExecuteNonQuery();
                    connection.Close();
                    LoadData();
                    MessageBox.Show("Sửa thành công");
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
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string sql = "delete from MonHoc where MaMH=@MaMonHoc";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@MaMonHoc", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()?.Trim());
                command.ExecuteNonQuery();
                connection.Close();
                LoadData();
                MessageBox.Show("Xóa thành công");
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
