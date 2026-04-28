using System;

namespace homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入數字，用,分開:");
            string input = Console.ReadLine();
            string[] parts = input.Split(',');

            Console.Write("倒置結果：");
            for (int i = parts.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                    Console.Write(parts[i]);
                else
                    Console.Write(parts[i] + ",");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}