using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kedrolivanskaya
{
   public class  Incom
    {
        private string title;
       
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
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

        public Incom(string title, DateTime date, double price, bool type)
        {
            this.title = title;
            this.price = price;
            this.type = type;
            this.date = date;
        }

    }
}
