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
    }
}