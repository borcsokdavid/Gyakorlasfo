using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabitelso
{
    class Elso
    {
        public int ElsoSzam { get; set; }
        public bool logikaiErtek { get; set; }


        public Elso(int a)
        {
            this.ElsoSzam = a;

        }

        public Elso(bool b)
        {
            this.logikaiErtek = b;
        }

        public int Sum(Elso ertek)
        {
            return this.ElsoSzam + ertek.ElsoSzam;
        }

        public bool Elojel()
        {
            if (this.ElsoSzam <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}