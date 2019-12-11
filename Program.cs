using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7strings
{
    class Program
    {
        
         
        static void Main(string[] args)
        { //metoda concat
            string nonculoare1 = "alb";
          string nonculoare2 = "negru"; 
           string nonculoare = string.Concat( nonculoare1,nonculoare2);
            Console.WriteLine(nonculoare);

            //metoda "trim"
            string cut = "  I have a string";
            Console.WriteLine(cut.Trim());

            //metoda replace
            string rrr = "1";
            string inlocuire =rrr.Replace("1", "2");
            Console.WriteLine(inlocuire);

            //metoda "ToUpper"
            string lower = "abcd";
            string up=lower.ToUpper();
            Console.WriteLine(up);


           
            
            //metoda "lastindexof"
            string last = "aaa bbb ccce";
            Console.WriteLine(last.LastIndexOf("e"));

            //metoda "startswith"
            string incepe = "cabcaa";
            Console.WriteLine(incepe.StartsWith("c"));

            //metoda "substring"
            string under = "Ihave a string";
            int val = 4;
            string Substring = under.Substring(val);
            Console.WriteLine(val);

        }
    }
}
