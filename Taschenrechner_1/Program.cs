using System;

namespace Taschenrechner_1 {
    class Program {
        static void Main(string[] args) {
            //Uer Story: Titel: Addieren Als Benutzer möchte ich Zahlen addieren, um mir deren Summe anzeigen zu lassen Anforderung: -Zahlen von 0 bis 9 können verwendet werden

            Console.Write("1. Summand eingeben: ");
            int ersteZahl;

            while (!int.TryParse(Console.ReadLine(), out ersteZahl)) {
                Console.Write("keine Zahl oder zu grosser Wert (Maximalwert: {0}). \n1. Summand eingeben: ", int.MaxValue);
            }

            Console.Write("2. Summand eingeben: ");
            int zweiteZahl;
            while (!int.TryParse(Console.ReadLine(), out zweiteZahl)) {
                Console.Write("keine Zahl oder zu grosser Wert (Maximalwert: {0}). \n2. Summand eingeben: ", int.MaxValue);
            }

            UInt64 result = (UInt64)ersteZahl + (UInt64)zweiteZahl;

            Console.WriteLine("Resultat: " + result +  "\n\nbeliebige Taste drücken zum Beenden...") ;

            Console.ReadKey();
        }
    }
}
