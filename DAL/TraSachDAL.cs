using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class TraSachDAL
    {
        QuanLyThuVienEntities data = new QuanLyThuVienEntities();

        public int DemSo()
        {
            return data.TraSaches.Count() + 1;
        }

        public bool ThemTraSach(TraSachDTO traSachDTO)
        {
            try
            {
                TraSach traSach = new TraSach {
                    MaMuon = traSachDTO.MaMuon,
                    MaTra = traSachDTO.MaTra,
                    NgayLap = traSachDTO.NgayLap,
                    TrangThai = true          
                };

                data.TraSaches.Add(traSach);
                data.SaveChanges();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
