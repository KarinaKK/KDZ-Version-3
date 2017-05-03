using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kedrolivanskaya
{
    class Product: Incom
    {
        private int q;

        public int Q
        {
            get { return q; }
            set { q = value; }
        }
        public Product(string title, double price, bool type, int q):base(title,price, type)
        {
            this.q = q;
        }
    }
}
