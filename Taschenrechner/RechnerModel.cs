namespace Taschenrechner {
    public enum Fehler {
        Keiner,
        UngueltigeOperation,
        GrenzwertUeberschreitung
    }

    public class RechnerModel {
        public Fehler AktuellerFehler { get; private set; }
        public double Resultat { get; private set; }
        private double ersteZahl;

        public double ErsteZahl {
            get { return ersteZahl; }
            set {
                if (value != ersteZahl) {
                    AktuellerFehler = PruefeZahlAufGrenzWert(value);
                    ersteZahl = value;
                }; 
            }
        }

        private double zweiteZahl;
        public double ZweiteZahl {
            get { return zweiteZahl; }
            set {
                if (value != zweiteZahl) {
                    AktuellerFehler = PruefeZahlAufGrenzWert(value);
                    zweiteZahl = value;
                };
            }
        }

        private Fehler PruefeZahlAufGrenzWert(double zahl) {
            Fehler fehler;

            if (zahl < -10.0 || zahl > 100.0) {
                fehler = Fehler.GrenzwertUeberschreitung;
            }
            else {
                fehler = Fehler.Keiner;
            }
            return fehler;
        }

        private string operation = "ungültig";
        public string Operation {
            get {
                return operation;
            }
            set {
                if (value != operation) {
                    switch (value) {
                        case "+":
                        case "-":
                        case "/":
                        case "*":
                            if (AktuellerFehler == Fehler.UngueltigeOperation) {
                                AktuellerFehler = Fehler.Keiner;
                            }
                            operation = value;
                            break;

                        default:
                            operation = "ungueltig";
                            AktuellerFehler = Fehler.UngueltigeOperation;
                            break;
                    }
                }
            }
        }

        public RechnerModel() {
            Resultat = 0;
            Operation = "unbekannt";
            AktuellerFehler = Fehler.Keiner;
        }

        public void FehlerZuruecksetzen() {
            AktuellerFehler = Fehler.Keiner;
        }

        public void Berechne() {
            if (AktuellerFehler != Fehler.Keiner) {
                return;
            }

            switch (Operation) {
                case "+":
                    Resultat = Addiere(ErsteZahl, ZweiteZahl);
                    break;
                case "-":
                    Resultat = Subtrahiere(ErsteZahl, ZweiteZahl);
                    break;
                case "/":
                    Resultat = Dividiere(ErsteZahl, ZweiteZahl);
                    break;
                case "*":
                    Resultat = Multipliziere(ErsteZahl, ZweiteZahl);
                    break;
                default:
                    break;
            }

            ersteZahl = Resultat;
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
