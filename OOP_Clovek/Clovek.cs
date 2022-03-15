using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Clovek
{
    public class Clovek
    {
        //soukromé proměnné nejsou dostupné mimo třídu člověk
        private int dovednost;
        private int energie;

        //vlastnosti - zveřejňují hodnoty ven z třídy
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }
        public int Energie { get=>energie; }
        public int Zivot { get; set; }
        public int Dovednost { get =>dovednost; }
        
          //konstruktor - pomocí této metody vznine konkrétní objekt - instance třídy
        public Clovek()
        {
            Jmeno = "";
            Prijmeni = "";
            DatumNarozeni = DateTime.Now;
            energie = 100;
            Zivot = 100;
            dovednost = 0;
        }

        public void Zestarnout()
        {
            energie -= 10;
            if (energie < 0)
            {
                energie = 0;
            }
            Zivot += 2;

            if (Zivot > 120)
            {
                Zivot = 120;
            }
        }

        public void Zvysitdovednosti()
        {
            dovednost += 10;
            if (dovednost > 100)
            {
                dovednost = 100;
            }
            
        }



          public void Zvysitdovednost()
        {
            dovednost += 20;
            energie += 10;
        }

        

    }
}
