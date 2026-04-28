using System;

namespace homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個整數數字：");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int digit = n - i + 1;    //重複次數                
                string line = new string((char)('0' + digit), i);  //字串輸入
                Console.WriteLine(line);
            }

            Console.ReadKey();
        }
    }
}