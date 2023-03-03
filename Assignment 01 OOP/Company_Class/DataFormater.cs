using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Class
{
    public class DataFormater : Employee
    {
        public new DateTime[] hiringDate { get; set; }
        public DataFormater(int size) : base(size)
        {
            hiringDate = new DateTime[size];
        }

        public override string ToString()
        {
            return $"{hiringDate}";
        }
    }
}
