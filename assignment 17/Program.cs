using assignment_17.Biniding;
using assignment_17.Interface;
using assignment_17.Overriding;

namespace assignment_17
{
    internal class Program
    {
        #region Polymorphism - overloading
        //public static int Sum(int x, int y)
        //{
        //    return x + y;
        //}

        //public static int sum(int x, int y, int z)
        //{
        //    return x + y + z;
        //}

        //public static int sum(int x, int y, int z, int e)
        //{
        //    return x + y + z + e;
        //} 
        #endregion

        //public static void ProccessEmp(FullTimeEmployee employee)
        //{
        //    if (employee != null)
        //    {
        //        employee.MyFunc01();
        //        employee.MyFunc02();
        //    }
        //}

        //public static void ProccessEmp(Employee employee)
        //{
        //    if (employee != null)
        //    {
        //        employee.MyFunc01();
        //        employee.MyFunc02();
        //    }
        //}
        static void Main(string[] args)
        {
            #region Overloading
            //int result = Sum(1, 2);
            //Console.WriteLine(result);

            //Console.WriteLine("kerloss");
            //Console.WriteLine('A');
            //Console.WriteLine(2);
            //Console.WriteLine(2.0F);
            //Console.WriteLine(2.0M);
            //Console.WriteLine(20000000000000); 
            #endregion

            #region Binding
            //TypeA typeA = new TypeA(1);
            //typeA.A = 2;

            //typeA.MyFunc01();
            //typeA.MyFunc02();

            //////before override of TypeB
            ////TypeB typeB = new TypeB(1,2);
            ////typeB.A = 3;
            ////typeB.B = 4;
            ////typeB.MyFunc01();//I am Base
            ////typeB.MyFunc02();//A = 3

            ////after override
            //TypeB typeB = new TypeB(1, 2);
            //typeB.A = 3;
            //typeB.B = 4;
            //typeB.MyFunc01();//I am Child
            //typeB.MyFunc02();//B = 4

            ////Binding
            ////reference from parent = object from child

            //TypeA RefBase = new TypeB(1, 2);
            //RefBase.A = 4;  //Valid
            //                //RefBase.B = 5;  //invalid

            //RefBase.MyFunc01(); //I am Base [new => Parent] static Binided method
            //RefBase.MyFunc02(); //B = 2 [override => Child] Dynamic Binided method

            ////RefBase.Print():    //NotValid 
            #endregion

            #region Not Binding
            //TypeA typeA = new TypeB(1, 2);  //biniding
            //typeA = new TypeA(1);

            ////TypeB typeB =  (TypeB)TypeA;    //casting [unsave casting] 
            #endregion

            #region Business need of biniding
            //FullTimeEmployee fullTime1 = new FullTimeEmployee()  //object incializer
            //{
            //    Id = 10,
            //    Name = "Ali",
            //    Age = 25,
            //    Salary = 3000,
            //};    //not binding

            //PartTimeEmployee partTime1 = new PartTimeEmployee()
            //{
            //    Id = 20,
            //    Name = "Mona",
            //    Age = 28,
            //    HourRate = 2500
            //};    //not binding

            //ProccessEmp(fullTime1);
            //ProccessEmp(partTime1);

            Employee fullTime = new FullTimeEmployee()  //object incializer
            {
                Id = 10,
                Name = "Ali",
                Age = 25,
                Salary = 3000,
            };  //Binding

            Employee partTime = new PartTimeEmployee()
            {
                Id = 20,
                Name = "Mona",
                Age = 28,
                HourRate = 2500
            };  //Binding

            //fullTime.Id = 10;
            //fullTime.Name = "Ali";
            //fullTime.Age = 30;
            //fullTime.Salary = 3000;

            ProccessEmp(fullTime);
            ProccessEmp(partTime);



            Employee employee = new Employee(); //ref (parent) => object (parent)
            FullTimeEmployee employee1 = new FullTimeEmployee(); //ref (child) => object (child)
            PartTimeEmployee employee2 = new PartTimeEmployee(); //ref (child) => object (child)
            Employee employee3 = new FullTimeEmployee();    //ref (parent) => object (child)
            Employee employee4 = new PartTimeEmployee();   //ref (parent) => object (child)

            //ProccessEmp(employee);
            //ProccessEmp(employee1);
            //ProccessEmp(employee2);
            //ProccessEmp(employee3);
            //ProccessEmp(employee4); 
            #endregion

            #region More practice on Binding
            //TypeA typeA = new TypeC(1, 2, 3);   //binding

            //typeA.A = 1;
            ////typeA.B = 1;    //invalid
            ////typeA.C = 1;    //invalid

            //typeA.MyFunc01();   //I am Base [Static Biniding]
            //typeA.MyFunc02();   //C = 3 [Dynamic Binding]

            //-----------------------------------------------------//
            //TypeB typeB = new TypeC(1, 2, 3);   //binding

            //typeB.A = 1;
            //typeB.B = 1;
            ////typeB.C = 1;    //invalid

            //typeB.MyFunc01();   //I am Child [Static Biniding]
            //typeB.MyFunc02();   //C = 3 [Dynamic Binding]

            //---------------------------------------------------------//

            //TypeA typeA = new TypeA(1); //ref [parent] +> object [parent]
            //TypeB typeB = new TypeB(1, 2); //ref [parent] +> object [parent]
            //TypeC typeC = new TypeC(1, 2, 3); //ref [parent] +> object [parent]
            //TypeD typeD = new TypeD(1, 2, 3, 4); //ref [parent] +> object [parent]
            //TypeE typeE = new TypeE(1, 2, 3, 4, 5); //ref [parent] +> object [parent]
            //TypeA typea = new TypeE(1, 2, 3, 4, 5); //ref [parent] +> object [child]
            //TypeB typeb = new TypeE(1, 2, 3, 4, 5); //ref [parent] +> object [child]
            //TypeC typec = new TypeE(1, 2, 3, 4, 5); //ref [parent] +> object [child]
            //TypeD typed = new TypeE(1, 2, 3, 4, 5); //ref [parent] +> object [child]

            //typeA.MyFunc02();   //A = 1
            //typeB.MyFunc02();   //B = 2
            //typeC.MyFunc02();   //C = 3
            //typeD.MyFunc02();   //D = 4
            //typeE.MyFunc02();   //E = 5
            //typea.MyFunc02();   //C = 3
            //typeb.MyFunc02();   //C = 3
            //typec.MyFunc02();   //C = 3
            //typed.MyFunc02();   //E = 5

            //----------------------------------------------------------------------------//

            ////indirect Parent
            //TypeA typeA = new TypeE(1, 2, 3, 4, 5); //ref [parent] => object [child]
            //TypeB typeB = new TypeE(1, 2, 3, 4, 5); //ref [parent] +> object [child]
            //TypeC typeC = new TypeE(1, 2, 3, 4, 5); //ref [parent] +> object [child]

            //typeA.MyFunc02();   //C = 3 [Dynamic Binding]
            //typeB.MyFunc02();   //C = 3 [Dynamic Binding]
            //typeC.MyFunc02();   //C = 3 [Dynamic Binding]

            //TypeD typeD = new TypeE(1, 2, 3, 4, 5);
            //typeD.MyFunc02();   //E = 5

            //TypeE typeE = new TypeM(1, 2, 3, 4, 5, 6);
            //typeE.MyFunc02();   //M = 6 
            #endregion

            IMyType myType = new MyType();

            myType.MyFunc();
            myType.Age = 25;

            //myType.print();
            //myType.MyTypeFunc();
        }
    }
}



