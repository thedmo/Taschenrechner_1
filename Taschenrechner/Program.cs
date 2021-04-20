using System;

namespace Taschenrechner {
    class Program {
        static void Main(string[] args) {

            Console.Clear();

            string ersterSummand = HoleEingabe("1. Summand eingeben: ");

            string zweiterSummand = HoleEingabe("2. Summand eingeben: ");

            double ersteZahl = Convert.ToDouble(ersterSummand);
            double zweiteZahl = Convert.ToDouble(zweiterSummand);

            double result = Addiere(ersteZahl, zweiteZahl);

            Console.WriteLine("Resultat: " + result);

            WarteAufBenutzerEingabe();
        }

        static string HoleEingabe(string ausgabeText) {
            Console.WriteLine(ausgabeText);
            string s = Console.ReadLine();
            return s;
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
