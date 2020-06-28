using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace Quản_lý_thư_viện_Tri_Thức
{
    public partial class TraSach : Form
    {
        CTMuonSachBUS cTMuonSachBUS = new CTMuonSachBUS();
        SachBUS sachBUS = new SachBUS();
        TraSachBUS traSachBUS = new TraSachBUS();
        CTTraSachBUS ctTraSachBUS = new CTTraSachBUS();
        public TraSach()
        {
            InitializeComponent();
        }

        private void TraSach_Load(object sender, EventArgs e)
        {
            txtMaTra.Text = traSachBUS.phatSinhMa();
            dtgv_MuonSach.AutoGenerateColumns = false;
            dtgv_MuonSach.DataSource = cTMuonSachBUS.LayDSCTMuonSach();


            DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)MaSach;

            col.DataSource = sachBUS.LayDSSach();
            col.DisplayMember = "TenSach";
            col.ValueMember = "MaSach";
        }

        private void dtgv_MuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            else
            {
                txtMaMuon.Text = dtgv_MuonSach.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenSach.Text = sachBUS.timSach(dtgv_MuonSach.Rows[e.RowIndex].Cells[1].Value.ToString()).TenSach;
                txtSoLuong.Text = dtgv_MuonSach.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            TraSachDTO traSachDTO = new TraSachDTO { 
                MaTra = txtMaTra.Text,
                NgayLap = DateTime.Now,
                MaMuon = txtMaMuon.Text,
                TrangThai = true
            
            };

            CTTraSachDTO ctTraSachDTO = new CTTraSachDTO {
                MaTra = txtMaTra.Text,
                MaSach = dtgv_MuonSach.Rows[dtgv_MuonSach.SelectedRows[0].Index].Cells[1].Value.ToString(),
                NgayTra = DateTime.Now,
                SoLuong = int.Parse(txtSoLuong.Text),
                TienPhat = 0,
                TrangThai = true,
                
            
            };

            if (traSachBUS.ThemTraSach(traSachDTO) && ctTraSachBUS.ThemCTTraSach(ctTraSachDTO) && cTMuonSachBUS.SuaCTMuonSach(txtMaMuon.Text, ctTraSachDTO.MaSach))
            {
                MessageBox.Show("Tra thanh cong");
                TraSach_Load(sender, e);
            }
            else
                MessageBox.Show("Tra that bai");
        }
    }
}
