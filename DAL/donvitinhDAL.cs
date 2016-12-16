using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PUB;

namespace DAL
{
    public class donvitinhDAL
    {
        public static List<donvitinhPUB> dsdonvitinh()
        {
            List<donvitinhPUB> dsdvt = new List<donvitinhPUB>();
            using (TSCDEntities t = new TSCDEntities())
            {
                var query = from s in t.DONVITINHs
                            select s;
                foreach (var row in query)
                {
                    donvitinhPUB tb = new donvitinhPUB();
                    tb.Madonvitinh = row.madonvitinh;
                    tb.Tendonvitinh= row.tendonvitinh;
                    dsdvt.Add(tb);
                }
                return dsdvt;
            }
        }
    }
}
