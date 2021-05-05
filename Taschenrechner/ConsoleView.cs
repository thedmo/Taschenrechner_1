using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner {
    class ConsoleView {
        private RechnerModel model;

        public string AusgabeString { get; private set; }

        public ConsoleView(RechnerModel model) {
            this.model = model;
            
            //Ausgabe leeren
            Console.Clear();

            //AusgabeString initialisieren
            AusgabeString = "";
        }

        public void GebeResultatAus(string operation) {

            switch (operation) {
                case "+":
                    AusgabeString = "Die Summe beträgt: " + model.Resultat;
                    break;
                case "-":
                    AusgabeString = "Die Differenz beträgt: " + model.Resultat;
                    break;
                case "/":
                    AusgabeString = "Der Quotient beträgt: " + model.Resultat;
                    break;
                case "*":
                    AusgabeString = "Das Produkt beträgt: " + model.Resultat;
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
