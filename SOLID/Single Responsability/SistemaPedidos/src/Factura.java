public class Factura {
    private String cliente;
    private double monto;

    public Factura(String cliente, double monto) {
        this.cliente = cliente;
        this.monto = monto;
    }

    public void generarFactura() {
        System.out.println("Pedido para: " + cliente + " Con un monto de: " + monto);
    }
}
