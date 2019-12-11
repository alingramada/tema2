using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int day;
            int year;
            int month;
            string gender;
            int age;
            int date;
            
            DateTime dateTime= DateTime.UtcNow.Date;

            Console.WriteLine("Type your birth year!");
            string y= Console.ReadLine();
            year = Convert.ToInt16(y);
            Console.WriteLine("Type  the month of your birth!");
            string m= Console.ReadLine();
            month = Convert.ToInt16(m);
            Console.WriteLine("Type your birth day!");
            string d = Console.ReadLine();
            day = Convert.ToInt16(d);
            Console.WriteLine("Type your gender (M or F)!");
            Convert date= dateTime(year, month, day);
            string today= DateTime.Now.ToString("d/MM/yyyy");
            int age = today - date;
            if (age>= 65 && gender==m || age>=63 && gender==f)
            {
                Console.WriteLine("Retired");
            }
            else if (age<65 && gender == m || age<63 && gender == f)
            {   
                Console.WriteLine("more years to retire");
            }


          
        }
    }
}
