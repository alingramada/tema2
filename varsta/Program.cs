using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varsta
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int value1 = 65;
            int value2 = 63;
            
            string gender;
            int age;
            int ytogoM;
            int ytogoF;

            Console.WriteLine("Type the day");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the month");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Type the year");
            int year = int.Parse(Console.ReadLine());
            
            var date = $"{day}/{month}/{year}";
            age = DateTime.Now.Year - year;
            Console.WriteLine(age);

            Console.WriteLine("Type your gender (M or F)!");
            gender = Console.ReadLine();

            
            

                if (age >= 65 && gender == "M" || age >= 63 && gender == "F")
                {
                    Console.WriteLine("Retired");
                Console.ReadLine();
                }
                if (age <= 65 && gender == "M")
                {

                    ytogoM= value1 - Convert.ToInt32(age);
                    Console.WriteLine("{0} more years to retire", ytogoM);
                Console.ReadLine();
                }
                if  (age <= 63 && gender == "F")
                {
                    ytogoF = value2 - age;
                    Console.WriteLine("{0} more years until retirement", ytogoF);
                Console.ReadLine();
                }
                
            
        }
    }
}
