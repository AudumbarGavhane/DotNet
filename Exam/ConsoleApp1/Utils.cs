using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Utils
    {
        

        public static List<People> GetPopulatedList()
        {

            List<People> list = new List<People>();
            list.Add(new People ("Audumbar",new DateTime(1999,9,14),"Shrigonda"));
            list.Add(new People("Akash", new DateTime(1999, 2, 21), "Shrigonda"));
            list.Add(new People("Shree", new DateTime(1999, 6, 14), "Shrigonda"));
            list.Add(new People("Anirudh", new DateTime(1999, 5, 31), "Shrigonda"));
            list.Add(new People("Ashish", new DateTime(1999, 1, 14), "Shrigonda"));

            list.Add(new People("Shridhar", new DateTime(1985, 10, 21), "beed"));
            list.Add(new People("sanket", new DateTime(1987, 6, 14), "latur"));
            list.Add(new People("Anirudh", new DateTime(1989, 5, 31), "kopargaon"));
          

            list.Add(new People("Monu", new DateTime(1978, 2, 21), "pedgaon"));
            list.Add(new People("Shree", new DateTime(1977, 6, 14), "wadgaon"));

            return list;
        }








    }
}
