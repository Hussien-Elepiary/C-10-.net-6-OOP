

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
