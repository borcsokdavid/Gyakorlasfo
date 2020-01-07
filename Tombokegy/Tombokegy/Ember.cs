using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombokegy
{
    class Ember
    {
        private int magassag;
        private int testsuly;
        private string szuletesiEv;
        static public string osztaly = "Szoftverfejlesztő";
        static public int evfolyam = 13;

        public int Magassag
        {
            get { return this.magassag; }
            set
            {
                if (value < 0 || value > 450)
                    throw new ArgumentException("Nem jó magasság érték!");
                this.magassag = value;
            }
        }

        public int Testsuly
        {
            get { return this.testsuly; }
            set
            {
                if (Testsuly < 0)
                    throw new ArgumentException("Nem jó testsúly érték!");
                this.testsuly = value;
            }
        }

        public string SzuletesiEv
        {
            get { return this.szuletesiEv; }
            set { this.szuletesiEv = value; }
        }

        public Ember(int Magassag, int Testsuly, string SzuletesiEv)
        {
            if (Magassag < 0 || Magassag > 450)
                throw new ArgumentException("Nem jó magasság érték!");
            if (Testsuly < 0)
                throw new ArgumentException("Nem jó testsúly érték!");
            this.magassag = Magassag;
            this.testsuly = Testsuly;
            this.szuletesiEv = SzuletesiEv;
        }

        public Ember()
        {

        }

        public int GetMagassag()
        {
            return this.magassag;
        }

        public void SetMagassag(int value)
        {
            if (value < 0 || value > 450)
                throw new ArgumentException("Nem jó magasságérték!");
            this.magassag = value;
        }

        public int GetTestsuly()
        {
            return this.testsuly;
        }

        public void SetTestsuly(int value)
        {
            if (value < 0)
                throw new ArgumentException("Nem jó testsúlyérték!");
            this.testsuly = value;
        }

        public string GetSzuletesiEv()
        {
            return this.szuletesiEv;
        }

        public void SetSzuletesiEv(string value)
        {
            this.szuletesiEv = value;
        }

        public void Kiir(int i)
        {
            Console.WriteLine($"Az {i}. ember magassága: {this.magassag}");
            Console.WriteLine($"Az {i}. ember testsúlya: {this.testsuly}");
            Console.WriteLine($"Az {i}. ember születési éve: {this.szuletesiEv}");
            Console.WriteLine($"Az {i}. ember osztálya: {evfolyam}/{osztaly}");
        }

        static public void KiirOsztaly()
        {
            Console.WriteLine($"Évfolyam: {evfolyam}, osztály: {osztaly}");
        }
    }
}
