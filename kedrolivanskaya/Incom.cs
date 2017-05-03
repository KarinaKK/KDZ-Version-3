using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kedrolivanskaya
{
    class Incom
    {
        private string title;
       
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private double price;

        public double  Price
        {
            get { return price; }
            set { price = value; }
        }
        private bool type;

        public bool Type
        {
            get { return type; }
            set {  type = value; }
        }

        public Incom(string title, double price, bool type)
        {
            this.title = title;
            this.price = price;
            this.type = type;
        }

    }
}
