using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class SporiciUcet : BeznyUcet
    {

        public SporiciUcet(string radekCSV) :base(radekCSV)
        {

        }

        public SporiciUcet(string nazevUctu, string klient) :base (nazevUctu, klient)
        {
            TypUctu = "Spořící účet";
        }

        public SporiciUcet(string nazevUctu, string klient, string typUctu, string cisloUctu, string castka) : base(nazevUctu,klient, typUctu, cisloUctu, castka)
        {

        }
    }
}
