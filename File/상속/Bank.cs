using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 상속
{
    internal class Bank
    {
        protected string name;
        protected int money;
        public void WithDraw() { }
        public void Deposit() { }

        public void Show()
        {
            Console.WriteLine($"Bank의 이름 : {name} \n \"Bank의 금액 : {money}");
        }

        public Bank(string name, int money)
        {
            this.name = name;
            this.money = money;
        }
    }
    class CenterBank : Bank
    {
        public void MakeMoeny() { }
        public CenterBank(string name, string parentName, int money, int centermoney) : base(name,money)
        {

        }
        public void Show()
        {
            base.name = "부모의 이름";
            this.name = "중앙은행";
            money = 500000;
        }
    }
}
