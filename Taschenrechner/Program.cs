using System;

namespace Taschenrechner {
    class Program {
        static void Main(string[] args) {
            //Ausgabe leeren
            Console.Clear();

            //Eingabe
            string ersteEingabe = HoleBenutzerEingabe("1. Wert eingeben: ");
            string zweiteEingabe = HoleBenutzerEingabe("2. Wert eingeben: ");
            string operation = HoleBenutzerEingabe("Operator eingeben (+, -, / oder *): ");

            //Umwandlung zu Zahl
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double ersteZahl = Convert.ToDouble(ersteEingabe);
            double zweiteZahl = Convert.ToDouble(zweiteEingabe);

            //Berechnung
            double result = Berechne(ersteZahl, zweiteZahl, operation);

            //Ausgabe
            Ausgabe(operation, result);

            //Beenden
            HoleBenutzerEingabe("Drücke Return zum beenden...");
        }

        private static void Ausgabe(string operation, double resultat) {
            string ausgabeString = "";
            
            switch (operation) {
                case "+":
                    ausgabeString = "Die Summe beträgt: " + resultat;
                    break;
                case "-":
                    ausgabeString = "Die Differenz beträgt: " + resultat;
                    break;
                case "/":
                    ausgabeString = "Der Quotient beträgt: " + resultat;
                    break;
                case "*":
                    ausgabeString = "Das Produkt beträgt: " + resultat;
                    break;
                default:
                    ausgabeString = "Keine gültige Operation eingegeben..";
                    break;
            }

            Console.WriteLine(ausgabeString);
        }

        static string HoleBenutzerEingabe(string ausgabeText) {
            Console.Write(ausgabeText);
            string s = Console.ReadLine();
            return s;
        }

        private static double Berechne(double ersteZahl, double zweiteZahl, string operand) {
            double resultat = 0;
            switch (operand) {
                case "+":
                    resultat = Addiere(ersteZahl, zweiteZahl);
                    break;
                case "-":
                    resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    break;
                case "/":
                    resultat = Dividiere(ersteZahl, zweiteZahl);
                    break;
                case "*":
                    resultat = Multipliziere(ersteZahl, zweiteZahl);
                    break;
                default:
                    break;
            }
            return resultat;
        }

        private static double Addiere(double ersterSummand, double zweiterSummand) {
            double summe = ersterSummand + zweiterSummand;
            return summe;
        }

        private static double Subtrahiere(double minuend, double subtrahend) {
            double differenz = minuend - subtrahend;
            return differenz;
        }

        private static double Dividiere(double dividend, double divisor) {
            double quotient = dividend / divisor;
            return quotient;
        }

        private static double Multipliziere (double ersterFaktor, double zweiterFaktor) {
            double produkt = ersterFaktor * zweiterFaktor;
            return produkt;
        }
    }
}
