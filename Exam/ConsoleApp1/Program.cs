

//Name:Audumbar Popat Gavhane
//PRN:230341220039
//CCPP ID: PD0497

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Welcome Population Management System...");
                List<People> list = Utils.GetPopulatedList();
                list.ForEach(p => { Console.WriteLine(p); });
                Dictionary<string, List<People>> peopleList = new Dictionary<string, List<People>>();
                bool exit = false;

                while (!exit)
                {
                    System.Console.WriteLine("Enter the choice!....");
                    Console.WriteLine(
                        "1. Add a record\n" +
                        "2. Display Record\n" +
                        "3. Arranged record" +
                        "4. Exit..\n");

                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 1://Add the members to the list
                            Console.WriteLine("Enter the person's details.\nDate of Birth yy-mm-dd, Name, City.");
                            People newPerson = new People(
                               //Name
                                Console.ReadLine(),
                               //date
                                new DateTime(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())),
                               //city
                                Console.ReadLine());

                                Console.WriteLine("Person is created. "+newPerson.ToString());

                            list.Add(newPerson);
                       
                            break; 
                        case 2://Display
                            for(int i = 0; i < 10; i++)
                            {
                                
                                var sublist = list.FindAll(a => (DateTime.Now.Year - a.DateOfBirth.Year) > ((i + 1) * 10 - 10) && (DateTime.Now.Year - a.DateOfBirth.Year) <= ((i + 1) * 10));
                                var count = list.FindAll(a => (DateTime.Now.Year - a.DateOfBirth.Year) > ((i + 1) * 10 - 10) && (DateTime.Now.Year - a.DateOfBirth.Year) <= ((i + 1) * 10)).Count();
                                if (count != 0)
                                {
                                    string key= $"{ ((i + 1) * 10 - 10)}-{ ((i + 1) * 10)}";
                                    peopleList.Add(key, sublist);
                                }
                            }

                            var sortedList=peopleList.OrderBy(kv => kv.Value.Count);

                            foreach(var keyValue in sortedList)
                            {
                                Console.WriteLine("Age id between " + keyValue.Key + "--------Count " + keyValue.Value.Count());
                                keyValue.Value.ForEach(val=>Console.WriteLine(val));
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------");
                            }
                            break; 
                        case 3:
                            exit=true;
                            Console.WriteLine("Thank you for visiting!!");
                            break;
                        default: Console.WriteLine("Please Enter a valid Input");
                            break;
                    }
                }//End of while
            }catch(Exception ex) { Console.WriteLine(ex.Message);}//end of catch block
        }//End of Main
    }//End of Class
}
