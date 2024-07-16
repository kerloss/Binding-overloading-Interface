using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_17.Biniding
{
    internal class PartTimeEmployee : Employee
    {
        public decimal HourRate { get; set; }

        public void MyFunc01()
        {
            Console.WriteLine("I am Part Time Employee");
        }

        public override void MyFunc02()
        {
            Console.WriteLine($"ID : {Id} , Name : {Name} , Age : {Age} , HourRate : {HourRate}");
        }
    }
}
