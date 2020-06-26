namespace Quản_lý_thư_viện_Tri_Thức
{
    partial class frmThongKeMuonSach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.rdoCrystal = new System.Windows.Forms.RadioButton();
            this.cbbDauSach = new System.Windows.Forms.ComboBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.rdoHoaDon = new System.Windows.Forms.RadioButton();
            this.rdoTheoNhom = new System.Windows.Forms.RadioButton();
            this.rdoTheoDauSach = new System.Windows.Forms.RadioButton();
            this.rdoTatCaSach = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.rdoCrystal);
            this.groupBox1.Controls.Add(this.cbbDauSach);
            this.groupBox1.Controls.Add(this.btnXacNhan);
            this.groupBox1.Controls.Add(this.rdoHoaDon);
            this.groupBox1.Controls.Add(this.rdoTheoNhom);
            this.groupBox1.Controls.Add(this.rdoTheoDauSach);
            this.groupBox1.Controls.Add(this.rdoTatCaSach);
            this.groupBox1.Location = new System.Drawing.Point(88, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 380);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại thống kê";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(467, 294);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 36);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // rdoCrystal
            // 
            this.rdoCrystal.AutoSize = true;
            this.rdoCrystal.Location = new System.Drawing.Point(13, 80);
            this.rdoCrystal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoCrystal.Name = "rdoCrystal";
            this.rdoCrystal.Size = new System.Drawing.Size(152, 17);
            this.rdoCrystal.TabIndex = 6;
            this.rdoCrystal.Text = "Tất cả sách (Crystal report)";
            this.rdoCrystal.UseVisualStyleBackColor = true;
            // 
            // cbbDauSach
            // 
            this.cbbDauSach.FormattingEnabled = true;
            this.cbbDauSach.Location = new System.Drawing.Point(185, 129);
            this.cbbDauSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbDauSach.Name = "cbbDauSach";
            this.cbbDauSach.Size = new System.Drawing.Size(203, 21);
            this.cbbDauSach.TabIndex = 5;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(280, 294);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(108, 36);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // rdoHoaDon
            // 
            this.rdoHoaDon.AutoSize = true;
            this.rdoHoaDon.Location = new System.Drawing.Point(13, 230);
            this.rdoHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoHoaDon.Name = "rdoHoaDon";
            this.rdoHoaDon.Size = new System.Drawing.Size(124, 17);
            this.rdoHoaDon.TabIndex = 3;
            this.rdoHoaDon.Text = "Hóa đơn (dữ liệu giả)";
            this.rdoHoaDon.UseVisualStyleBackColor = true;
            // 
            // rdoTheoNhom
            // 
            this.rdoTheoNhom.AutoSize = true;
            this.rdoTheoNhom.Location = new System.Drawing.Point(13, 180);
            this.rdoTheoNhom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoTheoNhom.Name = "rdoTheoNhom";
            this.rdoTheoNhom.Size = new System.Drawing.Size(103, 17);
            this.rdoTheoNhom.TabIndex = 2;
            this.rdoTheoNhom.Text = "Sách theo nhóm";
            this.rdoTheoNhom.UseVisualStyleBackColor = true;
            // 
            // rdoTheoDauSach
            // 
            this.rdoTheoDauSach.AutoSize = true;
            this.rdoTheoDauSach.Location = new System.Drawing.Point(13, 130);
            this.rdoTheoDauSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoTheoDauSach.Name = "rdoTheoDauSach";
            this.rdoTheoDauSach.Size = new System.Drawing.Size(122, 17);
            this.rdoTheoDauSach.TabIndex = 1;
            this.rdoTheoDauSach.Text = "Sách theo đầu sách";
            this.rdoTheoDauSach.UseVisualStyleBackColor = true;
            // 
            // rdoTatCaSach
            // 
            this.rdoTatCaSach.AutoSize = true;
            this.rdoTatCaSach.Location = new System.Drawing.Point(13, 30);
            this.rdoTatCaSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoTatCaSach.Name = "rdoTatCaSach";
            this.rdoTatCaSach.Size = new System.Drawing.Size(82, 17);
            this.rdoTatCaSach.TabIndex = 0;
            this.rdoTatCaSach.Text = "Tất cả sách";
            this.rdoTatCaSach.UseVisualStyleBackColor = true;
            // 
            // frmThongKeMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmThongKeMuonSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbDauSach;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.RadioButton rdoHoaDon;
        private System.Windows.Forms.RadioButton rdoTheoNhom;
        private System.Windows.Forms.RadioButton rdoTheoDauSach;
        private System.Windows.Forms.RadioButton rdoTatCaSach;
        private System.Windows.Forms.RadioButton rdoCrystal;
        private System.Windows.Forms.Button btnHuy;
    }
}