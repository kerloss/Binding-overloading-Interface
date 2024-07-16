using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_17.Overriding
{
    public class TypeB : TypeA  
    //typeB by default do chaining on paramater less constructor in typeA but if TypeA have paramaterized then we
    //have 2 solution if do in typeA paramater less of make in typeB here ctor paramater less
    {
        public int B { get; set; }

        public TypeB(int _A , int _B) : base(_A)
        {
            B = _B;
        }

        //1-Apply function overriding using new keyword
        //Static Binding method
        //Compilar will bind func call based on ref not object
        //binding at compilation time [Early binding]
        public new void MyFunc01()
        {
            Console.WriteLine("I am Child");
        }

        //2-Apply function overriding using override keyword
        //but the func will be overridng using "override keyword"
        //make the func in (parent) public virtual
        //Dynamic Bindng mehod
        //compilar bind for func call based on object not ref
        //binding at Run time [Late biniding]
        public override void MyFunc02()
        {
            Console.WriteLine($"TypeB : B = {B}");
        }

        public void Print()
        {
            Console.WriteLine("hello");
        }
    }

    class TypeC : TypeB
    {
        public int C { get; set; }

        public TypeC(int _A , int _B , int _C):base(_A, _B)
        {
            C = _C;
        }

        public new void MyFunc01()
        {
            Console.WriteLine("I am grand child");
        }

        public override void MyFunc02()
        {
            Console.WriteLine($"C = {C}");
        }
    }

    class TypeD : TypeC
    {
        public int D { get; set; }

        public TypeD(int _A , int _B , int _C , int _D):base(_A , _B , _C)
        {
            D = _D;
        }

        public new void MyFunc01()
        {
            Console.WriteLine("I child of parent C");
        }

        public new virtual void MyFunc02()
        {
            Console.WriteLine($"D = {D}");
        }
    }

    class TypeE : TypeD
    {
        public int E { get; set; }

        public TypeE(int _A , int _B , int _C , int _D ,int _E):base(_A , _B , _C , _D)
        {
            E = _E;
        }

        public override void MyFunc02()
        {
            Console.WriteLine($"E = {E}");
        }
    }

    class TypeM : TypeE
    {
        public int M { get; set; }

        public TypeM(int _A, int _B, int _C, int _D, int _E , int _M):base(_A , _B , _C, _D, _E)
        {
            M = _M;
        }

        public override void MyFunc02()
        {
            Console.WriteLine($"M = {M}");
        }
    }
}
