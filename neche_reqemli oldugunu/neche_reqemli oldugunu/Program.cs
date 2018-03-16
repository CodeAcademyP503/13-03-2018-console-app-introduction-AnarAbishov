using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neche_reqemli_oldugunu
{
    class Program
    {
        static void Main(string[] args)
        {
            void hesablama()
            {
                Console.WriteLine("Reqem daxil edin:");
                Console.WriteLine("------------------------");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a>0)
                {
                    
                    int counter = 0;
                    for (int start = 1; start <= a; counter++)
                    {
                        start = start * 10;
                    }
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Daxil etdiyiniz eded " + counter + " reqemlidir");
                    Console.WriteLine("------------------------");

                    hesablama();
                    
                }
                else
                {
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Duzgun reqem yaz");
                    Console.WriteLine("------------------------");
                    hesablama();

                }
            }
            hesablama();
            


        }
    }
}
