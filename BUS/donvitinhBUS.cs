using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PUB;
using DAL;

namespace BUS
{
    public class donvitinhBUS
    {
        public static List<donvitinhPUB> dsdonvitinh()
        {
            return DAL.donvitinhDAL.dsdonvitinh();
        }
    }
}
