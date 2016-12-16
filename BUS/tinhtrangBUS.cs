using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PUB;
using DAL;

namespace BUS
{
    public class tinhtrangBUS
    {
        public static List<tinhtrangPUB> dstinhtrang()
        {
            return DAL.tinhtrangDAL.dstinhtrang();
        }
    }
}
