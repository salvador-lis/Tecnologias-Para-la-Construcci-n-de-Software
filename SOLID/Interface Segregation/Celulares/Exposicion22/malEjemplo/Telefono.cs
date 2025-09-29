using System;

namespace malEjemplo
{
    public abstract class Telefono
    {
        public string marca;
        public int modelo;
        public int precio;
        public int RAM;

        public Telefono(string marca, int modelo, int precio, int RAM)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
            this.RAM = RAM;
        }

        public abstract void escribir();
        public abstract void llamar();

        public abstract void pagarConNFC();
        public abstract void usarAsistenteVirtual();
        public abstract void desbloquearConHuella();
    }
}