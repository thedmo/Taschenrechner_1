using System;

namespace Taschenrechner {
    class Program {
        static void Main(string[] args) {

            Console.Clear();


            Console.Write("1. Summand eingeben: ");
            string ersterSummand = Console.ReadLine();

            Console.Write("2. Summand eingeben: ");
            string zweiterSummand = Console.ReadLine();

            double ersteZahl = Convert.ToDouble(ersterSummand);
            double zweiteZahl = Convert.ToDouble(zweiterSummand);

            double result = Addiere(ersteZahl, zweiteZahl);

            Console.WriteLine("Resultat: " + result);

            WarteAufBenutzerEingabe();
        }

        private static double Addiere(double ersteZahl, double zweiteZahl) {
            double summe = ersteZahl + zweiteZahl;
            return summe;
        }

        static void WarteAufBenutzerEingabe() {
            Console.WriteLine("Zum Beenden bitte Return drücken.");
            Console.ReadLine();
        }
    }
}
