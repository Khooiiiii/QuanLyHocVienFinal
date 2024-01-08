namespace QuanLyHocVienFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            ToolStripMenuItemNamHoc = new ToolStripMenuItem();
            ToolStripMenuItemHocKy = new ToolStripMenuItem();
            ToolStripMenuItemMonHoc = new ToolStripMenuItem();
            ToolStripMenuItemHocVien = new ToolStripMenuItem();
            ToolStripMenuItemGiaoVien = new ToolStripMenuItem();
            ToolStripMenuItemPhongDaoTao = new ToolStripMenuItem();
            ToolStripMenuItemSoDiem = new ToolStripMenuItem();
            ToolStripMenuItemLop = new ToolStripMenuItem();
            ToolStripMenuItemPhuHuynh = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 34);
            label1.Name = "label1";
            label1.Size = new Size(655, 35);
            label1.TabIndex = 0;
            label1.Text = "TRUNG TÂM MẠNG MÁY TÍNH NHẤT NGHỆ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(246, 83);
            label2.Name = "label2";
            label2.Size = new Size(278, 32);
            label2.TabIndex = 1;
            label2.Text = "Lập Trình C# Cơ Bản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(309, 115);
            label3.Name = "label3";
            label3.Size = new Size(114, 22);
            label3.TabIndex = 2;
            label3.Text = "-----oOo-----";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(213, 169);
            label4.Name = "label4";
            label4.Size = new Size(311, 35);
            label4.TabIndex = 3;
            label4.Text = "QUẢN LÝ HỌC VIÊN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(396, 253);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(392, 125);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 80);
            label6.Name = "label6";
            label6.Size = new Size(53, 22);
            label6.TabIndex = 1;
            label6.Text = "Lớp: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 34);
            label5.Name = "label5";
            label5.Size = new Size(149, 22);
            label5.TabIndex = 0;
            label5.Text = "Người thực hiện: ";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItemNamHoc, ToolStripMenuItemHocKy, ToolStripMenuItemMonHoc, ToolStripMenuItemHocVien, ToolStripMenuItemGiaoVien, ToolStripMenuItemPhongDaoTao, ToolStripMenuItemSoDiem, ToolStripMenuItemLop, ToolStripMenuItemPhuHuynh });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(73, 24);
            toolStripMenuItem1.Text = "Quản lý";
            // 
            // ToolStripMenuItemNamHoc
            // 
            ToolStripMenuItemNamHoc.Name = "ToolStripMenuItemNamHoc";
            ToolStripMenuItemNamHoc.Size = new Size(245, 26);
            ToolStripMenuItemNamHoc.Text = "Quản lý năm học";
            ToolStripMenuItemNamHoc.Click += ToolStripMenuItemNamHoc_Click;
            // 
            // ToolStripMenuItemHocKy
            // 
            ToolStripMenuItemHocKy.Name = "ToolStripMenuItemHocKy";
            ToolStripMenuItemHocKy.Size = new Size(245, 26);
            ToolStripMenuItemHocKy.Text = "Quản lý học kỳ";
            ToolStripMenuItemHocKy.Click += ToolStripMenuItemHocKy_Click;
            // 
            // ToolStripMenuItemMonHoc
            // 
            ToolStripMenuItemMonHoc.Name = "ToolStripMenuItemMonHoc";
            ToolStripMenuItemMonHoc.Size = new Size(245, 26);
            ToolStripMenuItemMonHoc.Text = "Quản lý môn học";
            ToolStripMenuItemMonHoc.Click += ToolStripMenuItemMonHoc_Click;
            // 
            // ToolStripMenuItemHocVien
            // 
            ToolStripMenuItemHocVien.Name = "ToolStripMenuItemHocVien";
            ToolStripMenuItemHocVien.Size = new Size(245, 26);
            ToolStripMenuItemHocVien.Text = "Quản lý học viên";
            ToolStripMenuItemHocVien.Click += ToolStripMenuItemHocVien_Click;
            // 
            // ToolStripMenuItemGiaoVien
            // 
            ToolStripMenuItemGiaoVien.Name = "ToolStripMenuItemGiaoVien";
            ToolStripMenuItemGiaoVien.Size = new Size(245, 26);
            ToolStripMenuItemGiaoVien.Text = "Quản lý giáo viên";
            ToolStripMenuItemGiaoVien.Click += ToolStripMenuItemGiaoVien_Click;
            // 
            // ToolStripMenuItemPhongDaoTao
            // 
            ToolStripMenuItemPhongDaoTao.Name = "ToolStripMenuItemPhongDaoTao";
            ToolStripMenuItemPhongDaoTao.Size = new Size(245, 26);
            ToolStripMenuItemPhongDaoTao.Text = "Quản lý phòng đào tạo";
            ToolStripMenuItemPhongDaoTao.Click += ToolStripMenuItemPhongDaoTao_Click;
            // 
            // ToolStripMenuItemSoDiem
            // 
            ToolStripMenuItemSoDiem.Name = "ToolStripMenuItemSoDiem";
            ToolStripMenuItemSoDiem.Size = new Size(245, 26);
            ToolStripMenuItemSoDiem.Text = "Quản lý sổ điểm";
            ToolStripMenuItemSoDiem.Click += ToolStripMenuItemSoDiem_Click;
            // 
            // ToolStripMenuItemLop
            // 
            ToolStripMenuItemLop.Name = "ToolStripMenuItemLop";
            ToolStripMenuItemLop.Size = new Size(245, 26);
            ToolStripMenuItemLop.Text = "Quản lý lớp";
            ToolStripMenuItemLop.Click += ToolStripMenuItemLop_Click;
            // 
            // ToolStripMenuItemPhuHuynh
            // 
            ToolStripMenuItemPhuHuynh.Name = "ToolStripMenuItemPhuHuynh";
            ToolStripMenuItemPhuHuynh.Size = new Size(245, 26);
            ToolStripMenuItemPhuHuynh.Text = "Quản lý phụ huynh";
            ToolStripMenuItemPhuHuynh.Click += ToolStripMenuItemPhuHuynh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 387);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Màn hình chính";
            FormClosed += Form1_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem ToolStripMenuItemHocKy;
        private ToolStripMenuItem ToolStripMenuItemNamHoc;
        private ToolStripMenuItem ToolStripMenuItemMonHoc;
        private ToolStripMenuItem ToolStripMenuItemHocVien;
        private ToolStripMenuItem ToolStripMenuItemGiaoVien;
        private ToolStripMenuItem ToolStripMenuItemPhongDaoTao;
        private ToolStripMenuItem ToolStripMenuItemSoDiem;
        private ToolStripMenuItem ToolStripMenuItemLop;
        private ToolStripMenuItem ToolStripMenuItemPhuHuynh;
    }
}
