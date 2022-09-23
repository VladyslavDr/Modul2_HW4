using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari_Park
{
    public abstract class Dog : Predatory
    {
        public Dog(DateTime birthDate, Weight weight, Country habitat, bool tame, Wool wool, string nickname, Length canineLength, Length mustacheLength)
            : base(birthDate, weight, habitat, tame, wool, nickname, canineLength)
        {
        }
    }
}
