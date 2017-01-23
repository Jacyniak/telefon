using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Sms : Usluga
    {
        private string numer;
        public override void ObliczCene()
        {
            base.cena = 0.15;
        }
        public Sms(DateTime czas,string numer):
            base(czas)
        {
            this.numer = numer;
            ObliczCene();
        }
        public override string ToString()
        {
            return "Smsm: numer " + numer + ",data i godzina smsa " + czas + "laczny koszt: " + cena;
        }
    }
}
