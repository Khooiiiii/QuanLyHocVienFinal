namespace QuanLyHocVienFinal
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnReturn = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            btnReload = new Button();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnEdit = new Button();
            btnDel = new Button();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(791, 428);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(113, 47);
            btnReturn.TabIndex = 18;
            btnReturn.Text = "Trở về";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(553, 428);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(113, 47);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(434, 428);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 47);
            btnSave.TabIndex = 16;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReload
            // 
            btnReload.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReload.Location = new Point(77, 428);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(113, 47);
            btnReload.TabIndex = 15;
            btnReload.Text = "Reload";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnReload_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(77, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(843, 125);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(175, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(336, 34);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(175, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(336, 34);
            textBox1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 80);
            label6.Name = "label6";
            label6.Size = new Size(121, 26);
            label6.TabIndex = 1;
            label6.Text = "Mã chức vụ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 34);
            label5.Name = "label5";
            label5.Size = new Size(132, 26);
            label5.TabIndex = 0;
            label5.Text = "Mã giáo viên";
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(315, 428);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(113, 47);
            btnEdit.TabIndex = 13;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDel.Location = new Point(672, 428);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(113, 47);
            btnDel.TabIndex = 12;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(196, 428);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 47);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(77, 162);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(843, 246);
            dataGridView1.TabIndex = 10;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 492);
            Controls.Add(btnReturn);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnReload);
            Controls.Add(groupBox1);
            Controls.Add(btnEdit);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form8";
            FormClosed += Form8_FormClosed;
            Load += Form8_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnReturn;
        private Button btnCancel;
        private Button btnSave;
        private Button btnReload;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Button btnEdit;
        private Button btnDel;
        private Button btnAdd;
        private DataGridView dataGridView1;
    }
}