namespace 메소드_심화
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int shaerNumber = 0;
            int remainder = 0;
            Parent parent = new Parent();
            parent.Method1();
            parent.Method2();
            parent.Divide(3, 2, ref shaerNumber, ref remainder);
            parent.Divide2(3, 2, out int int1, out int t1);
            Console.WriteLine($"나누기 값 확인 몫 : {shaerNumber} \n  나머지 : {remainder}");
            Parent child = new Child();
            child.Method1();
            child.Method2();
        }
    }
}
//        /\
//       /  \
//      /    \
//     /      \
//    /        \
//   /          \
//  /____________\