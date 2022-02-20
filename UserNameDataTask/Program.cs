using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja eesnime;
            //programm küsib kasutajalt numbrit 1 - 3;
            //kui kasutaja siestab 1, siis kuvatakse kasutaja eesnime tagurpidi;
            //kui kasutaja valib 2, siis kuvatakse kasutaja eesnime esimest tähte;
            //kui kasutaja valib 3, siis kuvatakse  kasutaja eesnime pikkust;

            Console.WriteLine("Sisestage oma eesnimi:");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Vali number 1 - 3:");
            int vali = Convert.ToInt32(Console.ReadLine());

            switch (vali)
            {
                case 1:
                    tagurpidinimi(eesnimi);
                    break;


                case 2:
                    esimenetäht(eesnimi);
                    break;


                case 3:
                    nimepikkus(eesnimi);
                    break;


                default:
                    Console.WriteLine("Kena päeva jätku!");
                    break;

            }



        }

        public static void tagurpidinimi(string eesnimi)
        {
            for (int i = eesnimi.Length - 1; i >= 0; i--)
            {

                Console.Write(eesnimi[i]);
            }
        }

        public static void esimenetäht(string eesnimi)
        {

            Console.WriteLine($"Sinu eesnime esimene täht on {eesnimi[0]}.");
        }

        public static void nimepikkus(string eesnimi)
        {

            Console.WriteLine($"Sinu eesnimi on {eesnimi.Length} tähte pikk.");
        }

    }
}