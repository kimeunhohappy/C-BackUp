using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 메소드_심화
{
    internal class Parent
    {
        public void Method1() 
        {
            Console.WriteLine("Parent의 Method1");
        }
        public virtual void Method2()
        {
            Console.WriteLine("Parent의 Mehod2");
        }
        public void Divide(int first, int second, ref int shaerNumber, ref int remainderNumber)
        {
            first = 3;
            second = 2;
            shaerNumber = first / second;
            remainderNumber = first % shaerNumber;
        }
        public void Divide2(int first, int second, out int shaerNumber, out int remainderNumber)
        {
            first = 3;
            second = 2;
            shaerNumber = first / second;
            remainderNumber = first % shaerNumber;
        }
    }
    class Child : Parent 
    { 
        public new void Method1() 
        {
            Console.WriteLine("Child의 Method1");
        }
        public override void Method2()
        {
            Console.WriteLine("Child의 Method2");
        }
        int shaerNumber = 0;
        int remainderNumber = 0;
    }
}
