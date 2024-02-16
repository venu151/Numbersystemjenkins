using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class NumberSystem
    {
        static int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        public static void OddNum()
        {
            foreach (int i in numbers) {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);   
                }
              }
        }
        public static void EvenNum()
        {
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
