using System;

namespace Wej1___2A
{
    class Program
    {
        static void Main(string[] args)
        {

            Prostokat P1 = new Prostokat(3, 2);
            Console.WriteLine("Pole prostokata 1: {0}", P1.podajPole());
            Console.WriteLine("Obwod prostokata 1: {0}", P1.podajObwod());
            
        }
    }

    public class Prostokat
    {
        double bokA;
        double bokB;

        public Prostokat(double bokA, double bokB)
        {
            this.bokA = bokA;
            this.bokB = bokB;

        }

        public double podajPole()
        {
            double pole;
            pole = bokA * bokB;

            return pole;
        }

        public double podajObwod()
        {
            double obwod;
            obwod = 2 * bokA + 2 * bokB;

            return obwod;
        }


    }
}
