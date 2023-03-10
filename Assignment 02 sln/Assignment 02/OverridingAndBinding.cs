using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    public class TypeA
    {
        public int A { get; set; }

        public TypeA(int _A)
        {
            A = _A;
        }

        public void myFun1()
        {
            Console.WriteLine("Iam Type A");
        }
        public virtual void myFun2()
        {
            Console.WriteLine($"Values of A : {A}");
        }
    }
    public class TypeB:TypeA
    {
        public int B { get; set; }

        public TypeB(int _A, int _B) :base(_A)
        {
            B = _B;
        }

        public new  void myFun1()
        {
            Console.WriteLine("Iam Type B");
        }
        public override void myFun2()
        {
            Console.WriteLine($"Values of B : {A} , {B}");
        }
    }
    public class TypeC:TypeB
    {
        public int C { get; set; }

        public TypeC(int _A,int _B, int _C ):base(_A,_B)
        {
            C = _C;
        }
        public new static void myFun1()
        {
            Console.WriteLine("Iam Type C");
        }
        public  new void myFun2()
        {
            Console.WriteLine($"Values of C : {A} , {B} , {C}");
        }
    }

    internal class Overriding
    {
        public void overridingMethod()
        {
            Console.WriteLine("typeA");
            TypeA typeA = new TypeA(1);
            typeA.A = 11;
            typeA.myFun1(); // Iam Type A
            typeA.myFun2(); // Values of A : 11

            Console.WriteLine("typeB");
            TypeA typeB = new TypeB(1,2);
            typeB.A = 11;
            //typeB.B = 22;
            typeB.myFun1(); // Iam Type A
            typeB.myFun2(); // Values of B : 11 , 2

            Console.WriteLine("typeC");
            TypeA typeC = new TypeC(1,2,3);
            typeC.A = 11;
            //typeC.B = 22;
            //typeC.C = 33;
            typeC.myFun1(); // Iam Type A
            typeC.myFun2(); // Values of B : 11 , 2

            Console.WriteLine("typeC02");
            TypeB typeC02 = new TypeC(1, 2, 3);
            typeC02.A = 11;
            typeC02.B = 22;
            //typeC02.C = 33;
            typeC02.myFun1(); // Iam Type B
            typeC02.myFun2(); // Values of B : 11 , 2


            #region What is not Binding 
            //TypeC typeC1 = TypeA(1);
            #endregion
        }
    }
}
