using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PUB;
using DAL;

namespace BUS
{
    public class phongquantriBUS
    {
        public static List<phongquantriPUB> dsphongquantri()
        {
            return DAL.phongquantriDAL.dsphongquantri();
        }
    }
}
