using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_Class
{
    public class Security
    {
        [Flags]
        public enum securityLevels
        {
            guest = 1, Developer = 2, secretary = 4, DBA = 8
        }
    }
}
