using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            int intAantal, intTeller;
            String strKlas;

            Console.WriteLine("In welke klas zit je?:");
            strKlas = Console.ReadLine();
            Console.WriteLine("Hoeveel leerlingen zitten er in jouw klas?:");
            intAantal = Convert.ToInt32(Console.ReadLine());

            string[] arrayKlas = new String[intAantal];

            for (intTeller = 0; intTeller < intAantal; intTeller++)
            {
                Console.WriteLine("Leerling" + (intTeller + 1).ToString() + ": ");
                arrayKlas[intTeller] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("In " + strKlas + "zitten de volgende leerlingen");

            for (intTeller = 0; intTeller < intAantal; intTeller++)
            {
                Console.WriteLine(arrayKlas[intTeller]);
            }
            Console.ReadLine();
        }
    }
}