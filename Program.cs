using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace overloading
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            string b = "";
            do
            {
                Console.WriteLine("Jus zinote norimos markes gamintoja? (t) or (n)");
                b = Console.ReadLine();
            } while (b!="t" && b!="n");

            if (b == "t")
            {
                Console.Clear();
                Console.Write("Iveskite gamintoja: ");
                string gamintojas = Console.ReadLine();
                Console.Write("Iveskite marke: ");
                string marke = Console.ReadLine();
                Masina masina = new Masina(gamintojas, marke);
            }

            if (b == "n")
            {
                Console.Clear();
                Console.Write("Iveskite marke: ");
                Masina masina2 = new Masina(Console.ReadLine());
            }
            
//            Masina masina = new Masina(Console.ReadLine(), Console.ReadLine());
            
 //           Masina masina2 = new Masina(Console.ReadLine());

        }
    }
}
