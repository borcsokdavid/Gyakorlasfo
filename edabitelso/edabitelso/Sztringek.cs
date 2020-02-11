using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabitelso
{
    class Sztringek
    {
      public string Szoveg { get; set; }
        
      public Sztringek(string szoveg)
        {
            this.Szoveg = szoveg;
        }  

        public bool EgyenloHosszuak(Sztringek masik)
        {
            if (this.Szoveg.Length == masik.Szoveg.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        

        public bool VanESpaceMasodik()
        {
            bool vanE = false;

            for (int i = 0; i < this.Szoveg.Length; i++)
            {
                if (this.Szoveg[i] == ' ')
                {
                    vanE = true;
                }
            }



            return vanE;
        }
    }
}
