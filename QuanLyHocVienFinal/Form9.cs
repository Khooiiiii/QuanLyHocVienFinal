using System.Data;
using System.Data.SqlClient;

namespace QuanLyHocVienFinal
{
    public partial class Form9 : Form
    {
        Boolean add;
        public Form9()
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
            textBox6.ResetText();
            textBox7.ResetText();
            textBox8.ResetText();
            textBox9.ResetText();
            textBox10.ResetText();
            textBox11.ResetText();
            textBox12.ResetText();
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string sql = "select * from sodiem";
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

        private void Form9_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
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
            textBox6.ResetText();
            textBox7.ResetText();
            textBox8.ResetText();
            textBox9.ResetText();
            textBox10.ResetText();
            textBox11.ResetText();
            textBox12.ResetText();
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
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString()?.Trim();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString()?.Trim();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString()?.Trim();
            textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString()?.Trim();
            textBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString()?.Trim();
            textBox11.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString()?.Trim();
            textBox12.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString()?.Trim();
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
                sql = "insert into sodiem values(@MaMH,@MaHV,@MaLop,@MaGV,@XepLoai,@DiemHS1,@DiemHS2,@ThiHk1,@ThiHk2,@TBMHK1,@TBMHK2,@TBMCN)";
                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@MaMH", textBox1.Text);
                command.Parameters.AddWithValue("@MaHV", textBox2.Text);
                command.Parameters.AddWithValue("@MaLop", textBox3.Text);
                command.Parameters.AddWithValue("@MaGV", textBox4.Text);
                command.Parameters.AddWithValue("@XepLoai", textBox5.Text);
                command.Parameters.AddWithValue("@DiemHS1", textBox6.Text);
                command.Parameters.AddWithValue("@DiemHS2", textBox7.Text);
                command.Parameters.AddWithValue("@ThiHk1", textBox8.Text);
                command.Parameters.AddWithValue("@ThiHk2", textBox9.Text);
                command.Parameters.AddWithValue("@TBMHK1", textBox10.Text);
                command.Parameters.AddWithValue("@TBMHK2", textBox11.Text);
                command.Parameters.AddWithValue("@TBMCN", textBox12.Text);

                command.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Đã thêm xong!");
            }
            if (!add)
            {

                sql = "update sodiem set MaMH=@MaMH,MaHV=@MaHV,MaLop=@MaLop,MaGV=@MaGV,XepLoai=@XepLoai,DiemHS1=@DiemHS1,DiemHS2=@DiemHS2,ThiHk1=@ThiHk1,ThiHk2=@ThiHk2,TBMHK1=@TBMHK1,TBMHK2=@TBMHK2,TBMCN=@TBMCN where MaMH=@MaMHData";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@MaMH", textBox1.Text);
                command.Parameters.AddWithValue("@MaHV", textBox2.Text);
                command.Parameters.AddWithValue("@MaLop", textBox3.Text);
                command.Parameters.AddWithValue("@MaGV", textBox4.Text);
                command.Parameters.AddWithValue("@XepLoai", textBox5.Text);
                command.Parameters.AddWithValue("@DiemHS1", textBox6.Text);
                command.Parameters.AddWithValue("@DiemHS2", textBox7.Text);
                command.Parameters.AddWithValue("@ThiHk1", textBox8.Text);
                command.Parameters.AddWithValue("@ThiHk2", textBox9.Text);
                command.Parameters.AddWithValue("@TBMHK1", textBox10.Text);
                command.Parameters.AddWithValue("@TBMHK2", textBox11.Text);
                command.Parameters.AddWithValue("@TBMCN", textBox12.Text);
                command.Parameters.AddWithValue("@MaMHData", dataGridView1.CurrentRow.Cells[0].Value.ToString()?.Trim());
                command.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=KHOOIIIII\\SQLEXPRESS;Initial Catalog=quanlyhocvien;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string sql = "delete from sodiem where MaMH=@MaMH";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@MaMH", dataGridView1.CurrentRow.Cells[0].Value.ToString()?.Trim());
                command.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Đã xóa xong!");
            }
            catch (Exception)
            {
                MessageBox.Show("Không xóa được!");
            }


        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }
    }
}
