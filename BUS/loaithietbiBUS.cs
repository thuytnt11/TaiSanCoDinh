using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using PUB;

namespace BUS
{
    public class loaithietbiBUS
    {
        public static List<loaithietbiPUB> dsloaithietbi()
        {
            return DAL.loaithietbiDAL.dsloaithietbi();
        }
    }
}
