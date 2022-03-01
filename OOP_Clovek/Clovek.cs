using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Clovek
{
    public class Clovek
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }
        public int Energie { get; set; }
        public int Zivot { get; set; }
        public int Dovednost { get; set; }

        public Clovek()
        {
            Jmeno = "";
            Prijmeni = "";
            DatumNarozeni = DateTime.Now;
            Energie = 100;
            Zivot = 100;
            Dovednost = 0;
        }

    }
}
