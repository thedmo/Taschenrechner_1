using System;

namespace Taschenrechner {
    class Program {
        static void Main(string[] args) {
            
            //Klassen instantiieren
            RechnerModel model = new RechnerModel();
            ConsoleView console = new ConsoleView(model);

            //Eingabe
            string ersteEingabe = console.HoleBenutzerEingabe("1. Wert eingeben: ");
            string zweiteEingabe = console.HoleBenutzerEingabe("2. Wert eingeben: ");
            string operation = console.HoleBenutzerEingabe("Operator eingeben (+, -, / oder *): ");

            //Umwandlung zu Zahl
            // TODO: Auslagern in Methode, wenn Struktur umfangreicher geworden ist.
            double ersteZahl = Convert.ToDouble(ersteEingabe);
            double zweiteZahl = Convert.ToDouble(zweiteEingabe);

            //Berechnung
            model.Berechne(ersteZahl, zweiteZahl, operation);

            //Ausgabe
            console.GebeResultatAus(operation);

            //Beenden
            console.HoleBenutzerEingabe("Drücke Return zum beenden...");
        }
    }
}
