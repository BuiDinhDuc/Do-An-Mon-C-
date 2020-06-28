namespace Quản_lý_thư_viện_Tri_Thức
{
    partial class frmXemTraSach
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
            this.dtgv_MuonSach = new System.Windows.Forms.DataGridView();
            this.MaTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MuonSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_MuonSach
            // 
            this.dtgv_MuonSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_MuonSach.BackgroundColor = System.Drawing.Color.Silver;
            this.dtgv_MuonSach.ColumnHeadersHeight = 25;
            this.dtgv_MuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTra,
            this.MaSach,
            this.SoLuong,
            this.NgayTra});
            this.dtgv_MuonSach.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgv_MuonSach.Location = new System.Drawing.Point(110, 167);
            this.dtgv_MuonSach.Margin = new System.Windows.Forms.Padding(4);
            this.dtgv_MuonSach.Name = "dtgv_MuonSach";
            this.dtgv_MuonSach.ReadOnly = true;
            this.dtgv_MuonSach.RowHeadersWidth = 51;
            this.dtgv_MuonSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_MuonSach.Size = new System.Drawing.Size(913, 400);
            this.dtgv_MuonSach.TabIndex = 16;
            this.dtgv_MuonSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_MuonSach_CellContentClick);
            // 
            // MaTra
            // 
            this.MaTra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaTra.DataPropertyName = "MaTra";
            this.MaTra.HeaderText = "Mã trả";
            this.MaTra.MinimumWidth = 6;
            this.MaTra.Name = "MaTra";
            this.MaTra.ReadOnly = true;
            this.MaTra.Width = 150;
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
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày trả";
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.ReadOnly = true;
            // 
            // frmXemTraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 600);
            this.Controls.Add(this.dtgv_MuonSach);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmXemTraSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXemTraSach";
            this.Load += new System.EventHandler(this.frmXemTraSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MuonSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dtgv_MuonSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTra;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
    }
}