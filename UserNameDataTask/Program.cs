using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnimi
            //programm küsib kasutajal sisestada numbrit 1-3
            //kui kasutaja sisestab "1", siis kuvatakse kasutaja eesnimi tagurpidi
            //kui kasutaja sisestab" 2", siis kuvatakse kasutaja eesnime esimene täht
            //kui kasutaja sisestab "3", siis kuvatakse kasutaja eesnime pikkus

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Sisesta number vahemikus '1' kuni '3':");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '1':
                    NameReverse(userName);
                    break;
                case '2':
                    FirstLetterName(userName);
                    break;
                case '3':
                    NameLength(userName);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }

        }

        public static void NameReverse(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
        public static void FirstLetterName(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}.");
        }
        public static void NameLength(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }
    }
}
