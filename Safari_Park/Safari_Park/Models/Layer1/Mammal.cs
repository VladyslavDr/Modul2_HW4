using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari_Park
{
    public abstract class Mammal : Animal
    {
        public Mammal(DateTime birthDate, Weight weight, Country habitat, bool tame, Wool wool, string nickname)
            : base(birthDate, weight, habitat, tame)
        {
            Wool = wool;
            Nickname = nickname;
        }

        public Wool Wool { get; init; }
        public string Nickname { get; set; }
    }
}
