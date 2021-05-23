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
            HoleErsteZahlVonBenutzer();

            model.Operation = HoleOperationVonBenutzer();

            HoleZweiteZahlVonBenutzer();
        }

        public void HoleWeitereBenutzerEingabe() {
            model.ErsteZahl = model.Resultat;
            HoleZweiteZahlVonBenutzer();
        }

        private void HoleErsteZahlVonBenutzer() {
            string eingabe;

            if (BenutzerWillBeenden) {
                return;
            }
            do {
                Console.WriteLine("Zahl eingeben (tippe \"fertig\" zum Beenden)");
                eingabe = Console.ReadLine();

                if (eingabe.ToLower() == "fertig") {
                    BenutzerWillBeenden = true;
                }
                else {
                    model.ErsteZahl = KonvertiereZahl(eingabe);
                    if (model.AktuellerFehler == Fehler.GrenzwertUeberschreitung) {
                        Console.WriteLine("Fehler: die eingegebene Zahl ist ausserhalb des Erlaubten Bereiches von -10.0 und 100.0");
                    }
                }
            } while (model.AktuellerFehler == Fehler.GrenzwertUeberschreitung && !BenutzerWillBeenden);
        }

        private void HoleZweiteZahlVonBenutzer() {
            string eingabe;

            if (BenutzerWillBeenden) {
                return;
            }
            do {
                Console.WriteLine("Zahl eingeben (tippe \"fertig\" zum Beenden)");
                eingabe = Console.ReadLine();

                if (eingabe.ToLower() == "fertig") {
                    BenutzerWillBeenden = true;
                }
                else {
                    model.ZweiteZahl = KonvertiereZahl(eingabe);
                    if (model.AktuellerFehler == Fehler.GrenzwertUeberschreitung) {
                        Console.WriteLine("Fehler: die eingegebene Zahl ist ausserhalb des Erlaubten Bereiches von -10.0 und 100.0");
                    }
                }
            } while (model.AktuellerFehler == Fehler.GrenzwertUeberschreitung && !BenutzerWillBeenden);
        }

        private double KonvertiereZahl(string eingabe) {

            double zahl;

            while (!double.TryParse(eingabe, out zahl)) {
                Console.WriteLine("Fehler: unerlaubte Sonderzeichen oder leere Zahl. Erlaubte Sonderzeichen:\n. für Komma, ' für Tausendertrennung, - zur Angabe von Negativen Zahlen.");
                Console.Write("Bitte Zahl eingeben: ");
                eingabe = Console.ReadLine();
            }

            return zahl;
        }

        private string HoleOperationVonBenutzer() {
            if (BenutzerWillBeenden) {
                return "";
            }

            string operation;
            do {
                Console.Write("Bitte Operand eingeben (+, -, /, *): ");
                operation = Console.ReadLine();

                model.Operation = operation;

                if (model.AktuellerFehler == Fehler.UngueltigeOperation) {
                    Console.WriteLine("FEHLER: die eingegebene Operation wird nicht unterstützt.");
                }

            } while (model.AktuellerFehler == Fehler.UngueltigeOperation);

            return operation;
        }
    }
}
