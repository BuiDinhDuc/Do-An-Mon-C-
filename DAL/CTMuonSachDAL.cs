using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class CTMuonSachDAL
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();
        
        
        public bool ThemCTMuonSach(List<CTMuonSachDTO> lstCTMuon)
        {
         
            try
            {
                foreach(CTMuonSachDTO ct in lstCTMuon)
                {
                    CTMuonSach cT = new CTMuonSach { 
                    
                    MaMuon = ct.MaMuon,
                    MaSach = ct.MaSach,
                    SoLuong = ct.SoLuong,
                    TrangThai = ct.TrangThai,
                    GiaSach = 0
                   
                    };

                    data.CTMuonSaches.Add(cT);
          
                }
                data.SaveChanges();


                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public List<CTMuonSachDTO> LayDSCTMuonSach()
        {
            List<CTMuonSachDTO> result = new List<CTMuonSachDTO>();

            result = data.CTMuonSaches.Where(u => u.TrangThai.Value == true).Select(u => new CTMuonSachDTO { 
                MaMuon = u.MaMuon,
                MaSach = u.MaSach,
                SoLuong = u.SoLuong.Value,
                TrangThai = u.TrangThai.Value

            }).ToList();

            return result;
        }


        public bool SuaCTMuonSach(string MaMuonSach,string MaSach)
        {

            try
            {
                CTMuonSach result = data.CTMuonSaches.SingleOrDefault(u => u.MaMuon == MaMuonSach && u.MaSach == MaSach);
                result.TrangThai = false;
                data.SaveChanges();
                return true;
            }catch(Exception)
            {
                return false;
            }
           
        }
    }
}
