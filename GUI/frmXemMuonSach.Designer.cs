namespace Quản_lý_thư_viện_Tri_Thức
{
    partial class frmXemMuonSach
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtMaMuon = new System.Windows.Forms.TextBox();
            this.txtNguoiLap = new System.Windows.Forms.TextBox();
            this.txtSoThe = new System.Windows.Forms.TextBox();
            this.dtgvMuonSach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.MaMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMuonSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(786, 38);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(396, 38);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(370, 23);
            this.txtTimKiem.TabIndex = 1;
            // 
            // txtMaMuon
            // 
            this.txtMaMuon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMaMuon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMaMuon.Location = new System.Drawing.Point(521, 120);
            this.txtMaMuon.Name = "txtMaMuon";
            this.txtMaMuon.Size = new System.Drawing.Size(340, 23);
            this.txtMaMuon.TabIndex = 4;
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.Location = new System.Drawing.Point(521, 194);
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.Size = new System.Drawing.Size(340, 23);
            this.txtNguoiLap.TabIndex = 5;
            // 
            // txtSoThe
            // 
            this.txtSoThe.Location = new System.Drawing.Point(521, 156);
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.Size = new System.Drawing.Size(340, 23);
            this.txtSoThe.TabIndex = 6;
            // 
            // dtgvMuonSach
            // 
            this.dtgvMuonSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMuon,
            this.SoThe,
            this.MaNV,
            this.NgayMuon});
            this.dtgvMuonSach.Location = new System.Drawing.Point(163, 286);
            this.dtgvMuonSach.Name = "dtgvMuonSach";
            this.dtgvMuonSach.ReadOnly = true;
            this.dtgvMuonSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMuonSach.Size = new System.Drawing.Size(880, 263);
            this.dtgvMuonSach.TabIndex = 7;
            this.dtgvMuonSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMuonSach_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã mượn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số thẻ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Người lập";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày lập";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(521, 241);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(340, 23);
            this.dtpNgayLap.TabIndex = 12;
            // 
            // MaMuon
            // 
            this.MaMuon.DataPropertyName = "MaMuon";
            this.MaMuon.HeaderText = "Mã mượn";
            this.MaMuon.Name = "MaMuon";
            // 
            // SoThe
            // 
            this.SoThe.DataPropertyName = "SoThe";
            this.SoThe.HeaderText = "Số thẻ";
            this.SoThe.Name = "SoThe";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.Name = "NgayMuon";
            // 
            // frmXemMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 561);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvMuonSach);
            this.Controls.Add(this.txtSoThe);
            this.Controls.Add(this.txtNguoiLap);
            this.Controls.Add(this.txtMaMuon);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXemMuonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXemMuonSach";
            this.Load += new System.EventHandler(this.frmXemMuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMuonSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtMaMuon;
        private System.Windows.Forms.TextBox txtNguoiLap;
        private System.Windows.Forms.TextBox txtSoThe;
        private System.Windows.Forms.DataGridView dtgvMuonSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
    }
}