using System.Data;
using System.Data.SqlClient;
namespace QuanLyHocVienFinal
{
    public partial class Form3 : Form
    {
        Boolean add;
        public Form3()
        {
            InitializeComponent();
        }
        public void Form3_Load(object sender, EventArgs e)
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
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string sql = "select * from Namhoc";
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


        private void button2_Click(object sender, EventArgs e)
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
                    string sql = "delete from NamHoc where MaNH = @MaNamHoc";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MaNamHoc", dataGridView1.Rows[r].Cells[0].Value.ToString());
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
            else
            {
                MessageBox.Show("Chọn dòng cần xóa");
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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

        private void Form3_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Form form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
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
                    string sql = "insert into NamHoc values(@MaNamHoc, @TenNamHoc)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MaNamHoc", textBox1.Text);
                    command.Parameters.AddWithValue("@TenNamHoc", textBox2.Text);
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
                    string sql = "update NamHoc set TenNH = @TenNamHoc, MaNH=@MaNamHoc where MaNH = @MaNamHocData";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@MaNamHoc", textBox1.Text);
                    command.Parameters.AddWithValue("@TenNamHoc", textBox2.Text);
                    command.Parameters.AddWithValue("@MaNamHocData", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()?.Trim());
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
    }
}
