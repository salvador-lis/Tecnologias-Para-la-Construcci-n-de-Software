using System;

namespace buenEjemplo
{
    public class Iphone16 : TelefonoBasico, NFC, AsistenteVirtual
    {
        public Iphone16(string marca, int modelo, int precio, int RAM) : base(marca, modelo, precio, RAM)
        {

        }

        public override void escribir()
        {
            Console.WriteLine($"escribiendo desde mi {marca}");
        }

        public override void llamar()
        {
            Console.WriteLine($" llamando desde mi {marca}");
        }

        public void pagarConNFC()
        {
            Console.WriteLine("pagando con NFC");
        }

        public void usarAsistenteVirtual()
        {
            Console.WriteLine("hablando con Siri");
        }
    }
}