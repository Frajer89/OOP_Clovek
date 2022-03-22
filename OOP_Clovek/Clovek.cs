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
        public int Energie { get => energie; }
        public int Zivot { get; set; }
        public int Dovednost { get => dovednost; }

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
                Zivot -= 10;
            }
            else
            {
                Zivot += 10;
            }

            if (Zivot > 200)
            {
                Zivot = 200;
            }

            if (Zivot < 0)
            {
                Zivot = 0;
            }

            

        }

        public void Zvysitdovednost()
        {
            dovednost += 10;
            energie += 10;
        }

        public void Zvysitdovednosti()
        {
            dovednost += 10;
            energie += 10;

            if (energie < 0)
            {
                energie = 0;
            }

            if (energie > 200)
            {
                energie = 200;
            }

            if (dovednost > 200)
            {
                dovednost = 200;
            }

        }
        public void Utok()
        {
            Zivot -= 10;
            if (Zivot < 0)
            {
                Zivot = 0;
            }
        }

        public void SuperUtok()
        {
            Zivot -= 25;
            if (Zivot < 0)
            {
                Zivot = 0;
            }

        }
        




























    }
}
