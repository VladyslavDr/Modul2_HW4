using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari_Park
{
    public class Weight
    {
        public Weight(int value)
        {
            Value = value;
        }

        public int Value { get; init; }
        public Measure Measure => Measure.Kg;
    }
}
