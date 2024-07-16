using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_17.Overriding
{
    public class TypeA
    {
        public int A { get; set; }

        public TypeA(int _a) //paramater less constructor => Do Nothing
        {
            A = _a;
        }

        public void MyFunc01()
        {
            Console.WriteLine("I am Base");
        }

        public virtual void MyFunc02()
        {
            Console.WriteLine($"TypeA : A = {A}");
        }
    }
}
