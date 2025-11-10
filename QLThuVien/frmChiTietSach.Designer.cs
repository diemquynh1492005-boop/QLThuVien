namespace QLThuVien
{
    partial class frmChiTietSach
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
            this.lblmaintext = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.btnDong = new Guna.UI2.WinForms.Guna2Button();
            this.txtMaDauSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenDauSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.txtTacGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.txtNamXB = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNamXB = new System.Windows.Forms.Label();
            this.txtGiaBia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGiaBia = new System.Windows.Forms.Label();
            this.txtChuDe = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblChuDe = new System.Windows.Forms.Label();
            this.txtNXB = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNXB = new System.Windows.Forms.Label();
            this.txtKho = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblKho = new System.Windows.Forms.Label();
            this.txtLoaiSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLoaiSach = new System.Windows.Forms.Label();
            this.txtSoTrang = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSoTrang = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmaintext
            // 
            this.lblmaintext.AutoSize = true;
            this.lblmaintext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblmaintext.Font = new System.Drawing.Font("Segoe UI", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaintext.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblmaintext.Location = new System.Drawing.Point(3, 0);
            this.lblmaintext.Name = "lblmaintext";
            this.lblmaintext.Size = new System.Drawing.Size(1366, 142);
            this.lblmaintext.TabIndex = 0;
            this.lblmaintext.Text = "THÔNG TIN CHI TIẾT SÁCH";
            this.lblmaintext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblmaintext, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1372, 142);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSach.Location = new System.Drawing.Point(68, 196);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(171, 37);
            this.lblMaSach.TabIndex = 1;
            this.lblMaSach.Text = "Mã đầu sách";
            this.lblMaSach.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDong
            // 
            this.btnDong.BorderRadius = 15;
            this.btnDong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDong.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDong.Location = new System.Drawing.Point(1145, 768);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(193, 74);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // txtMaDauSach
            // 
            this.txtMaDauSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDauSach.DefaultText = "";
            this.txtMaDauSach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDauSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDauSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDauSach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDauSach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDauSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaDauSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMaDauSach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDauSach.Location = new System.Drawing.Point(258, 187);
            this.txtMaDauSach.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMaDauSach.Name = "txtMaDauSach";
            this.txtMaDauSach.PlaceholderText = "";
            this.txtMaDauSach.ReadOnly = true;
            this.txtMaDauSach.SelectedText = "";
            this.txtMaDauSach.Size = new System.Drawing.Size(371, 56);
            this.txtMaDauSach.TabIndex = 3;
            // 
            // txtTenDauSach
            // 
            this.txtTenDauSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDauSach.DefaultText = "";
            this.txtTenDauSach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDauSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDauSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDauSach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDauSach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDauSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenDauSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTenDauSach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDauSach.Location = new System.Drawing.Point(258, 285);
            this.txtTenDauSach.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTenDauSach.Name = "txtTenDauSach";
            this.txtTenDauSach.PlaceholderText = "";
            this.txtTenDauSach.ReadOnly = true;
            this.txtTenDauSach.SelectedText = "";
            this.txtTenDauSach.Size = new System.Drawing.Size(371, 56);
            this.txtTenDauSach.TabIndex = 5;
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.Location = new System.Drawing.Point(68, 294);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(174, 37);
            this.lblTenSach.TabIndex = 4;
            this.lblTenSach.Text = "Tên đầu sách";
            // 
            // txtTacGia
            // 
            this.txtTacGia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtTacGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTacGia.DefaultText = "";
            this.txtTacGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTacGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTacGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTacGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTacGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTacGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTacGia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTacGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTacGia.Location = new System.Drawing.Point(258, 391);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTacGia.Multiline = true;
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.PlaceholderText = "";
            this.txtTacGia.ReadOnly = true;
            this.txtTacGia.SelectedText = "";
            this.txtTacGia.Size = new System.Drawing.Size(371, 56);
            this.txtTacGia.TabIndex = 7;
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTacGia.Location = new System.Drawing.Point(68, 400);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(100, 37);
            this.lblTacGia.TabIndex = 6;
            this.lblTacGia.Text = "Tác giả";
            // 
            // txtNamXB
            // 
            this.txtNamXB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamXB.DefaultText = "";
            this.txtNamXB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamXB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamXB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamXB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamXB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamXB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNamXB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNamXB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamXB.Location = new System.Drawing.Point(258, 499);
            this.txtNamXB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.PlaceholderText = "";
            this.txtNamXB.ReadOnly = true;
            this.txtNamXB.SelectedText = "";
            this.txtNamXB.Size = new System.Drawing.Size(371, 56);
            this.txtNamXB.TabIndex = 9;
            // 
            // lblNamXB
            // 
            this.lblNamXB.AutoSize = true;
            this.lblNamXB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamXB.Location = new System.Drawing.Point(68, 508);
            this.lblNamXB.Name = "lblNamXB";
            this.lblNamXB.Size = new System.Drawing.Size(190, 37);
            this.lblNamXB.TabIndex = 8;
            this.lblNamXB.Text = "Năm xuất bản";
            // 
            // txtGiaBia
            // 
            this.txtGiaBia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaBia.DefaultText = "";
            this.txtGiaBia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaBia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaBia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaBia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGiaBia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtGiaBia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaBia.Location = new System.Drawing.Point(258, 600);
            this.txtGiaBia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtGiaBia.Name = "txtGiaBia";
            this.txtGiaBia.PlaceholderText = "";
            this.txtGiaBia.ReadOnly = true;
            this.txtGiaBia.SelectedText = "";
            this.txtGiaBia.Size = new System.Drawing.Size(371, 56);
            this.txtGiaBia.TabIndex = 11;
            // 
            // lblGiaBia
            // 
            this.lblGiaBia.AutoSize = true;
            this.lblGiaBia.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaBia.Location = new System.Drawing.Point(68, 609);
            this.lblGiaBia.Name = "lblGiaBia";
            this.lblGiaBia.Size = new System.Drawing.Size(101, 37);
            this.lblGiaBia.TabIndex = 10;
            this.lblGiaBia.Text = "Giá bìa";
            // 
            // txtChuDe
            // 
            this.txtChuDe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChuDe.DefaultText = "";
            this.txtChuDe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChuDe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChuDe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChuDe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChuDe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChuDe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtChuDe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtChuDe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChuDe.Location = new System.Drawing.Point(902, 391);
            this.txtChuDe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtChuDe.Name = "txtChuDe";
            this.txtChuDe.PlaceholderText = "";
            this.txtChuDe.ReadOnly = true;
            this.txtChuDe.SelectedText = "";
            this.txtChuDe.Size = new System.Drawing.Size(371, 56);
            this.txtChuDe.TabIndex = 15;
            // 
            // lblChuDe
            // 
            this.lblChuDe.AutoSize = true;
            this.lblChuDe.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuDe.Location = new System.Drawing.Point(712, 400);
            this.lblChuDe.Name = "lblChuDe";
            this.lblChuDe.Size = new System.Drawing.Size(103, 37);
            this.lblChuDe.TabIndex = 14;
            this.lblChuDe.Text = "Chủ đề";
            // 
            // txtNXB
            // 
            this.txtNXB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNXB.DefaultText = "";
            this.txtNXB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNXB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNXB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNXB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNXB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNXB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNXB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNXB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNXB.Location = new System.Drawing.Point(902, 499);
            this.txtNXB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.PlaceholderText = "";
            this.txtNXB.ReadOnly = true;
            this.txtNXB.SelectedText = "";
            this.txtNXB.Size = new System.Drawing.Size(371, 56);
            this.txtNXB.TabIndex = 17;
            // 
            // lblNXB
            // 
            this.lblNXB.AutoSize = true;
            this.lblNXB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNXB.Location = new System.Drawing.Point(712, 508);
            this.lblNXB.Name = "lblNXB";
            this.lblNXB.Size = new System.Drawing.Size(71, 37);
            this.lblNXB.TabIndex = 16;
            this.lblNXB.Text = "NXB";
            // 
            // txtKho
            // 
            this.txtKho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKho.DefaultText = "";
            this.txtKho.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKho.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKho.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtKho.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKho.Location = new System.Drawing.Point(902, 600);
            this.txtKho.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtKho.Name = "txtKho";
            this.txtKho.PlaceholderText = "";
            this.txtKho.ReadOnly = true;
            this.txtKho.SelectedText = "";
            this.txtKho.Size = new System.Drawing.Size(371, 56);
            this.txtKho.TabIndex = 19;
            // 
            // lblKho
            // 
            this.lblKho.AutoSize = true;
            this.lblKho.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKho.Location = new System.Drawing.Point(712, 609);
            this.lblKho.Name = "lblKho";
            this.lblKho.Size = new System.Drawing.Size(66, 37);
            this.lblKho.TabIndex = 18;
            this.lblKho.Text = "Kho";
            // 
            // txtLoaiSach
            // 
            this.txtLoaiSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoaiSach.DefaultText = "";
            this.txtLoaiSach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoaiSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoaiSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoaiSach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoaiSach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaiSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoaiSach.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLoaiSach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoaiSach.Location = new System.Drawing.Point(902, 285);
            this.txtLoaiSach.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLoaiSach.Name = "txtLoaiSach";
            this.txtLoaiSach.PlaceholderText = "";
            this.txtLoaiSach.ReadOnly = true;
            this.txtLoaiSach.SelectedText = "";
            this.txtLoaiSach.Size = new System.Drawing.Size(371, 56);
            this.txtLoaiSach.TabIndex = 21;
            // 
            // lblLoaiSach
            // 
            this.lblLoaiSach.AutoSize = true;
            this.lblLoaiSach.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiSach.Location = new System.Drawing.Point(712, 294);
            this.lblLoaiSach.Name = "lblLoaiSach";
            this.lblLoaiSach.Size = new System.Drawing.Size(129, 37);
            this.lblLoaiSach.TabIndex = 20;
            this.lblLoaiSach.Text = "Loại sách";
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoTrang.DefaultText = "";
            this.txtSoTrang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoTrang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoTrang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoTrang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoTrang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoTrang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoTrang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSoTrang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoTrang.Location = new System.Drawing.Point(902, 187);
            this.txtSoTrang.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.PlaceholderText = "";
            this.txtSoTrang.ReadOnly = true;
            this.txtSoTrang.SelectedText = "";
            this.txtSoTrang.Size = new System.Drawing.Size(371, 56);
            this.txtSoTrang.TabIndex = 23;
            // 
            // lblSoTrang
            // 
            this.lblSoTrang.AutoSize = true;
            this.lblSoTrang.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTrang.Location = new System.Drawing.Point(712, 196);
            this.lblSoTrang.Name = "lblSoTrang";
            this.lblSoTrang.Size = new System.Drawing.Size(121, 37);
            this.lblSoTrang.TabIndex = 22;
            this.lblSoTrang.Text = "Số trang";
            // 
            // frmChiTietSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1372, 863);
            this.Controls.Add(this.txtSoTrang);
            this.Controls.Add(this.lblSoTrang);
            this.Controls.Add(this.txtLoaiSach);
            this.Controls.Add(this.lblLoaiSach);
            this.Controls.Add(this.txtKho);
            this.Controls.Add(this.lblKho);
            this.Controls.Add(this.txtNXB);
            this.Controls.Add(this.lblNXB);
            this.Controls.Add(this.txtChuDe);
            this.Controls.Add(this.lblChuDe);
            this.Controls.Add(this.txtGiaBia);
            this.Controls.Add(this.lblGiaBia);
            this.Controls.Add(this.txtNamXB);
            this.Controls.Add(this.lblNamXB);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.lblTacGia);
            this.Controls.Add(this.txtTenDauSach);
            this.Controls.Add(this.lblTenSach);
            this.Controls.Add(this.txtMaDauSach);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lblMaSach);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmChiTietSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmChiTietSach";
            this.Load += new System.EventHandler(this.frmChiTietSach_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmaintext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMaSach;
        private Guna.UI2.WinForms.Guna2Button btnDong;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDauSach;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDauSach;
        private System.Windows.Forms.Label lblTenSach;
        private Guna.UI2.WinForms.Guna2TextBox txtTacGia;
        private System.Windows.Forms.Label lblTacGia;
        private Guna.UI2.WinForms.Guna2TextBox txtNamXB;
        private System.Windows.Forms.Label lblNamXB;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaBia;
        private System.Windows.Forms.Label lblGiaBia;
        private Guna.UI2.WinForms.Guna2TextBox txtChuDe;
        private System.Windows.Forms.Label lblChuDe;
        private Guna.UI2.WinForms.Guna2TextBox txtNXB;
        private System.Windows.Forms.Label lblNXB;
        private Guna.UI2.WinForms.Guna2TextBox txtKho;
        private System.Windows.Forms.Label lblKho;
        private Guna.UI2.WinForms.Guna2TextBox txtLoaiSach;
        private System.Windows.Forms.Label lblLoaiSach;
        private Guna.UI2.WinForms.Guna2TextBox txtSoTrang;
        private System.Windows.Forms.Label lblSoTrang;
    }
}