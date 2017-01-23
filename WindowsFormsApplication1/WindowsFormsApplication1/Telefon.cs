using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    class Telefon : IBiling, IDodaj
    {
        private List<Usluga> biling = new List<Usluga>();
        public void DodajPolaczenie(string numer, int czasP)
        {
            biling.Add(new Polaczenie(DateTime.Now, numer, czasP));
        }
        public void DodajSms(string numer)
        {
            biling.Add(new Sms(DateTime.Now, numer));
        }
        public void DodajInternet(int iloscMB)
        {
            biling.Add(new Internet(DateTime.Now, iloscMB));
        }
        public override string ToString()
        {
            string temp = "";
            foreach (Object obj in biling)
                temp += obj.ToString() + Environment.NewLine;
            return temp;
        }
        public void ZapiszBiling()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/ZadanieBiling/";

            if (Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
            string name = "biling.txt";

            using (StreamWriter writer = new StreamWriter(path + name))
            {
                writer.Write(biling.ToString());
            }

        }
    }


}
