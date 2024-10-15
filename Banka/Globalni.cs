using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka
{
    class Globalni
    {
        public static List<Klient> seznamKlientu = new List<Klient>();
        public static List<BeznyUcet> seznamBeznychUctu = new List<BeznyUcet>();
        public static List<SporiciUcet> seznamSporicichUctu = new List<SporiciUcet>();

        public static void NactiSeznamKlientu()
        {
            bool souborBankovniUcetExistuje = File.Exists("Klienti.csv");

            if (!souborBankovniUcetExistuje)
            {
                StreamWriter streamWriter = new StreamWriter("Klienti.csv", false, Encoding.UTF8);
                streamWriter.WriteLine("Jméno;Příjmení;Příhlašovací jméno;Heslo;Běžné a spořící účty");
                streamWriter.Close();
            }

            using (StreamReader streamReader = new StreamReader("Klienti.csv", Encoding.UTF8))
            {
                streamReader.ReadLine();
                string radekCSV;
                while (!streamReader.EndOfStream)
                {
                    radekCSV = streamReader.ReadLine();
                    seznamKlientu.Add(new Klient(radekCSV));
                }
            }
        }   

        public static void NactiSeznamBeznychUctu()
        {

            bool souborBeznyUcetExistuje = File.Exists("BezneUcty.csv");

            if (!souborBeznyUcetExistuje)
            {
                StreamWriter streamWriter = new StreamWriter("BezneUcty.csv", false, Encoding.UTF8);
                streamWriter.WriteLine("Název účtu;Klient;Typ účtu; Číslo účtu; Částka");
                streamWriter.Close();
            }

            using (StreamReader streamReader = new StreamReader("BezneUcty.csv", Encoding.UTF8))
            {
                streamReader.ReadLine();
                string radekCSV;
                while (!streamReader.EndOfStream)
                {
                    radekCSV = streamReader.ReadLine();
                    seznamBeznychUctu.Add(new BeznyUcet(radekCSV));
                }
            }
        }
        public static void NactiSeznamSporicichUctu()
        {
            bool souborSporiciUcetExistuje = File.Exists("SporiciUcty.csv");

            if (!souborSporiciUcetExistuje)
            {
                StreamWriter streamWriter = new StreamWriter("SporiciUcty.csv", false, Encoding.UTF8);
                streamWriter.WriteLine("Název účtu;Klient;Typ účtu; Číslo účtu; Částka");
                streamWriter.Close();
            }

            using (StreamReader streamReader = new StreamReader("SporiciUcty.csv", Encoding.UTF8))
            {
                streamReader.ReadLine();
                string radekCSV;
                while (!streamReader.EndOfStream)
                {
                    radekCSV = streamReader.ReadLine();
                    seznamSporicichUctu.Add(new SporiciUcet(radekCSV));
                }
            }
        }

        public static void UlozSeznamKlientu()
        {
            using (StreamWriter streamWriter = new StreamWriter("Klienti.csv", false, Encoding.UTF8))
            {
                streamWriter.WriteLine("Jméno;Příjmení;Příhlašovací jméno;Heslo;Běžné a spořící účty");
                foreach(Klient klient in seznamKlientu)
                {
                    streamWriter.WriteLine(klient.ToCSV());
                }
            }
        }

        public static void UlozSeznamBeznychUctu()
        {
            using (StreamWriter streamWriter = new StreamWriter("BezneUcty.csv", false, Encoding.UTF8))
            {
                streamWriter.WriteLine("Název účtu;Klient;Typ účtu; Číslo účtu; Částka");
                foreach (BeznyUcet beznyUcet in seznamBeznychUctu)
                {
                    streamWriter.WriteLine(beznyUcet.ToCSV());
                }
            }
        }

        public static void UlozSeznamSporicichUctu()
        {
            using (StreamWriter streamWriter = new StreamWriter("SporiciUcty.csv", false, Encoding.UTF8))
            {
                streamWriter.WriteLine("Název účtu;Klient;Typ účtu; Číslo účtu; Částka");
                foreach (SporiciUcet sporiciUcet in seznamSporicichUctu)
                {
                    streamWriter.WriteLine(sporiciUcet.ToCSV());
                }
            }
        }
    }
}
