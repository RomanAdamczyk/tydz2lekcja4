using System;

namespace tydz2lekcja4zad3
{
    class Program
    {
      
        static void Main(string[] args)
      
        {
            Console.WriteLine("podaj długość prostokąta");
            string aString = Console.ReadLine();
            Console.WriteLine("podaj szerokość prostokąta");
            string bString = Console.ReadLine();

            double a = Double.Parse(aString);
            double b = Double.Parse(bString);
            double c = Math.Pow(Math.Pow(a, 2) + Math.Pow(b, 2), 0.5);

            Console.WriteLine($"{c}");
        }
    }
}
