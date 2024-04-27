  internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("반복 횟수를 입력하시오");
            int a = int.Parse(Console.ReadLine());
            int b = 0;
            for (int i = a; i != 1; i--)
            {
                for(int j = a; j != 1; j--)
                {
                   Console.WriteLine($"{i} x {j} = ?");
                   b = int.Parse(Console.ReadLine());
                   if(i*j == b)
                   {
                      Console.WriteLine("맞았습니다!");
                   }
                   else
                   {
                        Console.WriteLine($"틀렸습니다... {b}이(가) 아니라 {i*j}입니다..");
                   }
                }
            }
        }
    }
