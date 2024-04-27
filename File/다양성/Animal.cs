using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 다양성
{
    class Worker
    {
        public void CareAnimal(Animal animal)
        {
            animal.HP = animal.HP + 10;
        }
    }

    internal class Animal
    {
        public int HP;
    }
    class Animal_Tiger : Animal
    {
        void Run() { }
    }
    class Animal_Shark : Animal
    {
        void Swim() { }
    }
    class Animal_Eagle : Animal
    {
        void Fly() { }
    }
}
