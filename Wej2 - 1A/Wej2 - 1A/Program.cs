using System;

namespace Wej2___1A
{
    class Program
    {
        static void Main(string[] args)
        {

            Samochod s1 = new Samochod();

            s1.Uruchom();
            s1.JedzDoPrzodu();
            s1.JedzDoTyłu();
            s1.Wylacz();
            s1.JedzDoPrzodu();


            Rower r1 = new Rower();

            r1.JedzDoPrzodu();
            r1.JedzDoTyłu();
            
        }

    }

    class Pojazd
    {
        string marka;
        string model;

        public virtual void JedzDoPrzodu()
        {

        }

        public virtual void JedzDoTyłu()
        {

        }
    }

    class Samochod : Pojazd
    {

        bool czyUruchominy;

        public override void JedzDoPrzodu()
        {
            base.JedzDoPrzodu();
            if (czyUruchominy == true)
            {
                Console.WriteLine("Jade do przodu samochodem");
            }
            else
                Console.WriteLine("Samochod nie jest uruchomiony");
        }

        public override void JedzDoTyłu()
        {
            base.JedzDoTyłu();
            if (czyUruchominy == true)
            {
                Console.WriteLine("Jade do tylu samochodem");
            }
            else
                Console.WriteLine("Samochod nie jest uruchomiony");
        }

        public void Uruchom()
        {
            Console.WriteLine("Uruchamiam...");
            czyUruchominy = true;
        }

        public void Wylacz()
        {
            Console.WriteLine("Wylaczam...");
            czyUruchominy = false;
        }

    }

    class Rower : Pojazd
    {
        public override void JedzDoPrzodu()
        {
            base.JedzDoPrzodu();
            Console.WriteLine("Jade do przodu rowerem");
        }

        public override void JedzDoTyłu()
        {
            base.JedzDoTyłu();
            Console.WriteLine("Pcham rower do tylu");
        }

    }
}
