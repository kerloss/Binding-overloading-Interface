using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_17.Interface
{
    interface IMyType
    {
        //Default access modifier inside interface => [public]
        //private not allowed inside interface but we can use it with Default imlemented method

        public int Age { get; set; } //1.signature for property
                                     //but inside struct or class named automatic 

        //2.signature for method
        public void MyFunc();

        //3.Default implemented method
        private void Print()
        {
            Console.WriteLine("Default implemented method");
        }
    }
}
