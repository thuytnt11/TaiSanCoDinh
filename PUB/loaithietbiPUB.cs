using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PUB
{
    public class loaithietbiPUB
    {
        private int? maloai;
        private string tenloai;

        public int? Maloai
        {
            get
            {
                return maloai;
            }

            set
            {
                maloai = value;
            }
        }

        public string Tenloai
        {
            get
            {
                return tenloai;
            }

            set
            {
                tenloai = value;
            }
        }
    }
}
