namespace QLThuVien.All_User_Control
{
    partial class UC_Reader
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnltren = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpngayhanthe = new System.Windows.Forms.DateTimePicker();
            this.dtpngaycapthe = new System.Windows.Forms.DateTimePicker();
            this.txtsodienthoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtemaildocgia = new Guna.UI2.WinForms.Guna2TextBox();
            this.txthoten = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmathemuon = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblngayhanthe = new System.Windows.Forms.Label();
            this.lblngaycapthe = new System.Windows.Forms.Label();
            this.lblnghenghiep = new System.Windows.Forms.Label();
            this.lblsodienthoai = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblhotendocgia = new System.Windows.Forms.Label();
            this.lblmathemuon = new System.Windows.Forms.Label();
            this.txtnhaptendocgia = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbnghenghiep = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbtentruong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbltentruong = new System.Windows.Forms.Label();
            this.lblquanlydocgia = new System.Windows.Forms.Label();
            this.pnlduoi = new Guna.UI2.WinForms.Guna2Panel();
            this.btnsuadg = new Guna.UI2.WinForms.Guna2Button();
            this.btnxoadg = new Guna.UI2.WinForms.Guna2Button();
            this.btnthemdg = new Guna.UI2.WinForms.Guna2Button();
            this.btntaomoidg = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.grbthongtindocgia = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnltren.SuspendLayout();
            this.pnlduoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.grbthongtindocgia.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnltren, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlduoi, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.67901F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.32099F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1107, 648);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnltren
            // 
            this.pnltren.Controls.Add(this.grbthongtindocgia);
            this.pnltren.Controls.Add(this.txtnhaptendocgia);
            this.pnltren.Controls.Add(this.cbtentruong);
            this.pnltren.Controls.Add(this.lbltentruong);
            this.pnltren.Controls.Add(this.lblquanlydocgia);
            this.pnltren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltren.Location = new System.Drawing.Point(3, 3);
            this.pnltren.Name = "pnltren";
            this.pnltren.Size = new System.Drawing.Size(1101, 289);
            this.pnltren.TabIndex = 0;
            this.pnltren.Paint += new System.Windows.Forms.PaintEventHandler(this.pnltren_Paint);
            // 
            // dtpngayhanthe
            // 
            this.dtpngayhanthe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngayhanthe.Location = new System.Drawing.Point(718, 89);
            this.dtpngayhanthe.Name = "dtpngayhanthe";
            this.dtpngayhanthe.Size = new System.Drawing.Size(154, 26);
            this.dtpngayhanthe.TabIndex = 18;
            // 
            // dtpngaycapthe
            // 
            this.dtpngaycapthe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaycapthe.Location = new System.Drawing.Point(718, 53);
            this.dtpngaycapthe.Name = "dtpngaycapthe";
            this.dtpngaycapthe.Size = new System.Drawing.Size(154, 26);
            this.dtpngaycapthe.TabIndex = 17;
            // 
            // txtsodienthoai
            // 
            this.txtsodienthoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsodienthoai.DefaultText = "";
            this.txtsodienthoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsodienthoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsodienthoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsodienthoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsodienthoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsodienthoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsodienthoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsodienthoai.Location = new System.Drawing.Point(324, 133);
            this.txtsodienthoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.PlaceholderText = "";
            this.txtsodienthoai.SelectedText = "";
            this.txtsodienthoai.Size = new System.Drawing.Size(243, 32);
            this.txtsodienthoai.TabIndex = 16;
            // 
            // txtemaildocgia
            // 
            this.txtemaildocgia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemaildocgia.DefaultText = "";
            this.txtemaildocgia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemaildocgia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemaildocgia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemaildocgia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemaildocgia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemaildocgia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtemaildocgia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemaildocgia.Location = new System.Drawing.Point(324, 95);
            this.txtemaildocgia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtemaildocgia.Name = "txtemaildocgia";
            this.txtemaildocgia.PlaceholderText = "";
            this.txtemaildocgia.SelectedText = "";
            this.txtemaildocgia.Size = new System.Drawing.Size(243, 32);
            this.txtemaildocgia.TabIndex = 15;
            // 
            // txthoten
            // 
            this.txthoten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthoten.DefaultText = "";
            this.txthoten.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txthoten.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txthoten.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txthoten.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txthoten.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txthoten.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txthoten.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txthoten.Location = new System.Drawing.Point(324, 53);
            this.txthoten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txthoten.Name = "txthoten";
            this.txthoten.PlaceholderText = "";
            this.txthoten.SelectedText = "";
            this.txthoten.Size = new System.Drawing.Size(243, 32);
            this.txthoten.TabIndex = 14;
            // 
            // txtmathemuon
            // 
            this.txtmathemuon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmathemuon.DefaultText = "";
            this.txtmathemuon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmathemuon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmathemuon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmathemuon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmathemuon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmathemuon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmathemuon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmathemuon.Location = new System.Drawing.Point(324, 15);
            this.txtmathemuon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmathemuon.Name = "txtmathemuon";
            this.txtmathemuon.PlaceholderText = "";
            this.txtmathemuon.SelectedText = "";
            this.txtmathemuon.Size = new System.Drawing.Size(243, 32);
            this.txtmathemuon.TabIndex = 13;
            // 
            // lblngayhanthe
            // 
            this.lblngayhanthe.AutoSize = true;
            this.lblngayhanthe.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblngayhanthe.Location = new System.Drawing.Point(574, 93);
            this.lblngayhanthe.Name = "lblngayhanthe";
            this.lblngayhanthe.Size = new System.Drawing.Size(113, 21);
            this.lblngayhanthe.TabIndex = 12;
            this.lblngayhanthe.Text = "Ngày hạn thẻ";
            // 
            // lblngaycapthe
            // 
            this.lblngaycapthe.AutoSize = true;
            this.lblngaycapthe.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblngaycapthe.Location = new System.Drawing.Point(574, 53);
            this.lblngaycapthe.Name = "lblngaycapthe";
            this.lblngaycapthe.Size = new System.Drawing.Size(111, 21);
            this.lblngaycapthe.TabIndex = 11;
            this.lblngaycapthe.Text = "Ngày cấp thẻ";
            // 
            // lblnghenghiep
            // 
            this.lblnghenghiep.AutoSize = true;
            this.lblnghenghiep.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnghenghiep.Location = new System.Drawing.Point(574, 13);
            this.lblnghenghiep.Name = "lblnghenghiep";
            this.lblnghenghiep.Size = new System.Drawing.Size(110, 21);
            this.lblnghenghiep.TabIndex = 10;
            this.lblnghenghiep.Text = "Nghề nghiệp";
            // 
            // lblsodienthoai
            // 
            this.lblsodienthoai.AutoSize = true;
            this.lblsodienthoai.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsodienthoai.Location = new System.Drawing.Point(197, 133);
            this.lblsodienthoai.Name = "lblsodienthoai";
            this.lblsodienthoai.Size = new System.Drawing.Size(109, 19);
            this.lblsodienthoai.TabIndex = 9;
            this.lblsodienthoai.Text = "Số điện thoại";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(198, 95);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(51, 19);
            this.lblemail.TabIndex = 8;
            this.lblemail.Text = "Email";
            // 
            // lblhotendocgia
            // 
            this.lblhotendocgia.AutoSize = true;
            this.lblhotendocgia.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhotendocgia.Location = new System.Drawing.Point(198, 53);
            this.lblhotendocgia.Name = "lblhotendocgia";
            this.lblhotendocgia.Size = new System.Drawing.Size(59, 19);
            this.lblhotendocgia.TabIndex = 7;
            this.lblhotendocgia.Text = "Họ tên";
            // 
            // lblmathemuon
            // 
            this.lblmathemuon.AutoSize = true;
            this.lblmathemuon.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmathemuon.Location = new System.Drawing.Point(197, 15);
            this.lblmathemuon.Name = "lblmathemuon";
            this.lblmathemuon.Size = new System.Drawing.Size(110, 19);
            this.lblmathemuon.TabIndex = 6;
            this.lblmathemuon.Text = "Mã thẻ mượn";
            // 
            // txtnhaptendocgia
            // 
            this.txtnhaptendocgia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnhaptendocgia.DefaultText = "Nhập tên độc giả để tìm kiếm";
            this.txtnhaptendocgia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnhaptendocgia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnhaptendocgia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnhaptendocgia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnhaptendocgia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnhaptendocgia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtnhaptendocgia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnhaptendocgia.Location = new System.Drawing.Point(251, 74);
            this.txtnhaptendocgia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnhaptendocgia.Name = "txtnhaptendocgia";
            this.txtnhaptendocgia.PlaceholderText = "";
            this.txtnhaptendocgia.SelectedText = "";
            this.txtnhaptendocgia.Size = new System.Drawing.Size(718, 36);
            this.txtnhaptendocgia.TabIndex = 5;
            // 
            // cbnghenghiep
            // 
            this.cbnghenghiep.BackColor = System.Drawing.Color.Transparent;
            this.cbnghenghiep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbnghenghiep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnghenghiep.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbnghenghiep.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbnghenghiep.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbnghenghiep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbnghenghiep.ItemHeight = 30;
            this.cbnghenghiep.Items.AddRange(new object[] {
            "Học sinh",
            "Sinh viên",
            "Giảng viên"});
            this.cbnghenghiep.Location = new System.Drawing.Point(718, 13);
            this.cbnghenghiep.Name = "cbnghenghiep";
            this.cbnghenghiep.Size = new System.Drawing.Size(124, 36);
            this.cbnghenghiep.TabIndex = 4;
            // 
            // cbtentruong
            // 
            this.cbtentruong.BackColor = System.Drawing.Color.Transparent;
            this.cbtentruong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbtentruong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtentruong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbtentruong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbtentruong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbtentruong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbtentruong.ItemHeight = 30;
            this.cbtentruong.Items.AddRange(new object[] {
            "Độc giả"});
            this.cbtentruong.Location = new System.Drawing.Point(104, 74);
            this.cbtentruong.Name = "cbtentruong";
            this.cbtentruong.Size = new System.Drawing.Size(140, 36);
            this.cbtentruong.TabIndex = 3;
            // 
            // lbltentruong
            // 
            this.lbltentruong.AutoSize = true;
            this.lbltentruong.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltentruong.Location = new System.Drawing.Point(100, 49);
            this.lbltentruong.Name = "lbltentruong";
            this.lbltentruong.Size = new System.Drawing.Size(94, 21);
            this.lbltentruong.TabIndex = 1;
            this.lbltentruong.Text = "Tên trường";
            // 
            // lblquanlydocgia
            // 
            this.lblquanlydocgia.AutoSize = true;
            this.lblquanlydocgia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblquanlydocgia.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquanlydocgia.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblquanlydocgia.Location = new System.Drawing.Point(448, 17);
            this.lblquanlydocgia.Name = "lblquanlydocgia";
            this.lblquanlydocgia.Size = new System.Drawing.Size(188, 24);
            this.lblquanlydocgia.TabIndex = 0;
            this.lblquanlydocgia.Text = "QUẢN LÝ ĐỘC GIẢ";
            // 
            // pnlduoi
            // 
            this.pnlduoi.Controls.Add(this.btnsuadg);
            this.pnlduoi.Controls.Add(this.btnxoadg);
            this.pnlduoi.Controls.Add(this.btnthemdg);
            this.pnlduoi.Controls.Add(this.btntaomoidg);
            this.pnlduoi.Controls.Add(this.guna2DataGridView1);
            this.pnlduoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlduoi.Location = new System.Drawing.Point(3, 298);
            this.pnlduoi.Name = "pnlduoi";
            this.pnlduoi.Size = new System.Drawing.Size(1101, 347);
            this.pnlduoi.TabIndex = 1;
            // 
            // btnsuadg
            // 
            this.btnsuadg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsuadg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsuadg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsuadg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsuadg.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnsuadg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuadg.ForeColor = System.Drawing.Color.White;
            this.btnsuadg.Location = new System.Drawing.Point(835, 266);
            this.btnsuadg.Name = "btnsuadg";
            this.btnsuadg.Size = new System.Drawing.Size(166, 45);
            this.btnsuadg.TabIndex = 4;
            this.btnsuadg.Text = "Sửa";
            // 
            // btnxoadg
            // 
            this.btnxoadg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnxoadg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnxoadg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnxoadg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnxoadg.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnxoadg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoadg.ForeColor = System.Drawing.Color.White;
            this.btnxoadg.Location = new System.Drawing.Point(601, 266);
            this.btnxoadg.Name = "btnxoadg";
            this.btnxoadg.Size = new System.Drawing.Size(166, 45);
            this.btnxoadg.TabIndex = 3;
            this.btnxoadg.Text = "Xóa";
            // 
            // btnthemdg
            // 
            this.btnthemdg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthemdg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthemdg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthemdg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthemdg.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnthemdg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemdg.ForeColor = System.Drawing.Color.White;
            this.btnthemdg.Location = new System.Drawing.Point(361, 266);
            this.btnthemdg.Name = "btnthemdg";
            this.btnthemdg.Size = new System.Drawing.Size(166, 45);
            this.btnthemdg.TabIndex = 2;
            this.btnthemdg.Text = "Thêm";
            // 
            // btntaomoidg
            // 
            this.btntaomoidg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntaomoidg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntaomoidg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntaomoidg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntaomoidg.FillColor = System.Drawing.SystemColors.Highlight;
            this.btntaomoidg.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaomoidg.ForeColor = System.Drawing.Color.White;
            this.btntaomoidg.Location = new System.Drawing.Point(126, 266);
            this.btntaomoidg.Name = "btntaomoidg";
            this.btntaomoidg.Size = new System.Drawing.Size(166, 45);
            this.btntaomoidg.TabIndex = 1;
            this.btntaomoidg.Text = "Tạo mới";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(56, 0);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 62;
            this.guna2DataGridView1.RowTemplate.Height = 28;
            this.guna2DataGridView1.Size = new System.Drawing.Size(990, 245);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // grbthongtindocgia
            // 
            this.grbthongtindocgia.Controls.Add(this.lblnghenghiep);
            this.grbthongtindocgia.Controls.Add(this.dtpngayhanthe);
            this.grbthongtindocgia.Controls.Add(this.lblsodienthoai);
            this.grbthongtindocgia.Controls.Add(this.lblemail);
            this.grbthongtindocgia.Controls.Add(this.dtpngaycapthe);
            this.grbthongtindocgia.Controls.Add(this.lblhotendocgia);
            this.grbthongtindocgia.Controls.Add(this.lblngaycapthe);
            this.grbthongtindocgia.Controls.Add(this.txtsodienthoai);
            this.grbthongtindocgia.Controls.Add(this.lblmathemuon);
            this.grbthongtindocgia.Controls.Add(this.lblngayhanthe);
            this.grbthongtindocgia.Controls.Add(this.txtemaildocgia);
            this.grbthongtindocgia.Controls.Add(this.cbnghenghiep);
            this.grbthongtindocgia.Controls.Add(this.txtmathemuon);
            this.grbthongtindocgia.Controls.Add(this.txthoten);
            this.grbthongtindocgia.Location = new System.Drawing.Point(56, 116);
            this.grbthongtindocgia.Name = "grbthongtindocgia";
            this.grbthongtindocgia.Size = new System.Drawing.Size(990, 158);
            this.grbthongtindocgia.TabIndex = 19;
            this.grbthongtindocgia.TabStop = false;
            this.grbthongtindocgia.Text = "Thông tin độc giả";
            // 
            // UC_Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_Reader";
            this.Size = new System.Drawing.Size(1107, 648);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnltren.ResumeLayout(false);
            this.pnltren.PerformLayout();
            this.pnlduoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.grbthongtindocgia.ResumeLayout(false);
            this.grbthongtindocgia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel pnltren;
        private System.Windows.Forms.Label lbltentruong;
        private System.Windows.Forms.Label lblquanlydocgia;
        private Guna.UI2.WinForms.Guna2Panel pnlduoi;
        private Guna.UI2.WinForms.Guna2TextBox txtnhaptendocgia;
        private Guna.UI2.WinForms.Guna2ComboBox cbnghenghiep;
        private Guna.UI2.WinForms.Guna2ComboBox cbtentruong;
        private System.Windows.Forms.Label lblngayhanthe;
        private System.Windows.Forms.Label lblngaycapthe;
        private System.Windows.Forms.Label lblnghenghiep;
        private System.Windows.Forms.Label lblsodienthoai;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblhotendocgia;
        private System.Windows.Forms.Label lblmathemuon;
        private Guna.UI2.WinForms.Guna2TextBox txtsodienthoai;
        private Guna.UI2.WinForms.Guna2TextBox txtemaildocgia;
        private Guna.UI2.WinForms.Guna2TextBox txthoten;
        private Guna.UI2.WinForms.Guna2TextBox txtmathemuon;
        private System.Windows.Forms.DateTimePicker dtpngayhanthe;
        private System.Windows.Forms.DateTimePicker dtpngaycapthe;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button btnsuadg;
        private Guna.UI2.WinForms.Guna2Button btnxoadg;
        private Guna.UI2.WinForms.Guna2Button btnthemdg;
        private Guna.UI2.WinForms.Guna2Button btntaomoidg;
        private System.Windows.Forms.GroupBox grbthongtindocgia;
    }
}
