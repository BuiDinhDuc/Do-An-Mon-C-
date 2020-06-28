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
    public partial class frmXemMuonSach : Form
    {
        MuonSachBUS muonSachBUS = new MuonSachBUS();
        public frmXemMuonSach()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmXemMuonSach_Load(object sender, EventArgs e)
        {
            dtgvMuonSach.AutoGenerateColumns = false;
            dtgvMuonSach.DataSource = muonSachBUS.LayDSMuonSach();
        }

        private void dtgvMuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;

            if (vitri < 0) return;
            else
            {
                NhanVienBUS nhanVienBUS = new NhanVienBUS();
                txtMaMuon.Text = dtgvMuonSach.Rows[vitri].Cells[0].Value.ToString();
                txtSoThe.Text = dtgvMuonSach.Rows[vitri].Cells[1].Value.ToString();
                txtNguoiLap.Text = nhanVienBUS.timNhanVien1(dtgvMuonSach.Rows[vitri].Cells[2].Value.ToString()).HoTenNV;
                dtpNgayLap.Value = (DateTime)dtgvMuonSach.Rows[vitri].Cells[3].Value;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != null)
            {
                dtgvMuonSach.AutoGenerateColumns = false;
                dtgvMuonSach.DataSource = muonSachBUS.TimMuonSach(txtTimKiem.Text);
            }
            else
            {
                dtgvMuonSach.AutoGenerateColumns = false;
                dtgvMuonSach.DataSource = muonSachBUS.LayDSMuonSach();
            }
        }
    }
}
