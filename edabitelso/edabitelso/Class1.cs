using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabitelso
{
    class Elso
    {
        public int ElsoSzam { get; set; }


        public Elso(int a)
        {
            this.ElsoSzam = a;

        }

        public int Sum(Elso ertek)
        {
            return this.ElsoSzam + ertek.ElsoSzam;
        }
    }
}