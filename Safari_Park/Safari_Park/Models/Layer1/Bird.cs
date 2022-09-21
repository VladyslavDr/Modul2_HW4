using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari_Park
{
    public abstract class Bird : Animal
    {
        public Bird(DateTime birthDate, Weight weight, Country habitat, bool tame, Plumage plumage)
            : base(birthDate, weight, habitat, tame)
        {
            Plumage = plumage;
        }

        public Plumage Plumage { get; init; }
    }
}
