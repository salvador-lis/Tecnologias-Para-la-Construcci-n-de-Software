public abstract class Carro{
    private String marca;
    private int llantas;
    private String color;


    public Carro(String marca,int llantas,String color){
        this.marca=marca;
        this.llantas=llantas;
        this.color=color;
    }

    public void encender(){
        System.out.println("El carro esta encendido");
    }

    public abstract void acelerar();
}