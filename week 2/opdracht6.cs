using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int[,] weer = new int[4, 7]
                {
                    { 15, 1, 2, 0, 20, 5, 7 },
                    { 6, 3, 0, 8, 9, 15, 7},
                    { 2, 3, 5, 7, 8, 9, 10 },
                    {11, 13, 16, 13, 15, 11, 7}
                };
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 7; col++)
                {
                    total += weer[row, col];
                }
                Console.WriteLine(total / 7);
                total = 0;
            }
            
        }
    }
}
