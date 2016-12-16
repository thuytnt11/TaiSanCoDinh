using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PUB;

namespace DAL
{
    public class phongquantriDAL
    {
        public static List<phongquantriPUB> dsphongquantri()
        {
            List<phongquantriPUB> dspqt = new List<phongquantriPUB>();
            using (TSCDEntities t = new TSCDEntities())
            {
                var query = from s in t.PHONGQUANTRIs
                            select s;
                foreach (var row in query)
                {
                    phongquantriPUB tb = new phongquantriPUB();
                    tb.Maphongquantri = row.maphongquantri;
                    tb.Tenphongquantri = row.tenphongquantri;
                    dspqt.Add(tb);
                }
                return dspqt;
            }
        }
    }
}
