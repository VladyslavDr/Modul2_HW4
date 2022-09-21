using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari_Park
{
    public class Ostrich : Bird
    {
        public Ostrich(DateTime birthDate, Weight weight, Country habitat, bool tame, Plumage plumage, int wingspan)
            : base(birthDate, weight, habitat, tame, plumage)
        {
            Wingspan = wingspan;
        }

        public int Wingspan { get; init; }
    }
}
