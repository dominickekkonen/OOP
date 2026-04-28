using System;
using System.Collections.Generic;

namespace OOP
{
    public class Koolihaldus
    {
        private List<Isik> inimesed = new List<Isik>();

        public void LisaInimene(Isik isik)
        {
            inimesed.Add(isik);
        }

        public void KuvaKõik()
        {
            foreach (var isik in inimesed)
            {
                isik.Kirjelda();
            }
        }
        public void OtsiNimeJärgi(string otsitavNimi)
        {
            foreach(var isik in inimesed)
            {
                if (isik.Nimi == otsitavNimi)
                {
                    isik.Kirjelda();
                }
                else
                {
                    Console.WriteLine("Isik ei otsitav");
                }
            }
        }
    }
}
