public class App {
    public static void main(String[] args) throws Exception {
        SistemaPedidos pedidos= new SistemaPedidos("salva", "late");
        MaquinaCafe cafe = new MaquinaCafe("null");
        Factura factura=new Factura("Salva", 80);
        Notification notificacion=new Notificacion("Salva","Tu pedido");

        pedidos.tomarPedido();
        cafe.prepararCafe();
        factura.generarFactura();
    }
}
