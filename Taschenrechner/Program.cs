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
            RechnerModel model = new RechnerModel();
            model.Berechne(ersteZahl, zweiteZahl, operation);

            //Ausgabe
            Ausgabe(operation, model.Resultat);

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
    }
}
