using System;
using System.Collections.Generic;
using ProyectoVideojuego.Models; 

class Program
{
    static void Main(string[] args)
    {
        List<Personaje> listaPersonajes = new List<Personaje>();
        bool ejecutando = true;

        while (ejecutando)
        {
            Console.Clear();
            Console.WriteLine("        SISTEMA DE VIDEOJUEGO           ");
            Console.WriteLine("1. Crear nuevo personaje");
            Console.WriteLine("2. Mostrar personajes creados");
            Console.WriteLine("3. Salir");
            Console.WriteLine("                                      ");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    CrearNuevoPersonaje(listaPersonajes);
                    break;
                case "2":
                    MostrarLista(listaPersonajes);
                    break;
                case "3":
                    ejecutando = false;
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Presione una tecla para reintentar.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void CrearNuevoPersonaje(List<Personaje> lista)
    {
        Console.Clear();
        Console.WriteLine("    Seleccione el tipo de personaje    ");
        Console.WriteLine("1. Guerrero");
        Console.WriteLine("2. Mago");
        string tipo = Console.ReadLine();

        Console.Write("Nombre: "); string nom = Console.ReadLine();
        Console.Write("Vida: "); int vid = int.Parse(Console.ReadLine());
        Console.Write("Ataque: "); int atk = int.Parse(Console.ReadLine());
        Console.Write("Tipo (Aliado/Villano): "); string bando = Console.ReadLine();

        if (tipo == "1")
        {
            Console.Write("Defensa: "); int def = int.Parse(Console.ReadLine());
            Console.Write("Arma: "); string arma = Console.ReadLine();

            lista.Add(new Guerrero(nom, vid, atk, bando, def, arma));
            Console.WriteLine("\n¡Guerrero creado con éxito!");
        }
        else if (tipo == "2")
        {
            Console.Write("Hechizo Principal: "); string hechizo = Console.ReadLine();

            lista.Add(new Mago(nom, vid, atk, bando, hechizo));
            Console.WriteLine("\n¡Mago creado exitosamente!");
        }

        Console.WriteLine("Presione una tecla para volver al menú.");
        Console.ReadKey();
    }

    static void MostrarLista(List<Personaje> lista)
    {
        Console.Clear();
        Console.WriteLine("       LISTADO DE PERSONAJES        ");

        if (lista.Count == 0)
        {
            Console.WriteLine("La lista está vacía.");
        }
        else
        {
            foreach (var p in lista)
            {
                p.MostrarDetalles();
            }
        }

        Console.WriteLine("\nPresione una tecla para volver.");
        Console.ReadKey();
    }
}