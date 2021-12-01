using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsEpuletek
{
    class Csaladihaz : Epuletek
    {
        int ottelok;
        bool garazs;
        string[] teto;

        public int Ottelok { get => ottelok; set => ottelok = value; }
        public bool Garazs { get => garazs; set => garazs = value; }
        public string[] Teto { get => teto; set => teto = value; }

        public Csaladihaz(string cim, int alapterulet, string[] epitesianyag, DateTime kezdet, DateTime vege, int ottelok, bool garazs, string[] teto) :base(cim, alapterulet, epitesianyag, kezdet, vege)
        {
            Ottelok = ottelok;
            Garazs = garazs;
            Teto = teto;
        }
    }
}
