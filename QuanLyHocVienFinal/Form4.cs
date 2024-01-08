using System.Data;
using System.Data.SqlClient;

namespace QuanLyHocVienFinal
{
    public partial class Form4 : Form
    {
        Boolean add;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string sql = "select * from HocKy";
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

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
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
                    string sql = "insert into HocKy values(@MaHocKy,@MaNamHoc,@TenHocKy)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MaHocKy", textBox1.Text);
                    command.Parameters.AddWithValue("@MaNamHoc", textBox2.Text);
                    command.Parameters.AddWithValue("@TenHocKy", textBox3.Text);
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
                int r = dataGridView1.CurrentCell.RowIndex;
                string connectionString = "Data Source=KHOOIIIII\\SQLEXPRESS;Initial Catalog=quanlyhocvien;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    string sql = "update HocKy set MaHk=@MaHk, MaNH=@MaNH, TenHk=@TenHk where MaHK=@MaHKData";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MaHocKy", textBox1.Text);
                    command.Parameters.AddWithValue("@MaNH", textBox2.Text);
                    command.Parameters.AddWithValue("@TenHK", textBox3.Text);
                    command.Parameters.AddWithValue("@MaHKData", dataGridView1.Rows[r].Cells[0].Value.ToString()?.Trim());
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
            //Delete the selected row
            if (dataGridView1.CurrentCell != null)
            {
                int r = dataGridView1.CurrentCell.RowIndex;

                //delete in database
                string connectionString = "Data Source=KHOOIIIII\\SQLEXPRESS;Initial Catalog=quanlyhocvien;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    string sql = "delete from HocKy where MaHK=@MaHocKy";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MaHocKy", dataGridView1.Rows[r].Cells[0].Value.ToString());
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
            else
            {
                MessageBox.Show("Chọn dòng cần xóa");
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
