using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner {
    class ConsoleView {

        public string AusgabeString { get; private set; }

        public ConsoleView() {
            //Ausgabe leeren
            Console.Clear();

            //AusgabeString initialisieren
            AusgabeString = "";
        }

        public void GebeResultatAus(string operation, double resultat) {

            switch (operation) {
                case "+":
                    AusgabeString = "Die Summe beträgt: " + resultat;
                    break;
                case "-":
                    AusgabeString = "Die Differenz beträgt: " + resultat;
                    break;
                case "/":
                    AusgabeString = "Der Quotient beträgt: " + resultat;
                    break;
                case "*":
                    AusgabeString = "Das Produkt beträgt: " + resultat;
                    break;
                default:
                    AusgabeString = "Keine gültige Operation eingegeben..";
                    break;
            }

            Console.WriteLine(AusgabeString);
        }

        public string HoleBenutzerEingabe(string ausgabeText) {
            Console.Write(ausgabeText);
            string s = Console.ReadLine();
            return s;
        }
    }
}
