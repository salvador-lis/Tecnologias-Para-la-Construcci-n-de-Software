using Producto;

namespace ProductosConcretos
{
    public class TarjetaCreditoPago : IPago
    {
        public void ProcesarPago(decimal monto)
        {
            Console.WriteLine($"Procesando pago con tarjeta de crédito: ${monto}");
        }

        public bool ValidarPago()
        {
            Console.WriteLine("Validando tarjeta de crédito...");
            return true;
        }
    }
}