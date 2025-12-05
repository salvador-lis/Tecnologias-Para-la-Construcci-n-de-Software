using Producto;
using ProductosConcretos;

namespace Factory
{
    public static class PagoFactory
    {
        public static IPago crearPago(TipoPago tipoPago)
        {
            return tipoPago switch
            {
                TipoPago.TarjetaCredito => new TarjetaCreditoPago(),
                TipoPago.Paypal => new PayPalPago(),
                TipoPago.Transferencia => new TransferenciaPago(),
                _ => throw new ArgumentException("Tipo de pago no soportado")
            };
        }
    }
}