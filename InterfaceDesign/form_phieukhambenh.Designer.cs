﻿
namespace InterfaceDesign
{
    partial class form_phieukhambenh
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
            this.lv_PKB = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtb_TrieuChung = new System.Windows.Forms.TextBox();
            this.txtb_MaBenhNhan = new System.Windows.Forms.TextBox();
            this.txtb_MaPhieuKham_PKB = new System.Windows.Forms.TextBox();
            this.dtbx_NgayKham = new System.Windows.Forms.DateTimePicker();
            this.lb_TrieuChung = new System.Windows.Forms.Label();
            this.lb_NgayKham = new System.Windows.Forms.Label();
            this.lb_MaBenhNhan = new System.Windows.Forms.Label();
            this.lb_MaPhieuKham_PKB = new System.Windows.Forms.Label();
            this.lb_PhieuKhamBenh = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_PKB = new System.Windows.Forms.TextBox();
            this.txtb_CTBenh = new System.Windows.Forms.TextBox();
            this.cbx_TenLoaiBenh = new System.Windows.Forms.ComboBox();
            this.txtb_MaPhieuKham_CTBenh = new System.Windows.Forms.TextBox();
            this.lv_ChiTietBenh = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_TenLoaiBenh = new System.Windows.Forms.Label();
            this.lb_MaPhieuKham_CTBenh = new System.Windows.Forms.Label();
            this.lb_ChiTietBenh = new System.Windows.Forms.Label();
            this.cbx_TenThuoc = new System.Windows.Forms.ComboBox();
            this.lv_CTPKB = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtb_LieuDung = new System.Windows.Forms.TextBox();
            this.lb_LieuDung = new System.Windows.Forms.Label();
            this.txtb_SoLuong = new System.Windows.Forms.TextBox();
            this.lb_SoLuong = new System.Windows.Forms.Label();
            this.txtb_MaPhieuKham_CTPKB = new System.Windows.Forms.TextBox();
            this.lb_TenThuoc = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lb_ChiTietPhieuKhamBenh = new System.Windows.Forms.Label();
            this.btn_Sua_SuaChiTietBenh = new System.Windows.Forms.Button();
            this.btn_Xoa_XoaChiTietBenh = new System.Windows.Forms.Button();
            this.btn_Them_ThemChiTietBenh = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lb_MaPhieuKham_CTPKB = new System.Windows.Forms.Label();
            this.btn_Sua_SuaPKB = new System.Windows.Forms.Button();
            this.btn_Xoa_XoaPKB = new System.Windows.Forms.Button();
            this.btn_Them_ThemPKB = new System.Windows.Forms.Button();
            this.btn_Sua_SuaChiTietPKN = new System.Windows.Forms.Button();
            this.btn_Xoa_XoaChiTietPKB = new System.Windows.Forms.Button();
            this.btn_Them_ThemChiTietPKB = new System.Windows.Forms.Button();
            this.btn_TrangChu_PKB = new System.Windows.Forms.Button();
            this.btn_TroVe_PKB = new System.Windows.Forms.Button();
            this.btn_Luu_CTB = new System.Windows.Forms.Button();
            this.btn_Luu_PKB = new System.Windows.Forms.Button();
            this.btn_Luu_CTPKB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_PKB
            // 
            this.lv_PKB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lv_PKB.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lv_PKB.FullRowSelect = true;
            this.lv_PKB.GridLines = true;
            this.lv_PKB.HideSelection = false;
            this.lv_PKB.Location = new System.Drawing.Point(67, 347);
            this.lv_PKB.Margin = new System.Windows.Forms.Padding(2);
            this.lv_PKB.Name = "lv_PKB";
            this.lv_PKB.Size = new System.Drawing.Size(522, 347);
            this.lv_PKB.TabIndex = 45;
            this.lv_PKB.UseCompatibleStateImageBehavior = false;
            this.lv_PKB.View = System.Windows.Forms.View.Details;
            this.lv_PKB.VirtualMode = true;
            this.lv_PKB.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã PK ";
            this.columnHeader1.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã BN";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày khám";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Triệu chứng";
            this.columnHeader4.Width = 127;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tiền thuốc";
            this.columnHeader5.Width = 113;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tiền khám";
            this.columnHeader6.Width = 115;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tổng tiền";
            this.columnHeader7.Width = 78;
            // 
            // txtb_TrieuChung
            // 
            this.txtb_TrieuChung.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_TrieuChung.Location = new System.Drawing.Point(255, 227);
            this.txtb_TrieuChung.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_TrieuChung.Multiline = true;
            this.txtb_TrieuChung.Name = "txtb_TrieuChung";
            this.txtb_TrieuChung.Size = new System.Drawing.Size(315, 38);
            this.txtb_TrieuChung.TabIndex = 41;
            this.txtb_TrieuChung.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtb_MaBenhNhan
            // 
            this.txtb_MaBenhNhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_MaBenhNhan.Location = new System.Drawing.Point(255, 130);
            this.txtb_MaBenhNhan.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_MaBenhNhan.Multiline = true;
            this.txtb_MaBenhNhan.Name = "txtb_MaBenhNhan";
            this.txtb_MaBenhNhan.Size = new System.Drawing.Size(146, 29);
            this.txtb_MaBenhNhan.TabIndex = 40;
            this.txtb_MaBenhNhan.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtb_MaPhieuKham_PKB
            // 
            this.txtb_MaPhieuKham_PKB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_MaPhieuKham_PKB.Location = new System.Drawing.Point(255, 81);
            this.txtb_MaPhieuKham_PKB.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_MaPhieuKham_PKB.Multiline = true;
            this.txtb_MaPhieuKham_PKB.Name = "txtb_MaPhieuKham_PKB";
            this.txtb_MaPhieuKham_PKB.Size = new System.Drawing.Size(146, 29);
            this.txtb_MaPhieuKham_PKB.TabIndex = 39;
            this.txtb_MaPhieuKham_PKB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtbx_NgayKham
            // 
            this.dtbx_NgayKham.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dtbx_NgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbx_NgayKham.Location = new System.Drawing.Point(255, 177);
            this.dtbx_NgayKham.Margin = new System.Windows.Forms.Padding(2);
            this.dtbx_NgayKham.Name = "dtbx_NgayKham";
            this.dtbx_NgayKham.Size = new System.Drawing.Size(146, 34);
            this.dtbx_NgayKham.TabIndex = 38;
            this.dtbx_NgayKham.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lb_TrieuChung
            // 
            this.lb_TrieuChung.AutoSize = true;
            this.lb_TrieuChung.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_TrieuChung.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TrieuChung.Location = new System.Drawing.Point(75, 238);
            this.lb_TrieuChung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TrieuChung.Name = "lb_TrieuChung";
            this.lb_TrieuChung.Size = new System.Drawing.Size(127, 27);
            this.lb_TrieuChung.TabIndex = 37;
            this.lb_TrieuChung.Text = "Triệu chứng";
            this.lb_TrieuChung.Click += new System.EventHandler(this.label9_Click);
            // 
            // lb_NgayKham
            // 
            this.lb_NgayKham.AutoSize = true;
            this.lb_NgayKham.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_NgayKham.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayKham.Location = new System.Drawing.Point(75, 183);
            this.lb_NgayKham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_NgayKham.Name = "lb_NgayKham";
            this.lb_NgayKham.Size = new System.Drawing.Size(122, 27);
            this.lb_NgayKham.TabIndex = 36;
            this.lb_NgayKham.Text = "Ngày khám";
            this.lb_NgayKham.Click += new System.EventHandler(this.label8_Click);
            // 
            // lb_MaBenhNhan
            // 
            this.lb_MaBenhNhan.AutoSize = true;
            this.lb_MaBenhNhan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_MaBenhNhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaBenhNhan.Location = new System.Drawing.Point(75, 132);
            this.lb_MaBenhNhan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MaBenhNhan.Name = "lb_MaBenhNhan";
            this.lb_MaBenhNhan.Size = new System.Drawing.Size(159, 27);
            this.lb_MaBenhNhan.TabIndex = 35;
            this.lb_MaBenhNhan.Text = "Mã Bệnh Nhân";
            this.lb_MaBenhNhan.Click += new System.EventHandler(this.label7_Click);
            // 
            // lb_MaPhieuKham_PKB
            // 
            this.lb_MaPhieuKham_PKB.AutoSize = true;
            this.lb_MaPhieuKham_PKB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_MaPhieuKham_PKB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaPhieuKham_PKB.Location = new System.Drawing.Point(75, 82);
            this.lb_MaPhieuKham_PKB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MaPhieuKham_PKB.Name = "lb_MaPhieuKham_PKB";
            this.lb_MaPhieuKham_PKB.Size = new System.Drawing.Size(169, 27);
            this.lb_MaPhieuKham_PKB.TabIndex = 34;
            this.lb_MaPhieuKham_PKB.Text = "Mã Phiếu Khám";
            this.lb_MaPhieuKham_PKB.Click += new System.EventHandler(this.label6_Click);
            // 
            // lb_PhieuKhamBenh
            // 
            this.lb_PhieuKhamBenh.AutoSize = true;
            this.lb_PhieuKhamBenh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PhieuKhamBenh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_PhieuKhamBenh.Location = new System.Drawing.Point(195, 24);
            this.lb_PhieuKhamBenh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_PhieuKhamBenh.Name = "lb_PhieuKhamBenh";
            this.lb_PhieuKhamBenh.Size = new System.Drawing.Size(235, 35);
            this.lb_PhieuKhamBenh.TabIndex = 33;
            this.lb_PhieuKhamBenh.Text = "Phiếu khám bệnh";
            this.lb_PhieuKhamBenh.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 29;
            // 
            // txtb_PKB
            // 
            this.txtb_PKB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtb_PKB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtb_PKB.Enabled = false;
            this.txtb_PKB.Location = new System.Drawing.Point(54, 43);
            this.txtb_PKB.Multiline = true;
            this.txtb_PKB.Name = "txtb_PKB";
            this.txtb_PKB.Size = new System.Drawing.Size(550, 662);
            this.txtb_PKB.TabIndex = 46;
            this.txtb_PKB.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtb_CTBenh
            // 
            this.txtb_CTBenh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtb_CTBenh.Enabled = false;
            this.txtb_CTBenh.Location = new System.Drawing.Point(665, 43);
            this.txtb_CTBenh.Multiline = true;
            this.txtb_CTBenh.Name = "txtb_CTBenh";
            this.txtb_CTBenh.Size = new System.Drawing.Size(629, 264);
            this.txtb_CTBenh.TabIndex = 47;
            this.txtb_CTBenh.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // cbx_TenLoaiBenh
            // 
            this.cbx_TenLoaiBenh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_TenLoaiBenh.FormattingEnabled = true;
            this.cbx_TenLoaiBenh.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbx_TenLoaiBenh.Location = new System.Drawing.Point(860, 155);
            this.cbx_TenLoaiBenh.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_TenLoaiBenh.Name = "cbx_TenLoaiBenh";
            this.cbx_TenLoaiBenh.Size = new System.Drawing.Size(139, 34);
            this.cbx_TenLoaiBenh.TabIndex = 56;
            this.cbx_TenLoaiBenh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtb_MaPhieuKham_CTBenh
            // 
            this.txtb_MaPhieuKham_CTBenh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_MaPhieuKham_CTBenh.Location = new System.Drawing.Point(860, 92);
            this.txtb_MaPhieuKham_CTBenh.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_MaPhieuKham_CTBenh.Multiline = true;
            this.txtb_MaPhieuKham_CTBenh.Name = "txtb_MaPhieuKham_CTBenh";
            this.txtb_MaPhieuKham_CTBenh.Size = new System.Drawing.Size(139, 34);
            this.txtb_MaPhieuKham_CTBenh.TabIndex = 50;
            this.txtb_MaPhieuKham_CTBenh.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // lv_ChiTietBenh
            // 
            this.lv_ChiTietBenh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9});
            this.lv_ChiTietBenh.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lv_ChiTietBenh.FullRowSelect = true;
            this.lv_ChiTietBenh.GridLines = true;
            this.lv_ChiTietBenh.HideSelection = false;
            this.lv_ChiTietBenh.Location = new System.Drawing.Point(1040, 62);
            this.lv_ChiTietBenh.Margin = new System.Windows.Forms.Padding(2);
            this.lv_ChiTietBenh.Name = "lv_ChiTietBenh";
            this.lv_ChiTietBenh.Size = new System.Drawing.Size(227, 173);
            this.lv_ChiTietBenh.TabIndex = 52;
            this.lv_ChiTietBenh.UseCompatibleStateImageBehavior = false;
            this.lv_ChiTietBenh.View = System.Windows.Forms.View.Details;
            this.lv_ChiTietBenh.VirtualMode = true;
            this.lv_ChiTietBenh.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "STT";
            this.columnHeader8.Width = 55;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên loại bệnh";
            this.columnHeader9.Width = 172;
            // 
            // lb_TenLoaiBenh
            // 
            this.lb_TenLoaiBenh.AutoSize = true;
            this.lb_TenLoaiBenh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_TenLoaiBenh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenLoaiBenh.Location = new System.Drawing.Point(687, 158);
            this.lb_TenLoaiBenh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TenLoaiBenh.Name = "lb_TenLoaiBenh";
            this.lb_TenLoaiBenh.Size = new System.Drawing.Size(143, 27);
            this.lb_TenLoaiBenh.TabIndex = 51;
            this.lb_TenLoaiBenh.Text = "Tên loại bệnh";
            this.lb_TenLoaiBenh.Click += new System.EventHandler(this.label15_Click);
            // 
            // lb_MaPhieuKham_CTBenh
            // 
            this.lb_MaPhieuKham_CTBenh.AutoSize = true;
            this.lb_MaPhieuKham_CTBenh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_MaPhieuKham_CTBenh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaPhieuKham_CTBenh.Location = new System.Drawing.Point(687, 94);
            this.lb_MaPhieuKham_CTBenh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MaPhieuKham_CTBenh.Name = "lb_MaPhieuKham_CTBenh";
            this.lb_MaPhieuKham_CTBenh.Size = new System.Drawing.Size(169, 27);
            this.lb_MaPhieuKham_CTBenh.TabIndex = 48;
            this.lb_MaPhieuKham_CTBenh.Text = "Mã Phiếu Khám";
            this.lb_MaPhieuKham_CTBenh.Click += new System.EventHandler(this.label14_Click);
            // 
            // lb_ChiTietBenh
            // 
            this.lb_ChiTietBenh.AutoSize = true;
            this.lb_ChiTietBenh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChiTietBenh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_ChiTietBenh.Location = new System.Drawing.Point(899, 20);
            this.lb_ChiTietBenh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ChiTietBenh.Name = "lb_ChiTietBenh";
            this.lb_ChiTietBenh.Size = new System.Drawing.Size(180, 35);
            this.lb_ChiTietBenh.TabIndex = 49;
            this.lb_ChiTietBenh.Text = "Chi tiết bệnh";
            this.lb_ChiTietBenh.Click += new System.EventHandler(this.label13_Click);
            // 
            // cbx_TenThuoc
            // 
            this.cbx_TenThuoc.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cbx_TenThuoc.FormattingEnabled = true;
            this.cbx_TenThuoc.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbx_TenThuoc.Location = new System.Drawing.Point(824, 424);
            this.cbx_TenThuoc.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_TenThuoc.Name = "cbx_TenThuoc";
            this.cbx_TenThuoc.Size = new System.Drawing.Size(204, 34);
            this.cbx_TenThuoc.TabIndex = 70;
            // 
            // lv_CTPKB
            // 
            this.lv_CTPKB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.lv_CTPKB.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lv_CTPKB.FullRowSelect = true;
            this.lv_CTPKB.GridLines = true;
            this.lv_CTPKB.HideSelection = false;
            this.lv_CTPKB.Location = new System.Drawing.Point(681, 575);
            this.lv_CTPKB.Margin = new System.Windows.Forms.Padding(2);
            this.lv_CTPKB.Name = "lv_CTPKB";
            this.lv_CTPKB.Size = new System.Drawing.Size(598, 122);
            this.lv_CTPKB.TabIndex = 69;
            this.lv_CTPKB.UseCompatibleStateImageBehavior = false;
            this.lv_CTPKB.View = System.Windows.Forms.View.Details;
            this.lv_CTPKB.VirtualMode = true;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "STT";
            this.columnHeader10.Width = 54;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Tên thuốc";
            this.columnHeader12.Width = 181;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Số lượng";
            this.columnHeader13.Width = 108;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Liều dùng";
            this.columnHeader14.Width = 115;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Thành tiền";
            this.columnHeader15.Width = 129;
            // 
            // txtb_LieuDung
            // 
            this.txtb_LieuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtb_LieuDung.Location = new System.Drawing.Point(823, 472);
            this.txtb_LieuDung.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_LieuDung.Name = "txtb_LieuDung";
            this.txtb_LieuDung.Size = new System.Drawing.Size(108, 34);
            this.txtb_LieuDung.TabIndex = 68;
            // 
            // lb_LieuDung
            // 
            this.lb_LieuDung.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lb_LieuDung.AutoSize = true;
            this.lb_LieuDung.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_LieuDung.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lb_LieuDung.Location = new System.Drawing.Point(696, 482);
            this.lb_LieuDung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_LieuDung.Name = "lb_LieuDung";
            this.lb_LieuDung.Size = new System.Drawing.Size(109, 27);
            this.lb_LieuDung.TabIndex = 67;
            this.lb_LieuDung.Text = "Liều dùng";
            // 
            // txtb_SoLuong
            // 
            this.txtb_SoLuong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_SoLuong.Location = new System.Drawing.Point(1147, 475);
            this.txtb_SoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_SoLuong.Name = "txtb_SoLuong";
            this.txtb_SoLuong.Size = new System.Drawing.Size(108, 34);
            this.txtb_SoLuong.TabIndex = 66;
            // 
            // lb_SoLuong
            // 
            this.lb_SoLuong.AutoSize = true;
            this.lb_SoLuong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_SoLuong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoLuong.Location = new System.Drawing.Point(1031, 475);
            this.lb_SoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_SoLuong.Name = "lb_SoLuong";
            this.lb_SoLuong.Size = new System.Drawing.Size(97, 27);
            this.lb_SoLuong.TabIndex = 65;
            this.lb_SoLuong.Text = "Số lượng";
            // 
            // txtb_MaPhieuKham_CTPKB
            // 
            this.txtb_MaPhieuKham_CTPKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtb_MaPhieuKham_CTPKB.Location = new System.Drawing.Point(885, 369);
            this.txtb_MaPhieuKham_CTPKB.Margin = new System.Windows.Forms.Padding(2);
            this.txtb_MaPhieuKham_CTPKB.Name = "txtb_MaPhieuKham_CTPKB";
            this.txtb_MaPhieuKham_CTPKB.Size = new System.Drawing.Size(143, 34);
            this.txtb_MaPhieuKham_CTPKB.TabIndex = 58;
            // 
            // lb_TenThuoc
            // 
            this.lb_TenThuoc.AutoSize = true;
            this.lb_TenThuoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_TenThuoc.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lb_TenThuoc.Location = new System.Drawing.Point(694, 426);
            this.lb_TenThuoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TenThuoc.Name = "lb_TenThuoc";
            this.lb_TenThuoc.Size = new System.Drawing.Size(109, 27);
            this.lb_TenThuoc.TabIndex = 62;
            this.lb_TenThuoc.Text = "Tên thuốc";
            this.lb_TenThuoc.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label17.Location = new System.Drawing.Point(759, 376);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 27);
            this.label17.TabIndex = 59;
            // 
            // lb_ChiTietPhieuKhamBenh
            // 
            this.lb_ChiTietPhieuKhamBenh.AutoSize = true;
            this.lb_ChiTietPhieuKhamBenh.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChiTietPhieuKhamBenh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_ChiTietPhieuKhamBenh.Location = new System.Drawing.Point(812, 321);
            this.lb_ChiTietPhieuKhamBenh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_ChiTietPhieuKhamBenh.Name = "lb_ChiTietPhieuKhamBenh";
            this.lb_ChiTietPhieuKhamBenh.Size = new System.Drawing.Size(344, 35);
            this.lb_ChiTietPhieuKhamBenh.TabIndex = 60;
            this.lb_ChiTietPhieuKhamBenh.Text = " Chi tiết phiếu khám bệnh";
            this.lb_ChiTietPhieuKhamBenh.Click += new System.EventHandler(this.label18_Click);
            // 
            // btn_Sua_SuaChiTietBenh
            // 
            this.btn_Sua_SuaChiTietBenh.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Sua_SuaChiTietBenh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua_SuaChiTietBenh.Location = new System.Drawing.Point(1201, 257);
            this.btn_Sua_SuaChiTietBenh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua_SuaChiTietBenh.Name = "btn_Sua_SuaChiTietBenh";
            this.btn_Sua_SuaChiTietBenh.Size = new System.Drawing.Size(66, 38);
            this.btn_Sua_SuaChiTietBenh.TabIndex = 73;
            this.btn_Sua_SuaChiTietBenh.Text = "Sửa";
            this.btn_Sua_SuaChiTietBenh.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa_XoaChiTietBenh
            // 
            this.btn_Xoa_XoaChiTietBenh.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Xoa_XoaChiTietBenh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_XoaChiTietBenh.Location = new System.Drawing.Point(1086, 257);
            this.btn_Xoa_XoaChiTietBenh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa_XoaChiTietBenh.Name = "btn_Xoa_XoaChiTietBenh";
            this.btn_Xoa_XoaChiTietBenh.Size = new System.Drawing.Size(70, 38);
            this.btn_Xoa_XoaChiTietBenh.TabIndex = 72;
            this.btn_Xoa_XoaChiTietBenh.Text = "Xóa";
            this.btn_Xoa_XoaChiTietBenh.UseVisualStyleBackColor = false;
            // 
            // btn_Them_ThemChiTietBenh
            // 
            this.btn_Them_ThemChiTietBenh.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Them_ThemChiTietBenh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_ThemChiTietBenh.Location = new System.Drawing.Point(714, 227);
            this.btn_Them_ThemChiTietBenh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them_ThemChiTietBenh.Name = "btn_Them_ThemChiTietBenh";
            this.btn_Them_ThemChiTietBenh.Size = new System.Drawing.Size(89, 38);
            this.btn_Them_ThemChiTietBenh.TabIndex = 71;
            this.btn_Them_ThemChiTietBenh.Text = "Thêm";
            this.btn_Them_ThemChiTietBenh.UseVisualStyleBackColor = false;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(665, 333);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(629, 376);
            this.textBox7.TabIndex = 57;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // lb_MaPhieuKham_CTPKB
            // 
            this.lb_MaPhieuKham_CTPKB.AutoSize = true;
            this.lb_MaPhieuKham_CTPKB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_MaPhieuKham_CTPKB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaPhieuKham_CTPKB.Location = new System.Drawing.Point(696, 375);
            this.lb_MaPhieuKham_CTPKB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_MaPhieuKham_CTPKB.Name = "lb_MaPhieuKham_CTPKB";
            this.lb_MaPhieuKham_CTPKB.Size = new System.Drawing.Size(169, 27);
            this.lb_MaPhieuKham_CTPKB.TabIndex = 77;
            this.lb_MaPhieuKham_CTPKB.Text = "Mã Phiếu Khám";
            // 
            // btn_Sua_SuaPKB
            // 
            this.btn_Sua_SuaPKB.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Sua_SuaPKB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua_SuaPKB.Location = new System.Drawing.Point(427, 290);
            this.btn_Sua_SuaPKB.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua_SuaPKB.Name = "btn_Sua_SuaPKB";
            this.btn_Sua_SuaPKB.Size = new System.Drawing.Size(66, 38);
            this.btn_Sua_SuaPKB.TabIndex = 82;
            this.btn_Sua_SuaPKB.Text = "Sửa";
            this.btn_Sua_SuaPKB.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa_XoaPKB
            // 
            this.btn_Xoa_XoaPKB.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Xoa_XoaPKB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_XoaPKB.Location = new System.Drawing.Point(296, 290);
            this.btn_Xoa_XoaPKB.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa_XoaPKB.Name = "btn_Xoa_XoaPKB";
            this.btn_Xoa_XoaPKB.Size = new System.Drawing.Size(70, 38);
            this.btn_Xoa_XoaPKB.TabIndex = 81;
            this.btn_Xoa_XoaPKB.Text = "Xóa";
            this.btn_Xoa_XoaPKB.UseVisualStyleBackColor = false;
            // 
            // btn_Them_ThemPKB
            // 
            this.btn_Them_ThemPKB.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Them_ThemPKB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_ThemPKB.Location = new System.Drawing.Point(464, 88);
            this.btn_Them_ThemPKB.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them_ThemPKB.Name = "btn_Them_ThemPKB";
            this.btn_Them_ThemPKB.Size = new System.Drawing.Size(89, 38);
            this.btn_Them_ThemPKB.TabIndex = 80;
            this.btn_Them_ThemPKB.Text = "Thêm";
            this.btn_Them_ThemPKB.UseVisualStyleBackColor = false;
            // 
            // btn_Sua_SuaChiTietPKN
            // 
            this.btn_Sua_SuaChiTietPKN.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Sua_SuaChiTietPKN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua_SuaChiTietPKN.Location = new System.Drawing.Point(933, 524);
            this.btn_Sua_SuaChiTietPKN.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua_SuaChiTietPKN.Name = "btn_Sua_SuaChiTietPKN";
            this.btn_Sua_SuaChiTietPKN.Size = new System.Drawing.Size(66, 38);
            this.btn_Sua_SuaChiTietPKN.TabIndex = 85;
            this.btn_Sua_SuaChiTietPKN.Text = "Sửa";
            this.btn_Sua_SuaChiTietPKN.UseVisualStyleBackColor = false;
            this.btn_Sua_SuaChiTietPKN.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Xoa_XoaChiTietPKB
            // 
            this.btn_Xoa_XoaChiTietPKB.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Xoa_XoaChiTietPKB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_XoaChiTietPKB.Location = new System.Drawing.Point(764, 524);
            this.btn_Xoa_XoaChiTietPKB.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa_XoaChiTietPKB.Name = "btn_Xoa_XoaChiTietPKB";
            this.btn_Xoa_XoaChiTietPKB.Size = new System.Drawing.Size(70, 38);
            this.btn_Xoa_XoaChiTietPKB.TabIndex = 84;
            this.btn_Xoa_XoaChiTietPKB.Text = "Xóa";
            this.btn_Xoa_XoaChiTietPKB.UseVisualStyleBackColor = false;
            // 
            // btn_Them_ThemChiTietPKB
            // 
            this.btn_Them_ThemChiTietPKB.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Them_ThemChiTietPKB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_ThemChiTietPKB.Location = new System.Drawing.Point(1166, 388);
            this.btn_Them_ThemChiTietPKB.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them_ThemChiTietPKB.Name = "btn_Them_ThemChiTietPKB";
            this.btn_Them_ThemChiTietPKB.Size = new System.Drawing.Size(89, 38);
            this.btn_Them_ThemChiTietPKB.TabIndex = 83;
            this.btn_Them_ThemChiTietPKB.Text = "Thêm";
            this.btn_Them_ThemChiTietPKB.UseVisualStyleBackColor = false;
            this.btn_Them_ThemChiTietPKB.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_TrangChu_PKB
            // 
            this.btn_TrangChu_PKB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TrangChu_PKB.BackgroundImage = global::InterfaceDesign.Properties.Resources.home;
            this.btn_TrangChu_PKB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TrangChu_PKB.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_TrangChu_PKB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TrangChu_PKB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TrangChu_PKB.Location = new System.Drawing.Point(5, 5);
            this.btn_TrangChu_PKB.Name = "btn_TrangChu_PKB";
            this.btn_TrangChu_PKB.Size = new System.Drawing.Size(39, 39);
            this.btn_TrangChu_PKB.TabIndex = 86;
            this.btn_TrangChu_PKB.Text = " ";
            this.btn_TrangChu_PKB.UseVisualStyleBackColor = false;
            this.btn_TrangChu_PKB.Click += new System.EventHandler(this.btn_TrangChu_PKB_Click);
            // 
            // btn_TroVe_PKB
            // 
            this.btn_TroVe_PKB.BackColor = System.Drawing.Color.White;
            this.btn_TroVe_PKB.BackgroundImage = global::InterfaceDesign.Properties.Resources.back;
            this.btn_TroVe_PKB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TroVe_PKB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TroVe_PKB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TroVe_PKB.Location = new System.Drawing.Point(7, 61);
            this.btn_TroVe_PKB.Name = "btn_TroVe_PKB";
            this.btn_TroVe_PKB.Size = new System.Drawing.Size(35, 35);
            this.btn_TroVe_PKB.TabIndex = 87;
            this.btn_TroVe_PKB.Text = " ";
            this.btn_TroVe_PKB.UseVisualStyleBackColor = false;
            this.btn_TroVe_PKB.Click += new System.EventHandler(this.btn_TroVe_PKB_Click);
            // 
            // btn_Luu_CTB
            // 
            this.btn_Luu_CTB.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Luu_CTB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu_CTB.Location = new System.Drawing.Point(910, 257);
            this.btn_Luu_CTB.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Luu_CTB.Name = "btn_Luu_CTB";
            this.btn_Luu_CTB.Size = new System.Drawing.Size(89, 38);
            this.btn_Luu_CTB.TabIndex = 88;
            this.btn_Luu_CTB.Text = "Lưu";
            this.btn_Luu_CTB.UseVisualStyleBackColor = false;
            // 
            // btn_Luu_PKB
            // 
            this.btn_Luu_PKB.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Luu_PKB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu_PKB.Location = new System.Drawing.Point(108, 290);
            this.btn_Luu_PKB.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Luu_PKB.Name = "btn_Luu_PKB";
            this.btn_Luu_PKB.Size = new System.Drawing.Size(89, 38);
            this.btn_Luu_PKB.TabIndex = 89;
            this.btn_Luu_PKB.Text = "Lưu";
            this.btn_Luu_PKB.UseVisualStyleBackColor = false;
            this.btn_Luu_PKB.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btn_Luu_CTPKB
            // 
            this.btn_Luu_CTPKB.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Luu_CTPKB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu_CTPKB.Location = new System.Drawing.Point(1190, 524);
            this.btn_Luu_CTPKB.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Luu_CTPKB.Name = "btn_Luu_CTPKB";
            this.btn_Luu_CTPKB.Size = new System.Drawing.Size(89, 38);
            this.btn_Luu_CTPKB.TabIndex = 90;
            this.btn_Luu_CTPKB.Text = "Lưu";
            this.btn_Luu_CTPKB.UseVisualStyleBackColor = false;
            // 
            // form_phieukhambenh
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Luu_CTPKB);
            this.Controls.Add(this.btn_Luu_PKB);
            this.Controls.Add(this.btn_Luu_CTB);
            this.Controls.Add(this.btn_TroVe_PKB);
            this.Controls.Add(this.btn_TrangChu_PKB);
            this.Controls.Add(this.btn_Sua_SuaChiTietPKN);
            this.Controls.Add(this.btn_Xoa_XoaChiTietPKB);
            this.Controls.Add(this.btn_Them_ThemChiTietPKB);
            this.Controls.Add(this.btn_Sua_SuaPKB);
            this.Controls.Add(this.btn_Xoa_XoaPKB);
            this.Controls.Add(this.btn_Them_ThemPKB);
            this.Controls.Add(this.lb_MaPhieuKham_CTPKB);
            this.Controls.Add(this.btn_Sua_SuaChiTietBenh);
            this.Controls.Add(this.btn_Xoa_XoaChiTietBenh);
            this.Controls.Add(this.btn_Them_ThemChiTietBenh);
            this.Controls.Add(this.cbx_TenThuoc);
            this.Controls.Add(this.lv_CTPKB);
            this.Controls.Add(this.txtb_LieuDung);
            this.Controls.Add(this.lb_LieuDung);
            this.Controls.Add(this.txtb_SoLuong);
            this.Controls.Add(this.lb_SoLuong);
            this.Controls.Add(this.txtb_MaPhieuKham_CTPKB);
            this.Controls.Add(this.lb_TenThuoc);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lb_ChiTietPhieuKhamBenh);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.cbx_TenLoaiBenh);
            this.Controls.Add(this.txtb_MaPhieuKham_CTBenh);
            this.Controls.Add(this.lv_ChiTietBenh);
            this.Controls.Add(this.lb_TenLoaiBenh);
            this.Controls.Add(this.lb_MaPhieuKham_CTBenh);
            this.Controls.Add(this.lb_ChiTietBenh);
            this.Controls.Add(this.txtb_CTBenh);
            this.Controls.Add(this.lv_PKB);
            this.Controls.Add(this.txtb_TrieuChung);
            this.Controls.Add(this.txtb_MaBenhNhan);
            this.Controls.Add(this.txtb_MaPhieuKham_PKB);
            this.Controls.Add(this.dtbx_NgayKham);
            this.Controls.Add(this.lb_TrieuChung);
            this.Controls.Add(this.lb_NgayKham);
            this.Controls.Add(this.lb_MaBenhNhan);
            this.Controls.Add(this.lb_MaPhieuKham_PKB);
            this.Controls.Add(this.lb_PhieuKhamBenh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_PKB);
            this.Name = "form_phieukhambenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Khám Bệnh";
            this.Load += new System.EventHandler(this.form_phieukhambenh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_PKB;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txtb_TrieuChung;
        private System.Windows.Forms.TextBox txtb_MaBenhNhan;
        private System.Windows.Forms.TextBox txtb_MaPhieuKham_PKB;
        private System.Windows.Forms.DateTimePicker dtbx_NgayKham;
        private System.Windows.Forms.Label lb_TrieuChung;
        private System.Windows.Forms.Label lb_NgayKham;
        private System.Windows.Forms.Label lb_MaBenhNhan;
        private System.Windows.Forms.Label lb_MaPhieuKham_PKB;
        private System.Windows.Forms.Label lb_PhieuKhamBenh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_PKB;
        private System.Windows.Forms.TextBox txtb_CTBenh;
        private System.Windows.Forms.ComboBox cbx_TenLoaiBenh;
        private System.Windows.Forms.TextBox txtb_MaPhieuKham_CTBenh;
        private System.Windows.Forms.ListView lv_ChiTietBenh;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label lb_TenLoaiBenh;
        private System.Windows.Forms.Label lb_MaPhieuKham_CTBenh;
        private System.Windows.Forms.Label lb_ChiTietBenh;
        private System.Windows.Forms.ComboBox cbx_TenThuoc;
        private System.Windows.Forms.ListView lv_CTPKB;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.TextBox txtb_LieuDung;
        private System.Windows.Forms.Label lb_LieuDung;
        private System.Windows.Forms.TextBox txtb_SoLuong;
        private System.Windows.Forms.Label lb_SoLuong;
        private System.Windows.Forms.TextBox txtb_MaPhieuKham_CTPKB;
        private System.Windows.Forms.Label lb_TenThuoc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lb_ChiTietPhieuKhamBenh;
        private System.Windows.Forms.Button btn_Sua_SuaChiTietBenh;
        private System.Windows.Forms.Button btn_Xoa_XoaChiTietBenh;
        private System.Windows.Forms.Button btn_Them_ThemChiTietBenh;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lb_MaPhieuKham_CTPKB;
        private System.Windows.Forms.Button btn_Sua_SuaPKB;
        private System.Windows.Forms.Button btn_Xoa_XoaPKB;
        private System.Windows.Forms.Button btn_Them_ThemPKB;
        private System.Windows.Forms.Button btn_Sua_SuaChiTietPKN;
        private System.Windows.Forms.Button btn_Xoa_XoaChiTietPKB;
        private System.Windows.Forms.Button btn_Them_ThemChiTietPKB;
        private System.Windows.Forms.Button btn_TrangChu_PKB;
        private System.Windows.Forms.Button btn_TroVe_PKB;
        private System.Windows.Forms.Button btn_Luu_CTB;
        private System.Windows.Forms.Button btn_Luu_PKB;
        private System.Windows.Forms.Button btn_Luu_CTPKB;
    }
}