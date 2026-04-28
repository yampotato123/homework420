namespace homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入數字，用,分開:");
            string input = Console.ReadLine();
            string[] nums = input.Split(',');

            List<int> oddList = new List<int>();
            List<int> evenList = new List<int>();

            foreach (string part in nums)
            {
                if (int.TryParse(part.Trim(), out int num))
                {
                    if (num % 2 == 0)
                        evenList.Add(num);
                    else
                        oddList.Add(num);
                }
            }

            Console.WriteLine($"奇數:{string.Join(",", oddList)}");
            Console.WriteLine($"偶數:{string.Join(",", evenList)}");

            Console.ReadLine();
        }
    }
}