using System;

namespace ProyectoVideojuego.Models
{
    public class Mago : Personaje
    {
        public string HechizoPrincipal { get; set; }

        public Mago(string nombre, int vida, int ataque, string bando, string hechizo)
            : base(nombre, vida, ataque, bando)
        {
            HechizoPrincipal = hechizo;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine($"[MAGO] -> Nombre: {Nombre} | Vida: {Vida} | Ataque: {Ataque} | Bando: {Bando} | Hechizo: {HechizoPrincipal}");
        }
    }
}
