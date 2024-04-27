namespace 상속
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank mybank = new Bank("농협", 1000);
            CenterBank centerBank = new CenterBank("중앙은행", "부모", 10000, 0);

        }
    }
}