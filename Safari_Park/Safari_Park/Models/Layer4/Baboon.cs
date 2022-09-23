using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari_Park
{
    public class Baboon : Monkey
    {
        public Baboon(DateTime birthDate, Weight weight, Country habitat, bool tame, Wool wool, string nickname, ConsoleColor assColor, TypeOfBaboon type)
            : base(birthDate, weight, habitat, tame, wool, nickname)
        {
            AssСolor = assColor;
            TypeOfBaboon = type;
        }

        public ConsoleColor AssСolor { get; init; }

        public TypeOfBaboon Type { get; init; }
    }
}
