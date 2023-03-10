using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    internal interface ISeries
    {
        public int Current { get; set; }
        public void GetNext();

        public void Reset()
        {
            Current = 0;
        }
    }

    class SeriesOf2 : ISeries
    {
        public int Current { get; set; }
        public void GetNext()
        {
            Current += 2;
        }
    }
    class SeriesOf3 : ISeries
    {
        public int Current { get; set; }
        public void GetNext()
        {
            Current += 3;
        }
    }

    class SeriesOf4
    {
        public int Current { get; set; }
        public void GetNext()
        {
            Current += 4;
        }
    }
}
