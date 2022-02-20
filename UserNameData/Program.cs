using System;

namespace UserNameData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal eesnime;
            //programm kuvab kasutaja eesnime pikkust;
            //programm kuvab kasutaja eesnime esimsest tähte;
            //programm kuvab kasutaja eesnime tagurpidi;
            //main meetodis ei tohi olla rohkem, kui kolm rida koodi;
            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            GetUsernameData(userName);
        }

        public static void GetUsernameData(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }


        }







    }
}