using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PUB;

namespace DAL
{
    public class loaithietbiDAL
    {
        public static List<loaithietbiPUB> dsloaithietbi()
        {
            List<loaithietbiPUB> dsltb = new List<loaithietbiPUB>();
            using (TSCDEntities t = new TSCDEntities())
            {
                var query = from s in t.LOAITHIETBIs
                            select s;
                foreach (var row in query)
                {
                    loaithietbiPUB tb = new loaithietbiPUB();
                    tb.Maloai = row.maloai;
                    tb.Tenloai = row.tenloai;
                    dsltb.Add(tb);
                }
                return dsltb;
            }
        }
    }
}
