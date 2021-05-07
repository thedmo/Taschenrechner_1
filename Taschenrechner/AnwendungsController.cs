using System;

namespace Taschenrechner {
    class AnwendungsController {

        RechnerModel model;
        ConsoleView console;

        public AnwendungsController(RechnerModel model, ConsoleView console) {
            this.model = model;
            this.console = console;
        }

        public void Ausführen() {

            //Eingabe
            console.HoleBenutzerEingabe();

            //Berechnung
            model.Berechne();

            //Ausgabe
            console.GebeResultatAus();

            //Beenden
            console.WarteAufBenutzerEingabe();
        }
    }
}
