using System;

namespace buenEjemplo
{
    public class Xiaomi12 : TelefonoBasico, DesbloqueoBiometrico
    {
        public Xiaomi12(string marca, int modelo, int precio, int RAM) : base(marca, modelo, precio, RAM)
        {

        }

        public override void escribir()
        {
            Console.WriteLine($" escribiendo desde mi {marca}");
        }

        public override void llamar()
        {
            Console.WriteLine($"llamando desde mi {marca}");
        }

        public void desbloquearConHuella()
        {
            Console.WriteLine($"desbloquendo mi {marca}");
        }
    }
}