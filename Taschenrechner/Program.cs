using System;

namespace Taschenrechner {
    class Program {
        static void Main(string[] args) {
            //Ausgabe leeren
            Console.Clear();

            //Eingabe
            string ersterSummand = HoleEingabe("1. Summand eingeben: ");
            string zweiterSummand = HoleEingabe("2. Summand eingeben: ");

            //Umwandlung zu Zahl
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double ersteZahl = Convert.ToDouble(ersterSummand);
            double zweiteZahl = Convert.ToDouble(zweiterSummand);

            //Berechnung
            double result = Addiere(ersteZahl, zweiteZahl);
            double result2 = Subtrahiere(ersteZahl, zweiteZahl);

            //Ausgabe
            Console.WriteLine("Summe der zwei Zahlen: " + result);
            Console.WriteLine("Differenz der zwei Zahlen: " + result2);


            //Beenden
            WarteAufBenutzerEingabe();
        }

        static string HoleEingabe(string ausgabeText) {
            Console.Write(ausgabeText);
            string s = Console.ReadLine();
            return s;
        }

        private static double Addiere(double ersteZahl, double zweiteZahl) {
            double summe = ersteZahl + zweiteZahl;
            return summe;
        }

        private static double Subtrahiere(double minuend, double subtrahend) {
            double differenz = minuend - subtrahend;
            return differenz;
        }

        static void WarteAufBenutzerEingabe() {
            Console.WriteLine("Zum Beenden bitte Return drücken.");
            Console.ReadLine();
        }
    }
}
