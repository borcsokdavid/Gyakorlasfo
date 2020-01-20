using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabitelso
{
    class elso
    {
        public int elsoSzam { get; set; }
        public bool logikaiErtek { get; set; }


        public elso(int a)
        {
            this.elsoSzam = a;

        }

        public elso(bool b)
        {
            this.logikaiErtek = b;
        }

        public int Sum(elso ertek)
        {
            return this.elsoSzam + ertek.elsoSzam;
        }

        public bool Elojel()
        {
            if (this.elsoSzam <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool OttelOszthato ()
        {
            if (this.elsoSzam % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool OttelOszthato(elso masik)
        {
            if (this.elsoSzam % masik.elsoSzam == 0)
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
