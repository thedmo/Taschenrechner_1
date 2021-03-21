using System;

namespace Taschenrechner_1 {
    class Program {
        static void Main(string[] args) {
            //Uer Story: Titel: Addieren Als Benutzer möchte ich Zahlen addieren, um mir deren Summe anzeigen zu lassen Anforderung: -Zahlen von 0 bis 9 können verwendet werden

            Console.Write("1. Summand eingeben: ");
            float ersteZahl;

            while (!float.TryParse(Console.ReadLine(), out ersteZahl)) {
                Console.Write("keine Zahl oder zu grosser Wert (Maximalwert: {0:F}). \n1. Summand eingeben: ", float.MaxValue);
            }

            Console.Write("2. Summand eingeben: ");
            float zweiteZahl;
            while (!float.TryParse(Console.ReadLine(), out zweiteZahl)) {
                Console.Write("keine Zahl oder zu grosser Wert (Maximalwert: {0:F}). \n2. Summand eingeben: ", float.MaxValue);
            }

            double result = ersteZahl + zweiteZahl;

            Console.WriteLine("Resultat: " + result +  "\n\nbeliebige Taste drücken zum Beenden...") ;

            Console.ReadKey();
        }
    }
}
