using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_17.Interface
{
    class MyType : IMyType //from class to interface this (:) means implements else is named inheritance
    {
        public int Age { get; set; }    //Automatic property

        public void MyFunc()
        {
            Console.WriteLine("Hello Route!");
        }

        public void MyTypeFunc()
        {
            Console.WriteLine("Hello!!!");
        }
    }
}
