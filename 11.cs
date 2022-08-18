using System;

namespace HomeWork0
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            int[] Arr = "Bakı".GetValueIndexes('a');
            foreach (int item in Arr)
            {
                Console.WriteLine(item);

            }
        }
    }
}
