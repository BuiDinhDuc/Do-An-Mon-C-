using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class TraSachBUS
    {
        TraSachDAL traSachDAL = new TraSachDAL();
        public string phatSinhMa()
        {
            string Ma = "MT";
            int so = traSachDAL.DemSo();

            int idem = 0;
            foreach (char i in so.ToString())
            {
                idem++;
            }

            for (int j = 0; j < 8 - idem; j++)
            {
                Ma += "0";
            }

            return Ma + so.ToString();
        }

        public bool ThemTraSach(TraSachDTO traSachDTO)
        {
            return traSachDAL.ThemTraSach(traSachDTO);
        }

    }
}
