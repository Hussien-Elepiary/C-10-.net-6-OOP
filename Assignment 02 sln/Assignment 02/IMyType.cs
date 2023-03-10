using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    internal interface IMyType
    {
        public int Salary { get; set; }

        void MyFun();

        void Default() 
        {
            Console.WriteLine("Iam InterFace Default");
        }
    }

    class MyType : IMyType /* : Implments */
    {
        public int Salary { get; set; }
        public void MyFun()
        {
            Console.WriteLine("Hello MyFun");
        }
    }

}
