using System;

namespace Taschenrechner {
    class Program {
        static void Main(string[] args) {
            //Ausgabe leeren
            Console.Clear();

            //Eingabe
            string ersteEingabe = HoleBenutzerEingabe("1. Wert eingeben: ");
            string zweiteEingabe = HoleBenutzerEingabe("2. Wert eingeben: ");
            string operation = HoleBenutzerEingabe("Operator eingeben (+ oder -): ");

            //Umwandlung zu Zahl
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double ersteZahl = Convert.ToDouble(ersteEingabe);
            double zweiteZahl = Convert.ToDouble(zweiteEingabe);

            //Berechnung
            double result = 0;
            switch (operation) {
                case "+":
                    result = Addiere(ersteZahl, zweiteZahl);
                    Console.WriteLine("Die Summe beträgt: " + result);
                    break;
                case "-":
                    result = Subtrahiere(ersteZahl, zweiteZahl);
                    Console.WriteLine("Die Differenz beträgt: " + result);
                    break;
                default:
                    Console.WriteLine("Keine gültige Operation eingegeben..");
                    break;
            }

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
