using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace MergeTwoArrayDistinct
{
    class Program
    {
        public static string[] UniqueNamesUsingArray(string[] names1, string[] names2)
        {
            int distinctCount = 0;
            string[] names = new string[names1.Length + names2.Length];
            string[] temp = new string[names1.Length + names2.Length];

            Array.Sort(names1);
            Array.Sort(names2);
            names1.CopyTo(names, 0);
            names2.CopyTo(names, names1.Length);
            Array.Sort(names);

            for (int i = 0; i < names.Length; i++)
            {
                if (i < names.Length - 1)
                {
                    if (names[i] != names[i + 1])
                    {
                        temp[distinctCount] = names[i];
                        distinctCount += 1;
                    }
                }
                else
                {
                    temp[distinctCount] = names[i];
                    distinctCount += 1;
                }
            }

            string[] final = new string[distinctCount];
            for (int i = 0; i < distinctCount; i++)
            {
                final[i] = temp[i];
            }

            return final;
        }

        public static List<String> UniqueNamesUsingList(List<String> names1, List<String> names2)
        {
            return names1.Union(names2).ToList();
        }

        static void Main(string[] args)
        {
            int repeateCount = 1000000 / 6 + 1;

            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            string[] data1 = new string[repeateCount * names1.Length];
            string[] data2 = new string[repeateCount * names2.Length];
            for (int i = 0; i < repeateCount; i++)
            {
                names1.CopyTo(data1, names1.Length * i);
                names2.CopyTo(data2, names2.Length * i);
            }

            // Test using Array
            var watch = new Stopwatch();
            watch.Start();
            Console.WriteLine(string.Join(", ", UniqueNamesUsingArray(data1, data2)));
            watch.Stop();
            TimeSpan timeSpan = watch.Elapsed;
            Console.WriteLine($"Total elements in Array: {data1.Length + data2.Length} \nTime taken using Array: {timeSpan.TotalMilliseconds} ms\n");

            // Test using List
            List<string> list1 = data1.ToList();
            List<string> list2 = data2.ToList();
            watch.Reset();
            watch.Start();
            Console.WriteLine(string.Join(", ", UniqueNamesUsingList(list1, list2)));
            watch.Stop();
            timeSpan = watch.Elapsed;
            Console.WriteLine($"Total elements in List: {data1.Length + data2.Length} \nTime taken using List: {timeSpan.TotalMilliseconds} ms\n");
        }
    }
}
