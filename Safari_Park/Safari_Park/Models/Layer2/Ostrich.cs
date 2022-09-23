using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari_Park
{
    public class Ostrich : Bird
    {
        public Ostrich(DateTime birthDate, Weight weight, Country habitat, bool tame, Plumage plumage, Length wingspan, BeakForm beakForm)
            : base(birthDate, weight, habitat, tame, plumage, beakForm)
        {
            Wingspan = wingspan;
        }

        public Length Wingspan { get; init; }
    }
}
