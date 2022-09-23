using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari_Park
{
    public class Gorilla : Monkey
    {
        public Gorilla(DateTime birthDate, Weight weight, Country habitat, bool tame, Wool wool, string nickname, TypeOfGorilla typeOfGorilla)
            : base(birthDate, weight, habitat, tame, wool, nickname)
        {
            TypeOfGorilla = typeOfGorilla;
        }

        public TypeOfGorilla TypeOfGorilla { get; init; }
    }
}
