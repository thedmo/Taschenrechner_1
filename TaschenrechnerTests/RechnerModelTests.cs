using Microsoft.VisualStudio.TestTools.UnitTesting;
using Taschenrechner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner.Tests {
    [TestClass()]
    public class RechnerModelTests {
        [TestMethod()]
        public void Berechne_DivisiondurchNull_ErgibtUnendlich() {
            RechnerModel model = new RechnerModel {
                ErsteZahl = -10,
                Operation = "/",
                ZweiteZahl = 0
            };

            model.Berechne();

            Assert.IsTrue(model.Resultat == double.PositiveInfinity || model.Resultat == double.NegativeInfinity);
        }

        [TestMethod()]
        public void Obere_Grenzwertüberschreitung() {
            RechnerModel model = new RechnerModel {
                ErsteZahl = 101,
                Operation = "+",
                ZweiteZahl = 0
            };
            Assert.AreEqual(Fehler.GrenzwertUeberschreitung, model.AktuellerFehler);
        }
        
        [TestMethod()]
        public void Untere_Grenzwertüberschreitung() {
            RechnerModel model = new RechnerModel {
                ErsteZahl = 0,
                Operation = "-",
                ZweiteZahl = -11
            };
            Assert.AreEqual(Fehler.GrenzwertUeberschreitung, model.AktuellerFehler);
        }        

        [TestMethod()]
        public void Falsche_Operation() {
            RechnerModel model = new RechnerModel {
                ErsteZahl = 0,
                ZweiteZahl = -5
            };

            model.Operation = "";

            Assert.AreEqual(Fehler.UngueltigeOperation, model.AktuellerFehler);
        }

    }
}