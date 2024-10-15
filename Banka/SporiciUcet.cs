using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    public class SporiciUcet : BeznyUcet
    {

        public SporiciUcet(string text) :base(text)
        {
            if (!text.Contains(";"))
            {
                Klient = text;
                TypUctu = "Spořící účet";
            }
        }

        public SporiciUcet(string klient, string typUctu, string cisloUctu, string castka) : base(klient, typUctu, cisloUctu, castka)
        {

        }
    }
}
