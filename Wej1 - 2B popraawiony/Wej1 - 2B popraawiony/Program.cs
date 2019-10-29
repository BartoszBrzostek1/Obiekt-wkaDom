using System;

namespace Wej1___2B_popraawiony
{
    class Program
    {
        static void Main(string[] args)
        {

            Pracownik P1 = new Pracownik("Michal", "Trupel", 2000);
            Pracownik P2 = new Pracownik("Tomasz", "Ator", 2000.51);

            Console.WriteLine(P1.roczneZarobki());
            Console.WriteLine(P2.roczneZarobki());

        }
    }
}
