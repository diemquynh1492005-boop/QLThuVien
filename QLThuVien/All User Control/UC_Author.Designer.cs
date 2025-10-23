namespace QLThuVien.All_User_Control
{
    partial class UC_Author
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnltop = new Guna.UI2.WinForms.Guna2Panel();
            this.btntacgiasach = new Guna.UI2.WinForms.Guna2Button();
            this.btntacgia = new Guna.UI2.WinForms.Guna2Button();
            this.tablepanelbody = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnltop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnltop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tablepanelbody, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.472178F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.52782F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1252, 629);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnltop.Controls.Add(this.btntacgiasach);
            this.pnltop.Controls.Add(this.btntacgia);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnltop.Location = new System.Drawing.Point(3, 3);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1246, 41);
            this.pnltop.TabIndex = 0;
            // 
            // btntacgiasach
            // 
            this.btntacgiasach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntacgiasach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntacgiasach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntacgiasach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntacgiasach.FillColor = System.Drawing.Color.White;
            this.btntacgiasach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntacgiasach.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btntacgiasach.Location = new System.Drawing.Point(265, 0);
            this.btntacgiasach.Name = "btntacgiasach";
            this.btntacgiasach.Size = new System.Drawing.Size(180, 49);
            this.btntacgiasach.TabIndex = 1;
            this.btntacgiasach.Text = "Tác giả sách";
            this.btntacgiasach.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btntacgia
            // 
            this.btntacgia.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntacgia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntacgia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntacgia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntacgia.FillColor = System.Drawing.Color.White;
            this.btntacgia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntacgia.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btntacgia.Location = new System.Drawing.Point(51, 0);
            this.btntacgia.Name = "btntacgia";
            this.btntacgia.Size = new System.Drawing.Size(180, 49);
            this.btntacgia.TabIndex = 0;
            this.btntacgia.Text = "Tác giả";
            this.btntacgia.Click += new System.EventHandler(this.btntacgia_Click);
            // 
            // tablepanelbody
            // 
            this.tablepanelbody.ColumnCount = 1;
            this.tablepanelbody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablepanelbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablepanelbody.Location = new System.Drawing.Point(3, 50);
            this.tablepanelbody.Name = "tablepanelbody";
            this.tablepanelbody.RowCount = 1;
            this.tablepanelbody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablepanelbody.Size = new System.Drawing.Size(1246, 576);
            this.tablepanelbody.TabIndex = 1;
            // 
            // UC_Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UC_Author";
            this.Size = new System.Drawing.Size(1252, 629);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnltop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel pnltop;
        private Guna.UI2.WinForms.Guna2Button btntacgiasach;
        private Guna.UI2.WinForms.Guna2Button btntacgia;
        private System.Windows.Forms.TableLayoutPanel tablepanelbody;
    }
}
