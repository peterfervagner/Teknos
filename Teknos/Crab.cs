using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Teknos
{
    internal class Crab : Food
    {
        int meret;
        public int Random()
        {
            Random rnd = new Random();
                return rnd.Next(1, 11);
        }
        public int Meret
        {
            get { return meret; }
            set { meret = Random(); }
        }
        public override int Value()
        {
            Meret = meret;
            meret *= 10;
            return meret;
        }
    }
}