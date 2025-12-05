using System;
using System.IO;

namespace ProxyImagenDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IImagen img = new ProxyImagen("salida-proxy.jpg");

            // 1ra vez: genera el .jpg y lo "muestra"
            string ruta1 = img.Mostrar();
            Console.WriteLine("Ruta devuelta: " + ruta1);

            Console.WriteLine("\n--- Segunda solicitud ---\n");

            // 2da vez: reutiliza el archivo
            string ruta2 = img.Mostrar();
            Console.WriteLine("Ruta devuelta: " + ruta2);

            Console.WriteLine("\nAbre el archivo para verlo: " + Path.GetFullPath(ruta2));
        }
    }
}