using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 추상화
{
    internal class 추상_클래스
    {

    }
    abstract class Car
    {
        protected abstract void SpeedUp();
        protected abstract void SpeedDown();
        public void Show() 
        { 

        }
    }
    class Truck : Car
    {

    }
}
