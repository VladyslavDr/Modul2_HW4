using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safari_Park
{
    public class Wool
    {
        public Wool(WoolType type, ConsoleColor color)
        {
            Color = color;
            Type = type;
        }

        public ConsoleColor Color { get; set; }
        public WoolType Type { get; set; }
    }
}
