namespace homework420
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"請輸入一個整數數字:");
            int x = int.Parse(Console.ReadLine()); ;
            if (x % 2 == 0)
                Console.WriteLine($"{x}是偶數");
            else
                Console.WriteLine($"{x}是奇數");
        }
    }
}
