using System.Collections.Generic;
using System;
using System.Reflection;

namespace VuvejdaneNaSoisukOtKonzolata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"list [{i}] = {list[i]}");
            }
        }
    }
}

