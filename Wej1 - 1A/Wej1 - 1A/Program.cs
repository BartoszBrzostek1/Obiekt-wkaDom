using System;

namespace Wej1___1A
{
    //Zadanie 1
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj temeperature w stopniach Celsjusza");
            double tem;
            tem = int.Parse(Console.ReadLine());
            Console.WriteLine("Temeratura w C: {0}", tem);
            double f;
            f = tem * 1.8 + 32;
            Console.WriteLine("Temperatura w F: {0}", f);

        }
    }
}
