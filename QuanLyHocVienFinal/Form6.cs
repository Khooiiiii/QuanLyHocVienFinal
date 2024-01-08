using System.Data;
using System.Data.SqlClient;

namespace QuanLyHocVienFinal
{
    public partial class Form6 : Form
    {
        Boolean add;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = new Form1();
            form.Show();
            this.Hide();

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
            textBox7.ResetText();
            textBox8.ResetText();
            dateTimePicker1.Refresh();
            radioButton1.Checked = true;
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                string sql = "select * from HocVien";
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
            textBox7.ResetText();
            textBox8.ResetText();
            radioButton1.Checked = true;
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnReturn.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            dateTimePicker1.Refresh();
            textBox1.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            add = false;
            textBox1.Focus();
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnReturn.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            dateTimePicker1.Refresh();
            textBox1.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[r].Cells[3].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.Rows[r].Cells[4].Value;
            if (dataGridView1.Rows[r].Cells[5].Value.ToString()?.Trim() == "nam")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            textBox7.Text = dataGridView1.Rows[r].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[r].Cells[7].Value.ToString();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (add)
            {
                string connectionString = "Data Source=KHOOIIIII\\SQLEXPRESS;Initial Catalog=quanlyhocvien;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string sql = "insert into HocVien values(@MaHV,@MaLop,@MaMH,@HoTenHV,@NgaySinhHV,@GioiTinhHV,@DiaChiHv,@SdtHV)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("MaHV", textBox1.Text);
                command.Parameters.AddWithValue("MaLop", textBox2.Text);
                command.Parameters.AddWithValue("MaMH", textBox3.Text);
                command.Parameters.AddWithValue("HoTenHV", textBox4.Text);
                command.Parameters.AddWithValue("NgaySinhHV", dateTimePicker1.Value);
                if (radioButton1.Checked)
                {
                    command.Parameters.AddWithValue("GioiTinhHV", "nam");
                }
                else
                {
                    command.Parameters.AddWithValue("GioiTinhHV", "nu");
                }
                command.Parameters.AddWithValue("DiaChiHv", textBox7.Text);
                command.Parameters.AddWithValue("SdtHV", textBox8.Text);
                int kq = (int)command.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                string connectionString = "Data Source=KHOOIIIII\\SQLEXPRESS;Initial Catalog=quanlyhocvien;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string sql = "update HocVien set MaHV=@MaHV, MaLop=@MaLop,MaMH=@MaMH,HoTenHV=@HoTenHV,NgaySinhHV=@NgaySinhHV,GioiTinhHV=@GioiTinhHV,DiaChiHv=@DiaChiHv,SdtHV=@SdtHV where MaHV=@MaHVData";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("MaHV", textBox1.Text);
                command.Parameters.AddWithValue("MaLop", textBox2.Text);
                command.Parameters.AddWithValue("MaMH", textBox3.Text);
                command.Parameters.AddWithValue("HoTenHV", textBox4.Text);
                command.Parameters.AddWithValue("NgaySinhHV", dateTimePicker1.Value);
                if (radioButton1.Checked)
                {
                    command.Parameters.AddWithValue("GioiTinhHV", "nam");
                }
                else
                {
                    command.Parameters.AddWithValue("GioiTinhHV", "nu");
                }
                command.Parameters.AddWithValue("DiaChiHv", textBox7.Text);
                command.Parameters.AddWithValue("SdtHV", textBox8.Text);
                command.Parameters.AddWithValue("MaHVData", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()?.Trim());
                int kq = (int)command.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            string connectionString = "Data Source=KHOOIIIII\\SQLEXPRESS;Initial Catalog=quanlyhocvien;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string sql = "delete from HocVien where MaHV=@MaHV";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("MaHV", dataGridView1.Rows[r].Cells[0].Value.ToString());
            int kq = (int)command.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.Show();
            this.Hide();

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadData();

        }
    }
}
