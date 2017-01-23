using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Polaczenie : Usluga
    {
        private string numer;
        private int czasP;
        public override void ObliczCene()
        {
            base.cena = czasP * 0.29;
        }
        public Polaczenie(DateTime czas, string numer, int czasP):
            base(czas)
        {
            this.numer = numer;
            this.czasP = czasP;
            ObliczCene();
        }
        public override string ToString()
        {
            return "polaczenia: numer " + numer + "data i godzina rozmowy: " + czas + ", dlugosc trawania " + czasP + ", laczny koszt" + cena;
        }

    }
}
