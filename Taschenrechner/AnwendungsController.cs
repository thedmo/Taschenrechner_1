namespace Taschenrechner {
    class AnwendungsController {

        RechnerModel model;
        ConsoleView console;

        public AnwendungsController(RechnerModel model, ConsoleView console) {
            this.model = model;
            this.console = console;
        }

        public void Ausführen() {
            console.HoleErsteBenutzerEingaben();
            
            model.Berechne();

            console.GebeResultatAus();
            console.HoleWeitereBenutzerEingabe();

            while (!console.BenutzerWillBeenden) {
                model.Berechne();

                console.GebeResultatAus();
                console.HoleWeitereBenutzerEingabe();
            }
        }
    }
}
