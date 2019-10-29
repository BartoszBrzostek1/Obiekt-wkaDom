using System;

public class Pracownik
{
    string imie;
    string nazwisko;
    double pensja;

	public Pracownik(string imie, string nazwisko, double pensja)
	{

        this.imie = imie;
        this.nazwisko = nazwisko;
        this.pensja = pensja;

	}

    public string roczneZarobki()
    {
        string c;
        c = "Roczna pensja " + imie + " " + nazwisko + " wynosi " + pensja + "pln.";
        return c;

    }
}
