using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public override string ToString()
        {
            if (Hours != 0)
            {
                Console.WriteLine($"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}");
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            }
            else if (Minutes != 0)
            {
                Console.WriteLine($"Minutes: {Minutes}, Seconds: {Seconds}");
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            }else if (Seconds != 0)
            {
                Console.WriteLine($"Seconds: {Seconds}");
                return $"Seconds: {Seconds}";
            }
            else
            {
                Console.WriteLine($"No Time");
                return $"No Time";
            }


        }
        public override int GetHashCode()
        {
            return 11;
        }

        public Duration(){ }
        public Duration(int duration)
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(duration);
            Hours = timeSpan.Hours;
            Minutes = timeSpan.Minutes;
            Seconds = timeSpan.Seconds;
        }
        public Duration(int _Hrs, int _Min, int _Sec)
        {
            Hours = _Hrs;
            Minutes = _Min;
            Seconds = _Sec;
        }

        #region Oprators +
        public static Duration operator +(Duration Rigth, Duration Left)
        {
            return new Duration()
            {
                Hours = (Rigth?.Hours ?? 0) + (Left?.Hours ?? 0),
                Minutes = (Rigth?.Minutes ?? 0) + (Left?.Minutes ?? 0),
                Seconds = (Rigth?.Seconds ?? 0) + (Left?.Seconds ?? 0)
            };
        }
        public static Duration operator +(Duration Rigth, int Left)
        {
            Duration durationLeft = new Duration(Left);
            return new Duration()
            {
                Hours = (Rigth?.Hours ?? 0) + (durationLeft?.Hours ?? 0),
                Minutes = (Rigth?.Minutes ?? 0) + (durationLeft?.Minutes ?? 0),
                Seconds = (Rigth?.Seconds ?? 0) + (durationLeft?.Seconds ?? 0)
            };
        }
        public static Duration operator +(int Left, Duration Rigth)
        {
            Duration durationLeft = new Duration(Left);
            return new Duration()
            {
                Hours = (Rigth?.Hours ?? 0) + (durationLeft?.Hours ?? 0),
                Minutes = (Rigth?.Minutes ?? 0) + (durationLeft?.Minutes ?? 0),
                Seconds = (Rigth?.Seconds ?? 0) + (durationLeft?.Seconds ?? 0)
            };
        }
        #endregion
        #region Oprator ++ & --
        public static Duration operator ++(Duration duration)
        {
            return new Duration()
            {
                Hours = duration?.Hours ?? 0,
                Minutes = (duration?.Minutes ?? 0) + 1,
                Seconds = duration?.Seconds ?? 0
            };
        }
        public static Duration operator --(Duration duration)
        {
            return new Duration()
            {
                Hours = duration?.Hours ?? 0,
                Minutes = (duration?.Minutes ?? 0) - 1,
                Seconds = duration?.Seconds ?? 0
            };
        }
        #endregion
        #region Oprators -
        public static Duration operator -(Duration Rigth, Duration Left)
        {
            return new Duration()
            {
                Hours = (Rigth?.Hours ?? 0) - (Left?.Hours ?? 0),
                Minutes = (Rigth?.Minutes ?? 0) - (Left?.Minutes ?? 00),
                Seconds = (Rigth?.Seconds ?? 0) - (Left?.Seconds ?? 0)
            };
        }
        #endregion
        #region Oprators > <=
        public static bool operator >(Duration Rigth, Duration Left)
        {
            if (Rigth?.Hours == Left?.Hours)
                if (Rigth?.Minutes == Left?.Minutes)
                    return Rigth?.Seconds > Left?.Seconds;
                else 
                    return Rigth?.Minutes > Left?.Minutes;
            else
                return Rigth?.Hours > Left?.Hours;
        }
        public static bool operator <(Duration Rigth, Duration Left)
        {
            if (Rigth?.Hours == Left?.Hours)
                if (Rigth?.Minutes == Left?.Minutes)
                    return Rigth?.Seconds < Left?.Seconds;
                else
                    return Rigth?.Minutes < Left?.Minutes;
            else
                return Rigth?.Hours < Left?.Hours;
        }
        public static bool operator >= (Duration Rigth, Duration Left)
        {
            if (Rigth?.Hours == Left?.Hours)
                if (Rigth?.Minutes == Left?.Minutes)
                    return Rigth?.Seconds >= Left?.Seconds;
                else
                    return Rigth?.Minutes >= Left?.Minutes;
            else
                return Rigth?.Hours >= Left?.Hours;
        }
        public static bool operator <=(Duration Rigth, Duration Left)
        {
            if (Rigth?.Hours == Left?.Hours)
                if (Rigth?.Minutes == Left?.Minutes)
                    return Rigth?.Seconds <= Left?.Seconds;
                else
                    return Rigth?.Minutes <= Left?.Minutes;
            else
                return Rigth?.Hours <= Left?.Hours;
        }
        #endregion
        #region True And False
        public static bool operator true(Duration duration)
        {
            if ((duration?.Hours) != 0 && (duration?.Minutes) != 0 && (duration?.Seconds != 0))
                return true;
            else 
                return false;
        }
        public static bool operator false(Duration duration)
        {
            if ((duration?.Hours == 0) && (duration?.Minutes == 0) && (duration?.Seconds == 0))
                return true;
            else 
                return false;
        }
        #endregion
        #region Casting
        public static explicit operator DateTime(Duration duration)
        {
            return new DateTime(1, 1, 1, duration?.Hours?? 0, duration?.Minutes ?? 0, duration?.Seconds ?? 0);
        }
        #endregion
    }
}
