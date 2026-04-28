using System;

namespace homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入中華民國年份：");
            int rocYear = int.Parse(Console.ReadLine());

            int adYear = rocYear + 1911;

            if (DateTime.IsLeapYear(adYear))
                Console.WriteLine($"中華民國 {rocYear} 年是閏年");
            else
                Console.WriteLine($"中華民國 {rocYear} 年不是閏年");

            Console.ReadKey();
        }
    }
}