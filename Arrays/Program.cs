using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1D-Arrays
            int[] integerListe = new int[4];

            integerListe[0] = 10;
            integerListe[1] = 20;
            integerListe[2] = 30;
            integerListe[3] = 40;

            Console.WriteLine(integerListe[1]);
            Console.ReadKey();
        }
    }
}
