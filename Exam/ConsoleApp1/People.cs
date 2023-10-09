using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class People
    {
        public string Name;
        public DateTime DateOfBirth;
        public string CityOfResidence;
        public int count1=0;
        
        public People(  string name = "", DateTime dateOfBirth = new DateTime(), string cityOfResidence= "") { 
            
            this.Name = name;
            this.CityOfResidence = cityOfResidence;
            if(dateOfBirth != null ) {
                this.DateOfBirth = dateOfBirth;
            }
            else { this.DateOfBirth = DateTime.Now;
            }         
        }



         public override string ToString()
        {
            return $"Name: {Name}, Date of Birth: {DateOfBirth}, City:{CityOfResidence}";
        }

    }




}
