namespace QLThuVien
{
    partial class UCQuanLyMuonTra
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
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPhieuMuon = new Guna.UI2.WinForms.Guna2Button();
            this.btnPhieuTra = new Guna.UI2.WinForms.Guna2Button();
            this.btnPhieuPhat = new Guna.UI2.WinForms.Guna2Button();
            this.panelNoiDung = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnPhieuMuon);
            this.panelMenu.Controls.Add(this.btnPhieuTra);
            this.panelMenu.Controls.Add(this.btnPhieuPhat);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(2409, 83);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnPhieuMuon
            // 
            this.btnPhieuMuon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhieuMuon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhieuMuon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhieuMuon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhieuMuon.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPhieuMuon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuMuon.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPhieuMuon.Location = new System.Drawing.Point(4, 5);
            this.btnPhieuMuon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPhieuMuon.Name = "btnPhieuMuon";
            this.btnPhieuMuon.Size = new System.Drawing.Size(600, 70);
            this.btnPhieuMuon.TabIndex = 1;
            this.btnPhieuMuon.Text = "PHIẾU MƯỢN";
            this.btnPhieuMuon.Click += new System.EventHandler(this.btnPhieuMuon_Click);
            // 
            // btnPhieuTra
            // 
            this.btnPhieuTra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhieuTra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhieuTra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhieuTra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhieuTra.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPhieuTra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuTra.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPhieuTra.Location = new System.Drawing.Point(612, 5);
            this.btnPhieuTra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPhieuTra.Name = "btnPhieuTra";
            this.btnPhieuTra.Size = new System.Drawing.Size(600, 70);
            this.btnPhieuTra.TabIndex = 2;
            this.btnPhieuTra.Text = "PHIẾU TRẢ";
            this.btnPhieuTra.VisibleChanged += new System.EventHandler(this.btnPhieuTra_Click);
            this.btnPhieuTra.Click += new System.EventHandler(this.btnPhieuTra_Click);
            // 
            // btnPhieuPhat
            // 
            this.btnPhieuPhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhieuPhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhieuPhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhieuPhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhieuPhat.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPhieuPhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuPhat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPhieuPhat.Location = new System.Drawing.Point(1220, 5);
            this.btnPhieuPhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPhieuPhat.Name = "btnPhieuPhat";
            this.btnPhieuPhat.Size = new System.Drawing.Size(570, 70);
            this.btnPhieuPhat.TabIndex = 3;
            this.btnPhieuPhat.Text = "PHIẾU PHẠT";
            this.btnPhieuPhat.Click += new System.EventHandler(this.btnPhieuPhat_Click);
            // 
            // panelNoiDung
            // 
            this.panelNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNoiDung.Location = new System.Drawing.Point(0, 0);
            this.panelNoiDung.Margin = new System.Windows.Forms.Padding(0);
            this.panelNoiDung.Name = "panelNoiDung";
            this.panelNoiDung.Size = new System.Drawing.Size(2409, 995);
            this.panelNoiDung.TabIndex = 1;
            this.panelNoiDung.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNoiDung_Paint_1);
            // 
            // UCQuanLyMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelNoiDung);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UCQuanLyMuonTra";
            this.Size = new System.Drawing.Size(2409, 995);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private Guna.UI2.WinForms.Guna2Button btnPhieuMuon;
        private Guna.UI2.WinForms.Guna2Button btnPhieuTra;
        private Guna.UI2.WinForms.Guna2Button btnPhieuPhat;
        private System.Windows.Forms.Panel panelNoiDung;
    }
}
