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
    public partial class frmXemTraSach : Form
    {
        CTTraSachBUS CTTraSachBUS = new CTTraSachBUS();
        SachBUS sachBUS = new SachBUS();
        public frmXemTraSach()
        {
            InitializeComponent();
        }

        private void frmXemTraSach_Load(object sender, EventArgs e)
        {
            dtgv_MuonSach.AutoGenerateColumns = false;
            dtgv_MuonSach.DataSource = CTTraSachBUS.LayDSCTTraSach();

            DataGridViewComboBoxColumn col = (DataGridViewComboBoxColumn)MaSach;

            col.DataSource = sachBUS.LayDSSach();
            col.DisplayMember = "TenSach";
            col.ValueMember = "MaSach";
        }
    }
}
