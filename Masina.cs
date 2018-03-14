using System;
namespace overloading
{
    public class Masina
    {
        private string marke;
        private string modelis;

        private string[] masinuMasivas = new string[] { "audi", "vw", "bmw" };

        private string[][] markiuMasivas = new string[][] { new string[]{ "200", "100", "80" }, new string[]{ "jeta", "pasat", "golf" }, new string[]{"325","530","750"} };

        public Masina(string Marke, string Modelis)
        {
            marke = Marke;
            modelis = Modelis;
            if (true)
            {

            }
            markeIRmodelis(Marke,Modelis);
        }
        
        public Masina(string Modelis)
        {
            modelis = Modelis;
            if (true)
            {

            }
            kuris(Modelis);
        }
        
        private void markeIRmodelis(string mar, string mod)
        {
            bool rado = true;
            Console.Clear();
            for (int i = 0; i < masinuMasivas.Length; i++)           
            {
                if (mar == masinuMasivas[i])
                {
                    //Console.WriteLine(masinuMasivas[i]);
                    //Console.WriteLine(markiuMasivas[i].Length);
                    rado = true;
                    for (int e = 0;e < 3; e++)   // NELEIDO IRASHYTI VIETON 3 markiuMasivas[i].Length !!!
                    {
                        //Console.WriteLine(markiuMasivas[i][e]);
                        if (mod == markiuMasivas[i][e])
                        {
                            rado = true;
                            Console.WriteLine($"Jusu pasirinktas auto ({mar} {mod}) yra pardavime.");
                            break;
                        }
                        else
                        {
                            rado = false;
                        }
                    }
                }
                
            }
            if (rado == false)
            {
                Console.WriteLine($"Siuo metu auto ({mar} {mod}) NETURIME PARDAVIME.");
            }
        }
        private void kuris(string model)
        {
            bool rado = true;
            int e = 0;
            Console.Clear();
            for (; e < 3; e++)
            {
                for (int i = 0; i < markiuMasivas.Length; i++)
                {
                    if (model != markiuMasivas[e][i])
                    {
                        //Console.WriteLine(markiuMasivas[e][i]);
                        //Console.WriteLine(e);
                        rado = false;
                    }
                    else
                    {
                        Console.WriteLine("radau");
                        Console.WriteLine($"Jusu marke ({model}) priklauso gamintojuj ({masinuMasivas[e]}) ir mes turim ja pardavime.");
                    }

                }
            }

            if (rado == false)
            {
                Console.WriteLine($"Marke {model} Nerastas!");
            }
        }
    }
}
