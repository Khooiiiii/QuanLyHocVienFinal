using System.Data;
using System.Data.SqlClient;

namespace QuanLyHocVienFinal
{
    public partial class Form8 : Form
    {
        Boolean add;
        public Form8()
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
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string sql = "select * from phongdaotao";
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

        private void Form8_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
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
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnReturn.Enabled = false;
            textBox1.Focus();


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            add = false;
            int r = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1.Rows[r].Cells[0].Value.ToString()?.Trim();
            textBox2.Text = dataGridView1.Rows[r].Cells[1].Value.ToString()?.Trim();
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnReturn.Enabled = false;
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
                    string sql = "insert into phongdaotao values(@MaGV, @MaCV)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MaGV", textBox1.Text);
                    command.Parameters.AddWithValue("@MaCV", textBox2.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Thêm thành công");
                    LoadData();
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
                    string sql = "update phongdaotao set MaGV=@MaGV, MaCV=@MaCV where MaGV=@MaGVData";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MaGV", textBox1.Text);
                    command.Parameters.AddWithValue("@MaCV", textBox2.Text);
                    command.Parameters.AddWithValue("@MaGVData", dataGridView1.CurrentRow.Cells["MaGV"].Value.ToString()?.Trim());
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Sửa thành công");
                    LoadData();
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
                string sql = "delete from phongdaotao where MaGV=@MaGV";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@MaGV", dataGridView1.CurrentRow.Cells["MaGV"].Value.ToString()?.Trim());
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Xóa thành công");
                LoadData();
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
