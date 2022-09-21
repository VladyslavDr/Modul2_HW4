using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari_Park
{
    public abstract class Animal : IComparable
    {
        private Weight _weight;
        private Country _country;
        private bool _tame;
        private DateTime _birthDate;
        public Animal(DateTime birthDate, Weight weight, Country habitat, bool tame)
        {
            _birthDate = birthDate;
            _weight = weight;
            _country = habitat;
            _tame = tame;
        }

        /*
        public Weight Weight { get; set; }
        public Country Habitat { get; set; }
        public bool Tame { get; set; }
        */
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
