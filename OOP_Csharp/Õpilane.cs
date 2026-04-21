using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public enum Õppevorm
    {
        Päevane,
        Kaugõpe,
        Ekstern,
        AkadeemilinePuhkus
    }
    public class Õpilane : Isik, ITööline
    {
        public string Kool { get; set; }
        public int Klass { get; set; }
        public Õppevorm Staatus { get; set; }

        private double keskmineHinne;
        public double KeskmineHinne {
            get { return keskmineHinne; }
            set {
                if (value > 0 && value <= 5.0)
                {
                    keskmineHinne = value;
                }
                else
                {
                    throw new ArgumentException("Keskmine hinne peab olema suurem kui 0 ja väiksem või võrdne 5.0-ga.");
                }
            }
        }

        public int Puudumised { get; set; } = 0;
        public bool SaabEritoetust { get; set; }
        public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.Toetus;

        public double ArvutaPalk()
        {
            int toetus = 0;
            if (SaabEritoetust)
            {
                toetus += 120;
            }
            if (Puudumised < 30 && KeskmineHinne >= 3.8)
            {
                toetus += 60;
            }
            return toetus;
        }

        public void Õpi()
        {
            Console.WriteLine($"{Nimi} õpib {Kool} {Klass}. klassis.");
        }

        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpilane {Nimi} ja käin {Klass}. klassis. Vorm: {Staatus}");
        }

    }
}
