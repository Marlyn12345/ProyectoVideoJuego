using System;

namespace ProyectoVideojuego.Models
{
    public class Guerrero : Personaje
    {
        public int Defensa { get; set; }
        public string Arma { get; set; }

        public Guerrero(string nombre, int vida, int ataque, string bando, int defensa, string arma)
            : base(nombre, vida, ataque, bando)
        {
            Defensa = defensa;
            Arma = arma;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine($"[GUERRERO] -> Nombre: {Nombre} | Vida: {Vida} | Ataque: {Ataque} | Bando: {Bando} | Defensa: {Defensa} | Arma: {Arma}");
        }
    }
}
