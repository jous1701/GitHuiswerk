using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {

            //WEEK 2 OPGAVE 1
            int[] number;
            number = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Voer een getal in.");
                number[i] = Convert.ToInt32(Console.ReadLine());

            }
            int total = 0;
            foreach (int item in number)
            {
                total += item;
            }
            Console.WriteLine("Totaal is" + " " + total);


            //OPGAVE 2
            {
                int[] number2;
                number2 = new int[9];
                for (int i = 0; i < 9; i++)
                {
                    Console.WriteLine("Voer 9 getallen in.");
                    number2[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Hoeveelste getal wilt u zien?");
                Console.WriteLine("0 voor getal 1 en 8 voor getal 9");
                int avg;
                avg = Convert.ToInt32(Console.ReadLine());
                Convert.ToInt32(number[avg]);
                Console.WriteLine(number[avg]);
            }

            //OPGAVE 3
            {
                int[] even;
                even = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Voer 10 getallen in.");
                    even[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < 10; i++)
                {
                    if (even[i] % 2 == 0)
                    {

                        Console.WriteLine(even);
                    }
                }
            }
            //OPGAVE 4
            {
                int[] array1 = {1,2,3,4,5};
                int[] array2 = {1,2,3,4,5};
                int[] array3 = new int[5];

                Console.WriteLine("Voer 5 nummers in.");
                int[] getal;
                getal = new int[5];
                for (int i = 0; i < 5; i++)
                    
                    
                {
                    Console.WriteLine("Voer 5 nummers in.");
                    getal[i] = Convert.ToInt32(Console.ReadLine());

                }
                int totaal = 0;
                foreach (int item in getal)
                {
                    totaal += item;
                }
                Console.WriteLine("Voer nogmaals 5 nummers in.");
                int[] getal2;
                getal2 = new int[5];
                for (int i = 0; i < 5; i++)


                {
                    Console.WriteLine("Voer 5 nummers in.");
                    getal2[i] = Convert.ToInt32(Console.ReadLine());

                }
                int totaal2 = 0;
                foreach (int item in getal)
                {
                    totaal2 += item;
                }
                Console.WriteLine(array1 + array2 + array3);
                
                
                //Console.WriteLine("{0} + {1} = {2}", number1[i], number2[i], number3[i]);


            }

        }
    }
}
