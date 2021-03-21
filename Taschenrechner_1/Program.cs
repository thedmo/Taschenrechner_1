using System;

namespace Taschenrechner_1 {
    class Program {
        static void Main(string[] args) {
            //Uer Story: Titel: Addieren Als Benutzer möchte ich Zahlen addieren, um mir deren Summe anzeigen zu lassen Anforderung: -Zahlen von 0 bis 9 können verwendet werden

            Console.Write("1. Summand eingeben: ");
            int ersteZahl;

            while (!int.TryParse(Console.ReadLine(), out ersteZahl)) {
                Console.Write("keine Zahl, nochmal: ");
            }

            Console.Write("2. Summand eingeben: ");
            int zweiteZahl;

            while (!int.TryParse(Console.ReadLine(), out zweiteZahl)) {
                Console.Write("keine Zahl, nochmal: ");
            }

            int result = ersteZahl + zweiteZahl;

            Console.WriteLine("Das Resultat ist: " + result + "\n\nbeliebige Taste drücken zum Beenden...");

            Console.ReadKey();
        }
    }
}
