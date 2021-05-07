namespace Taschenrechner {
    class RechnerModel {
        public double Resultat { get; private set; }
        public string Operation { get; private set; }

        public RechnerModel() {
            Resultat = 0;
            Operation = "unbekannt";
        }
        public void Berechne(double ersteZahl, double zweiteZahl, string operation) {
            Operation = operation;

            switch (operation) {
                case "+":
                    Resultat = Addiere(ersteZahl, zweiteZahl);
                    break;
                case "-":
                    Resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    break;
                case "/":
                    Resultat = Dividiere(ersteZahl, zweiteZahl);
                    break;
                case "*":
                    Resultat = Multipliziere(ersteZahl, zweiteZahl);
                    break;
                default:
                    break;
            }
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
