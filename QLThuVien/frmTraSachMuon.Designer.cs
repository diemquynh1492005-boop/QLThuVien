namespace QLThuVien
{
    partial class frmTraSachMuon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTraSachMuon = new System.Windows.Forms.Label();
            this.pnlThongTin = new System.Windows.Forms.Panel();
            this.txtMaDGTSM = new System.Windows.Forms.TextBox();
            this.lblTSM2 = new System.Windows.Forms.Label();
            this.txtMaPMTSM = new System.Windows.Forms.TextBox();
            this.lblTSM = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSachDaMuon = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSachDaTra = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnChuyen = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaTSM = new Guna.UI2.WinForms.Guna2Button();
            this.btnLuuTSM = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.pnlThongTin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDaMuon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDaTra)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.lblTraSachMuon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 57);
            this.panel1.TabIndex = 0;
            // 
            // lblTraSachMuon
            // 
            this.lblTraSachMuon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTraSachMuon.AutoSize = true;
            this.lblTraSachMuon.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblTraSachMuon.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraSachMuon.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTraSachMuon.Location = new System.Drawing.Point(393, 9);
            this.lblTraSachMuon.Name = "lblTraSachMuon";
            this.lblTraSachMuon.Size = new System.Drawing.Size(316, 46);
            this.lblTraSachMuon.TabIndex = 0;
            this.lblTraSachMuon.Text = "TRẢ SÁCH MƯỢN ";
            this.lblTraSachMuon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlThongTin
            // 
            this.pnlThongTin.Controls.Add(this.txtMaDGTSM);
            this.pnlThongTin.Controls.Add(this.lblTSM2);
            this.pnlThongTin.Controls.Add(this.txtMaPMTSM);
            this.pnlThongTin.Controls.Add(this.lblTSM);
            this.pnlThongTin.Location = new System.Drawing.Point(0, 88);
            this.pnlThongTin.Name = "pnlThongTin";
            this.pnlThongTin.Size = new System.Drawing.Size(1100, 67);
            this.pnlThongTin.TabIndex = 1;
            // 
            // txtMaDGTSM
            // 
            this.txtMaDGTSM.Location = new System.Drawing.Point(629, 23);
            this.txtMaDGTSM.Name = "txtMaDGTSM";
            this.txtMaDGTSM.Size = new System.Drawing.Size(173, 22);
            this.txtMaDGTSM.TabIndex = 3;
            // 
            // lblTSM2
            // 
            this.lblTSM2.AutoSize = true;
            this.lblTSM2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSM2.Location = new System.Drawing.Point(543, 21);
            this.lblTSM2.Name = "lblTSM2";
            this.lblTSM2.Size = new System.Drawing.Size(65, 23);
            this.lblTSM2.TabIndex = 2;
            this.lblTSM2.Text = "Mã ĐG";
            // 
            // txtMaPMTSM
            // 
            this.txtMaPMTSM.Location = new System.Drawing.Point(143, 21);
            this.txtMaPMTSM.Name = "txtMaPMTSM";
            this.txtMaPMTSM.Size = new System.Drawing.Size(164, 22);
            this.txtMaPMTSM.TabIndex = 1;
            // 
            // lblTSM
            // 
            this.lblTSM.AutoSize = true;
            this.lblTSM.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTSM.Location = new System.Drawing.Point(63, 21);
            this.lblTSM.Name = "lblTSM";
            this.lblTSM.Size = new System.Drawing.Size(66, 23);
            this.lblTSM.TabIndex = 0;
            this.lblTSM.Text = "Mã PM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSachDaMuon);
            this.groupBox1.Location = new System.Drawing.Point(43, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 297);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sách đã mượn";
            // 
            // dgvSachDaMuon
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.dgvSachDaMuon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSachDaMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvSachDaMuon.ColumnHeadersHeight = 4;
            this.dgvSachDaMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSachDaMuon.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvSachDaMuon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSachDaMuon.Location = new System.Drawing.Point(7, 32);
            this.dgvSachDaMuon.Name = "dgvSachDaMuon";
            this.dgvSachDaMuon.RowHeadersVisible = false;
            this.dgvSachDaMuon.RowHeadersWidth = 51;
            this.dgvSachDaMuon.RowTemplate.Height = 24;
            this.dgvSachDaMuon.Size = new System.Drawing.Size(431, 259);
            this.dgvSachDaMuon.TabIndex = 0;
            this.dgvSachDaMuon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSachDaMuon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSachDaMuon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSachDaMuon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSachDaMuon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSachDaMuon.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSachDaMuon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSachDaMuon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSachDaMuon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSachDaMuon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSachDaMuon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSachDaMuon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSachDaMuon.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvSachDaMuon.ThemeStyle.ReadOnly = false;
            this.dgvSachDaMuon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSachDaMuon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSachDaMuon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSachDaMuon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSachDaMuon.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSachDaMuon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSachDaMuon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSachDaTra);
            this.groupBox2.Location = new System.Drawing.Point(629, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 297);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sách đã trả";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dgvSachDaTra
            // 
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.dgvSachDaTra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSachDaTra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvSachDaTra.ColumnHeadersHeight = 4;
            this.dgvSachDaTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSachDaTra.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvSachDaTra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSachDaTra.Location = new System.Drawing.Point(6, 32);
            this.dgvSachDaTra.Name = "dgvSachDaTra";
            this.dgvSachDaTra.RowHeadersVisible = false;
            this.dgvSachDaTra.RowHeadersWidth = 51;
            this.dgvSachDaTra.RowTemplate.Height = 24;
            this.dgvSachDaTra.Size = new System.Drawing.Size(406, 259);
            this.dgvSachDaTra.TabIndex = 0;
            this.dgvSachDaTra.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSachDaTra.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSachDaTra.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSachDaTra.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSachDaTra.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSachDaTra.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSachDaTra.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSachDaTra.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSachDaTra.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSachDaTra.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSachDaTra.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSachDaTra.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSachDaTra.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvSachDaTra.ThemeStyle.ReadOnly = false;
            this.dgvSachDaTra.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSachDaTra.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSachDaTra.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSachDaTra.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSachDaTra.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSachDaTra.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSachDaTra.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnChuyen
            // 
            this.btnChuyen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChuyen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChuyen.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnChuyen.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyen.ForeColor = System.Drawing.Color.White;
            this.btnChuyen.Location = new System.Drawing.Point(523, 314);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(85, 45);
            this.btnChuyen.TabIndex = 4;
            this.btnChuyen.Text = ">>";
            // 
            // btnXoaTSM
            // 
            this.btnXoaTSM.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTSM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaTSM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaTSM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaTSM.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoaTSM.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTSM.ForeColor = System.Drawing.Color.White;
            this.btnXoaTSM.Location = new System.Drawing.Point(700, 510);
            this.btnXoaTSM.Name = "btnXoaTSM";
            this.btnXoaTSM.Size = new System.Drawing.Size(115, 45);
            this.btnXoaTSM.TabIndex = 5;
            this.btnXoaTSM.Text = "XÓA";
            // 
            // btnLuuTSM
            // 
            this.btnLuuTSM.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuTSM.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuuTSM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuuTSM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuuTSM.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnLuuTSM.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTSM.ForeColor = System.Drawing.Color.White;
            this.btnLuuTSM.Location = new System.Drawing.Point(863, 510);
            this.btnLuuTSM.Name = "btnLuuTSM";
            this.btnLuuTSM.Size = new System.Drawing.Size(116, 45);
            this.btnLuuTSM.TabIndex = 6;
            this.btnLuuTSM.Text = "LƯU";
            // 
            // frmTraSachMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1100, 567);
            this.Controls.Add(this.btnLuuTSM);
            this.Controls.Add(this.btnXoaTSM);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlThongTin);
            this.Controls.Add(this.panel1);
            this.Name = "frmTraSachMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTraSachMuon";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlThongTin.ResumeLayout(false);
            this.pnlThongTin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDaMuon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachDaTra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTraSachMuon;
        private System.Windows.Forms.Panel pnlThongTin;
        private System.Windows.Forms.Label lblTSM;
        private System.Windows.Forms.TextBox txtMaDGTSM;
        private System.Windows.Forms.Label lblTSM2;
        private System.Windows.Forms.TextBox txtMaPMTSM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button btnChuyen;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSachDaMuon;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSachDaTra;
        private Guna.UI2.WinForms.Guna2Button btnXoaTSM;
        private Guna.UI2.WinForms.Guna2Button btnLuuTSM;
    }
}