using System;

namespace Taschenrechner {
    class Program {
        static void Main(string[] args) {
            do {
                Console.Clear();


                Console.Write("1. Summand eingeben: ");
                string ersterSummand = Console.ReadLine();

                Console.Write("2. Summand eingeben: ");
                string zweiterSummand = Console.ReadLine();

                float ersteZahl = Convert.ToSingle(ersterSummand);
                float zweiteZahl = Convert.ToSingle(zweiterSummand);

                double result = ersteZahl + zweiteZahl;

                Console.WriteLine("Resultat: " + Convert.ToSingle(result) + "\n\nbeliebige Taste drücken zum Beenden...");

                Console.WriteLine("E drücken zum beenden, beliebige Taste drücken für weitere Berechnung");
            } while (Console.ReadKey().Key != ConsoleKey.E);
        }
    }
}
