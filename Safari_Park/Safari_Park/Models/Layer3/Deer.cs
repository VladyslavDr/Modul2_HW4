using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari_Park
{
    public abstract class Deer : Hoofed
    {
        public Deer(DateTime birthDate, Weight weight, Country habitat, bool tame, Wool wool, string nickname, Length horn)
            : base(birthDate, weight, habitat, tame, wool, nickname)
        {
            HoofType = HoofType.Paranormous;
            Horn = horn;
        }

        public Length Horn { get; init; }
    }
}
