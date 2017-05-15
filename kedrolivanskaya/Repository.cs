using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kedrolivanskaya
{
    class Repository
    {
        public static List<Incom> IncomList;
        public Repository()
        {
            IncomList = new List<Incom>();

            IncomList.Add(new Food("манка", DateTime.Now, 50, false, 10));
            IncomList.Add(new Food("гречка", DateTime.Now, 70, false, 5));
            IncomList.Add(new Food("крупа", DateTime.Now, 30, false, 6));
            IncomList.Add(new Incom("стипендия", DateTime.Now, 10000, true));
            IncomList.Add(new Gift("платье", DateTime.Now, 5000, false, 1));
        }
        public static double Count(bool type)
        {
            double sum = 0;
            List<Incom> newList = IncomList.Where(e1 => e1.Type == type).ToList();
            foreach (var item in newList)
            {
                sum += item.Price;
            
            }
            return sum;
        }

    }
}
