public abstract class Animal{
    protected boolean isAlive=true;
    protected int age;

    public Animal(int age){
        this.age=age;        
    }

    public abstract void hacerRuido();
}