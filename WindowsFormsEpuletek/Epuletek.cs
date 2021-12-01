using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsEpuletek
{
    class Epuletek
    {
        string cim;
        int alapterulet;
        string[] epitesianyag;
        DateTime kezdet;
        DateTime vege;

        public Epuletek(string cim, int alapterulet, string[] epitesianyag, DateTime kezdet, DateTime vege)
        {
            this.Cim = cim;
            this.Alapterulet = alapterulet;
            this.Epitesianyag = epitesianyag;
            this.Kezdet = kezdet;
            this.Vege = vege;
        }

        public string Cim { get => cim; set => cim = value; }
        public int Alapterulet { get => alapterulet; set => alapterulet = value; }
        public DateTime Kezdet { get => kezdet; set => kezdet = value; }
        public DateTime Vege { get => vege; set => vege = value; }
        public string[] Epitesianyag { get => epitesianyag; set => epitesianyag = value; }

        public override string ToString()
        {
            return cim;
        }
    }
}
