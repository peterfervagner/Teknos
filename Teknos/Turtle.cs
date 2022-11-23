using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teknos
{
    internal class Turtle
    {
        int happiness = 0;
        int fedLevel = 0;
        public int Random()
        {
            Random rnd = new Random();
            int szam = rnd.Next(0, 1001);
            return szam;
        }
        public int Happiness
        {
            get { return happiness; }
            set { happiness = Random(); }
        }
        public int FedLevel
        {
            get { return fedLevel; }
            set { fedLevel = Random(); }
        }
        public void Egyenlo()
        {
            Happiness = happiness;
            FedLevel = fedLevel;
        }

        public void Eat(int salad, int crab)
        {
            if (fedLevel+salad < 1000)
            {
                fedLevel += salad;
            }
            if (fedLevel + crab < 1000)
            {
                fedLevel += crab;
            }
            if (fedLevel < 500)
            {
                happiness += 2 * (salad + crab);
            }
            else
            {
                happiness -= 2 * (salad + crab);
            }
        }
    }
}
