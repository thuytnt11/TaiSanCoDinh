using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PUB;

namespace DAL
{
    public class tinhtrangDAL
    {
        public static List<tinhtrangPUB> dstinhtrang()
        {
            List<tinhtrangPUB> dstt = new List<tinhtrangPUB>();
            using (TSCDEntities t = new TSCDEntities())
            {
                var query = from s in t.TINHTRANGs
                            select s;
                foreach (var row in query)
                {
                    tinhtrangPUB tt = new tinhtrangPUB();
                    tt.Matinhtrang = row.matinhtrang;
                    tt.Tentinhtrang = row.tentinhtrang;
                    dstt.Add(tt);
                }
                return dstt;
            }
        }
    }
}
