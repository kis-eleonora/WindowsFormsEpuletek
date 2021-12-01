using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsEpuletek
{
    class Tombhaz : Epuletek
    {
        int lakasok;
        string[] fenntartas;
        bool lift;


        public int Lakasok { get => lakasok; set => lakasok = value; }
        public string[] Fenntartas { get => fenntartas; set => fenntartas = value; }
        public bool Lift { get => lift; set => lift = value; }
        public Tombhaz(string cim, int alapterulet, string[] epitesianyag, DateTime kezdet, DateTime vege, int lakasok, string[] fenntartas, bool lift) :base(cim, alapterulet, epitesianyag, kezdet, vege)
        {
            Lakasok = lakasok;
            Fenntartas = fenntartas;
            Lift = lift;
        }
    }
}
