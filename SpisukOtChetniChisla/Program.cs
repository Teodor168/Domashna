﻿namespace SpisukOtChetniChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dai chisla: ");
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listEven = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    listEven.Add(list[i]);
                }
            }
            Console.WriteLine(string.Join(" ", listEven));

        }    
    }
}
