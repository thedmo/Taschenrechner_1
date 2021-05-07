using System;

namespace Taschenrechner {
    class AnwendungsController {

        RechnerModel model;
        ConsoleView console;

        public AnwendungsController(RechnerModel model, ConsoleView console) {
            this.model = model;
            this.console = console;
        }

        public void StarteProgramm() {

            //Eingabe
            double ersteZahl = console.HoleZahlVonBenutzer();
            string operation = console.HoleOperandVonBenutzer();
            double zweiteZahl = console.HoleZahlVonBenutzer();

            //Berechnung
            model.Berechne(ersteZahl, zweiteZahl, operation);

            //Ausgabe
            console.GebeResultatAus();

            //Beenden
            console.WarteAufBenutzerEingabe();
        }

    }
}
