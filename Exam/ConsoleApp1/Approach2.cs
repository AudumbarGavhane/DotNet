using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Approach2
    {
        public static void Main()
        {
           //List<List<People>> list = new List<List<People>>(10);
           // List<People>[] list = new List<People>[10];

            List<People>[][] list = new List<People>[10][];



            Console.WriteLine("hrello");
            
            bool exit=false;

            List<People> list2 = Utils.GetPopulatedList();
            foreach (People people in list2) { Console.WriteLine(people); }
            while (!exit)
            {
                Console.WriteLine("Enter the choice");
                Console.WriteLine("" +
                    "1.Add People\n" +
                    "2. Display record\n" +
                    "3.Exit");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1: Console.WriteLine("Add Record");
                       // People people = new People() { Name = "Audumbar",DateOfBirth=new DateTime(1999,9,14),CityOfResidence="Ahmednagar" };


                     /*   new People("Audumbar", new DateTime(1999, 9, 14), "Shrigonda");
                        new People("Akash", new DateTime(1999, 2, 21), "Shrigonda");
                        new People("Shree", new DateTime(1999, 6, 14), "Shrigonda");
                        new People("Anirudh", new DateTime(1999, 5, 31), "Shrigonda");
                        new People("Ashish", new DateTime(1999, 1, 14), "Shrigonda");

                        new People("Shridhar", new DateTime(1985, 10, 21), "beed");
                        new People("sanket", new DateTime(1987, 6, 14), "latur");
                        new People("Anirudh", new DateTime(1989, 5, 31), "kopargaon");


                        new People("Monu", new DateTime(1978, 2, 21), "pedgaon");
                        new People("Shree", new DateTime(1977, 6, 14), "wadgaon");*/





                        for (int i = 0;i<list.Length;i++)
                        { 
                            if(DateTime.Now.Year - list2[i].DateOfBirth.Year > ((i * 10)-10) && DateTime.Now.Year - list2[i].DateOfBirth.Year <= (i*10))
                            {
                                Console.WriteLine(list2[i].ToString());
                                //list[i]=new List<People>().Add;
                            }
                        }

                        Console.WriteLine("all rec are populated displaying the list");
                        //    list.ForEach(e => e.ForEach(p => Console.WriteLine(p.ToString()))) ;

                        for(int i = 0; i < list.Length; i++)
                        {
                         //   list[i].ForEach(e=>Console.WriteLine());
                        }

                            break;
                        case 2: Console.WriteLine("display");

                      //  list.ForEach(e => e.ForEach(p => Console.WriteLine(p.ToString())));
                        break;
                }



            }
        }

    }
}
