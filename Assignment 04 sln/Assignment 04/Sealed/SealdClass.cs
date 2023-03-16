using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04.Sealed
{
    internal class SealdClass
    {
        public int X { get; set; }
        public virtual void funk () { }

    }
    internal class  SealdChild : SealdClass 
    {
        sealed public override void funk() { }
    }
    sealed class sealdGrand : SealdChild
    {
        /*public override void funk() { }*/ // it`s Seald Cannot be edited by override
        public new void funk() { } // but you can make a new inectance of it
    }

    /*class Test : sealdGrand*/  // Cannot inhert from Seald Class
    //{

    //}
}
