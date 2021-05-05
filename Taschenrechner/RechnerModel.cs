using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner {
    class RechnerModel {
        public double Berechne(double ersteZahl, double zweiteZahl, string operand) {
            double resultat = 0;
            switch (operand) {
                case "+":
                    resultat = Addiere(ersteZahl, zweiteZahl);
                    break;
                case "-":
                    resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    break;
                case "/":
                    resultat = Dividiere(ersteZahl, zweiteZahl);
                    break;
                case "*":
                    resultat = Multipliziere(ersteZahl, zweiteZahl);
                    break;
                default:
                    break;
            }
            return resultat;
        }

        private double Addiere(double ersterSummand, double zweiterSummand) {
            double summe = ersterSummand + zweiterSummand;
            return summe;
        }

        private double Subtrahiere(double minuend, double subtrahend) {
            double differenz = minuend - subtrahend;
            return differenz;
        }

        private double Dividiere(double dividend, double divisor) {
            double quotient = dividend / divisor;
            return quotient;
        }

        private double Multipliziere(double ersterFaktor, double zweiterFaktor) {
            double produkt = ersterFaktor * zweiterFaktor;
            return produkt;
        }
    }
}
