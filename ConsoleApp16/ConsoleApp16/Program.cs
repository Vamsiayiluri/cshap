using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S1 = "abcdabcabd";
            string S2 = "ab";
            List<int> indexes = new List<int>();

            int count = 0;
            for (int i = 0; i <= S1.Length - S2.Length; i++)
            {
                if (S1.Substring(i, S2.Length) == S2)
                {
                    count++;
                    indexes.Add(i);

                }
            }
            Console.WriteLine($"Number of times occurred: {count}");
            Console.WriteLine($"Index Positions: ");
            for (int i = 0; i < indexes.Count; i++)
            {
                Console.Write(indexes[i] + " ");
            }


        }
    }
}
