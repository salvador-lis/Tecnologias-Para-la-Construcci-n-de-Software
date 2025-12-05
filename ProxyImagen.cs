using System;

namespace ProxyImagenDemo
{
    public class ProxyImagen : IImagen
    {
        private readonly string _rutaArchivo;
        private ImagenReal? _real;

        public ProxyImagen(string rutaArchivo)
        {
            _rutaArchivo = rutaArchivo;
        }

        public string Mostrar()
        {
            if (_real == null)
            {
                _real = new ImagenReal(_rutaArchivo);
            }
            Console.WriteLine("[Proxy] Acceso concedido, usando la imagen real...");
            return _real.Mostrar();
        }
    }
}