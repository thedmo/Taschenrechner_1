namespace Taschenrechner {
    class Program {
        static void Main(string[] args) {

            //Klassen instantiieren
            RechnerModel model = new RechnerModel();
            ConsoleView console = new ConsoleView(model);
            AnwendungsController controller = new AnwendungsController(model, console);

            controller.StarteProgramm();
        }
    }
}
