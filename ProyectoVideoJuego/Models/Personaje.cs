using System;

namespace ProyectoVideojuego.Models
{
    public abstract class Personaje
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public string Bando { get; set; }

        public Personaje(string nombre, int vida, int ataque, string bando)
        {
            Nombre = nombre;
            Vida = vida;
            Ataque = ataque;
            Bando = bando;
        }

        public abstract void MostrarDetalles();
    }
}
