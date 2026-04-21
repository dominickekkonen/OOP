using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<ITööline> palgasaajad = new List<ITööline>();

            Õpetaja Marina = new Õpetaja();
            Marina.Nimi = "Marina";
            Marina.Sünniaasta = 1995;
            Marina.Aine = "programmeerimine";
            Marina.Hinda(hinne[rnd.Next(1,5)])
            Marina.Tunnidkuus = 28;
            Marina.Tunnitasu = 50;
            Marina.Õpeta();

            
            Õpetaja Jüri = new Õpetaja { Nimi = "Jüri", Sünniaasta = 1980, Aine = "Programmeerimise alused", Tunnidkuus = 40, Tunnitasu = 40 };

            Õpilane Dmitrij = new Õpilane();
            Dmitrij.Nimi = "Dmitrij";
            Dmitrij.Sünniaasta = 2008;
            Dmitrij.Puudumised = 7;
            Dmitrij.KeskmineHinne = 4.67;
            Dmitrij.Klass = 10;

            Õpilane Kati = new Õpilane { Nimi = "Dominic", Sünniaasta = 2009, Puudumised = 120, Klass=9, KeskmineHinne = 2, SaabEritoetust = false };
            // Lisame kõik palgasaajad ühte listi

            palgasaajad.AddRange(new ITööline[] { Dmitrij, Marina, Kati, Jüri });

            Direktor Direktor = new Direktor();
            Direktor.Nimi = "Viktor";
            Direktor.Sünniaasta = 1995;
            Direktor.Tunnidkuus = 45;
            Direktor.Tunnitasu = 68;
            palgasaajad.Add(Direktor);

            // 2. variant täitmine tsükli abil
            Random rnd = new Random();
            string[] nimed = { "Maria", "Kati", "Juhan", "Anna", "Siim" };

            for (int i = 0; i < nimed.Length; i++)
            {
                Õpilane õpilane = new Õpilane
                {
                    // see oli õpetaja vastus aga see võib tekkida kordav andmeid ehk inimesel võivad need dubleerida
                    //Nimi = nimed[rnd.Next(nimed.Length)],
                    Nimi = nimed[i],
                    Klass = rnd.Next(1, 13),
                    Kool = "TTHK",
                    KeskmineHinne = rnd.NextDouble() * 5,
                    Puudumised = rnd.Next(0, 350),
                    SaabEritoetust = rnd.Next(0, 2) == 1,
                    Staatus = (Õppevorm)rnd.Next(0, 4)

                };
                palgasaajad.Add(õpilane);
            }

            Console.WriteLine("\n--- Õpilase andmed ---");
            foreach (Isik isik in palgasaajad)
            {
                isik.Tervita();
            }

            Console.WriteLine("Väljamaksed:");
            foreach (ITööline isik in palgasaajad) {

                Isik inimene = (Isik)isik;

                string tüüp = isik.VäljamakseTüüp.ToString().ToLower();
                Console.WriteLine($"{inimene.GetType().Name} {inimene.Nimi} saab {tüüp}: {isik.ArvutaPalk()}");
            }
            Koolihaldus minuKool = new Koolihaldus();

            foreach (Isik isik in palgasaajad)
            {
                minuKool.LisaInimene(isik);
            }

            minuKool.KuvaKõik();
            Console.WriteLine("Sisesta otsitav nimi: ");
            string otsistavNimi = Console.ReadLine();
            minuKool.OtsiNimeJärgi(otsitavNimi);

            //õpetaja1.Kirjelda();
            //õpetaja1.Õpeta();

            //Õpilane õpilane1 = new Õpilane();
            //õpilane1.Nimi = "Artjom";
            //õpilane1.Sünniaasta = 2008;

            //õpilane1.Kool = "Tallinna Tööstushariduskeskus";
            //õpilane1.Klass = 1;
            //õpilane1.Kirjelda();
            //õpilane1.Õpi();
        }
    }    
}
