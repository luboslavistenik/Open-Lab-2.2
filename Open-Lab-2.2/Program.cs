using System;

namespace Open_Lab_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] array1 = { 2.11F, 2.22F, 2.33F, 2.44F, 2.55F };
            float count = 0;
            foreach (float element in array1)
                {
                count++;
                Console.WriteLine($"Element #{count}: {element}");
                }
            Console.WriteLine($"Number of elements: {count}");
        }
    }
}