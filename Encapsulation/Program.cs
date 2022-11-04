using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Console.WriteLine(Find(GenerationArray(numbers)));
            Console.ReadKey();
        }
        public static int[] GenerationArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            return array;
        }
        static string Find(int[] ints)
        {
            int count = 1;
            int summ = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] < 0)
                {
                    count = count * ints[i];
                }
                if (ints[i] > 0)
                {
                    summ += ints[i];
                }

            }
            return $"Сумма: {summ} и произведение: {count}";
        }

    }
}
