using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Õpetaja : Isik, ITööline, IHindaja
    {
        public double Tunnitasu { get; set; }
        public int Tunnidkuus { get; set; }

        public string Aine { get; set; }

        public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.Palk;


        public virtual double ArvutaPalk()
        {
            return Tunnitasu * Tunnidkuus;
        }

        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpetaja {Nimi} ja ma õpetan: {Aine}.");
        }
        public void Õpeta()
        { 
            Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
        }
        public void Hinda(string hinne)
        {
            Console.WriteLine($"Õpetja paned: {hinne}")
        }
    }
}
