using System;

namespace Wej2___1B
{
    class Program
    {
        static void Main(string[] args)
        {
            Wojownik x = new Wojownik("Olgierd", 24, 24, 15, 9);

            x.PrzedstawSie();
            Console.WriteLine("Sila ataku: " + x.SilaAtaku());
            x.WypiszHP();
            
        }
    }

    public abstract class Postac
    {
        public enum Rasa {Czlowiek, Krasnolud, Elf };
        public string imie;
        public int hp;
        public int maxHP;
        public int sila;
        public int zrecznosc;


        public double SilaAtaku()
        {
            double sa;

            sa = (sila * Math.Sqrt(zrecznosc)) * (hp / maxHP);
            return sa;
        }

        public void WypiszHP()
        {
            Console.WriteLine("{0} {1}/{2} HP",imie, hp, maxHP);
        }

        abstract public void PrzedstawSie();
    }

    public class Wojownik : Postac
    {
        public Wojownik(string imie, int hp, int maxHP, int sila, int zrecznosc)
        {
            this.imie = imie;
            this.hp = hp;
            this.maxHP = maxHP;
            this.sila = sila;
            this.zrecznosc = zrecznosc;
        }

        public override void PrzedstawSie()
        {
            Console.WriteLine("Imie: {0}, Rasa: {1}, Bron: Miecz dwureczny", imie, Rasa.Czlowiek );
        }


    }
}
