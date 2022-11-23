using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknos
{
    internal class Salad : Food
    {
        const int tapertek = 10;
        public override int Value()
        {
            return tapertek;
        }
    }
}
