using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Internet : Usluga
    {
        private int iloscMB;
        public override void ObliczCene()
        {
            base.cena = ((double)iloscMB / 756);
        }
        public Internet(DateTime czas, int iloscMB):
            base(czas)
        {
            this.iloscMB = iloscMB;
            ObliczCene();
        }
        public override string ToString()
        {
            return "Internet, data i godzina internetu: " + czas + ",iloscMB " + iloscMB + ", laczny koszt: " + cena;
        }
    }
}
