using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari_Park
{
    public abstract class Predatory : Mammal
    {
        public Predatory(DateTime birthDate, Weight weight, Country habitat, bool tame, Wool wool, string nickname, Length canineLength)
            : base(birthDate, weight, habitat, tame, wool, nickname)
        {
            CanineLength = canineLength;
        }

        public Length CanineLength { get; init; }
    }
}
