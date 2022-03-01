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
        private int energie;
        public int Energie { get=>energie; }
        public int Zivot { get; set; }
        private int dovednost;
        public int Dovednost { get =>dovednost; }

        public Clovek()
        {
            Jmeno = "";
            Prijmeni = "";
            DatumNarozeni = DateTime.Now;
            energie = 100;
            Zivot = 100;
            dovednost = 0;
        }

        public void Zvysitdovednost()
        {
            dovednost += 20;
            energie += 10;
        }

    }
}
