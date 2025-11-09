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
            this.pnltop = new Guna.UI2.WinForms.Guna2Panel();
            this.grbthongtindocgia = new System.Windows.Forms.GroupBox();
            this.lblnghenghiep = new System.Windows.Forms.Label();
            this.dtpngayhanthe = new System.Windows.Forms.DateTimePicker();
            this.lblsodienthoai = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.dtpngaycapthe = new System.Windows.Forms.DateTimePicker();
            this.lblhotendocgia = new System.Windows.Forms.Label();
            this.lblngaycapthe = new System.Windows.Forms.Label();
            this.txtsodienthoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblmathemuon = new System.Windows.Forms.Label();
            this.lblngayhanthe = new System.Windows.Forms.Label();
            this.txtemaildocgia = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbnghenghiep = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtmathemuon = new Guna.UI2.WinForms.Guna2TextBox();
            this.txthoten = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnhaptendocgia = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbtentruong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbltentruong = new System.Windows.Forms.Label();
            this.lblquanlydocgia = new System.Windows.Forms.Label();
            this.pnldown = new Guna.UI2.WinForms.Guna2Panel();
            this.btnsuadg = new Guna.UI2.WinForms.Guna2Button();
            this.btnxoadg = new Guna.UI2.WinForms.Guna2Button();
            this.btnthemdg = new Guna.UI2.WinForms.Guna2Button();
            this.btntaomoidg = new Guna.UI2.WinForms.Guna2Button();
            this.dgvdocgia = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnltop.SuspendLayout();
            this.grbthongtindocgia.SuspendLayout();
            this.pnldown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdocgia)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnltop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnldown, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.05202F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.94798F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1516, 865);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.grbthongtindocgia);
            this.pnltop.Controls.Add(this.txtnhaptendocgia);
            this.pnltop.Controls.Add(this.cbtentruong);
            this.pnltop.Controls.Add(this.lbltentruong);
            this.pnltop.Controls.Add(this.lblquanlydocgia);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnltop.Location = new System.Drawing.Point(3, 3);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1510, 401);
            this.pnltop.TabIndex = 0;
            this.pnltop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnltren_Paint);
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
            this.grbthongtindocgia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbthongtindocgia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbthongtindocgia.Location = new System.Drawing.Point(117, 168);
            this.grbthongtindocgia.Name = "grbthongtindocgia";
            this.grbthongtindocgia.Size = new System.Drawing.Size(1272, 244);
            this.grbthongtindocgia.TabIndex = 19;
            this.grbthongtindocgia.TabStop = false;
            this.grbthongtindocgia.Text = "Thông tin độc giả";
            // 
            // lblnghenghiep
            // 
            this.lblnghenghiep.AutoSize = true;
            this.lblnghenghiep.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnghenghiep.Location = new System.Drawing.Point(881, 27);
            this.lblnghenghiep.Name = "lblnghenghiep";
            this.lblnghenghiep.Size = new System.Drawing.Size(134, 28);
            this.lblnghenghiep.TabIndex = 10;
            this.lblnghenghiep.Text = "Nghề nghiệp";
            // 
            // dtpngayhanthe
            // 
            this.dtpngayhanthe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngayhanthe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngayhanthe.Location = new System.Drawing.Point(1041, 131);
            this.dtpngayhanthe.Name = "dtpngayhanthe";
            this.dtpngayhanthe.Size = new System.Drawing.Size(181, 34);
            this.dtpngayhanthe.TabIndex = 18;
            // 
            // lblsodienthoai
            // 
            this.lblsodienthoai.AutoSize = true;
            this.lblsodienthoai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsodienthoai.Location = new System.Drawing.Point(382, 183);
            this.lblsodienthoai.Name = "lblsodienthoai";
            this.lblsodienthoai.Size = new System.Drawing.Size(138, 28);
            this.lblsodienthoai.TabIndex = 9;
            this.lblsodienthoai.Text = "Số điện thoại";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(382, 131);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(64, 28);
            this.lblemail.TabIndex = 8;
            this.lblemail.Text = "Email";
            // 
            // dtpngaycapthe
            // 
            this.dtpngaycapthe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaycapthe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaycapthe.Location = new System.Drawing.Point(1041, 79);
            this.dtpngaycapthe.Name = "dtpngaycapthe";
            this.dtpngaycapthe.Size = new System.Drawing.Size(181, 34);
            this.dtpngaycapthe.TabIndex = 17;
            // 
            // lblhotendocgia
            // 
            this.lblhotendocgia.AutoSize = true;
            this.lblhotendocgia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhotendocgia.Location = new System.Drawing.Point(382, 79);
            this.lblhotendocgia.Name = "lblhotendocgia";
            this.lblhotendocgia.Size = new System.Drawing.Size(76, 28);
            this.lblhotendocgia.TabIndex = 7;
            this.lblhotendocgia.Text = "Họ tên";
            // 
            // lblngaycapthe
            // 
            this.lblngaycapthe.AutoSize = true;
            this.lblngaycapthe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblngaycapthe.Location = new System.Drawing.Point(881, 79);
            this.lblngaycapthe.Name = "lblngaycapthe";
            this.lblngaycapthe.Size = new System.Drawing.Size(138, 28);
            this.lblngaycapthe.TabIndex = 11;
            this.lblngaycapthe.Text = "Ngày cấp thẻ";
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
            this.txtsodienthoai.Location = new System.Drawing.Point(552, 183);
            this.txtsodienthoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.PlaceholderText = "";
            this.txtsodienthoai.SelectedText = "";
            this.txtsodienthoai.Size = new System.Drawing.Size(276, 42);
            this.txtsodienthoai.TabIndex = 16;
            // 
            // lblmathemuon
            // 
            this.lblmathemuon.AutoSize = true;
            this.lblmathemuon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmathemuon.Location = new System.Drawing.Point(382, 27);
            this.lblmathemuon.Name = "lblmathemuon";
            this.lblmathemuon.Size = new System.Drawing.Size(141, 28);
            this.lblmathemuon.TabIndex = 6;
            this.lblmathemuon.Text = "Mã thẻ mượn";
            // 
            // lblngayhanthe
            // 
            this.lblngayhanthe.AutoSize = true;
            this.lblngayhanthe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblngayhanthe.Location = new System.Drawing.Point(881, 131);
            this.lblngayhanthe.Name = "lblngayhanthe";
            this.lblngayhanthe.Size = new System.Drawing.Size(140, 28);
            this.lblngayhanthe.TabIndex = 12;
            this.lblngayhanthe.Text = "Ngày hạn thẻ";
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
            this.txtemaildocgia.Location = new System.Drawing.Point(552, 131);
            this.txtemaildocgia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtemaildocgia.Name = "txtemaildocgia";
            this.txtemaildocgia.PlaceholderText = "";
            this.txtemaildocgia.SelectedText = "";
            this.txtemaildocgia.Size = new System.Drawing.Size(276, 42);
            this.txtemaildocgia.TabIndex = 15;
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
            this.cbnghenghiep.Location = new System.Drawing.Point(1041, 27);
            this.cbnghenghiep.Name = "cbnghenghiep";
            this.cbnghenghiep.Size = new System.Drawing.Size(181, 36);
            this.cbnghenghiep.TabIndex = 4;
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
            this.txtmathemuon.Location = new System.Drawing.Point(552, 27);
            this.txtmathemuon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmathemuon.Name = "txtmathemuon";
            this.txtmathemuon.PlaceholderText = "";
            this.txtmathemuon.SelectedText = "";
            this.txtmathemuon.Size = new System.Drawing.Size(276, 42);
            this.txtmathemuon.TabIndex = 13;
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
            this.txthoten.Location = new System.Drawing.Point(552, 79);
            this.txthoten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txthoten.Name = "txthoten";
            this.txthoten.PlaceholderText = "";
            this.txthoten.SelectedText = "";
            this.txthoten.Size = new System.Drawing.Size(276, 42);
            this.txthoten.TabIndex = 14;
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
            this.txtnhaptendocgia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnhaptendocgia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnhaptendocgia.Location = new System.Drawing.Point(288, 104);
            this.txtnhaptendocgia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnhaptendocgia.Name = "txtnhaptendocgia";
            this.txtnhaptendocgia.PlaceholderText = "";
            this.txtnhaptendocgia.SelectedText = "";
            this.txtnhaptendocgia.Size = new System.Drawing.Size(1101, 56);
            this.txtnhaptendocgia.TabIndex = 5;
            // 
            // cbtentruong
            // 
            this.cbtentruong.BackColor = System.Drawing.Color.Transparent;
            this.cbtentruong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbtentruong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtentruong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbtentruong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbtentruong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtentruong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbtentruong.ItemHeight = 30;
            this.cbtentruong.Items.AddRange(new object[] {
            "Độc giả"});
            this.cbtentruong.Location = new System.Drawing.Point(117, 104);
            this.cbtentruong.Name = "cbtentruong";
            this.cbtentruong.Size = new System.Drawing.Size(164, 36);
            this.cbtentruong.TabIndex = 3;
            // 
            // lbltentruong
            // 
            this.lbltentruong.AutoSize = true;
            this.lbltentruong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltentruong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbltentruong.Location = new System.Drawing.Point(112, 69);
            this.lbltentruong.Name = "lbltentruong";
            this.lbltentruong.Size = new System.Drawing.Size(117, 28);
            this.lbltentruong.TabIndex = 1;
            this.lbltentruong.Text = "Tên trường";
            // 
            // lblquanlydocgia
            // 
            this.lblquanlydocgia.AutoSize = true;
            this.lblquanlydocgia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblquanlydocgia.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquanlydocgia.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblquanlydocgia.Location = new System.Drawing.Point(554, 19);
            this.lblquanlydocgia.Name = "lblquanlydocgia";
            this.lblquanlydocgia.Size = new System.Drawing.Size(371, 54);
            this.lblquanlydocgia.TabIndex = 0;
            this.lblquanlydocgia.Text = "QUẢN LÝ ĐỘC GIẢ";
            // 
            // pnldown
            // 
            this.pnldown.Controls.Add(this.btnsuadg);
            this.pnldown.Controls.Add(this.btnxoadg);
            this.pnldown.Controls.Add(this.btnthemdg);
            this.pnldown.Controls.Add(this.btntaomoidg);
            this.pnldown.Controls.Add(this.dgvdocgia);
            this.pnldown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldown.Location = new System.Drawing.Point(3, 410);
            this.pnldown.Name = "pnldown";
            this.pnldown.Size = new System.Drawing.Size(1510, 452);
            this.pnldown.TabIndex = 1;
            // 
            // btnsuadg
            // 
            this.btnsuadg.BorderRadius = 15;
            this.btnsuadg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsuadg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsuadg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsuadg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsuadg.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnsuadg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuadg.ForeColor = System.Drawing.Color.White;
            this.btnsuadg.Location = new System.Drawing.Point(1030, 403);
            this.btnsuadg.Name = "btnsuadg";
            this.btnsuadg.Size = new System.Drawing.Size(160, 46);
            this.btnsuadg.TabIndex = 4;
            this.btnsuadg.Text = "Sửa";
            // 
            // btnxoadg
            // 
            this.btnxoadg.BorderRadius = 15;
            this.btnxoadg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnxoadg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnxoadg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnxoadg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnxoadg.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnxoadg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoadg.ForeColor = System.Drawing.Color.White;
            this.btnxoadg.Location = new System.Drawing.Point(796, 403);
            this.btnxoadg.Name = "btnxoadg";
            this.btnxoadg.Size = new System.Drawing.Size(160, 46);
            this.btnxoadg.TabIndex = 3;
            this.btnxoadg.Text = "Xóa";
            // 
            // btnthemdg
            // 
            this.btnthemdg.BorderRadius = 15;
            this.btnthemdg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthemdg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthemdg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthemdg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthemdg.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnthemdg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemdg.ForeColor = System.Drawing.Color.White;
            this.btnthemdg.Location = new System.Drawing.Point(556, 403);
            this.btnthemdg.Name = "btnthemdg";
            this.btnthemdg.Size = new System.Drawing.Size(160, 46);
            this.btnthemdg.TabIndex = 2;
            this.btnthemdg.Text = "Thêm";
            // 
            // btntaomoidg
            // 
            this.btntaomoidg.BorderRadius = 15;
            this.btntaomoidg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntaomoidg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntaomoidg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntaomoidg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntaomoidg.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btntaomoidg.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaomoidg.ForeColor = System.Drawing.Color.White;
            this.btntaomoidg.Location = new System.Drawing.Point(321, 403);
            this.btntaomoidg.Name = "btntaomoidg";
            this.btntaomoidg.Size = new System.Drawing.Size(160, 46);
            this.btntaomoidg.TabIndex = 1;
            this.btntaomoidg.Text = "Tạo mới";
            // 
            // dgvdocgia
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvdocgia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdocgia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdocgia.ColumnHeadersHeight = 4;
            this.dgvdocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdocgia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdocgia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvdocgia.Location = new System.Drawing.Point(117, -6);
            this.dgvdocgia.Name = "dgvdocgia";
            this.dgvdocgia.RowHeadersVisible = false;
            this.dgvdocgia.RowHeadersWidth = 62;
            this.dgvdocgia.RowTemplate.Height = 28;
            this.dgvdocgia.Size = new System.Drawing.Size(1272, 388);
            this.dgvdocgia.TabIndex = 0;
            this.dgvdocgia.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvdocgia.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvdocgia.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvdocgia.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvdocgia.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvdocgia.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvdocgia.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvdocgia.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvdocgia.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvdocgia.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvdocgia.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvdocgia.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvdocgia.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvdocgia.ThemeStyle.ReadOnly = false;
            this.dgvdocgia.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvdocgia.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvdocgia.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvdocgia.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvdocgia.ThemeStyle.RowsStyle.Height = 28;
            this.dgvdocgia.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvdocgia.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // UC_Reader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UC_Reader";
            this.Size = new System.Drawing.Size(1516, 865);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.grbthongtindocgia.ResumeLayout(false);
            this.grbthongtindocgia.PerformLayout();
            this.pnldown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdocgia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel pnltop;
        private System.Windows.Forms.Label lbltentruong;
        private System.Windows.Forms.Label lblquanlydocgia;
        private Guna.UI2.WinForms.Guna2Panel pnldown;
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
        private Guna.UI2.WinForms.Guna2DataGridView dgvdocgia;
        private Guna.UI2.WinForms.Guna2Button btnsuadg;
        private Guna.UI2.WinForms.Guna2Button btnxoadg;
        private Guna.UI2.WinForms.Guna2Button btnthemdg;
        private Guna.UI2.WinForms.Guna2Button btntaomoidg;
        private System.Windows.Forms.GroupBox grbthongtindocgia;
    }
}
