using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class CTMuonSachBUS
    {
        CTMuonSachDAL ctmuonDAL = new CTMuonSachDAL();
        public bool ThemCTMuonSach(List<CTMuonSachDTO> lstCTMuon)
        {
            return ctmuonDAL.ThemCTMuonSach(lstCTMuon);
        }

        public List<CTMuonSachDTO> LayDSCTMuonSach()
        {
            return ctmuonDAL.LayDSCTMuonSach();
        }

        public bool SuaCTMuonSach(string MaMuon,string MaSach)
        {
            return ctmuonDAL.SuaCTMuonSach(MaMuon, MaSach);
        }
    }
}
