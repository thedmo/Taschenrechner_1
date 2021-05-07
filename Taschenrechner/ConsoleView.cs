using System;

namespace Taschenrechner {
    class ConsoleView {
        private RechnerModel model;

        public string AusgabeString { get; private set; }

        public bool BenutzerWillBeenden { get; private set; }


        public ConsoleView(RechnerModel model) {
            this.model = model;

            //Ausgabe leeren
            Console.Clear();

            //AusgabeString initialisieren
            AusgabeString = "";

            BenutzerWillBeenden = false;
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



        public void HoleErsteBenutzerEingaben() {
            model.ErsteZahl = HoleZahlVonBenutzer();
            model.Operation = HoleOperandVonBenutzer();
            model.ZweiteZahl = HoleZahlVonBenutzer();
        }

        public void HoleWeitereBenutzerEingabe() {

            string eingabe = HoleWeitereZahlVonBenutzer();

            if (eingabe.ToLower() == "fertig") {
                BenutzerWillBeenden = true;
            }
            else {

                model.ErsteZahl = model.Resultat;

                model.ZweiteZahl = Convert.ToDouble(eingabe);
            }

        }

        private double HoleZahlVonBenutzer() {
            string eingabe;
            Console.Write("Bitte Zahl eingeben: ");
            eingabe = Console.ReadLine();

            if (eingabe == "FERTIG") {
                BenutzerWillBeenden = true;

                eingabe = "0.0";
            }

            return Convert.ToDouble(eingabe);
        }

        private string HoleWeitereZahlVonBenutzer() {
            Console.Write("Weitere Zahl Eingeben (tippe \"Fertig\" zum Beenden):");
            return Console.ReadLine();
        }

        private string HoleOperandVonBenutzer() {
            Console.Write("Bitte Operand eingeben (+, -, /, *): ");
            return Console.ReadLine();
        }
    }
}
