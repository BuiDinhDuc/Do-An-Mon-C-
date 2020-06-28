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
    public partial class frmLapHoaDon : Form
    {
        List<CTMuonSachDTO> lstMuon = new List<CTMuonSachDTO>();

        CTMuonSachBUS ctMuonBUS = new CTMuonSachBUS();
        MuonSachBUS muonSachBUS = new MuonSachBUS();
        SachBUS SachBUS = new SachBUS();

         List<int> So = new List<int>();
          
    public frmLapHoaDon()
        {
            InitializeComponent();


        }
        
        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            foreach(MuonSachTamDTO item in frmTraSach.mst)
            {
                ListViewItem listViewItem = new ListViewItem(item.MaSach);
                listViewItem.SubItems.Add(item.TenSach);
                listViewItem.SubItems.Add(item.SoLuong.ToString());

                lsvSach.Items.Add(listViewItem);
            }

            txtMaMuon.Text = muonSachBUS.phatSinhMa();
            txtTenNhanVien.Text = frmTrangChu.NameofUser;

            dtpNgayLap.Value = dtpNgayTra.Value = DateTime.Now;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmTraSach.mst.Clear();

            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            List<SachMuonDTO> sachMuonDTOs = new List<SachMuonDTO>();

            MuonSachDTO muonSachDTO = new MuonSachDTO { 
                MaMuon = txtMaMuon.Text,
                SoThe = txtMaThe.Text,
                MaNV = frmDangNhap.MaNV,
                NgayMuon = dtpNgayLap.Value,
                NgayPhaiTra = dtpNgayTra.Value,
                TrangThai = true

            };

            List<CTMuonSachDTO> listCTMuon = new List<CTMuonSachDTO>();

            foreach (ListViewItem item in lsvSach.Items)
            {
                CTMuonSachDTO ct = new CTMuonSachDTO();
                ct.MaMuon = txtMaMuon.Text;
                ct.MaSach = item.Text;
                ct.SoLuong = int.Parse(item.SubItems[2].Text);
                ct.TrangThai = true;
                ct.GiaSach = 0;

                SachMuonDTO sachMuonDTO = new SachMuonDTO();
                sachMuonDTO.MaSach = item.Text;
                sachMuonDTO.SoSachMuon = ct.SoLuong;

                listCTMuon.Add(ct);
                sachMuonDTOs.Add(sachMuonDTO);
            }
            
            if(muonSachBUS.ThemMuonSach(muonSachDTO))
            {
                if (ctMuonBUS.ThemCTMuonSach(listCTMuon) && SachBUS.UpdateSoLuong(sachMuonDTOs))
                {
                    MessageBox.Show(Constrant.ThemThanhCong, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmTraSach.mst.Clear();
                    this.Close();

                }
                else
                    MessageBox.Show(Constrant.ThemThatBai, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show(Constrant.ThemThatBai, Constrant.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}
