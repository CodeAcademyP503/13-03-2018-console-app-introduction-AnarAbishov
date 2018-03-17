using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reqemleri_cemi
{
    class Program
    {
        static void Main(string[] args)
        {
            void hesablama()
            {
                Console.WriteLine("Reqem daxil edin");

                Console.WriteLine("---------------------");

                var n = Convert.ToInt32(Console.ReadLine());

                if (n>0)
                {
                    var total = 0;
                    for (var i = 0; n >= 1; i++)
                    {
                        total = total + n % 10;
                        n = (n / 10);
                    }
                    Console.WriteLine("---------------------");

                    Console.WriteLine("Yazilan ededin reqemlerinin cemi : " + total);
                    Console.WriteLine("---------------------");
                    hesablama();
                }
                
                else{
                    Console.WriteLine("---------------------");
                    Console.WriteLine("Duzgun reqem yazin!!!");
                    Console.WriteLine("---------------------");
                    hesablama();
                }

            }
            hesablama();
            
            
        }
    }
}
