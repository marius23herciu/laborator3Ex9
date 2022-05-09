using System;

namespace laborator3Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrieti un program care citind de la tastatura lungimea si latimea unui
            //dreptungh, va afisa diagonala acestuia.
            //             Calculul diagonalei va fi extras intr-o functie

            Console.WriteLine("Introduceti lungimea:");
            int lungime = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti latimea:");
            int latime = int.Parse(Console.ReadLine());

            if (lungime < 1 || latime < 1)
            {
                Console.WriteLine("Introduceti numere pozitive.");
                return;
            }

            double diagonala = DiagonalaDreptunghi(lungime, latime);
            Console.WriteLine("Diagonala dreptunghiului este: " + diagonala);
        }
        static double DiagonalaDreptunghi(int lungime, int latime)
        {
            double diagonala = Math.Sqrt(Math.Pow(lungime, 2) + Math.Pow(latime, 2)) ;
            return diagonala;
        }
    }
}
