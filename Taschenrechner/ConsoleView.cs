using System;

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

        public void GebeResultatAus() {
            switch (model.Operation) {
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

        public void HoleBenutzerEingabe() {
            model.ErsteZahl = HoleZahlVonBenutzer();
            model.Operation = HoleOperandVonBenutzer();
            model.ZweiteZahl = HoleZahlVonBenutzer();
        }

        private double HoleZahlVonBenutzer() {
            Console.Write("Bitte Zahl eingeben: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        private string HoleOperandVonBenutzer() {
            Console.Write("Bitte Operand eingeben (+, -, /, *): ");
            return Console.ReadLine();
        }

        public void WarteAufBenutzerEingabe() {
            Console.Write("Zum beenden bitte Return drücken...");
            Console.ReadLine();
        }
    }
}
