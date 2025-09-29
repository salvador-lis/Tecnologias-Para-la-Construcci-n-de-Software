using System;

namespace malEjemplo
{
    public class ZTE : Telefono
    {
        public ZTE(string marca, int modelo, int precio, int RAM) : base(marca, modelo, precio, RAM)
        {

        }

        public override void escribir()
        {
            Console.WriteLine($"Escribiendo desde mi {marca}");
        }

        public override void llamar()
        {
            Console.WriteLine($"llamdando desde mi {marca}");
        }

        public override void pagarConNFC()
        {
            Console.WriteLine("Este dispositivo no tiene acceso a esta función");
        }

        public override void usarAsistenteVirtual()
        {
            Console.WriteLine("Este dispositivo no tiene acceso a esta función");
        }

        public override void desbloquearConHuella()
        {
            Console.WriteLine("Este dispositivo no tiene acceso a esta función");
        }
    
    }
}