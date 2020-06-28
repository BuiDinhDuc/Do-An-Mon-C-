using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class CTTraSachDAL
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();

        public bool ThemCTTraSach(CTTraSachDTO CTTS)
        {
            try
            {
                CTTraSach traSach = new CTTraSach
                {
                    MaTra = CTTS.MaTra,
                    MaSach = CTTS.MaSach,
                    NgayTra = CTTS.NgayTra,
                    SoLuong = CTTS.SoLuong,
                    TienPhat = 0,
                    TrangThai = true

                };

                data.CTTraSaches.Add(traSach);
                data.SaveChanges();
                return true;
            }catch(Exception)
            {
                return false;
            }
          
        }

        public List<CTTraSachDTO> LayDSCTTraSach()
        {
            List<CTTraSachDTO> result = new List<CTTraSachDTO>();
            result = data.CTTraSaches.Where(u => u.TrangThai == true).Select(u => new CTTraSachDTO
            {
                MaSach = u.MaSach,
                MaTra = u.MaTra,
                NgayTra = u.NgayTra.Value,
                SoLuong = u.SoLuong.Value,
                TienPhat = u.TienPhat.Value,
                TrangThai = u.TrangThai.Value

            }).ToList();

            return result;
        }
    }
}
