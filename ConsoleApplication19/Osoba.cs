using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Osoba : IComparable<Osoba>
    {
        private int wiek;

        public int Wiek
        {
            get { return wiek; }
            set { wiek = value; }
        }

        private string imie;

        public string Imie
        {
            get { return imie; }
            set { imie = value; }
        }

        public Osoba(string imie, int wiek)
        {
            this.Wiek = wiek;
            this.Imie = imie;
        }

        public override string ToString()
        {
            return Imie + ", " + Wiek;
        }

        public int CompareTo(Osoba innaOsoba)
        {
            if (this.Imie == innaOsoba.Imie)
                return this.Wiek.CompareTo(innaOsoba.Wiek);
            return this.Imie.CompareTo(innaOsoba.Imie);
        }



    }
}
