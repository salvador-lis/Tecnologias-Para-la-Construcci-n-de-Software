using System;

namespace malEjemplo
{
    public class Xiaomi : Telefono
    {
        public Xiaomi(String marca, int modelo, int precio, int RAM) : base(marca, modelo, precio, RAM)
        {

        }

        public override void escribir()
        {
            Console.WriteLine($"escribiendo desde mi {marca}");

        }

        public override void llamar()
        {
            Console.WriteLine($"llamando desde mi {marca}");
        }

        public override void pagarConNFC()
        {
            Console.WriteLine("Este dispositivo no tiene acceso a esta funcion");
        }

        public override void usarAsistenteVirtual()
        {
            Console.WriteLine("este dispositivo no tiene acceso a esta funcion");
        }

        public override void desbloquearConHuella()
        {
            Console.WriteLine($" desbloquendo mi {marca} con mi huella");
        }

    }
}