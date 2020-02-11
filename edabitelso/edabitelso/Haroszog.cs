using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabitelso
{
    class Haroszog
    {
        public int Alap { get; set; }
        public int Magassag { get; set; }
        public Haroszog (int a, int b)
        {
            this.Alap = a;
            this.Magassag = a;
        }
    
        public double TeruletSzamol()
        {
            return (this.Alap * this.Magassag) / 2;
        }

        


    }
}
