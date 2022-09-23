using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari_Park
{
    public class Roe : Deer
    {
        public Roe(DateTime birthDate, Weight weight, Country habitat, bool tame, Wool wool, string nickname, Length horn, TypeOfRoe typeOfRoe)
            : base(birthDate, weight, habitat, tame, wool, nickname, horn)
        {
            TypeOfRoe = typeOfRoe;
        }

        public TypeOfRoe TypeOfRoe { get; init; }
    }
}
