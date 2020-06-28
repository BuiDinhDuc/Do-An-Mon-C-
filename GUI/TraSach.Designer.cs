namespace Quản_lý_thư_viện_Tri_Thức
{
    partial class TraSach
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
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaTra = new System.Windows.Forms.TextBox();
            this.txtMaMuon = new System.Windows.Forms.TextBox();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.dtgv_MuonSach = new System.Windows.Forms.DataGridView();
            this.MaMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MuonSach)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThongTin
            // 
            this.grpThongTin.Controls.Add(this.btnTraSach);
            this.grpThongTin.Controls.Add(this.txtTenSach);
            this.grpThongTin.Controls.Add(this.label1);
            this.grpThongTin.Controls.Add(this.txtSoLuong);
            this.grpThongTin.Controls.Add(this.txtMaTra);
            this.grpThongTin.Controls.Add(this.txtMaMuon);
            this.grpThongTin.Controls.Add(this.lblMaSach);
            this.grpThongTin.Controls.Add(this.lblTheLoai);
            this.grpThongTin.Controls.Add(this.lblTenSach);
            this.grpThongTin.Location = new System.Drawing.Point(775, 158);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(356, 253);
            this.grpThongTin.TabIndex = 16;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin chi tiết";
            // 
            // btnTraSach
            // 
            this.btnTraSach.Location = new System.Drawing.Point(145, 209);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(75, 23);
            this.btnTraSach.TabIndex = 20;
            this.btnTraSach.Text = "Trả sách";
            this.btnTraSach.UseVisualStyleBackColor = true;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(145, 90);
            this.txtTenSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.ReadOnly = true;
            this.txtTenSach.Size = new System.Drawing.Size(195, 23);
            this.txtTenSach.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên sách";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(145, 120);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.Size = new System.Drawing.Size(195, 23);
            this.txtSoLuong.TabIndex = 17;
            // 
            // txtMaTra
            // 
            this.txtMaTra.Location = new System.Drawing.Point(145, 30);
            this.txtMaTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTra.Name = "txtMaTra";
            this.txtMaTra.ReadOnly = true;
            this.txtMaTra.Size = new System.Drawing.Size(195, 23);
            this.txtMaTra.TabIndex = 0;
            // 
            // txtMaMuon
            // 
            this.txtMaMuon.Location = new System.Drawing.Point(145, 60);
            this.txtMaMuon.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaMuon.Name = "txtMaMuon";
            this.txtMaMuon.ReadOnly = true;
            this.txtMaMuon.Size = new System.Drawing.Size(195, 23);
            this.txtMaMuon.TabIndex = 1;
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSach.Location = new System.Drawing.Point(30, 33);
            this.lblMaSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(48, 17);
            this.lblMaSach.TabIndex = 0;
            this.lblMaSach.Text = "Mã trả";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheLoai.Location = new System.Drawing.Point(30, 123);
            this.lblTheLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(64, 17);
            this.lblTheLoai.TabIndex = 0;
            this.lblTheLoai.Text = "Số lượng";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSach.Location = new System.Drawing.Point(30, 63);
            this.lblTenSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(66, 17);
            this.lblTenSach.TabIndex = 0;
            this.lblTenSach.Text = "Mã mượn";
            // 
            // dtgv_MuonSach
            // 
            this.dtgv_MuonSach.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgv_MuonSach.ColumnHeadersHeight = 25;
            this.dtgv_MuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMuon,
            this.MaSach,
            this.SoLuong});
            this.dtgv_MuonSach.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgv_MuonSach.Location = new System.Drawing.Point(1, 158);
            this.dtgv_MuonSach.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv_MuonSach.Name = "dtgv_MuonSach";
            this.dtgv_MuonSach.ReadOnly = true;
            this.dtgv_MuonSach.RowHeadersWidth = 51;
            this.dtgv_MuonSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_MuonSach.Size = new System.Drawing.Size(750, 400);
            this.dtgv_MuonSach.TabIndex = 15;
            this.dtgv_MuonSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_MuonSach_CellClick);
            // 
            // MaMuon
            // 
            this.MaMuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaMuon.DataPropertyName = "MaMuon";
            this.MaMuon.HeaderText = "Mã mượn";
            this.MaMuon.MinimumWidth = 6;
            this.MaMuon.Name = "MaMuon";
            this.MaMuon.ReadOnly = true;
            this.MaMuon.Width = 150;
            // 
            // MaSach
            // 
            this.MaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.FillWeight = 450F;
            this.MaSach.HeaderText = "Tên Sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaSach.Width = 450;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.FillWeight = 50F;
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(445, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 63);
            this.label2.TabIndex = 17;
            this.label2.Text = "Trả sách";
            // 
            // TraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.dtgv_MuonSach);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TraSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả sách";
            this.Load += new System.EventHandler(this.TraSach_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MuonSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaTra;
        private System.Windows.Forms.TextBox txtMaMuon;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label lblTheLoai;
        private System.Windows.Forms.Label lblTenSach;
        public System.Windows.Forms.DataGridView dtgv_MuonSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMuon;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Label label2;
    }
}