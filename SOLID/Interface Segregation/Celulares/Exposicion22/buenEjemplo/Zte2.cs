using System;

namespace buenEjemplo
{
    public class Zte2 : TelefonoBasico
    {
        public Zte2(string marca, int modelo, int precio, int RAM) : base(marca, modelo, precio, RAM)
        {

        }

        public override void escribir()
        {
            Console.WriteLine($"escrbiendo desde mi {marca}");
        }

        public override void llamar()
        {
            Console.WriteLine($"llamando desde mi {marca}");
        }
    }
}