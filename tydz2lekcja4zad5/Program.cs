using System;

namespace tydz2lekcja4zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoje imię");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj swoje nazwisko");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj swój numer telefonu");
            string nrTel = Console.ReadLine();
            Console.WriteLine("Podaj swój adres e-mail");
            string email = Console.ReadLine();
            Console.WriteLine("Podaj swój wiek");
            string zmienna = Console.ReadLine();
            byte wiek = Byte.Parse(zmienna);
            Console.WriteLine("Podaj swoją wagę");
            zmienna = Console.ReadLine();
            double waga = Double.Parse(zmienna);
        }
    }
}
