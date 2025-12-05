using Factory;
using Producto;

class Program
{
    static void Main()
    {
        ProcesarPago(TipoPago.TarjetaCredito, 100.50m);
        ProcesarPago(TipoPago.Paypal, 75.25m);
        ProcesarPago(TipoPago.Transferencia, 200.00m);
    }

    static void ProcesarPago(TipoPago tipo, decimal monto)
    {
        IPago pago = PagoFactory.crearPago(tipo);
        if (pago.ValidarPago())
        {
            pago.ProcesarPago(monto);
        }
    }
}
