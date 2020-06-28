using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class CTTraSachBUS
    {
        CTTraSachDAL CTTSDAL = new CTTraSachDAL();

        public bool ThemCTTraSach(CTTraSachDTO cTTraSachDTO)
        {
            return CTTSDAL.ThemCTTraSach(cTTraSachDTO);
        }

        public List<CTTraSachDTO> LayDSCTTraSach()
        {
            return CTTSDAL.LayDSCTTraSach();
        }
    }
}
