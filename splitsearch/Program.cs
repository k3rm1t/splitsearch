using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace splitsearch //puolitushaku
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 99999999;
            int[] taul = new int[count];

            for (int i = 0; i < count; i++)
                {
                taul[i] = i + 1;
                }

            int mid, first = 0, last = taul.Length - 1;

            Console.WriteLine("Enter number:");
            int target = int.Parse(Console.ReadLine());
            var sw = new Stopwatch();
            sw.Start();
            while (first <= last)

            {
                
                mid = (first + last) / 2;

                if (target == taul[mid])

                {
                    Console.WriteLine("Target " + target + " was found at index " + mid);

                    break;

                }

                if (target < taul[mid])

                    last = mid - 1;

                else

                    first = mid + 1;
                
                
            }
            sw.Stop();
            Console.WriteLine("Time taken: {0}ms", sw.Elapsed.TotalMilliseconds);
        }
    }
}
