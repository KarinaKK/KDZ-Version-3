using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kedrolivanskaya
{
    class Gift : Incom
    {
        private int q;

        public int Q
        {
            get { return q; }
            set { q = value; }
        }

        public Gift( string title, DateTime date, double price, bool type, int q):base(title,date, price, type)
        {
            this.q = q;
        }
    }
}
