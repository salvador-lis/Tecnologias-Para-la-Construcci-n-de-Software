using System;
using malEjemplo;
using buenEjemplo;
namespace Exposicion22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ZTE miZte = new ZTE("ZTE", 2019, 1000, 2);

            miZte.escribir();
            miZte.llamar();
            miZte.pagarConNFC();
            miZte.usarAsistenteVirtual();
            miZte.desbloquearConHuella();

            Iphone15 miIphone = new Iphone15("Iphone", 15, 200000, 8);
            miIphone.escribir();
            miIphone.llamar();
            miIphone.pagarConNFC();
            miIphone.usarAsistenteVirtual();
            miIphone.desbloquearConHuella();

            Xiaomi miXiaomi = new Xiaomi("Xiaomi", 12, 1000, 6);
            miXiaomi.escribir();
            miXiaomi.llamar();
            miXiaomi.pagarConNFC();
            miXiaomi.usarAsistenteVirtual();
            miXiaomi.desbloquearConHuella();

            Console.WriteLine("Buen ejemplo");

            Zte2 miZte2 = new Zte2("ZTE", 2019, 1000, 2);
            miZte2.escribir();
            miZte2.llamar();

            Xiaomi12 miXiaomi12 = new Xiaomi12("Xiaomi", 2019, 1000, 2);
            miXiaomi12.escribir();
            miXiaomi12.llamar();
            miXiaomi12.desbloquearConHuella();

            Iphone16 miIphone16 = new Iphone16("Iphone", 2019, 1000, 2);
            miIphone16.escribir();
            miIphone16.llamar();
            miIphone16.pagarConNFC();
            miIphone16.usarAsistenteVirtual();

        }
    }
    
}