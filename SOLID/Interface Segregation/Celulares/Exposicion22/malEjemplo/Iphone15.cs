using System;

namespace malEjemplo
{
    public class Iphone15 : Telefono
    {
        public Iphone15(string marca, int modelo, int precio, int RAM) : base(marca, modelo, precio, RAM)
        {

        }

        public override void escribir()
        {
            Console.WriteLine($"Escribirndo desde mi {marca}");
        }

        public override void llamar()
        {
            Console.WriteLine($"llamando desde mi {marca}");
        }

        public override void pagarConNFC()
        {
            Console.WriteLine($" pagando con mi {marca} ");
        }

        public override void usarAsistenteVirtual()
        {
            Console.WriteLine("hablando con Siri");
        }

        public override void desbloquearConHuella()
        {
            Console.WriteLine("este dispositivo no tiene acceso a esta funcion");
        }
    }
}