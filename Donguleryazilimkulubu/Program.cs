using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguleryazilimkulubu
{
    class Program
    {
        static void Main(string[] args)
        {
            //while , for , foreach
            int a;

            /*
            for (a = 0; a < 10; a++)
            {
                Console.WriteLine(a);
            }
            */

            /*
            while(a < 10)
            {
                Console.WriteLine(a);
                a++;
                
            }
    */
            string[] Diller = new string[3];
            Diller[0] = "C#";
            Diller[1] = "JavaScript";
            Diller[2] = "Pyhton";

            foreach (string Dil in Diller)
            {
                Console.WriteLine(Dil);
            }




            Console.ReadLine();
        }

    }
}




/*

         

         Console.ReadLine();

 */
