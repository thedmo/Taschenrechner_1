using System;

namespace Taschenrechner {
    class Program {
        static void Main(string[] args) {
            //Ausgabe leeren
            Console.Clear();

            //Eingabe
            string ersteEingabe = HoleBenutzerEingabe("1. Wert eingeben: ");
            string zweiteEingabe = HoleBenutzerEingabe("2. Wert eingeben: ");

            //Umwandlung zu Zahl
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double ersteZahl = Convert.ToDouble(ersteEingabe);
            double zweiteZahl = Convert.ToDouble(zweiteEingabe);

            //Berechnung
            double result = Addiere(ersteZahl, zweiteZahl);
            double result2 = Subtrahiere(ersteZahl, zweiteZahl);

            //Ausgabe
            Console.WriteLine("Summe der zwei Zahlen: " + result);
            Console.WriteLine("Differenz der zwei Zahlen: " + result2);


            //Beenden
            HoleBenutzerEingabe("Drücke Return zum beenden...");
        }

        static string HoleBenutzerEingabe(string ausgabeText) {
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
    }
}
