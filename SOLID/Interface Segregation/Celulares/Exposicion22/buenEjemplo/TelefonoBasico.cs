using System;

namespace buenEjemplo
{
    public abstract class TelefonoBasico
    {
        public string marca;
        public int modelo;
        public int precio;
        public int RAM;

        public TelefonoBasico(string marca, int modelo, int precio, int RAM)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
            this.RAM = RAM;
        }

        public abstract void escribir();
        public abstract void llamar();
    }
}