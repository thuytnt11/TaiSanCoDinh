using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PUB
{
    public class tinhtrangPUB
    {
        private int? matinhtrang;
        private string tentinhtrang;

        public int? Matinhtrang
        {
            get
            {
                return matinhtrang;
            }

            set
            {
                matinhtrang = value;
            }
        }

        public string Tentinhtrang
        {
            get
            {
                return tentinhtrang;
            }

            set
            {
                tentinhtrang = value;
            }
        }
    }
}
